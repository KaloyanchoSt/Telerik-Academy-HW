namespace LongSequence
{
    using System;

    class LongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1002;
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * (-1));
                }
            }
            Console.WriteLine();
        }
    }
}