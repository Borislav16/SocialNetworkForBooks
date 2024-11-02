using Microsoft.EntityFrameworkCore;
using SocialNetworkForBooks.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        [Comment("Unique identifier for each review.")]
        public int Id { get; set; }

        [Required]
        [Comment("The ID of the book being reviewed.")]
        public int BookId { get; set; }

        [Required]
        [ForeignKey(nameof(BookId))]
        [Comment("The book that is being reviewed.")]
        public Book Book { get; set; } = null!;

        [Required]
        [Comment("The ID of the user who created the review.")]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        [Comment("The user who created the review.")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(DataConstants.ReviewContentMaxLength)]
        [Comment("The content of the review provided by the user.")]
        public string Content { get; set; } = null!;

        [Comment("The date and time when the review was created.")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
