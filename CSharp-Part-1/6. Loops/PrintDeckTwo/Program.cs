using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckTwo
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int count = Convert.ToInt32(n);
            string j = "J";
            string q = "Q";
            string k = "K";
            string a = "A";

            for (int i = 2; i <= count; i++)
            {
                if (i <= 10)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                if (i == 11)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
                }
                if (i == 12)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
                }
                if (i == 13)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
                }
                if (i == 14)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
                }
                else if (i > 14)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
        }
    }
}