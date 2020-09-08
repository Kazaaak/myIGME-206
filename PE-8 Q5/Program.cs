using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Q5
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Calculate z = 3y2 + 2x - 1  for the ranges: -1 <= x <= 1 in 0.1 increments
	    //                                                       1 <= y <= 4 in 0.1 increments
        // Restrictions: None
        static void Main(string[] args)
        {
            double x = -1, y = 1, z = -1;
            double[,,] mathArray = new double[0, 0, 0];
            
            // Loop through x from values -1 to 1 in 0.1 increments
            while (x < 1)
            {
                // Loop through x from values 1 to 4 in 0.1 increments
                while (y < 4.1)
                {
                    // Plug the numbers into the formula and print
                    z = ((3 * y) * (3 * y)) + (2 * x) - 1;
                    Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);

                    // Increment y
                    y += 0.1;
                }

                // Increment x and reset y
                x += 0.1;
                y = 1;
            }

        }
    }
}
