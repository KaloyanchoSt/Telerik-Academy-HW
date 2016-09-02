namespace SortingArray
{
    using System;
    using System.Linq;

    class SortingArray
    {
        static void Main()
        {
            // input
            Console.ReadLine();
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numArray);

            // ouput
            Console.WriteLine(string.Join(" ", numArray));
        }
    }
}
