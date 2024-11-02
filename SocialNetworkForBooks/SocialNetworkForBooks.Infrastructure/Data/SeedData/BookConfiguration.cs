using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetworkForBooks.Infrastructure.Data.Models;

namespace SocialNetworkForBooks.Infrastructure.Data.SeedDb
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            var data = new SeedData();
            builder.HasData(data.FirstBook, data.SecondBook);
        }
    }
}
