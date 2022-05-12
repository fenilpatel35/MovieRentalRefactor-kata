using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RefactoringPractices.MovieClasses;

namespace RefactoringPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating movies
            Movie t12 = new Movie("Titanic 2012", new NewReleasePrice());
            Movie HF2 = new Movie("Housefull 2 2010", new RegularPrice());
            Movie chump= new Movie("Chimpanjee", new ChildrenPrice());
            Movie shuarya = new Movie("Shaurya", new RegularPrice());

            // setting rental
            Rental titanicR = new Rental(t12, 2);
            Rental hf2R = new Rental(HF2, 3);
            Rental chimpanzeeR = new Rental(chump, 2);

            // customer
            Customer anshul = new Customer("Anshul Pandey");
            anshul.AddRental(titanicR);
            anshul.AddRental(hf2R);
            anshul.AddRental(chimpanzeeR);

            // calculate pricing
            anshul.Statement();

            Console.ReadLine();
        }
    }
}
