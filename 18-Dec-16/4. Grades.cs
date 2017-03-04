using System;

namespace Ocenki
{
    class Program
    {
        static void Main()
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var between5And6 = 0.0;
            var between4And5 = 0.0;
            var between3And4 = 0.0;
            var between2And3 = 0.0;

            var sum = 0.0;

            //Get all marks and update the above variables
            for (int i = 1; i <= studentsCount; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                sum = sum + grade;

                if (grade >= 2.00 && grade <= 2.99)
                {
                    between2And3++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    between3And4++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    between4And5++;
                }
                else if (grade >= 5)
                {
                    between5And6++;
                }

                //OPTIMIZATION: how can you reduce the complexity of the if statements?
            }

            /*
             * The calculations below are correct, but consider saving them in separate variables
             * to improve readability.
             */
            Console.WriteLine("Top students: {0:f2}%", between5And6 / studentsCount * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", between4And5 / studentsCount * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", between3And4 / studentsCount * 100);
            Console.WriteLine("Fail: {0:f2}%", between2And3 / studentsCount * 100);

            Console.WriteLine("Average: {0:f2}", sum / studentsCount);
        }
    }
}
