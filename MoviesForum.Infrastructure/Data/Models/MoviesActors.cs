using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesForum.Infrastructure.Data.Models
{
    public class MoviesActors
    {
        [Required]
        [ForeignKey(nameof(MovieId))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ActorId))]
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
