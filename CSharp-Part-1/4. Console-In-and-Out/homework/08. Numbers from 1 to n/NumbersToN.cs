using System;

namespace _08.Numbers_from_1_to_n
{
    class NumbersToN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
