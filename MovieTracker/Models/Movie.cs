using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieTracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Movie title is required.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Title must be between 2 and 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000,
            ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1888, 2100,
            ErrorMessage = "Enter a valid release year.")]
        public int ReleaseYear { get; set; }

        [Range(typeof(decimal), "0", "10",
            ErrorMessage = "Rating must be between 0 and 10.")]
        public decimal Rating { get; set; }

        [Url(ErrorMessage = "Please enter a valid image URL.")]
        public string? ImageUrl { get; set; }

        public bool IsWatched { get; set; }

        [Range(1, int.MaxValue,
            ErrorMessage = "Please select a genre.")]
        public int GenreId { get; set; }

        [Range(1, int.MaxValue,
            ErrorMessage = "Please select a director.")]
        public int DirectorId { get; set; }

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        [ValidateNever]
        public Director Director { get; set; } = null!;
    }
}