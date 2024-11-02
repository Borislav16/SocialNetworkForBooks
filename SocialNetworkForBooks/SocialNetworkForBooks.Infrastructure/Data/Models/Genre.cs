using Microsoft.EntityFrameworkCore;
using SocialNetworkForBooks.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkForBooks.Infrastructure.Data.Models
{
    public class Genre
    {
        [Key]
        [Comment("Unique identifier for each genre.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.GenreNameMaxLength)]
        [Comment("The name of the genre.")]
        public string Name { get; set; } = null!;

        public IList<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
