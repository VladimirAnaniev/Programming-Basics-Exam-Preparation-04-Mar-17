using System;

namespace SmartLili
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            var toysCount = 0;
            var money = 0.0;
            var moneyOnNextEvenBirthday = 10;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += moneyOnNextEvenBirthday - 1; // (Broter steals 1lv)
                    moneyOnNextEvenBirthday += 10;

                    //TODO: Can you calculate how much money Lili will recieve without helper variable?
                    /*
                     * Hint: use the iterator (i)
                     */
                }
                else
                {
                    toysCount++;
                }
            }

            var moneyFromToys = toysCount * toyPrice;

            money += moneyFromToys;

            if (washingMachinePrice <= money)
            {
                Console.WriteLine("Yes! {0:f2}", money - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachinePrice - money);
            }
        }
    }
}
