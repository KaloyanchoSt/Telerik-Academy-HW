namespace FibonacciNumbers
{
    using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.Write("0");
            }

            if (n > 1)
            {
                Console.Write(", 1");
            }

            if (n > 2)
            {
                long numberN = 0;
                long numberNplus1 = 1;
                for (int i = 3; i <= n; i++)
                {
                    long numberNplus2 = numberN + numberNplus1;
                    Console.Write(", {0}", numberNplus2);
                    numberN = numberNplus1;
                    numberNplus1 = numberNplus2;
                }
            }
        }
    }
}