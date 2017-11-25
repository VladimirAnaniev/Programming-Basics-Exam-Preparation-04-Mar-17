using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Happy_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int first = 1; first <=  9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for(int third = 1; third <= 9; third++)
                    {
                        for(int fourth = 1; fourth <= 9; fourth++)
                        {
                            if (first + second == third + fourth)
                            {
                                int sum = first + second;
                                if (n % sum == 0)
                                {
                                    Console.Write("{0}{1}{2}{3} ", first, second, third, fourth);
                                }
                            }
                        }
                    }
                }
                
            }
        }
    }
}
