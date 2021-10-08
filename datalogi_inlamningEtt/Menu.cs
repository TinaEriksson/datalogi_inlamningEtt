using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalogi_inlamningEtt
{
    class Menu
    {
        public void MainMenu()
        {
                Console.WriteLine("Hello. What do you want to do? \n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[1] Check primenumber. \n[2] List primenumbers. " +
                    "\n[3] Check next primenumber. \n[0] Exit.");
                Console.ResetColor();
            Console.Write("Choice: ");
            var choice = Convert.ToInt32(Console.ReadLine();

            switch(choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Wrong input. Try again!");
                    break;
            }
        }

    }
}
