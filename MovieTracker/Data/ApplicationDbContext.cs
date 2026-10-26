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

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 101,
                    Title = "The Dark Knight",
                    Description = "Batman faces the Joker as chaos spreads through Gotham City.",
                    ReleaseYear = 2008,
                    Rating = 9.0m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                    IsWatched = true,
                    GenreId = 1,
                    DirectorId = 1
                },
                new Movie
                {
                    Id = 102,
                    Title = "Interstellar",
                    Description = "Explorers travel beyond Earth to find a new home for humanity.",
                    ReleaseYear = 2014,
                    Rating = 8.7m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg",
                    IsWatched = true,
                    GenreId = 5,
                    DirectorId = 1
                },
                new Movie
                {
                    Id = 103,
                    Title = "Inception",
                    Description = "A skilled thief enters dreams to steal valuable secrets.",
                    ReleaseYear = 2010,
                    Rating = 8.8m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/pIkRyD18kl4FhoCNQuWxWu5cBLM.jpg",
                    IsWatched = true,
                    GenreId = 5,
                    DirectorId = 1
                },
                new Movie
                {
                    Id = 104,
                    Title = "Oppenheimer",
                    Description = "The story of the physicist who helped develop the atomic bomb.",
                    ReleaseYear = 2023,
                    Rating = 8.6m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg",
                    IsWatched = false,
                    GenreId = 3,
                    DirectorId = 1
                },
                new Movie
                {
                    Id = 105,
                    Title = "Pulp Fiction",
                    Description = "Interconnected crime stories unfold in Los Angeles.",
                    ReleaseYear = 1994,
                    Rating = 8.9m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg",
                    IsWatched = true,
                    GenreId = 3,
                    DirectorId = 3
                },
                new Movie
                {
                    Id = 106,
                    Title = "Django Unchained",
                    Description = "A freed slave joins a bounty hunter on a dangerous mission.",
                    ReleaseYear = 2012,
                    Rating = 8.5m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg",
                    IsWatched = false,
                    GenreId = 1,
                    DirectorId = 3
                },
                new Movie
                {
                    Id = 107,
                    Title = "The Godfather",
                    Description = "The Corleone family struggles with power, loyalty and organized crime.",
                    ReleaseYear = 1972,
                    Rating = 9.2m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
                    IsWatched = true,
                    GenreId = 3,
                    DirectorId = 7
                },
                new Movie
                {
                    Id = 108,
                    Title = "Goodfellas",
                    Description = "A young man rises through the ranks of organized crime.",
                    ReleaseYear = 1990,
                    Rating = 8.7m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg",
                    IsWatched = true,
                    GenreId = 3,
                    DirectorId = 4
                },
                new Movie
                {
                    Id = 109,
                    Title = "The Wolf of Wall Street",
                    Description = "A stockbroker builds a fortune through fraud and excess.",
                    ReleaseYear = 2013,
                    Rating = 8.2m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/34m2tygAYBGqA9MXKhRDtzYd4MR.jpg",
                    IsWatched = false,
                    GenreId = 2,
                    DirectorId = 4
                },
                new Movie
                {
                    Id = 110,
                    Title = "The Lord of the Rings: The Return of the King",
                    Description = "The final battle for Middle-earth begins.",
                    ReleaseYear = 2003,
                    Rating = 9.0m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg",
                    IsWatched = true,
                    GenreId = 9,
                    DirectorId = 12
                },
                new Movie
                {
                    Id = 111,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "A young hobbit begins a journey to destroy a powerful ring.",
                    ReleaseYear = 2001,
                    Rating = 8.8m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg",
                    IsWatched = true,
                    GenreId = 9,
                    DirectorId = 12
                },
                new Movie
                {
                    Id = 112,
                    Title = "Titanic",
                    Description = "A romance unfolds aboard the ill-fated ocean liner.",
                    ReleaseYear = 1997,
                    Rating = 7.9m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg",
                    IsWatched = true,
                    GenreId = 8,
                    DirectorId = 5
                },
                new Movie
                {
                    Id = 113,
                    Title = "Avatar",
                    Description = "A former marine explores the alien world of Pandora.",
                    ReleaseYear = 2009,
                    Rating = 7.9m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/kyeqWdyUXW608qlYkRqosgbbJyK.jpg",
                    IsWatched = false,
                    GenreId = 5,
                    DirectorId = 5
                },
                new Movie
                {
                    Id = 114,
                    Title = "Gladiator",
                    Description = "A Roman general becomes a gladiator seeking justice.",
                    ReleaseYear = 2000,
                    Rating = 8.5m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg",
                    IsWatched = true,
                    GenreId = 1,
                    DirectorId = 10
                },
                new Movie
                {
                    Id = 115,
                    Title = "Alien",
                    Description = "A spaceship crew encounters a terrifying extraterrestrial creature.",
                    ReleaseYear = 1979,
                    Rating = 8.5m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg",
                    IsWatched = false,
                    GenreId = 4,
                    DirectorId = 10
                },
                new Movie
                {
                    Id = 116,
                    Title = "Se7en",
                    Description = "Two detectives investigate a series of disturbing murders.",
                    ReleaseYear = 1995,
                    Rating = 8.6m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/191nKfP0ehp3uIvWqgPbFmI4lv9.jpg",
                    IsWatched = true,
                    GenreId = 6,
                    DirectorId = 11
                },
                new Movie
                {
                    Id = 117,
                    Title = "Fight Club",
                    Description = "An office worker becomes involved in an underground fighting movement.",
                    ReleaseYear = 1999,
                    Rating = 8.8m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg",
                    IsWatched = true,
                    GenreId = 3,
                    DirectorId = 11
                },
                new Movie
                {
                    Id = 118,
                    Title = "Dune: Part Two",
                    Description = "Paul Atreides joins the Fremen and faces his destiny.",
                    ReleaseYear = 2024,
                    Rating = 8.5m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/1pdfLvkbY9ohJlCjQH2CZjjYVvJ.jpg",
                    IsWatched = false,
                    GenreId = 5,
                    DirectorId = 13
                },
                new Movie
                {
                    Id = 119,
                    Title = "Spirited Away",
                    Description = "A young girl enters a mysterious world of spirits.",
                    ReleaseYear = 2001,
                    Rating = 8.6m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg",
                    IsWatched = true,
                    GenreId = 7,
                    DirectorId = 19
                },
                new Movie
                {
                    Id = 120,
                    Title = "The Grand Budapest Hotel",
                    Description = "A hotel concierge and his apprentice become involved in an unusual adventure.",
                    ReleaseYear = 2014,
                    Rating = 8.1m,
                    ImageUrl = "https://image.tmdb.org/t/p/w500/eWdyYQreja6JGCzqHWXpWHDrrPo.jpg",
                    IsWatched = false,
                    GenreId = 2,
                    DirectorId = 14
                }
            );
        }
    }
}