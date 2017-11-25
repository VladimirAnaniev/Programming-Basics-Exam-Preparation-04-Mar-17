using System;

namespace Axe
{
    class Program
    {
        static void Main()
        {
            /*
             * ---------------**--------
             * ---------------*-*-------
             * ---------------*--*------
             * ---------------*---*-----
             * ---------------*----*----
             * ****************----*----
             * ****************----*----
             * ---------------*----*----
             * --------------********---
             */
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;

            //Top part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', 3*n), 
                    new string('-', i), 
                    new string('-', width - (3*n + i + 2) ));
            }

            //Handle
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}*{1}",
                    new string('*', 3*n+1),
                    new string('-', n-1));
            }

            //Bottom part
            for (int i = 0; i < n / 2; i++)
            {
                var leftCount = 3 * n - i;
                var middleCount = n - 1 + 2 * i;

                if (i == n / 2 - 1)
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('-', leftCount),
                        new string('*', middleCount),
                        new string('-', width - (leftCount + middleCount + 2)));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftCount),
                    new string('-', middleCount),
                    new string('-', width - (leftCount + middleCount + 2)));
                }

                //TODO: Can you make this with only 1 Console.WriteLine??
                /*
                 * Hint: only the chars in the middle are different.
                 */
            }
        }
    }
}
