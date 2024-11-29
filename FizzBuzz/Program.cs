using System.ComponentModel;
using FizzBuzz;

var gameOn = true;

do
{

    //run startup menu
    //once successful, then run game logic
StartupMenu.Menu();

int validNumber = Helpers.ValidateInputNumber();

GameLogic.FizzBuzz(validNumber);
    

} while (gameOn);



