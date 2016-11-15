namespace Masages
{
    using System;
    using System.Linq;
    using System.Text;

    class Messages
    {
        private static void Main()
        {
            string[] words = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

            string firstInputNumber = Console.ReadLine();
            string addOrSubSign = Console.ReadLine();
            string secondInputNumber = Console.ReadLine();

            int addNewNumber = ResultString(words, firstInputNumber) + ResultString(words, secondInputNumber); 
            int subNewNumber = ResultString(words, firstInputNumber) - ResultString(words, secondInputNumber); 

            if (addOrSubSign == "-")
            {
                Console.WriteLine(Dec(subNewNumber, words));
            }
            else if (addOrSubSign == "+")
            {
                Console.WriteLine(Dec(addNewNumber, words));
            }
        }

        static int ResultString(string[] words, string number)
        {
            var currentLetter = new StringBuilder();
            int result = 0;
            foreach (var letter in number)
            {
                currentLetter.Append(letter);
                if (words.Contains(currentLetter.ToString()))
                {
                    int currentDigit = Array.IndexOf(words, currentLetter.ToString());
                    result *= 10;
                    result += currentDigit;
                    currentLetter.Clear();
                }
            }

            return result;
        }

        static string Dec(int dec, string[] words)
        {
            string result = string.Empty;

            do
            {
                result = words[(int)(dec % 10)] + result;
                dec = dec / 10;

            } while (dec > 0);

            return result;
        }
    }
}