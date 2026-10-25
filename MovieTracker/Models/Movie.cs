namespace MovieTracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public decimal Rating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public bool IsWatched  { get; set; }

        public int GenreId { get; set; }
        
        public int DirectorId { get; set; }

        public Genre Genre { get; set; } = null!;

        public Director Director { get; set; } = null!;

        






    }
}
