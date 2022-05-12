using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringPractices.MovieClasses
{
   public class Rental
    {
        private Movie _movie;
        private int _daysRented;
        public Rental(Movie movie, int rentedDays)
        {
            _movie = movie;
            _daysRented = rentedDays;
        }
        public int getRentedDays()
        {
            return _daysRented;
        }
        public Movie  getMovie ()
        {
            return _movie;
        }

        public double GetAmount()
        {
            return getMovie().Amount(getMovie(), getRentedDays());
        }

        public int GetFreqRentalPoints()
        {
            return getMovie().GetFreqRentalPoints(getMovie(), getRentedDays());
        }


    }
}
