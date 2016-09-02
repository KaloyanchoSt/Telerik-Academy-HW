namespace Rectangles
{
    using System;

    class Rectangles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double perimeter = (2 * b) + (2 * a);
            double area = b * a;
            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}