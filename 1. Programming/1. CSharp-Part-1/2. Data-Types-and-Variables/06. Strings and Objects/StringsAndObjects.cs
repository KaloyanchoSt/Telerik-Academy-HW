namespace StringsAndObjects
{
    using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string var1 = "Hello";
            string var2 = "World";
            object concatenation = var1 + " " + var2;
            string var3 = (string)concatenation;
            Console.WriteLine(var3);
        }
    }
}
