using System;

namespace _06.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x1, x2;

            if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                if (b * b - 4 * a * c == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    if (x1 < x2)
                    {
                        Console.WriteLine("{0:F2}\r\n{1:F2}", x1, x2);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}\r\n{1:F2}", x2, x1);
                    }
                }
            }
        }
    }
}