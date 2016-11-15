using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.RefactorLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int expectedValue = 666;
            var array = new Array[4];
            for (i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
