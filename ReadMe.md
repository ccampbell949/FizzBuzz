This is my solution to the common coding problem **FizzBuzz** 

**An example of the problem is as follows:**

Given an integer n, for every positive integer i <= n, the task is to print,

“FizzBuzz” if i is divisible by 3 and 5,
“Fizz” if i is divisible by 3,
“Buzz” if i is divisible by 5

Examples:

Input: n = 3
Output: [“1”, “2”, “Fizz”]


Input: n = 10
Output: [“1”, “2”, “Fizz”, “4”, “Buzz”, “Fizz”, “7”, “8”, “Fizz”, “Buzz”]


Input: n = 20
Output: [“1”, “2”, “Fizz”, “4”, “Buzz”, “Fizz”, “7”, “8”, “Fizz”, “Buzz”, “11”, “Fizz”, “13”, “14”, “FizzBuzz”, “16”, “17”, “Fizz”, “19”, “Buzz”]

**What I wanted from this:**

- Using this as a learning exercise, I didn't just want to create the main solution and leave it there - I wanted to practice creating classes outside of the main program

- After I created the solution, I spent time thinking of coding design principles such as abstraction of methods and classes and tried to implement these in the code
- I split the game logic into it's own class, and then tried to improved the useability of the program by asking the user for inputs, such as what number they wanted to use (rather than just hardcoding n=50 or similar)
- I also added a couple of validations to check that the user input was correct i.e. an appropriate "y/n" input or that an integer input is used for the FizzBuzz method 
- I added a way to allow
the user to easily exit the program, if for example they'd have had enough of playing this absolutely _scintillating_ game, or maybe if they've simply opened it accidentally.
