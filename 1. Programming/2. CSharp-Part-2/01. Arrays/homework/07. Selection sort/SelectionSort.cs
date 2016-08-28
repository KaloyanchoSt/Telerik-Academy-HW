using System;

namespace _07.Selection_sort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine("{0}", array[index]);
            }

        }
    }
}
