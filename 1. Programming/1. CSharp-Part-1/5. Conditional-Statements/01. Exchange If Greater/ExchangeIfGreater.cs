namespace ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
