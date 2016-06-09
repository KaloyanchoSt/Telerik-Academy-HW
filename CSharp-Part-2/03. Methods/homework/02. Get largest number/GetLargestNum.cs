using System;

namespace _02.Get_largest_number
{
    class GetLargestNum
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);

            Console.WriteLine("{0}", GetMax(GetMax(a, b), c));
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
