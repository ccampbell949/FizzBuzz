using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class StartupMenu
    {
        internal static void Menu()
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Would you like to play a game? Y/N");
            var userInput = Console.ReadLine();

            var validCharacter = Helpers.ValidateInputLetter(userInput);



  Switch
    }
}
