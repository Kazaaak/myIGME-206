using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Q7
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Accept a string from the user, then display it in reverse
        // Restrictions: None
        static void Main(string[] args)
        {
            string userInput;
            char[] transferArray;

            // Prompt the user to enter a string, save their input
            Console.Write("Please input a string: ");
            userInput = Console.ReadLine();

            // Convert input into an array of characters
            transferArray = userInput.ToCharArray();

            // Reverse the array of characters, then print
            Array.Reverse(transferArray);
            Console.WriteLine(transferArray);
        }
    }
}
