// See https://aka.ms/new-console-template for more information
using System;


namespace HobbyGenerator
{

    class Generator
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Please insert a name to whom you wish to assign a hobby.");
            string name = Console.ReadLine();
            Console.WriteLine();
            if (name == string.Empty)
            {
                Console.WriteLine(@"You have to write a name!
");
                Main(args);
            }
            
            Console.WriteLine(RandomFlavor.Flavorizer(Randomer.Randomizer(0, 6), name, HobbySender.Hobby(Randomer.Randomizer(0, 11))));
            Console.WriteLine();
            Main(args);
        }
    }


}