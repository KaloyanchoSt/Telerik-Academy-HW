using System;

namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint number = UInt32.Parse(Console.ReadLine()),
                 mask1,
                 mask2;
            int p, m, q, n, k;

            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            for (m = p, n = q; (m <= p + k - 1) && (n <= q + k - 1); n++, m++)
            {
                mask1 = number >> m;
                mask1 = mask1 & 1;

                mask2 = number >> n;
                mask2 = mask2 & 1;

                if (mask1 != mask2)
                {
                    mask1 = (uint)1 << m;
                    number = mask1 ^ number;

                    mask2 = (uint)1 << n;
                    number = mask2 ^ number;
                }
            }
            Console.WriteLine(number);
        }
    }
}