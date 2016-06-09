using System;

namespace _08.Maximal_sum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (currentSum <= 0)
                {
                    currentSum = 0;
                }

                currentSum += array[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            Console.WriteLine(maxSum);
        }

    }
}