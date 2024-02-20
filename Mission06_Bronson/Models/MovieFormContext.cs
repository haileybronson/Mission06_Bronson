﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Bronson.Models
{
    public class MovieFormContext : DbContext 
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) // constructor
        { 
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Category>().HasData(
                                                      
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Adventure" },
                new Category { CategoryId = 3, CategoryName = "Scientific" },
                new Category { CategoryId = 4, CategoryName = "Thriller" }

            );
        }
    }
}

