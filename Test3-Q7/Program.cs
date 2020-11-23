using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Q7
{
    class Program
    {
        // Class: IGME-206
        // Author: Gage Hubler
        // Purpose: Read a list of names and ages of 10 wizards, sort them by 
        //          age (using a lambda function!) and print
        // Restrictions: None

        static void Main(string[] args)
        {
            // Declare a list of wizards by name and age
            List<Wizard> wizard = new List<Wizard>()
            {
                new Wizard() { name = "Gage", age = 20 },
                new Wizard() { name = "Eleanor", age = 22 },
                new Wizard() { name = "Alice", age = 18 },
                new Wizard() { name = "Puck", age = 35 },
                new Wizard() { name = "Deirdre", age = 300 },
                new Wizard() { name = "Amy", age = 19 },
                new Wizard() { name = "Vergil", age = 17 },
                new Wizard() { name = "Lilya", age = 23 },
                new Wizard() { name = "Francisco", age = 21 },
                new Wizard() { name = "Collene", age = 25 },
            };

            // Sort the list using a lambda function
            wizard.Sort((a, b) => ((a.age).CompareTo(b.age)));

            // Loop through the list and print each entry
            foreach (Wizard wiz in wizard)
            {
                Console.WriteLine($"{wiz.name} - {wiz.age}");
            }
        }

        class Wizard {
            public string name;
            public int age;
        }
    }

}
