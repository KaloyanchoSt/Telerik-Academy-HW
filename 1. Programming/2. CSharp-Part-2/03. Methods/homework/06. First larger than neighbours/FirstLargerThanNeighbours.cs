using System;
using System.Linq;

namespace _06.First_larger_than_neighbours
{
    class FirstLargerThanNeighbours
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
            Console.WriteLine(FindFirstLarger(numArray));
        }

        static int FindFirstLarger(int[] numArray)
        {
            int index = 0;
            for (int i = 1; i < numArray.Length - 1; i++)
            {
                if (numArray[i - 1] < numArray[i] && numArray[i + 1] < numArray[i])
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }

            return index;
        }
    }
}
