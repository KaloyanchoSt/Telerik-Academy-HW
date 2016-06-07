using System;

namespace _11.Interval
{
    class Interval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int amountDivisibleBy5 = 0;

            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    amountDivisibleBy5++;
                }
            }
            Console.WriteLine(amountDivisibleBy5);
        }
    }
}