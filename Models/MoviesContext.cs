using Microsoft.EntityFrameworkCore;

namespace MoviesAPI.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options):base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
