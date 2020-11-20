using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Q1
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Promts a user for a string,
        //          Prints how many of each letter of the alphabet are in the string (case-insensitive)
        //          Prints the string in reverse order 
        //          Tests if the string is a palindrome (allowing for punctuation, spaces and different capitalization)
        // Restrictions: None

        static void Main(string[] args)
        {
            string userString;
            char[] splitStringArray;
            List<char> UsedList = new List<char>();

            // Request string from user
            Console.Write("Please enter a string: ");
            userString = Console.ReadLine();
            Console.WriteLine();

            // Convert string to an array of characters
            splitStringArray = userString.ToCharArray();

            char[] reverseStringArray = splitStringArray;

            // Iterate through each character in the array
            foreach (char c in splitStringArray)
            {
                // If the character is not a duplicate, print it and how many exist in the string
                if (!UsedList.Contains(c))
                {
                    // Tally used characters
                    UsedList.Add(c);

                    // Tally a count of each unique character and print
                    var count = userString.Count(x => x == c);
                    Console.WriteLine($"{c}: {count}");
                }
            }
            Console.WriteLine();

            // Reverse the string and print
            Array.Reverse(reverseStringArray);
            string reverseString = new string(reverseStringArray);
            Console.WriteLine(reverseString);
            Console.WriteLine();

            // Set strings to uppercase and remove non-alphanumeric characters
            string string1 = userString.ToUpper();
            string1 = String.Concat(Array.FindAll(string1.ToCharArray(), Char.IsLetterOrDigit));

            string string2 = reverseString.ToUpper();
            string2 = String.Concat(Array.FindAll(string2.ToCharArray(), Char.IsLetterOrDigit));

            // If the string forward and backward are equal, print that it is a palindrome, or vice versa
            if (string1 == string2)
            {
                Console.WriteLine("This string is a palindrome!\n");
            }
            else
            {
                Console.WriteLine("This string is not a palindrome.\n");
            }
        }
    }
}
