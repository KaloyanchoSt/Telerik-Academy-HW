namespace AppearanceCount
{
    using System;

    class AppearanceCount
    {
        static int CountAppearance(string[] numbers, int arrayLength, int searchingNumber)
        {
            int counter = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (int.Parse(numbers[i]) == searchingNumber)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            string inputNumbersString = Console.ReadLine();
            string[] numbers = inputNumbersString.Split(' ');
            int searchingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(CountAppearance(numbers, arrayLength, searchingNumber));
        }
    }
}