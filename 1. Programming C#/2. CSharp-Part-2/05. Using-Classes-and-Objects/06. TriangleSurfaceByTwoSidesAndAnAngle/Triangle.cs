namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    using System;

    class Triangle
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            double surface = (sideA * sideB * Math.Sin(angle * Math.PI / 180)) / 2;
            Console.WriteLine("{0:F2}", surface);
        }
    }
}
