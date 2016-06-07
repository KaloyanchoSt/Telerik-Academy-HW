using System;

namespace _04.Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|", a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
