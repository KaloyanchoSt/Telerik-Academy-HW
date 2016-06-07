using System;

namespace _11._3rd_Bit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberRight3 = number >> 3;
            int bit3 = numberRight3 & 1;
            Console.WriteLine(bit3);
        }
    }
}
