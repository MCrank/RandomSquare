using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 ## Instructions

                    1. Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.
                    2. With the resulting List, populate a new List that contains each number squared. For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
                    3. Then remove any number that is odd from the list of squared numbers.
             */

            Random random = new Random();
            
            // Create a lists
            var randomNumbers = new List<int>();
            var squaredNumbers = new List<int>();

            // Generate 20 Random numbers and populate first List
            for (int i = 0; i < 20; i++)
            {
                randomNumbers.Add(random.Next(50));
            }
            
            // Populate the Squared list and removed Odd squared number
            foreach (int number in randomNumbers)
            {
                var squared = number * number;
                if (squared % 2 != 1)
                {
                    squaredNumbers.Add(squared);
                }
            }

            Console.WriteLine("The Random squared event numbers are:\n ");
            foreach (var resultNumber in squaredNumbers)
            {
                Console.WriteLine(resultNumber);
            }
            Console.ReadLine();
        }
    }
}
