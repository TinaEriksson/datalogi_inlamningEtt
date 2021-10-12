using System;
using System.Collections.Generic;
using System.Linq;

namespace datalogi_inlamningEtt
{
    class PrimeNumbers
    {
        List<int> primeNumbersList = new List<int>();
        ColorText text = new ColorText();

        /// <summary>
        /// Method that takes a input and checks if it's a prime number.
        /// If true the number gets added to a list of prime-numbers.
        /// </summary>
        /// <returns>True if the input is a prime number, and false if it's not.</returns>
        public bool CalculateIfPrimeNumber(int userInput)
        {
            Console.Clear();

            if (userInput <= 1)
            {
                return false;
            }
            else if (userInput != 2 && userInput % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < userInput; i++)
            {
                if(userInput %i == 0)
                {
                    return false;
                }
            }
            primeNumbersList.Add(userInput);
            return true;
        }

        /// <summary>
        /// Lists all the numbers in the list of prime numbers.
        /// </summary>
        public void ListAllPrimeNumber()
        {
            Console.Clear();


            text.TextYellow("The list contains the following prime-numbers: ");
            foreach (var number in primeNumbersList)
            {
                text.TextCyan(number);
                if(number != primeNumbersList[^1])
                {
                    Console.Write(" | ");
                } 
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CheckNextPrimenNumber()
        {
            if(primeNumbersList.Count != 0)
            {
                primeNumbersList.Sort();
                int highestNumber = primeNumbersList.Last();
            }

         



          Console.ReadKey();
        }
    }
}
