using Microsoft.EntityFrameworkCore;
using VegaNew.Core.Models;
using VegaNew.Models;

namespace VegaNew.Persistence
{
    public class VegaNewDbContext: DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; } 

        public DbSet<Feature> Features { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public VegaNewDbContext(DbContextOptions<VegaNewDbContext> options)
            : base(options)
        {
        } 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
                new { vf.VehicleId, vf.FeatureId });
        }
    }
}
