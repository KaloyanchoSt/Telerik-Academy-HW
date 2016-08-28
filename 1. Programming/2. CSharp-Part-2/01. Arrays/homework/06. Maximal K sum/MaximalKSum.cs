/*  Problem 6. Maximal K sum
    Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    On the first line you will receive the number N. On the second line you will receive the number K.
    On the next N lines the numbers of the array will be given.
    Find the maximal sum of K elements in the array.                 */
using System;

namespace _06.Maximal_K_sum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array); //Sort:Lowest-Biggest(Еxample:2, 3, 6, 8, 10)
            Array.Reverse(array); //Reverse after Sort:Flip the array backwards(Еxample:10, 8, 6, 3, 2)
            int maxSumOfK = 0;

            for (int i = 0; i < k; i++)
            {
                maxSumOfK += array[i];
            }
            Console.WriteLine(maxSumOfK);
        }
    }
}
