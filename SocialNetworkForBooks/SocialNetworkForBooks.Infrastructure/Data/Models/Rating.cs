using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class Rating
    {
        [Key]
        [Comment("Unique identifier for each rating.")]
        public int Id { get; set; }

        [Required]
        [Comment("The ID of the book being rated.")]
        public int BookId { get; set; }

        [Required]
        [ForeignKey(nameof(BookId))]
        [Comment("The book that is being rated.")]
        public Book Book { get; set; } = null!;

        [Required]
        [Comment("The ID of the user who gave the rating.")]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        [Comment("The user who provided the rating.")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("The rating value, typically between 1 and 5.")]
        public int Value { get; set; }
    }
}
