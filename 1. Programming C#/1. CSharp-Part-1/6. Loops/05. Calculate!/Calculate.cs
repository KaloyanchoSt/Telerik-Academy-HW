namespace Calculate
{
    using System;

    class Calculate
    {
        static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            double numberFactorial = 1;

            for (int i = 1; i <= number; i++)
            {
                numberFactorial *= i;
                sum += numberFactorial / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}