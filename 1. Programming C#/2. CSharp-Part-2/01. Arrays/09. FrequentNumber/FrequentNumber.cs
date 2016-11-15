/*  Problem 9. Frequent number
    Write a program that finds the most frequent number in an array of N elements.
    Print the most frequent number and how many time it is repeated.
        Output should be REPEATING_NUMBER (REPEATED_TIMES times)                 */
namespace FrequentNumber
{
    using System;

    class FrequentNumber
    {
        static void Main()
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            int mostFreqNumber = 0, currentNumber = 0;
            int currentBestRepeated = 0, bestRepeated = 0;

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            // sorting the numbers in ascending order, so the elements with same value will be placed next to each other
            Array.Sort(arrayOfNumbers);

            for (int i = 0; i < n; i++)
            {
                currentNumber = arrayOfNumbers[i];

                for (int j = i; j < n; j++)
                {
                    if (currentNumber == arrayOfNumbers[j])
                    {
                        currentBestRepeated++;
                    }
                    else
                    {
                        break;
                    }
                }

                // in case when the last sequence is the maximal sequence of equal elements
                if (currentBestRepeated > bestRepeated)
                {
                    bestRepeated = currentBestRepeated;
                    mostFreqNumber = currentNumber;
                }

                currentBestRepeated = 0;
            }

            // output
            Console.WriteLine("{0} ({1} times)", mostFreqNumber, bestRepeated);
        }
    }
}
