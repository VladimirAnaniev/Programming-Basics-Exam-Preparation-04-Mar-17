using System;

namespace Combinations
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char forbidden = char.Parse(Console.ReadLine());

            int count = 0;
             
            /*
             * We can use char as an iterator in a for cycle
             */
            for (char first = start; first <= end; first++)
            {
                for (char second = start; second <= end; second++)
                {
                    for (char third = start; third <= end; third++)
                    {
                        if (forbidden == first || forbidden==second || forbidden==third)
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", first, second , third);
                        count++;

                        //TODO: Think of an optimization for this problem
                        /*
                         * Hint: If the first char is the forbidden, do we need to loop through all possibilities for the remaining characters?
                         */
                        
                    } 
                }
            }

            Console.WriteLine(count);
        }
    }
}
