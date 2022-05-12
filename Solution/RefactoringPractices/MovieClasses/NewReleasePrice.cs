namespace RefactoringPractices.MovieClasses
{
    internal class NewReleasePrice : Price
    {
        public NewReleasePrice() : base(Movie.NewRelease)
        {
        }

        public override double Amount(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFreqRentalPoints (int daysRented)
        {
            return 2;
        }
    }
}