using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetworkForBooks.Infrastructure.Data.Models;

namespace SocialNetworkForBooks.Infrastructure.Data.SeedDb
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();
            builder.HasData(data.AdminUser, data.GuestUser);
        }
    }
}
