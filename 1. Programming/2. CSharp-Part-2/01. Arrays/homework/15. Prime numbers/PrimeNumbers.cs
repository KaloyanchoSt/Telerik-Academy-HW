using System;

namespace _15.Prime_numbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];

            for (int i = 2; i < Math.Sqrt(primes.Length); i++)
            {
                if (primes[i] == false)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                    {
                        primes[j] = true;
                    }
                }
            }

            for (int i = primes.Length - 1; i >= 2; i--)
            {
                if (!primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}