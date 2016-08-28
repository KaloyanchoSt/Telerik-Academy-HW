using System;

namespace _05.Maximal_increasing_sequence
{
    class MaxIncSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            int currentLength = 1;
            int maxLength = 0;
            int endIndexBestLength = 0;

            for (int i = 0; i < arrayNums.Length - 1; i++)
            {
                if (arrayNums[i] <= arrayNums[i + 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        endIndexBestLength = i;
                    }
                    currentLength = 1;
                }
            }

            // in case when the last sequence is the maximal increasing sequence
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                endIndexBestLength = arrayNums.Length - 1;
            }

            Console.WriteLine(maxLength);
        }
    }
}