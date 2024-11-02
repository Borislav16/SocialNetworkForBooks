namespace SocialNetworkForBooks.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int BookTitleMaxLength = 60;
        public const int BookAuthorMaxLength = 50;
        public const int BookDescriptionMaxLength = 400;
        public const int BookCoverImageUrlMaxLength = 255;

        public const int GenreNameMaxLength = 30;

        public const int ReviewContentMaxLength = 1000;

        public const int UserBookStatusMaxLength = 20;

        public const int RatingMinValue = 1;
        public const int RatingMaxValue = 5;

        public const int UserFirstNameMinLength = 2;
        public const int UserFirstNameMaxLength = 50;
        public const int UserLastNameMinLength = 2;
        public const int UserLastNameMaxLength = 50;
    }
}
