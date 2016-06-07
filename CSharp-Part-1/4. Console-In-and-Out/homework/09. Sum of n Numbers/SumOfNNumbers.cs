using System;

namespace _09.Sum_of_n_Numbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double numberI;

            for (int i = 0; i < n; i++)
            {
                numberI = double.Parse(Console.ReadLine());
                sum += numberI;
            }

            Console.WriteLine(sum);
        }
    }
}