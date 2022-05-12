namespace RefactoringPractices.MovieClasses
{
    internal class RegularPrice : Price
    {

        public RegularPrice() : base(Movie.Regular)
        {
        }

        public override double Amount(int daysRented)
        {
            double totalAmount = 2;
            if (daysRented > 2)
            {
                totalAmount += (daysRented - 2) * 1.5;
            }

            return totalAmount;
        }

        public override int GetFreqRentalPoints(int daysRented)
        {
            return 1;
        }
    }
}