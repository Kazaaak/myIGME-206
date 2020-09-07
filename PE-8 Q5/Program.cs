using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -1, y = 1, z = -1;
            double[,,] mathArray = new double[0, 0, 0];
            
            while (x < 1)
            {
                while (y < 4.1)
                {
                    z = ((3 * y) * (3 * y)) + (2 * x) - 1;
                    Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
                    y += 0.1;
                }
                x += 0.1;
                y = 1;
            }

        }
    }
}
