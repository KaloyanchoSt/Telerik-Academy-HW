using System;

namespace _12.N_th_bit
{
    class NthBit
    {
        static void Main()
        {
            int p = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int numberRightP = p >> n;
            int bit = numberRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
