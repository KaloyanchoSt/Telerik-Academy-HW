using System;

namespace _05.Sort_by_string_length
{
    class SortByStringLength
    {
        static void Main()
        {
            string[] array = { "Mercedes", "Bmw", "Audi", "Porsche", "Opel" };

            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
