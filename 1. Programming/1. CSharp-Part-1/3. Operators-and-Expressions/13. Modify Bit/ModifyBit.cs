namespace ModifyBit
{
    using System;

    class ModifyBit
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            if (p >= 0 && p < 64)
            {
                if (v == 0)
                {
                    ulong mask = (ulong)~(1 << p);
                    ulong result = n & mask;
                    Console.WriteLine(result);
                }
                else if (v == 1)
                {
                    ulong mask = (ulong)1 << p;
                    ulong result = n | mask;
                    Console.WriteLine(result);
                }
            }
        }
    }
}