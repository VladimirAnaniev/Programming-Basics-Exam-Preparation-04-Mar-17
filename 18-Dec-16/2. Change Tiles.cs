using System;

namespace Tiles
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double priceWorker = double.Parse(Console.ReadLine());

            var area = width * height;
            var tileArea = (triangleSide * triangleHeight) / 2;
            var tilesNeeded = Math.Ceiling(area / tileArea) + 5;

            var price = tilePrice * tilesNeeded + priceWorker;

            if (price > money)
            {
                Console.WriteLine("You'll need {0:f2} lv more.", price - money);
            }
            else
            {
                Console.WriteLine("{0:f2} lv left.", money-price);
            }
        }
    }
}
