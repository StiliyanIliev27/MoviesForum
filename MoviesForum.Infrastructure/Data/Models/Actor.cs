using MoviesForum.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesForum.Infrastructure.Data.Models
{
    public class Actor
    {
        public Actor()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public Sex Sex { get; set; } 
    }
}
