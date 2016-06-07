using System;

namespace _02.Not_Divisible_Numbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = n;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
