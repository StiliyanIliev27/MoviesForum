using Microsoft.EntityFrameworkCore;
using MoviesForum.Infrastructure.Data.Configurations;
using MoviesForum.Infrastructure.Data.Models;

namespace MoviesForum.Infrastructure.Data
{
    public class MoviesForumDbContext : DbContext
    {
        public MoviesForumDbContext(DbContextOptions<MoviesForumDbContext> options) : base(options)
        {
        }
        public DbSet<Director> Directors { get; set; } = null!;
        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Actor> Actors { get; set; } = null!;
        public DbSet<MoviesActors> MoviesActors { get; set; } = null!;
        public DbSet<MoviesDirectors> MoviesDirectors { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MoviesActorsConfiguration());
            builder.ApplyConfiguration(new MoviesDirectorsConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
