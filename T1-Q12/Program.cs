using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Q12
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Increases the user's salary and congratulates them if they have my name
        // Restrictions: None
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            bool bRaise = false;

            Console.WriteLine("Please enter your name: ");
            sName = Console.ReadLine();

            bRaise = GiveRaise(sName, ref dSalary);

            if (bRaise == true)
            {
                Console.WriteLine("Congratulations on your raise, " + sName + ". Your new salary is: " + dSalary + "!");
            }
            
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "Gage") {
                salary += 19999.99;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
