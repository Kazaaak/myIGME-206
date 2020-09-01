using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3Question5Hubler
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3, input4;
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0;

            // Prompt the user for each value, then store as a string.
            Console.Write("Please enter your first integer: ");
            input1 = Console.ReadLine();

            Console.Write("Please enter your second integer: ");
            input2 = Console.ReadLine();

            Console.Write("Please enter your third integer: ");
            input3 = Console.ReadLine();

            Console.Write("Please enter your fourth integer: ");
            input4 = Console.ReadLine();

            // Convert the inputs into integers
            num1 = Convert.ToInt32(input1);
            num2 = Convert.ToInt32(input2);
            num3 = Convert.ToInt32(input3);
            num4 = Convert.ToInt32(input4);

            Console.WriteLine($"\nThe product of these numbers is: {num1 * num2 * num3 * num4}\n");
        }
    }
}
