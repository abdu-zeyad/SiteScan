using Boilerplate.Domain.Entities;
using Boilerplate.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Observation> Observations { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SubSite> SubSites { get; set; }
        public DbSet<ObservationPhoto> ObservationPhotos { get; set; }
        public DbSet<ObservationType> ObservationTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());


        }
    }
}
