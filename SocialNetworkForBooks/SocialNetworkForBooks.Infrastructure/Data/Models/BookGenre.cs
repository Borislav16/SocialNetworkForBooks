using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    [PrimaryKey(nameof(BookId), nameof(GenreId))]
    public class BookGenre
    {
        [Required]
        [Comment("The ID of the book associated with this genre.")]
        public int BookId { get; set; }

        [Required]
        [ForeignKey(nameof(BookId))]
        [Comment("The book associated with this genre.")]
        public Book Book { get; set; } = null!;

        [Required]
        [Comment("The ID of the genre associated with this book.")]
        public int GenreId { get; set; }

        [Required]
        [ForeignKey(nameof(GenreId))]
        [Comment("The genre associated with this book.")]
        public Genre Genre { get; set; } = null!;
    }
}
