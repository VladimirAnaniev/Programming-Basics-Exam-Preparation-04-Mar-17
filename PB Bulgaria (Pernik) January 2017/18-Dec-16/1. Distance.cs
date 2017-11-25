using System;

namespace Distance
{
    class Program
    {
        static void Main()
        {
            var speed = double.Parse(Console.ReadLine());
            var firstTimeInMinutes = double.Parse(Console.ReadLine());
            var secondTimeInMinutes = double.Parse(Console.ReadLine());
            var thirdTimeInMinutes = double.Parse(Console.ReadLine());

            var firstTimeInHours = firstTimeInMinutes / 60;
            var secondTimeInHours = secondTimeInMinutes / 60;
            var thirdTimeInHours = thirdTimeInMinutes / 60;

            var firstDistance = speed * firstTimeInHours;
            speed = speed * 1.1;
            var secondDistance = speed * secondTimeInHours;
            speed -= speed * 0.05;
            var thirdDistance = speed * thirdTimeInHours;

            Console.WriteLine("{0:f2}", thirdDistance+secondDistance+firstDistance);
        }
    }
}
