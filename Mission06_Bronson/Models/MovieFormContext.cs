using Microsoft.EntityFrameworkCore;

namespace Mission06_Bronson.Models
{
    public class MovieFormContext : DbContext 
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) // constructor
        { 
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Categories>().HasData(

                new Categories { CategoryId = 1, Category = "Action" },
                new Categories { CategoryId = 2, Category = "Adventure" },
                new Categories { CategoryId = 3, Category = "Scientific" },
                new Categories { CategoryId = 4, Category = "Thriller" }

            );
        }
    }
}

