namespace DecimalToBinary
{
    using System;

    class DecimalToBinary
    {
        private static void Main()
        {
            long decNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(decNumber));
        }

        private static string DecToBin(long decNumber)
        {
            string binNumber = string.Empty;
            string reverseNumber = string.Empty;

            if (decNumber == 0)
            {
                return binNumber += 0;
            }

            while (decNumber > 0)
            {
                reverseNumber += decNumber % 2;
                decNumber /= 2;
            }

            for (int i = reverseNumber.Length - 1; i >= 0; i--)
            {
                binNumber += reverseNumber[i];
            }
            return binNumber;
        }
    }
}