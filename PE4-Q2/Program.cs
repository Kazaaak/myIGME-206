using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1;
            string var2;
            int num1 = 0; ;
            int num2 = 0;

            // Repeat this statement while numbers are not valid
            do
            {
                // Request and record both integers from user
                Console.Write("Please enter an integer: ");
                var1 = Console.ReadLine();
                num1 = Convert.ToInt32(var1);

                Console.Write("Please enter another integer: ");
                var2 = Console.ReadLine();
                num2 = Convert.ToInt32(var2);

            // Repeat the looped code until only one number is > 10
            } while ((num1 > 10 && num2 > 10) || (!(num1 > 10) && !(num2 > 10)));
            
            // Indicate to the user that the code has successfully completed
            Console.WriteLine("Numbers are valid, thank you!");
        }
    }
}
