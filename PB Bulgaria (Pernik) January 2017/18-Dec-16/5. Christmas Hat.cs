using System;

namespace ChristmasHat
{
    class Program
    {
        static void Main()
        {
            /*
             * ......./|\.......
             * .......\|/.......
             * .......***.......
             * ......*-*-*......
             * .....*--*--*.....
             * ....*---*---*....
             * ...*----*----*...
             * ..*-----*-----*..
             * .*------*------*.
             * *-------*-------*
             * *****************
             * *.*.*.*.*.*.*.*.*
             * *****************
             */
            var n = int.Parse(Console.ReadLine());

            var width = 4 * n + 1;
            var height = 2 * n + 5;

            //Top of the hat
            Console.WriteLine("{0}/|\\{0}", new string('.', (width - 3) / 2));
            Console.WriteLine("{0}\\|/{0}", new string('.', (width - 3) / 2));

            /*
             * Reminder: \ <- this is a special symbol that escapes other special symbols
             * \" inside a string -> " as a character, not the end of the string
             * \' as char -> the symbol '
             * \n -> new line
             * \a -> plays ana alert sound
             * 
             * \ needs to be escaped also -> "\\" is \, "\\\\" is \\
             * 
             */

            //Middle
            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", 
                    new string('.', (width - i*2) / 2 - 1),
                    new string('-', i));
            }

            //Bottom
            Console.WriteLine(new string('*', width));

            for (int i = 1; i <= width / 2; i++)
            {
                Console.Write("*.");
            }
           // Console.Write('*');
           // Console.WriteLine();
            Console.WriteLine("*");

            Console.WriteLine(new string('*', width));

        }
    }
}
