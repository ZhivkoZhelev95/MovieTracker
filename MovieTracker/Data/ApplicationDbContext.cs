using Microsoft.EntityFrameworkCore;
using MovieTracker.Models;

namespace MovieTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Horror" },
                new Genre { Id = 5, Name = "Science Fiction" },
                new Genre { Id = 6, Name = "Thriller" },
                new Genre { Id = 7, Name = "Animation" },
                new Genre { Id = 8, Name = "Romance" },
                new Genre { Id = 9, Name = "Fantasy" },
                new Genre { Id = 10, Name = "Other" }
            );

            modelBuilder.Entity<Director>().HasData(
                new Director { Id = 1, Name = "Christopher Nolan" },
                new Director { Id = 2, Name = "Steven Spielberg" },
                new Director { Id = 3, Name = "Quentin Tarantino" },
                new Director { Id = 4, Name = "Martin Scorsese" },
                new Director { Id = 5, Name = "James Cameron" },
                new Director { Id = 6, Name = "Greta Gerwig" },
                new Director { Id = 7, Name = "Francis Ford Coppola" },
                new Director { Id = 8, Name = "Stanley Kubrick" },
                new Director { Id = 9, Name = "Alfred Hitchcock" },
                new Director { Id = 10, Name = "Ridley Scott" },
                new Director { Id = 11, Name = "David Fincher" },
                new Director { Id = 12, Name = "Peter Jackson" },
                new Director { Id = 13, Name = "Denis Villeneuve" },
                new Director { Id = 14, Name = "Wes Anderson" },
                new Director { Id = 15, Name = "Tim Burton" },
                new Director { Id = 16, Name = "Guillermo del Toro" },
                new Director { Id = 17, Name = "George Lucas" },
                new Director { Id = 18, Name = "Bong Joon-ho" },
                new Director { Id = 19, Name = "Hayao Miyazaki" },
                new Director { Id = 20, Name = "Other" }
            );
        }
    }
}