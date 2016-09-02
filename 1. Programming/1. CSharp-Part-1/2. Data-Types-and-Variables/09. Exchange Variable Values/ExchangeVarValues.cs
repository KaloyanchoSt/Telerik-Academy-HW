namespace ExchangeVariableValues
{
    using System;

    class ExchangeVarValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a: {0}  b: {1}", a, b);
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine("a: {0}  b: {1}", a, b);
        }
    }
}
