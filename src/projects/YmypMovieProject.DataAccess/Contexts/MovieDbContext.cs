using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.DataAccess.Contexts
{
    public sealed class MovieDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MERT\SQLEXPRESS01;Initial Catalog=YmypMovieDb;Integrated Security=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // movie model configuration
            modelBuilder.Entity<Movie>().Property(p => p.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Movie>().Property(m => m.Description).HasMaxLength(500);
            modelBuilder.Entity<Movie>().Property(p => p.IMDB).HasPrecision(4, 2); 
            modelBuilder.Entity<Movie>().HasKey(p => p.Id);
            modelBuilder.Entity<Movie>().HasOne(p => p.Category).WithMany(c => c.Movies).HasForeignKey(p => p.CategoryId);

            // category model configuration
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Category>().Property(p => p.Description).HasMaxLength(500);

            // director model configuration
            modelBuilder.Entity<Director>().Property(d => d.FirstName).HasMaxLength(50).IsRequired();  
            modelBuilder.Entity<Director>().Property(d => d.LastName).HasMaxLength(50).IsRequired();  

            base.OnModelCreating(modelBuilder);

            
            var categoryId = Guid.Parse("9CD54E24-2690-40D6-9E03-9607881A1C7C");
            var directorId = Guid.Parse("B3401950-FC04-481F-9BE8-28043B9B762C");


            // seed data for categories
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = categoryId, Name = "Aksiyon" },
            new Category { Id = Guid.NewGuid(), Name = "Bilim Kurgu" },
            new Category { Id = Guid.NewGuid(), Name = "Komedi" },
            new Category { Id = Guid.NewGuid(), Name = "Belgesel" },
            new Category { Id = Guid.NewGuid(), Name = "Fantastik" },   
            new Category { Id = Guid.NewGuid(), Name = "Korku" }
            );

            // seed data for directors
            modelBuilder.Entity<Director>().HasData(
    new Director { Id = directorId, FirstName = "Christopher", LastName = "Nolan", BirthDate = new DateTime(1970, 7, 30), Description = "British-American film director, producer, and screenwriter." },
    new Director { Id = Guid.NewGuid(), FirstName = "Steven", LastName = "Spielberg", BirthDate = new DateTime(1946, 12, 18), Description = "American film director, producer, and screenwriter." },
    new Director { Id = Guid.NewGuid(), FirstName = "Martin", LastName = "Scorsese", BirthDate = new DateTime(1942, 11, 17), Description = "American film director, producer, screenwriter, and actor." },
    new Director { Id = Guid.NewGuid(), FirstName = "Quentin", LastName = "Tarantino", BirthDate = new DateTime(1963, 3, 27), Description = "American filmmaker, actor, and screenwriter." },
    new Director { Id = Guid.NewGuid(), FirstName = "James", LastName = "Cameron", BirthDate = new DateTime(1954, 8, 16), Description = "Canadian filmmaker and environmental advocate." }
);

            // seed data for movies
            modelBuilder.Entity<Movie>().HasData(

                new Movie { Id = Guid.NewGuid(), Name = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", IMDB = 8.8m, PublishDate = new DateTime(2010, 7, 16), CategoryId = categoryId, DirectorId = directorId },

                new Movie { Id = Guid.NewGuid(), Name = "Interstellar", Description = "Interstellar movie Nolan..", IMDB = 8.7m, PublishDate = new DateTime(1999, 3, 31), CategoryId = categoryId, DirectorId = directorId },

                new Movie { Id = Guid.NewGuid(), Name = "The Dark Knight", Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", IMDB = 9.0m, PublishDate = new DateTime(2008, 7, 18), CategoryId = categoryId, DirectorId = directorId }
            );
        }
        
        




        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

