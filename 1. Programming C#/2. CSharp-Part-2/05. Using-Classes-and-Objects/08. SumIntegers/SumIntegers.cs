namespace SumIntegers
{
    using System;

    class SumIntegers
    {
        static void Main()
        {
            string inputNumbersString = Console.ReadLine();
            string[] numbers = inputNumbersString.Split(' ');

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}
