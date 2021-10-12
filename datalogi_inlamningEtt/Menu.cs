using System;
using System.Threading;

namespace datalogi_inlamningEtt
{
    class Menu
    {
        PrimeNumbers prime = new PrimeNumbers();
        bool keepGoing = true;
        ColorText text = new ColorText();

        public void MainMenu()
        {
            do {
                Console.Clear();
                Console.WriteLine("What do you want to do? \n");
                text.TextYellow("[1] Check primenumber. \n[2] List primenumbers. " +
                    "\n[3] Check next primenumber. \n[0] Exit.");
                Console.Write("\nChoice: ");

                var checkChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (checkChoice)
                {
                    Console.Write("Enter number: ");
                    var checkInput = int.TryParse(Console.ReadLine(), out int userInput);

                    switch (choice)
                    {
                        case 1:
                           if (prime.CalculateIfPrimeNumber(userInput))
                            {
                                text.TextGreen("The number you entered was a prime number.");
                            }
                            else
                            {
                                text.TextRed("You did not enter a prime number.");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            prime.ListAllPrimeNumber();
                            break;
                        case 3:
                            prime.CheckNextPrimenNumber();
                            break;
                        case 0:
                            Console.WriteLine("Goodbye");
                            keepGoing = false;
                            Environment.Exit(0);
                            break;
                    }
                }
                else 
                {
                    text.TextRed("Wrong input. Press enter, and try again!");
                    Console.ReadKey();
                }

            } while(keepGoing);
        }
    }
}
