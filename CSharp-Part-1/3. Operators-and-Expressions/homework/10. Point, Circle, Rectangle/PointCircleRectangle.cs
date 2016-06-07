using System;

namespace _10.Point__Circle__Rectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
            bool outsideRectangle = (x <= -1 || x >= 6) || (y <= -1 || y >= 2);
            bool inCircleOutsideRect = inCircle && outsideRectangle;

            Console.Write(inCircle ? "inside circle " : "outside circle ");
            Console.WriteLine(outsideRectangle ? "outside rectangle" : "inside rectangle");
            Console.Write(inCircleOutsideRect ? "inside circle " : "outside rectangle ");
        }
    }
}
