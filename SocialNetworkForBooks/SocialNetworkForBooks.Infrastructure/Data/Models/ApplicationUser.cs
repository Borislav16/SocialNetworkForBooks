using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Comment("The date and time when the user was created.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<UserLibrary> UserBooks { get; set; } = new List<UserLibrary>();
    }
}
