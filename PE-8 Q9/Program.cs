using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Q9
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Places double quotes around each word in a string
        // Restrictions: None
        static void Main(string[] args)
        {
            string userInput;
            string[] stringArray;

            // Prompt the user to enter a string, save their input
            Console.Write("Please input a string: ");
            userInput = Console.ReadLine();

            // Split the user input into an array
            stringArray = userInput.Split();

            // Loop through the array and put quotes around everything
            foreach (string word in stringArray)
            {
                Console.Write("\"{0}\" ", word);
            }
            // Put an extra line at the end to separate 
            Console.WriteLine(' ');
        }
    }
}
