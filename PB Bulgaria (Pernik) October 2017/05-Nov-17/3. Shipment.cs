using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Shippment
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double pricePerKm = 0;

            if (weight < 1)
            {
                pricePerKm = 0.03;
            }
            else if (weight <= 10)
            {
                pricePerKm = 0.05;
            }
            else if (weight <= 40)
            {
                pricePerKm = 0.1;
            }
            else if (weight <= 90)
            {
                pricePerKm = 0.15;
            }
            else if (weight <= 150)
            {
                pricePerKm = 0.2;
            }

            double price = distance * pricePerKm;

            if (type == "express")
            {
                double extra = 0;

                if (weight < 1)
                {
                    extra = pricePerKm * 0.8;
                }
                else if (weight <= 10)
                {
                    extra = pricePerKm * 0.4;
                }
                else if (weight <= 40)
                {
                    extra = pricePerKm * 0.05;
                } 
                else if (weight <= 90)
                {
                    extra = pricePerKm * 0.02;
                }
                else if (weight <= 150)
                {
                    extra = pricePerKm * 0.01;
                }

                double extraPrice = extra * weight * distance;

                price += extraPrice;
            }
			
			Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");
        }
    }
}
