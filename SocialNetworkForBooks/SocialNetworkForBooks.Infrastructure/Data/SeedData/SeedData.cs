using Microsoft.AspNetCore.Identity;
using SocialNetworkForBooks.Infrastructure.Data.Models;
using System;

namespace SocialNetworkForBooks.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser GuestUser { get; set; }

        public IdentityUserClaim<string> AdminUserClaim { get; set; }
        public IdentityUserClaim<string> GuestUserClaim { get; set; }

        public Genre ClassicGenre { get; set; }
        public Genre RomanceGenre { get; set; }

        public Book FirstBook { get; set; }
        public Book SecondBook { get; set; }

        public BookGenre FirstBookGenre { get; set; }
        public BookGenre SecondBookGenre { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedGenres();
            SeedBooks();
            SeedBookGenres();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser
            {
                Id = "admin-id-123",
                UserName = "admin@socialbooks.com",
                NormalizedUserName = "ADMIN@SOCIALBOOKS.COM",
                Email = "admin@socialbooks.com",
                NormalizedEmail = "ADMIN@SOCIALBOOKS.COM",
                FirstName = "Admin",
                LastName = "User"
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin123");

            GuestUser = new ApplicationUser
            {
                Id = "guest-id-456",
                UserName = "guest@socialbooks.com",
                NormalizedUserName = "GUEST@SOCIALBOOKS.COM",
                Email = "guest@socialbooks.com",
                NormalizedEmail = "GUEST@SOCIALBOOKS.COM",
                FirstName = "Guest",
                LastName = "User"
            };
            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest123");

            AdminUserClaim = new IdentityUserClaim<string>
            {
                Id = 1,
                ClaimType = "UserRole",
                ClaimValue = "Administrator",
                UserId = AdminUser.Id
            };
            GuestUserClaim = new IdentityUserClaim<string>
            {
                Id = 2,
                ClaimType = "UserRole",
                ClaimValue = "Guest",
                UserId = GuestUser.Id
            };
        }

        private void SeedGenres()
        {
            ClassicGenre = new Genre { Id = 1, Name = "Classic" };
            RomanceGenre = new Genre { Id = 2, Name = "Romance" };
        }

        private void SeedBooks()
        {
            FirstBook = new Book
            {
                Id = 1,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                PublicationDate = new DateTime(1813, 1, 28),
                Description = "A classic romance novel.",
                CoverImageUrl = "https://example.com/pride.jpg"
            };

            SecondBook = new Book
            {
                Id = 2,
                Title = "Wuthering Heights",
                Author = "Emily Brontë",
                PublicationDate = new DateTime(1847, 12, 17),
                Description = "A story of intense love and revenge.",
                CoverImageUrl = "https://example.com/wuthering.jpg"
            };
        }

        private void SeedBookGenres()
        {
            FirstBookGenre = new BookGenre
            {
                BookId = FirstBook.Id,
                GenreId = ClassicGenre.Id
            };

            SecondBookGenre = new BookGenre
            {
                BookId = SecondBook.Id,
                GenreId = RomanceGenre.Id
            };
        }
    }
}
