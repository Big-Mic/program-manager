
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProgramManager.Application;
using ProgramManager.Application.Interfaces;
using ProgramManager.Application.Services;
using ProgramManager.Domain.Interfaces;
using ProgramManager.Domain.Services;
using ProgramManager.Infrastructure;

namespace ProgramManagerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetSection("ConnectionString");
            var url = connectionString["DatabaseUrl"];
            var key = connectionString["DatabaseKey"];
            var db = connectionString["DatabaseName"];
            builder.Services.AddDbContext<ProgramDbContext>(options =>
                options.UseCosmos(url, key, db, options =>
                {
                }));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IProgramDbContext, ProgramDbContext>();
            builder.Services.AddScoped<IProgramService, ProgramService>();
            builder.Services.AddScoped<IProgramAppService, ProgramAppService>();
            builder.Services.AddScoped<IFileService, FileService>();
            builder.Services.AddScoped<IApplicationAppService, ApplicationAppService>();
            builder.Services.AddScoped<IApplicationTemplateService, ApplicationTemplateService>();
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            var app = builder.Build();
            SeedData(app.Services);
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        private static void SeedData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var database = scope.ServiceProvider.GetRequiredService<ProgramDbContext>();
                database.Database.EnsureCreated();
            }
        }
    }
}