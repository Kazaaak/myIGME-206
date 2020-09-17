using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Q3
{
    class Program
    {
        delegate string stringMethod();

        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Uses a delegate to impersonate the Console.ReadLine() function when asking for user input
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            stringMethod input = new stringMethod(ReadInput);
            Console.WriteLine(input());
        }

        static string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}