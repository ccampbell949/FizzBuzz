using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace FizzBuzz
{
    internal class StartupMenu
    {
        internal static void Menu()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Would you like to play a game? Y/N");
            var userInput = Console.ReadLine();

            var validCharacter = Helpers.ValidateInputLetter(userInput);

            //if the user selects Y, then continue with program
            //if user selects n, then close program
            switch (validCharacter.ToUpper())
            {
                case "Y":
                {
                    break;
                }
                case "N":
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
