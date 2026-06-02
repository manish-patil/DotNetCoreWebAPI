using F1API.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace F1API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Race> Races => Set<Race>();

        public DbSet<Circuit> Circuits => Set<Circuit>();

        public DbSet<Location> Locations => Set<Location>();

        // Inside your DbContext:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>()
                // Defines a composite primary key using both IDs
                .HasKey(r => new { r.Season, r.Round });
        }
    }
}
