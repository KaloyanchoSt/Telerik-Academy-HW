using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = ((double)2 * b + 2 * a);
            double area = ((double)b * a);
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}

