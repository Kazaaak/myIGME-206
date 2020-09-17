using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Q3
{
    class Program
    {
        delegate string stringMethod(string input);

        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Uses a delegate to impersonate the Console.ReadLine() function when asking for user input
        // Restrictions: None
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please enter a string: ");
            input = new stringMethod(ReadInput);
            Console.WriteLine(input);
        }

        static string ReadInput(string input)
        {
            input = Console.ReadLine();
            return input;
        }
    }
}