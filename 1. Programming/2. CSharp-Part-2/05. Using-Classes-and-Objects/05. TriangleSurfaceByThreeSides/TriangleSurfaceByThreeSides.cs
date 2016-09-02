namespace TriangleSurfaceByThreeSides
{
    using System;

    class TriangleSurfaceByThreeSides
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            double halfPerimeter = (sideA + sideB + sideC) / 2;

            Console.WriteLine("{0:F2}", CalculteArea(halfPerimeter, sideA, sideB, sideC));
        }

        static double CalculteArea(double number, double a, double b, double c)
        {
            double area = Math.Sqrt(number * (number - a) * (number - b) * (number - c));
            return area;
        }
    }
}
