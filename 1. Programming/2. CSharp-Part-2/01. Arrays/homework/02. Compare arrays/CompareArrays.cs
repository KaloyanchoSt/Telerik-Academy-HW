using System;

namespace _02.Compare_arrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] test = new int[n];
            int[] test2 = new int[n];
            bool isEqual = true;

            for (int i = 0; i < n; i++)
            {
                test[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                test2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != test2[i])
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
