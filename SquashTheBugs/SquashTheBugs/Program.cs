using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            // Compile-time error: Missing semicolon
            int i = 0;

            // declare string to hold all numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10
            // Logic error: loop should iterate 1-10 instead of 1-9
            // for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i)
            {

                // declare string to hold all numbers
                // Logic error: Variable initialized inside for loop not useable outside
                // string allNumbers = null;

                // output explanation of calculation
                // Compile time error: statement not interpolated correctly
                // Console.Write(i + "/" + i - 1 + " = ");
                Console.Write($"{ i }" + "/" + $"{ i - 1 }" + " = ");

                // output the calculation based on the numbers
                // Run-time error: division by zero possible
                // Logic error: Doesn't print as a double
                // Console.WriteLine(i / (i - 1));
                if (i == 1)
                {
                    Console.WriteLine("Undefined");
                }
                else
                {
                    Console.WriteLine(Convert.ToDouble(i) / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // Logic error: counter in for-loop body unnecessary 
                // i = i + 1;
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            // Compile-time error: statement not concatenated correctly
            Console.WriteLine($"These numbers have been processed: {allNumbers}");
        }
    }
}
