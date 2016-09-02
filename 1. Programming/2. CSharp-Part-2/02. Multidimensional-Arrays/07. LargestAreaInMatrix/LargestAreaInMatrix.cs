namespace LargestAreaInMatrix
{
    using System;

    class LargestAreaInMatrix
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int rows = int.Parse(numbers[0]);
            int cols = int.Parse(numbers[1]);

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            int counter = 0;
            int? bestElement = null;
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int currentCount = CheckElement(matrix, i, j, matrix[i, j], visited);

                    if (currentCount > counter)
                    {
                        bestElement = matrix[i, j];
                        counter = currentCount;
                    }
                }
            }

            PrintMatrix(matrix, counter, bestElement);
        }

        private static void PrintMatrix(int[,] matrix, int counter, int? bestElement)
        {
            Console.WriteLine("{0}", counter);
        }

        static bool InRange(int[,] array, int row, int col, bool[,] visited)
        {
            bool inRange = false;
            if ((row >= 0 && row < array.GetLength(0)) && (col >= 0 && col < array.GetLength(1)))
            {
                inRange = true;
            }

            if (inRange)
            {
                if (visited[row, col] == true)
                {
                    inRange = false;
                }
            }

            return inRange;
        }

        static int CheckElement(int[,] matrix, int row, int col, int value, bool[,] visited)
        {
            int count = 0;

            if (!InRange(matrix, row, col, visited))
            {
                return count;
            }
            else
            {
                if (matrix[row, col] == value)
                {
                    count++;

                    visited[row, col] = true;

                    count += CheckElement(matrix, row, col + 1, value, visited);
                    count += CheckElement(matrix, row, col - 1, value, visited);
                    count += CheckElement(matrix, row - 1, col, value, visited);
                    count += CheckElement(matrix, row + 1, col, value, visited);
                }
            }

            return count;
        }
    }
}