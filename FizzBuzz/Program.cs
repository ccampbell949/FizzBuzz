using System.ComponentModel;
using FizzBuzz;

//want to ask user for input

//while gameon is true, i want to keep asking for a valid number and running fizzbuzz, and also if the number is invalid, keep asking for a new one


var gameOn = true;

do
{
Console.WriteLine("Welcome to FizzBuzz!");
Console.WriteLine("Please enter a whole number: ");
var inputString = Console.ReadLine();

GameLogic.FizzBuzz(inputString);

    

} while (gameOn);



