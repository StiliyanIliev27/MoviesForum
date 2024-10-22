using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesForum.Infrastructure.Data.Models
{
    public class MoviesDirectors
    {
        [Required]
        [ForeignKey(nameof(MovieId))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(DirectorId))]
        public Guid DirectorId { get; set; }
        public Director Director { get; set; } = null!;
    }
}
