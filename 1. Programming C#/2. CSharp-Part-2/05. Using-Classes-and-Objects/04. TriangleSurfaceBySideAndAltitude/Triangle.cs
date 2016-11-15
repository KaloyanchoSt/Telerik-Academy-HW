namespace TriangleSurfaceBySideAndAltitude
{
    using System;

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
