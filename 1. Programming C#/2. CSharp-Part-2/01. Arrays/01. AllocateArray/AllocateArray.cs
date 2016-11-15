namespace AllocateArray
{
    using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int element = 0;
            int[] myIntArray = new int[n];
            for (int index = 0; index < myIntArray.Length; index++)
            {
                element = index * 5;
                Console.WriteLine("{0}", element);
            }
        }
    }
}
