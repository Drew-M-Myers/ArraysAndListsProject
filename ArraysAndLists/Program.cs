using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            
            var myArray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("Now class, what are the even numbers between 1 and 10?");
            Console.WriteLine("");

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach(var num in myArray)
            {
                if (num % 2 == 0) 
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.WriteLine("That is right Timmy! The numbers are");
            Console.WriteLine("");
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             * 
             * Try to be creative in your display
             */

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("Now, what are the odd numbers between 1 and 10?");
            Console.WriteLine("");
            Console.WriteLine("That is right Suzzie! The numbers are");
            Console.WriteLine("");

            foreach (int num in odds)
            {
                Console.WriteLine(num);
            }





            /*I made this before watching the Excersise 2 walkthrough. It worked, but I think it isn't 
              as efficient as it could have been since it didn't really pull from the array. With the 
              for loop, it would just add even numbers by counting from 2 by two, and doing the same for
              the odd, but starting at one. So there wasn't the pulling from the array.
            */

            /*
             
            Console.WriteLine("Now class, what are the even numbers between 1 and 10?");
            Console.WriteLine("");

            for (int i = 2; i <= 10; i += 2)
            {
                evens.Add(i);
            }

            Console.WriteLine("That is right Timmy! The numbers are");
            Console.WriteLine("");

            foreach (var num in evens)
            {
               Console.WriteLine($"{num}");
            }

            Console.WriteLine("");
            Console.WriteLine("Now, what are the odd numbers between 1 and 10?");
            Console.WriteLine("");

            for (int i = 1; i <= 10; i += 2)    
            {
                odds.Add(i);
            }

            Console.WriteLine("That is right Suzzie! The numbers are");
            Console.WriteLine("");

            foreach (int num in odds)
            {
               Console.WriteLine($"{num}");
            }
            */
        }
    }
}
