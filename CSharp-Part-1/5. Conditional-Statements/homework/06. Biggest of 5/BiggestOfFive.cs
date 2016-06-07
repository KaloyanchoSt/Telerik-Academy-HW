using System;

namespace _06.Biggest_of_5
{
    class BiggestOfFive
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            float biggest = a;
            if (b > biggest)
            {
                biggest = b;
            }
            if (c > biggest)
            {
                biggest = c;
            }
            if (d > biggest)
            {
                biggest = d;
            }
            if (e > biggest)
            {
                biggest = e;
            }

            Console.WriteLine(biggest);
        }
    }
}