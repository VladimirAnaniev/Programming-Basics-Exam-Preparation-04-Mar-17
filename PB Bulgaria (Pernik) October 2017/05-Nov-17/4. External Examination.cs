using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int poor = 0;
            int satisfactory = 0;
            int good = 0;
            int veryGood = 0;
            int excellent = 0;

            for (int i = 0; i < n; i++)
            {
                double currentPoints = double.Parse(Console.ReadLine());

                if (currentPoints <= 22.5)
                {
                    poor++;
                }
                else if (currentPoints <= 40.5)
                {
                    satisfactory++;
                }
                else if (currentPoints <= 58.5)
                {
                    good++;
                }
                else if (currentPoints <= 76.5)
                {
                    veryGood++;
                }
                else
                {
                    excellent++;
                }
            }

            double poorPct = poor / n * 100;
            Console.WriteLine($"{poorPct:f2}% poor marks");

            double satisfactoryPct = satisfactory / n * 100;
            Console.WriteLine($"{satisfactoryPct:f2}% satisfactory marks");

            double goodPct = good / n * 100;
            Console.WriteLine($"{goodPct:f2}% good marks");

            double veryGoodPct = veryGood / n * 100;
            Console.WriteLine($"{veryGoodPct:f2}% very good marks");

            double excellentPct = excellent / n * 100;
            Console.WriteLine($"{excellentPct:f2}% excellent marks");
        }
    }
}
