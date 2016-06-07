using System;

namespace _03.Check_for_a_Play_Card
{
    class CheckForACard
    {
        static void Main()
        {
            string card = Console.ReadLine();

            if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "3" || card == "J" || card == "j" || card == "Q" || card == "q" || card == "K" || card == "k" || card == "a" || card == "A")
            {
                Console.WriteLine("yes " + card);
            }
            else
            {
                Console.WriteLine("no " + card);
            }
        }
    }
}
