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
            double[,,] aZFunction = new double[21, 31, 3];
            double dX = -1, dY = 1, dZ = -1;
            int nX = 0, nY = 0;

            for (dX = -1; dX <= 1; dX += 0.1)
            {
                dX = Math.Round(dX, 1);
                nY = 0;
                for (dY = -1; dY <= 1; dY += 0.1)
                {
                    dX = Math.Round(dY, 1);

                    dZ = ((3 * dY) * (3 * dY)) + (2 * dX) - 1;

                    dX = Math.Round(dZ, 1);

                    aZFunction[nX, nY, 0] = dX;
                    aZFunction[nX, nY, 1] = dY;
                    aZFunction[nX, nY, 2] = dZ;

                    ++nY;
                }
                ++nX;
            }
        }
    }
}
