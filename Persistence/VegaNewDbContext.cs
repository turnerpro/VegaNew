using Microsoft.EntityFrameworkCore;
using VegaNew.Models;

namespace VegaNew.Persistence
{
    public class VegaNewDbContext: DbContext
    {
        public VegaNewDbContext(DbContextOptions<VegaNewDbContext> options)
            : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Feature> Features { get; set; }
    }
}
