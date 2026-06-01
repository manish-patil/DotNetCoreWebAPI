using F1API.Models;
using Microsoft.EntityFrameworkCore;

namespace F1API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Race> Races => Set<Race>();

        // Inside your DbContext:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defines a composite primary key using both IDs
            modelBuilder.Entity<Race>()
                .HasKey(r => new { r.Season, r.Round});
        }
    }
}
