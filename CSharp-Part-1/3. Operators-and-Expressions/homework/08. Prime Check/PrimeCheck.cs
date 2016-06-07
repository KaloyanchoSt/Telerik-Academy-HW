using System;

namespace _08.Prime_Check
{
    class PrimeCheck
    {
        static void Main()
        {
            uint intToCheck;
            int count = 0;
            Console.WriteLine("Provide a positive integer <= 100 to check:");
            while (!(uint.TryParse(Console.ReadLine(), out intToCheck) && (intToCheck <= 100)))
            {
                Console.WriteLine("false");
            }
            if (intToCheck != 1)
            {
                for (int i = 2; i <= Math.Sqrt(intToCheck); i++)
                {
                    count = count + (((intToCheck % i) == 0) ? 1 : 0);
                }
            }
            else
            {
                count = 2;
            }

            Console.WriteLine((count > 0) ? "Is Not Prime" : "Is Prime");
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
        }
    }

