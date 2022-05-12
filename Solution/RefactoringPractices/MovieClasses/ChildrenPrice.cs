namespace RefactoringPractices.MovieClasses
{
    internal class ChildrenPrice : Price
    {
        private int children;

        public ChildrenPrice() : base(Movie.Children)
        {
        }

        public override double Amount(int daysRented)
        {
            double totalAmount = 1.5;
            if (daysRented > 3)
            {
                totalAmount += (daysRented - 3) * 1.5;
            }

            return totalAmount;
        }
        public override int GetFreqRentalPoints(int daysRented)
        {
            return 1;
        }
    }

}