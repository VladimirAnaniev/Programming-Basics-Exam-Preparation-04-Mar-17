using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double meterPrice = double.Parse(Console.ReadLine());
            double meter2Weight = double.Parse(Console.ReadLine());

            int perimeter = 2 * (length + width);
            double price = perimeter * meterPrice;

            double fenceArea = perimeter * height;
            double fenceWight = fenceArea * meter2Weight;

            Console.WriteLine(perimeter);
            Console.WriteLine("{0:f2}", price);
            Console.WriteLine("{0:f3}", fenceWight);
        }
    }
}
