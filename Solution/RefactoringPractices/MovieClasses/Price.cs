namespace RefactoringPractices.MovieClasses
{
    public abstract class Price
    {
        private int _priceCode;

        public Price(int priceCode)
        {
            this._priceCode = priceCode;
        }

        public int PriceCode()
        {
            return _priceCode;
        }

        public abstract double Amount(int daysRented);

        public abstract int GetFreqRentalPoints(int daysRented);
    }
}