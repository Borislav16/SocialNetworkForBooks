using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialNetworkForBooks.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.UserFirstNameMaxLength)]
        [Comment("The first name of the user, with a minimum length of 2 and a maximum length of 50 characters.")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.UserLastNameMaxLength)]
        [Comment("The last name of the user, with a minimum length of 2 and a maximum length of 50 characters.")]
        public string LastName { get; set; } = null!;

        [Comment("The date and time when the user was created.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<UserLibrary> UserBooks { get; set; } = new List<UserLibrary>();
    }
}
