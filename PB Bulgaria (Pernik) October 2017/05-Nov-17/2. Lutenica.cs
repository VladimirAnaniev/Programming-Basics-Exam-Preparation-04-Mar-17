using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Lutenica
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            int boxesInTruck = int.Parse(Console.ReadLine());
            int jarsPerBox = int.Parse(Console.ReadLine());

            double lutenica = tomatoes / 5;
            double jarsFilled = lutenica / 0.535;
            double boxesFilled = jarsFilled / jarsPerBox;

            Console.WriteLine($"Total lutenica: {Math.Floor(lutenica)} kilograms.");

            if (boxesFilled > boxesInTruck)
            {
                double boxesLeft = Math.Floor(boxesFilled - boxesInTruck);
                Console.WriteLine($"{boxesLeft} boxes left.");

                double jarsLeft = Math.Floor(jarsFilled - boxesInTruck * jarsPerBox);
                Console.WriteLine($"{jarsLeft} jars left.");
            }
            else
            {
                double boxesNeeded = Math.Floor(boxesInTruck - boxesFilled);
                Console.WriteLine($"{boxesNeeded} more boxes needed.");

                double jarsNeeded = Math.Floor(boxesInTruck * jarsPerBox - jarsFilled);
                Console.WriteLine($"{jarsNeeded} more jars needed.");
            }
        }
    }
}
