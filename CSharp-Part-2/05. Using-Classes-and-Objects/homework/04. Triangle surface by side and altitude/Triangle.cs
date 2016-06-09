using System;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Triangle
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double alt = double.Parse(Console.ReadLine());

            double area = (side * alt) / 2;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
