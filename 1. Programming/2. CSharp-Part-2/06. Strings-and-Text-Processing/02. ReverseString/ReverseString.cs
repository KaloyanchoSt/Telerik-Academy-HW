namespace ReverseString
{
    using System;

    class ReverseString
    {
        static void Main()
        {
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", word[i]);
            }

            Console.WriteLine();
        }
    }
}
