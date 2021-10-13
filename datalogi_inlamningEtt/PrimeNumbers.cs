using System;
using System.Collections.Generic;
using System.Linq;

namespace datalogi_inlamningEtt
{
    class PrimeNumbers
    {
        readonly List<int> primeNumbersList = new();

        /// <summary>
        /// Calculates if the number is a prime number, or not.
        /// </summary>
        /// <param name="userInput">The input from the user</param>
        /// <returns>True if number is a prime number, and false if not.</returns>
        public bool CalculateIfPrimeNumber(int userInput)
        {
            if (userInput <= 1 || userInput != 2 && userInput % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < userInput; i++)
                {
                    if (userInput % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Adds a number to the list, if it does not alredy exist.
        /// And then sorts the numbers in the list.
        /// </summary>
        /// <param name="number">The prime number to add to list.</param>
        /// <returns>True if number did not alredy exist, and false if it did.</returns>
        public bool AddNumberToList(int number)
        {
            if (!primeNumbersList.Contains(number))
            {
                primeNumbersList.Add(number);
                primeNumbersList.Sort();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Lists all the numbers in the list of prime numbers.
        /// If the list is empty, a message will be printed.
        /// </summary>
        public void ListAllPrimeNumber()
        {
            if (primeNumbersList.Count > 0)
            {
                ColorText.TextYellow("The list contains the following prime numbers: ");
                foreach (var number in primeNumbersList)
                {
                    ColorText.TextCyan(number);
                    if (number != primeNumbersList[^1])
                    {
                        Console.Write(" | ");
                    }
                }
            }
            else
            {
                ColorText.TextRed("The list does not contain any prime numbers.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Checks for the next number that is a prime number.
        /// Adds the number to the list.
        /// And when it's found, it returns the number to the menu class.
        /// </summary>
        public int CheckNextPrimenNumber()
        {
            bool found = false;
            int highestNumber = 0;

            if (primeNumbersList.Count > 0)
            {
                highestNumber = primeNumbersList.Last();
            }
            while (!found)
            {
                highestNumber++;
                if (CalculateIfPrimeNumber(highestNumber))
                {
                    AddNumberToList(highestNumber);
                    found = true;
                }
            }
            return highestNumber;

        }
    }
}
