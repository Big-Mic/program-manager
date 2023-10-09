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
            modelBuilder.HasDefaultContainer("Relationships");
           // modelBuilder.Entity<Application>().ToContainer("Applications").HasNoDiscriminator();
            modelBuilder.Entity<Program>(e =>
            {
                e.ToContainer("Programs");
                e.HasNoDiscriminator()
                .HasMany(h => h.RequiredSkills).WithMany();
                e.HasOne(h => h.Type).WithMany().HasForeignKey(x => x.TypeId);
                e.OwnsOne(h => h.Application);
                e.OwnsMany(h => h.Stages).OwnsOne(x => x.VideoInterviewAdditionalField);
                e.HasOne(h => h.MinimumQualification).WithMany().HasForeignKey(x => x.MinimumQualificationId);
            });
            modelBuilder.Entity<Skill>(s =>
            {
                s.ToContainer("Skills").HasNoDiscriminator();
                
            });
            modelBuilder.Entity<ProgramType>(t =>
            {
                t.ToContainer("ProgramTypes").HasNoDiscriminator();
                t.HasData(new ProgramType("Full time"), new ProgramType("Part time"), new ProgramType("Internship"));
            });
            modelBuilder.Entity<Qualification>(q =>
            {
                q.ToContainer("Qualifications").HasNoDiscriminator();
                q.HasData(new Qualification("High School"), new Qualification("College"), new Qualification("MSc"), new Qualification("Phd"));
            });
        }

        public async Task<T> GetById<T>(Guid id) where T : Entity
        {
            return await Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<T>> GetByIds<T>(List<Guid> ids) where T : Entity
        {
            return await Set<T>().Where(x => ids.Contains(x.Id)).ToListAsync();
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
        public async Task<DbSet<T>> GetDbSet<T>() where T : Entity
        {
            return Set<T>();
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProgramType> ProgramTypes { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

    }
}
