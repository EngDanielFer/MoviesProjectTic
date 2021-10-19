using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MoviesProject.Shared.Entity;
using System;
namespace MoviesProject.Server
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Actor> Actors {get;set;}
        public DbSet<CategoryMovie> CategoriesMovie {get;set;}
        public DbSet<MovieActor> MoviesActor {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<CategoryMovie>().HasKey(x=> new {x.CategoryId, x.MovieId});
            modelBuilder.Entity<MovieActor>().HasKey(x=> new {x.MovieId, x.ActorId});
            base.OnModelCreating(modelBuilder);
        }
    }
}