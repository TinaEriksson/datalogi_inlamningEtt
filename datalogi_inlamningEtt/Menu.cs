﻿using System;
using System.Threading;

namespace datalogi_inlamningEtt
{
    class Menu
    {
        readonly PrimeNumbers prime = new();
        bool keepGoing = true;

        /// <summary>
        /// A method for the menu with a switch case for the different choices,
        /// and that keeps going as long as the user wants to. 
        /// </summary>
        public void MainMenu()
        {
            do {
                Console.Clear();
                Console.WriteLine("What do you want to do? \n");
                ColorText.TextYellow("[1] Check primenumber. \n[2] List primenumbers. " +
                    "\n[3] Check next primenumber. \n[0] Exit.");
                Console.Write("\nChoice: ");

                var checkChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (checkChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter number: ");
                            var checkInput = int.TryParse(Console.ReadLine(), out int userInput);
                            if (prime.CalculateIfPrimeNumber(userInput))
                            {
                                if (prime.AddNumberToList(userInput))
                                {
                                    ColorText.TextGreen("The number was a prime number, and was added to the list.");
                                }
                                else
                                {
                                    ColorText.TextGreen("The number was a prime number but alredy existed in the list.");
                                }
                            }
                            else
                            {
                                ColorText.TextRed("The number was not a prime number..");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            prime.ListAllPrimeNumber();
                            break;
                        case 3:
                            ColorText.TextYellow("The next prime number is: " + prime.CheckNextPrimenNumber());
                            Console.ReadKey();
                            break;
                        case 0:
                            ColorText.TextYellow("Goodbye");
                            keepGoing = false;
                            Console.ReadKey();
                            break;
                    }
                }
                else 
                {
                    ColorText.TextRed("Wrong input. Press enter, and try again!");
                    Console.ReadKey();
                }

            } while(keepGoing);
        }
    }
}
