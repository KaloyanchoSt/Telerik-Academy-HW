using System;

namespace _05.Triangle_surface_by_three_sides
{
    class Triangle
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            double halfPerimeter = (sideA + sideB + sideC) / 2;

            Console.WriteLine("{0:F2}", CalculteArea(halfPerimeter, sideA, sideB, sideC));
        }
        static double CalculteArea(double number, double A, double B, double C)
        {
            double area = Math.Sqrt(number * (number - A) * (number - B) * (number - C));
            return area;
        }
    }
}
