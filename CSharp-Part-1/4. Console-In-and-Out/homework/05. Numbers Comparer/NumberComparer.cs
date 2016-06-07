using System;

namespace _05.Numbers_Comparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);

            Console.WriteLine(greater);
        }
    }
}
