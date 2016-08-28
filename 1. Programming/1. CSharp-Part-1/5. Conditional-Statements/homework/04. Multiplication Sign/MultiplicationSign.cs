using System;

namespace _04.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double product = a * b * c;

            if (product == 0)
            {
                Console.WriteLine(0);
            }
            else if (product < 0)
            {
                Console.WriteLine("-");
            }
            else if (product > 0)
            {
                Console.WriteLine("+");
            }
        }
    }
}
