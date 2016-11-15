namespace NFactorial
{
    using System;
    using System.Numerics;

    class NFactorial
    {
        static BigInteger CalculateFactorial(int[] sequence)
        {
            BigInteger result = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                result *= sequence[i];
            }

            return result;
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] numArray = new int[number];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i + 1;
            }

            Console.WriteLine(CalculateFactorial(numArray));
        }
    }
}