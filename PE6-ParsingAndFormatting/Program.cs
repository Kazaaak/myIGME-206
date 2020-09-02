using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PE6_ParsingAndFormatting
{
    // Class:IGME-206
    // Author: Gage Hubler
    // Purpose: Generate a random number and have the user attempt to guess
    //     what it is
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            // Storage variables for the user input
            string userGuess;
            int numGuess = 0;

            // Print the random number for debug purposes
            Console.WriteLine("Your number is: " + randomNumber);

            // Iterate through the guess loop a maximum of 8 times
            for (int i = 0; i < 8; i++)
            {
                // Do while the number entered is invalid
                do {
                    // Tell the user what guess they're on, then read from their input,
                    //     parse the input to an int, and prompt the user to re-enter if invalid
                    Console.Write("Turn #" + (i + 1) + ": Enter your guess: ");
                    userGuess = Console.ReadLine();
                    numGuess = Int32.Parse(userGuess);

                    if (numGuess > 100 || numGuess < 0)
                    {
                        Console.WriteLine("Invalid guess - try again");
                    }
                } while (numGuess > 100 || numGuess < 0);

                // Check if the number entered is higher, lower, or equal to the random number
                if (numGuess > randomNumber)
                {
                    Console.WriteLine("Too high");
                } else if (numGuess < randomNumber) 
                {
                    Console.WriteLine("Too low");
                } else
                {
                    // If the user is correct, tell them, then break fron the for loop
                    Console.WriteLine("\nCorrect! You won in " + (i + 1) + " turn(s)!");
                    break;
                }

                // If the user does not guess it within 8 attempts, alert the user that they ran
                //     out of turns, and tell them what the number was.
                if (i == 7)
                {
                    Console.WriteLine("\nYou ran out of turns. The number was " + randomNumber);
                }
            }
        }
    }
}
