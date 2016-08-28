using System;

namespace _03.Sequence_in_matrix
{
    class SequenceInMatrix
    {
        static readonly int[,] changes = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };
        static void Main()
        {
            string[] strings = Console.ReadLine().Split();
            int rows = int.Parse(strings[0]);
            int cols = int.Parse(strings[1]);

            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                String[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = (input[j]);
                }
            }

            int bestLength = 0;
            string bestElement = string.Empty;
            FindLongestSequence(matrix, ref bestElement, ref bestLength);

            // The longest sequence of equal strings in the matrix
            //Console.WriteLine(string.Join(", ", Enumerable.Repeat(bestElement, bestLength)));

            // Output
            Console.WriteLine(bestLength);
        }

        /*A variable of a reference type does not contain its data directly; it contains a reference to its data. 
        When you pass a reference-type parameter by value, 
        it is possible to change the data pointed to by the reference, such as the value of a class member. */
        static void FindLongestSequence(string[,] matrix, ref string bestElement, ref int bestLength)
        {
            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                {
                    int direction = -1;

                    // direction => 0 (right); 1 (down diagonal); 2(up diagonal); 3(down)
                    while (++direction < 4)
                    {
                        int currRow = row + changes[direction, 0];
                        int currCol = col + changes[direction, 1];

                        int currentLength = 1;

                        while (InRangeAndEqual(matrix, row, col, currRow, currCol))
                        {
                            currentLength++;

                            if (currentLength > bestLength)
                            {
                                bestLength = currentLength;
                                bestElement = matrix[row, col];
                            }

                            currRow += changes[direction, 0];
                            currCol += changes[direction, 1];
                        }
                    }

                }
            }
        }

        static bool InRangeAndEqual(string[,] matrix, int row, int col, int currRow, int currCol)
        {
            return currRow >= 0 && currRow < matrix.GetLongLength(0) // in the range of rows
                && currCol >= 0 && currCol < matrix.GetLongLength(1) // in the range of cols
                && matrix[currRow, currCol] == matrix[row, col];
        }

    }
}

