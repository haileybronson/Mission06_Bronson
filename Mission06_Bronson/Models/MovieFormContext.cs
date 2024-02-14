using Microsoft.EntityFrameworkCore;

namespace Mission06_Bronson.Models
{
    public class MovieFormContext : DbContext 
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) // constructor
        { 
        }

        public DbSet<Form> Forms { get; set; }
    }
}

