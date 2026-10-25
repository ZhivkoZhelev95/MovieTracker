using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieTracker.Models

{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public decimal Rating { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsWatched  { get; set; }

        public int GenreId { get; set; }
        
        public int DirectorId { get; set; }

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        [ValidateNever]
        public Director Director { get; set; } = null!;








    }
}
