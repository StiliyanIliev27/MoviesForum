using MoviesForum.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesForum.Infrastructure.Data.Models
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Duration { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public int YearReleased { get; set; }
        public string? Description { get; set; } 
        public int Rating { get; set; }
    }
}
