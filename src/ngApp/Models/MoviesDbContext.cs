using Microsoft.Data.Entity;

namespace ngApp.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
