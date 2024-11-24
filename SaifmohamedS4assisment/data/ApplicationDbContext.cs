using Microsoft.EntityFrameworkCore;
using SaifmohamedS4assisment.models;

namespace SaifmohamedS4assisment.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Catigory> Categories { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
