namespace MoonGravity
{
    using System;

    class MoonGravity
    {
        static void Main()
        {
            double earthW = double.Parse(Console.ReadLine());
            double moonW = earthW * 0.17;

            Console.WriteLine("{0:F3}", moonW);
        }
    }
}
