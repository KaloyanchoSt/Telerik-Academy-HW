

namespace Age
{
    using System;

    class Age
    {
        static void Main()
        {
            DateTime ageNow = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan age = (now.Subtract(ageNow));
            Console.WriteLine(new DateTime(age.Ticks).Year - 1);
            Console.WriteLine((new DateTime(age.Ticks).Year - 1) + 10);
        }
    }
}
