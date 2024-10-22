using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesForum.Infrastructure.Data.Models;

namespace MoviesForum.Infrastructure.Data.Configurations
{
    internal class MoviesDirectorsConfiguration : IEntityTypeConfiguration<MoviesDirectors>
    {
        public void Configure(EntityTypeBuilder<MoviesDirectors> builder)
        {
            builder
                .HasKey(md => new { md.MovieId, md.DirectorId });
        }
    }
}
