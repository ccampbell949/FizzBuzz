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

        internal static string ValidateInput(string input)
        {
            while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out _))
        {
            Console.WriteLine("Please enter a valid number");
            var result= Console.ReadLine();
            
        }
            return result;
}
