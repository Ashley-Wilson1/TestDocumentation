using System;

namespace TestDocumentation
{
    /// <summary>
    /// Program is a generic class that doesn't do much.
    /// by Ashley Wilson
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point to the program.
        /// </summary>
        /// <param name="args">Array of strings from the command line.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// Compare two integers and outputs the biggest, zero if equal.
        /// </summary>
        /// <param name="number1">First number to compare.</param>
        /// <param name="number2">Second number to compare.</param>
        /// <returns>Bigeest integer or zero if equal.</returns>
        public int compare(int number1, int number2)
        {
            if (number1 > number2)
                return number1;
            else if (number1 < number2)
                return number2;
            else
                return 0;
        }

    }
}