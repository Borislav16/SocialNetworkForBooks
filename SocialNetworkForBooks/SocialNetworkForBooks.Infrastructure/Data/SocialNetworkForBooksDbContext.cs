using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SocialNetworkForBooks.Infrastructure.Data
{
    public class SocialNetworkForBooksDbContext : IdentityDbContext
    {
        public SocialNetworkForBooksDbContext(DbContextOptions<SocialNetworkForBooksDbContext> options)
            : base(options)
        {
        }
    }
}
