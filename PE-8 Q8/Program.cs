using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Q8
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Accepts a string and replaces all occurrences of the string "no" with "yes"
        // Restrictions: None
        static void Main(string[] args)
        {
            string userInput;

            // Prompt the user to enter a string, save their input
            Console.Write("Please input a string: ");
            userInput = Console.ReadLine();

            // Look for the word "no", then replace it with "yes"
            if (userInput.Contains("no") || userInput.Contains("No") || userInput.Contains("NO") || userInput.Contains("nO")) {
                userInput = userInput.Replace("no", "yes");
                userInput = userInput.Replace("No", "Yes");
                userInput = userInput.Replace("NO", "YES");
                userInput = userInput.Replace("nO", "yeS");
                Console.WriteLine(userInput);
            } else
            {
                // If "no" is not found, tell the user it doesn't contain it
                Console.WriteLine("String does not contain \"no\"");
            }
        }
    }
}
