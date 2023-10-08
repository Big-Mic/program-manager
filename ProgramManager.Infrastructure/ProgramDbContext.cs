using Azure;
using Microsoft.EntityFrameworkCore;
using ProgramManager.Domain.Entities;
using ProgramManager.Domain.Entities.Root;
using ProgramManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Infrastructure
{
    public class ProgramDbContext : DbContext, IProgramDbContext
    {
        public ProgramDbContext(DbContextOptions<ProgramDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().ToContainer("Applications").HasNoDiscriminator();
            modelBuilder.Entity<Program>().ToContainer("Programs").HasNoDiscriminator();
        }

        public async Task<T> GetById<T>(Guid id) where T : Entity
        {
            return await Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> Save<T>(T obj) where T : Entity
        {
            Set<T>().Add(obj);
            await SaveChangesAsync();
            return obj;
        }

        public async Task<T> Update<T>(T obj) where T : Entity
        {
            Set<T>().Update(obj);
            await SaveChangesAsync();
            return obj;
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Program> Programs { get; set; }

    }
}
