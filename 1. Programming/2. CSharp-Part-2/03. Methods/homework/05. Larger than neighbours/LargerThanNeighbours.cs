using System;
using System.Linq;

namespace _05.Larger_than_neighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            // input using System.Linq
            Console.ReadLine();
            int[] numArray = Console.ReadLine()          // Read Input 
                             .Trim(' ')
                             .Split(' ')                 // Split
                             .Select(x => int.Parse(x))  // Convert to INT
                             .ToArray();                 // Store in Array
            Console.WriteLine(CheckNeighbours(numArray));
        }

        static int CheckNeighbours(int[] numArray)
        {
                int counter = 0;
                for (int i = 1; i < numArray.Length - 1; i++)
            {
                    if (numArray[i - 1] < numArray[i] && numArray[i + 1] < numArray[i])
                    {
                        counter++;
                    }
            }

            return counter;
        }
    }
}

