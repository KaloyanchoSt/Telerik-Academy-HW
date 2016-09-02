namespace SubsetKWithSumS
{
    using System;

    class SubsetKWithSumS
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            int[] myIntArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                myIntArray[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
