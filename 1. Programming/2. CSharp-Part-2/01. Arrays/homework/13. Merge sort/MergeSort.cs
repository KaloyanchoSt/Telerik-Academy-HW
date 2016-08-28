/* Problem 13. Merge sort
   Write a program that sorts an array of integers using the Merge sort algorithm.
   Input: 
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
   Output:  Print the sorted array. Each number should be on a new line.
   Constraints: 1 <= N <= 1024                                                */
using System;

namespace _13.Merge_sort
{
    class MergeSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }
            MergeSort(numArray, 0, numArray.Length - 1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }

        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
    }
}
