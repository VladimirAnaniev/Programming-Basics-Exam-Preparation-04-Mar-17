using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Wheels_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());

            int count = 0;
            string password = "";

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
							// Can we optimize the first par of this check?
                            if (first < second && third > fourth)
                            {
                                if (control == first * second + third * fourth)
                                {
                                    //string current = $"{first}{second}{third}{fourth} ";
                                    string current = String.Format("{0}{1}{2}{3} ", first, second, third, fourth);
                                    count++;

                                    if (count == 4)
                                    {
                                        password = current;
                                    }
                                    Console.Write(current);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (count >= 4)
            {
                Console.WriteLine("Password: " + password);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
