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
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
			{
                num[i] = i + 1;
			}

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

			/* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */


			foreach (int evenNumber in num)
			{
				int newEvenNumber = evenNumber % 2;
				if (newEvenNumber == 0)
				{
					evens.Add(evenNumber);

				}

			}

            foreach (int oddNumber in num)
			{
                int newOddNumber = oddNumber % 2;
                if (newOddNumber == 1)
				{
                    odds.Add(oddNumber);
				}
			}

            foreach(var even in evens)
			{
				Console.WriteLine(even);
			}

            foreach(var odd in odds)
			{
                Console.WriteLine(odd);
			}

			/* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

		}
    }
}
