using System;

namespace _11.Binary_search
{
    class BinarySearch
    {
        static void Main()
        {
            // Input 
            int n = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }
            int element = int.Parse(Console.ReadLine()); //the element, whose index You want to find

            // Binary search works only on sorted arrays.
            Array.Sort(arrayNums);

            int leftRange = 0;
            int rightRange = arrayNums.Length - 1;
            int middle = 0;
            int index = -1;

            while (leftRange <= rightRange)
            {
                middle = (leftRange + rightRange) / 2;
                if (arrayNums[middle] < element)
                {
                    leftRange = middle + 1;
                }
                else if (arrayNums[middle] > element)
                {
                    rightRange = middle - 1;
                }
                else  // array[middle] == element 
                {
                    index = middle;
                    break;
                }
            }

            Console.WriteLine(index);

        }
    }
}
