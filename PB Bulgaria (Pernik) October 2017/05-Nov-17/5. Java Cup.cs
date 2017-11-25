using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.JavaCup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n + 6;
            int height = 3 * n + 1;

            // First Part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string(' ', n)}~ ~ ~");
            }

            //Middle Part
            Console.WriteLine(new string('=', width - 1));

            for (int i = 0; i < n - 2; i++)
            {
                int spacesWidth = n - 1;
                string spaces = new string(' ', spacesWidth);

                if (i == n / 2 - 1)
                {
                    //Print JAVA
                    string tildasEachSide = new string('~', n);
                    Console.WriteLine($"|{tildasEachSide}JAVA{tildasEachSide}|{spaces}|");
                }
                else
                {
                    int tildaWidth = width - spacesWidth - 3;
                    string tildas = new string('~', tildaWidth);

                    Console.WriteLine($"|{tildas}|{spaces}|");
                }
            }

            Console.WriteLine(new string('=', width - 1));

            // Bottom Part
            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', i);
                string kliombi = new string('@', width - n - 2 - 2 * i); // !!! Please dont use such names !!!

                Console.WriteLine($@"{spaces}\{kliombi}/");
            }

            Console.WriteLine(new string('=', width - n));
        }
    }
}
