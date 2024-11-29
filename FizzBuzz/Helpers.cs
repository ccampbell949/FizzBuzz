using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Helpers
    {
        //validate the input in here
        //check it is:
        //not null
        //is an integer

        internal static int ValidateInputNumber()
        {
            string? result;
            int validNumber;
            Console.WriteLine("Please enter a whole number");
            result = Console.ReadLine();

            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out validNumber) || validNumber <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                result = Console.ReadLine();
            } 
            
            return validNumber;
        }

        internal static string ValidateInputLetter(string input)
        {
            string? result = input.ToUpper();

            while (string.IsNullOrEmpty(input) || (result != "N" && result != "Y") || input.Length > 1)
            {
                Console.WriteLine("Please enter a valid character (y/n)");
                result = Console.ReadLine()?.ToUpper();

                if (string.IsNullOrEmpty(result))
                {
                    continue;
                }

                if (result.Length > 1)
                {
                    Console.WriteLine("Please only enter a single character");
                }
            }

            return result;
        }
    }
}
