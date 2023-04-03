using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.thursday;

            xmas.Santa = "Kris Kringle";

            xmas.Presents =  new string[3]{"PS6", "GTA6", "Jeep" }; 

            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"{present}");
            }

            Console.WriteLine($"\nWe like to call Santa, {xmas.Santa}");
        }
    }
}
