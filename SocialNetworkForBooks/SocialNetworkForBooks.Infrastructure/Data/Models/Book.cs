using Microsoft.EntityFrameworkCore;
using SocialNetworkForBooks.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.BookTitleMaxLength)]
        [Comment("The title of the book.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.BookAuthorMaxLength)]
        [Comment("The author of the book.")]
        public string Author { get; set; } = string.Empty;

        public DateTime PublicationDate { get; set; }

        [MaxLength(DataConstants.BookDescriptionMaxLength)]
        [Comment("A brief description of the book.")]
        public string? Description { get; set; }

        [MaxLength(DataConstants.BookCoverImageUrlMaxLength)]
        [Comment("URL to the cover image of the book.")]
        public string? CoverImageUrl { get; set; }

        // Navigation properties
        public IList<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();
        public IList<UserBook> UserBooks { get; set; } = new List<UserBook>();
    }
}

