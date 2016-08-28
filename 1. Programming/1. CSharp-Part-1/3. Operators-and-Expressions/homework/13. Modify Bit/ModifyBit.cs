using System;

namespace _13.Modify_Bit
{
    class ModifyBit
    {
        static void Main()
        {

            ulong N = ulong.Parse(Console.ReadLine());
            byte P = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());
            if (P >= 0 && P < 64)
            {
                if (v == 0)
                {

                    ulong mask = (ulong)~(1 << P);
                    ulong result = N & mask;
                    Console.WriteLine(result);
                }
                else if (v == 1)
                {
                    ulong mask = (ulong)1 << P;
                    ulong result = N | mask;
                    Console.WriteLine(result);
                }
            }
        }
    }
}