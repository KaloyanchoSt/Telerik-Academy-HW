/*  7. One system to any other
    Write a program to convert the number N 
    from any numeral system of given base s to any other numeral system of base d.
    Input: On the first line you will receive the number s.
           On the second line you will receive a number in base s - N. There will not be leading zeros
           On the third line you will receive the number d
    Output: Print N in base d. There should not be leading zeros. Use uppercase letters
    Constraints: 2 <= s, d <= 16;       1 <= N <= 1018
    Sample tests:
                    Input 	    Output
                    13          21
                    16
                    9 	                    
                    https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/04.%20Numeral-Systems/homework/07.%20One%20system%20to%20any%20other/README.md */

namespace OneSystemToAnyOther
{
    using System;

    class OneSystemToAnyOther
    {
        private static void Main()
        {
            long fromBase = long.Parse(Console.ReadLine());
            string number = Console.ReadLine();  // The number which is converted fromBase -> toBase
            long toBase = long.Parse(Console.ReadLine());

            Console.WriteLine(FromDecimalToBaseTwo(FromBaseOneToDecimal(number, fromBase), toBase));
        }

        private static long Power(long number, long power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        private static long FromBaseOneToDecimal(string number, long baseSystem)
        {
            long decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                long digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }

                decimalNumber += digit * Power(baseSystem, number.Length - i - 1);
            }

            return decimalNumber;
        }

        private static string FromDecimalToBaseTwo(long decimalNumber, long baseSystem)
        {
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                long digit = decimalNumber % baseSystem;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }

                decimalNumber /= baseSystem;
            }

            return result;
        }
    }
}
