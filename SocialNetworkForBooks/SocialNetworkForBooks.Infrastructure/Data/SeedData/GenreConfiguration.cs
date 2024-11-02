using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetworkForBooks.Infrastructure.Data.Models;

namespace SocialNetworkForBooks.Infrastructure.Data.SeedDb
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            var data = new SeedData();
            builder.HasData(data.ClassicGenre, data.RomanceGenre);
        }
    }
}
