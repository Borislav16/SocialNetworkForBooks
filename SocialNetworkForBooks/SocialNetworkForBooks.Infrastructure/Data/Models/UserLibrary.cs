using Microsoft.EntityFrameworkCore;
using SocialNetworkForBooks.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class UserLibrary
    {
        [Key]
        [Comment("Unique identifier for each entry in the user's library.")]
        public int Id { get; set; }

        [Required]
        [Comment("The ID of the book associated with this user entry.")]
        public int BookId { get; set; }

        [Required]
        [ForeignKey(nameof(BookId))]
        [Comment("The book associated with this user entry.")]
        public Book Book { get; set; } = null!;

        [Required]
        [Comment("The ID of the user associated with this entry.")]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        [Comment("The user who added this book to their library.")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.UserBookStatusMaxLength)]
        [Comment("The status of the book in the user's library (e.g., 'Read', 'Want to Read').")]
        public string Status { get; set; } = null!;
    }
}
