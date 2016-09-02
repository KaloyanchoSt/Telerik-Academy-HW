namespace PrintTheASCIITable
{
    using System;

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
