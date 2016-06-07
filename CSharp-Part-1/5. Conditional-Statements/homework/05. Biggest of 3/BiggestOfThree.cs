using System;

namespace _05.Biggest_of_3
{
    class BiggestOfThree
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b == a && b== c)
            {
                Console.WriteLine(c);
            }
            else if (c > b && a < c)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
