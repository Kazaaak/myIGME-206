using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Q4
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Recreate 3questions.exe
        // Restrictions: None
        static void Main(string[] args)
        {
            string sChoice;
            int iChoice;

            start:

            Console.Write("Choose your question (1-3): ");
            sChoice = Console.ReadLine();
            
            try
            {
                iChoice = Int32.Parse(sChoice);
            } catch
            {
                
            }
        }
    }
}
