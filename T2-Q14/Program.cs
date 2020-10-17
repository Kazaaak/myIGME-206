using System;

namespace StructToClass
{
    public class Friend
    {
        public string name { get; set; }
        public string greeting { get; set; }
        public DateTime birthdate { get; set; }
        public string address { get; set; }

        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = (Friend)friend.Shallowcopy();

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
