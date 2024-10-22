using System.ComponentModel.DataAnnotations;

namespace MoviesForum.Infrastructure.Data.Models
{
    public class Director
    {
        public Director()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; } = null!;
    }
}
