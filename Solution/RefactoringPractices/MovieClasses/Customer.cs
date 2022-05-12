using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace RefactoringPractices.MovieClasses
{
    class Customer
    {
        public String Name { get; set; }
        public List<Rental> Rentals = new List<Rental>();
        public Customer(String _name)
        {
            Name = _name;
        }

        public void  AddRental (Rental rental )
        {
            Rentals.Add(rental);
        }

        public String Statement ()
        {
            String statement = "Your total rental Charges";
            int rentalPoints = 0;
            double totalAmount = 0.0;

            foreach (Rental rental in Rentals)
            {
                int freqPoint = rental.GetFreqRentalPoints();
                rentalPoints += freqPoint;
                double thisMovieAmount = rental.GetAmount();
                totalAmount += thisMovieAmount;
                WriteOutputOfRental(rental.getMovie().Title, thisMovieAmount, freqPoint);
            }

            WriteOutputOfMyTotalRental(Rentals.Count, totalAmount, rentalPoints);
            return statement;
        }

        private void WriteOutputOfRental(string moveTitle, double totalAmount, int frqRentalPoints)
        {
            // console write here...
            string outputValue = String.Format("For Move:: {0} you were charged {1} and you earned {2} points.", moveTitle, totalAmount, frqRentalPoints);
            Console.WriteLine(outputValue);
        }

        private void WriteOutputOfMyTotalRental(int movieCount, double finalAmount, int rentalPoints)
        {
            // console write here...
            Console.WriteLine("**********************************closing Statement****************** ");
            string outputValue = String.Format("Total movies rented:: {0}, Total charges {1}, and Total rental points earned {2}.", movieCount, finalAmount, rentalPoints);
            Console.WriteLine(outputValue);
        }

        
    }
}
