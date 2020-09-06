using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace Mad_Libs
{
    // Class: IGME-206
    // Author: Gage Hubler
    // Purpose: Ask the user to play Mad Libs, read in a file, then use that to prompt the user to fill in guided prompts.
    //      Display the results at the end.
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string line;
            string resultString = "";
            string playing;
            List<string> stories = new List<string>();
            int storyChoice;
            int arraySize = 0;
            bool validAnswer = false;

            // Ask the user if they wish to play the game. Exit if no, proceed if yes, reprompt if an invalid answer is entered
            do
            {
                Console.Write("Would you like to play Mad Libs? (yes/no) : ");
                playing = Console.ReadLine();

                if (playing.ToLower() == "no")
                {
                    // Exit the program
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
                else if (playing.ToLower() == "yes")
                {
                    validAnswer = true;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no.");
                    validAnswer = false;
                }
            } while (validAnswer == false);
            
            // Read the madlib file from a fixed location on the c: drive
            StreamReader input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            
            // Add each line of text to an array
            while ((line = input.ReadLine()) != null)
            {
                stories.Add(line);
            }

            // Close the input file
            input.Close();

            // Determine the size of the array for later use
            arraySize = stories.Count;

            // Prompt the user to enter their name and then store it.
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            // Prompt the user to enter the story's number
            Console.Write(userName + ", what story would you like to choose? 1-" + (arraySize) + ": ");
            storyChoice = Int32.Parse(Console.ReadLine())-1;

            // Separate each word of the chosen story into an array called words
            string[] words = stories[storyChoice].Split(' ');

            // Loop through the story array while words still remain
            for (int i = 0; i < words.Length; i++)
            {
                // Add a newline character where indicated in the file
                if (words[i] == "\\n")
                {
                    resultString += "\n";
                } else if (words[i].Contains("{"))
                {
                    // If the word contains curly braces, ask the user to replace it with a word of a certain type. Add it to a string to be
                    //      printed later
                    if (words[i].Contains(","))
                    {
                        Console.Write("Please enter a(n) " + words[i].Trim('{', '}', ',').Replace('_', ' ') + ": ");
                        resultString += Console.ReadLine() + ", ";
                    }
                    else if (words[i].Contains("."))
                    {
                        Console.Write("Please enter a(n) " + words[i].Trim('{', '}', '.').Replace('_', ' ') + ": ");
                        resultString += Console.ReadLine() + ". ";
                    }
                    else
                    {
                        Console.Write("Please enter a(n) " + words[i].Trim('{', '}').Replace('_', ' ') + ": ");
                        resultString += Console.ReadLine() + " ";
                    }
                } else
                {
                    // Add the word to a string to be printed later
                    resultString += words[i] + " ";
                }
            }
            // Print the concatenated string that is the result of adding the word array together
            Console.WriteLine(resultString);
        }
    }
}
