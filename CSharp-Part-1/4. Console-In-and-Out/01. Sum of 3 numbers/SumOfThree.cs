using System;

namespace _01.Sum_of_3_numbers
{
    class SumOfThree
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;

            Console.WriteLine(sum);
        }
    }
}
