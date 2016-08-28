using System;

namespace _01.Fill_the_matrix
{
    class FillTheMatrix
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            string ch = Console.ReadLine();

            int[,] matrix = new int[n, n];

            if (ch == "a")
            {

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
