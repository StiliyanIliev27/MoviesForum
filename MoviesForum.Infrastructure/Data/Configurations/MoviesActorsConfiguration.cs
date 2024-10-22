using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesForum.Infrastructure.Data.Models;

namespace MoviesForum.Infrastructure.Data.Configurations
{
    internal class MoviesActorsConfiguration : IEntityTypeConfiguration<MoviesActors>
    {
        public void Configure(EntityTypeBuilder<MoviesActors> builder)
        {
            builder
                .HasKey(ma => new { ma.MovieId, ma.ActorId });
        }
    }
}
