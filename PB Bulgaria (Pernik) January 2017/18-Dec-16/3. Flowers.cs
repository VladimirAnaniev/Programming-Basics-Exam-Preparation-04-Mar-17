using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main()
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine(); //TODO: Can you read this as a char instead of string?

            var flowers = hrizantemi + rozi + laleta;
            var price = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                price = hrizantemi * 2 + rozi * 4.10 + laleta * 2.5;
            }
            else if(season == "Autumn" || season == "Winter")
            {
                price = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
            }
           
            // Bump prices up on holidays
            if (isHoliday == "Y")
            {
                price += price * 0.15;
            }

            // Discounts
            if (season == "Spring" && laleta >= 7)
            {
                price -= price * 0.05;
            }
            if (season == "Winter" && rozi >= 10)
            {
                price -= price * 0.1;
            }
            if (flowers >= 20)
            {
                price -= price * 0.2;
            }

            price += 2;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
