using System;

namespace _01.Say_Hello
{
    class SayHello
    {
        static void Main()
        {
            Hello();
        }
        static void Hello()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
