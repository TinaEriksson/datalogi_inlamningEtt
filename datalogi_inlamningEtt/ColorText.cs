using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalogi_inlamningEtt
{

    /// <summary>
    /// A helper class that colors the text.
    /// </summary>
    class ColorText
    {
        /// <summary>
        /// Colors the input text red.
        /// </summary>
        /// <param name="text">The input text sent in</param>
        public static void TextRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Colors the input text green.
        /// </summary>
        /// <param name="text">The input text sent in</param>
        public static void TextGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        /// Colors the input text Yellow.
        /// </summary>
        /// <param name="text">The input text sent in</param>
        public static void TextYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }


        /// <summary>
        /// Colors the input sent in.
        /// </summary>
        /// <param name="numbers">The numbers sent in</param>
        public static void TextCyan(int numbers)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(numbers);
            Console.ResetColor();
        }

    }
}
