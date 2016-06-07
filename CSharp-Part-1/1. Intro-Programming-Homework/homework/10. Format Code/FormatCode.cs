using System;

namespace _10.Format_Code
{
    class FormatCode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am horribly formatted program");
            Console.WriteLine("Numbers and squares:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + i * i);
            }
        }
    }
}
