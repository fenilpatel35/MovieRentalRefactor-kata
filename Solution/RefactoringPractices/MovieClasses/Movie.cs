using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringPractices.MovieClasses
{
    public class Movie
    {
        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Children = 2;

        private readonly string _title;
        private Price _price;

        public Movie(string title, Price price)
        {
            _title = title;
            _price = price;
        }

        public int GetPriceCode()
        {
            return _price.PriceCode();
        }

        public string Title
        {
            get { return _title; }
        }

        public double Amount(Movie movie, int daysRented)
        {
            return _price.Amount(daysRented);
        }

        public int GetFreqRentalPoints(Movie movie, int daysRented)
        {
            return _price.GetFreqRentalPoints(daysRented);
        }


    }



}
