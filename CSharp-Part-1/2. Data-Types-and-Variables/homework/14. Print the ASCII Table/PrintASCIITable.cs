using System;

namespace _14.Print_the_ASCII_Table
{
    class PrintASCIITable
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
