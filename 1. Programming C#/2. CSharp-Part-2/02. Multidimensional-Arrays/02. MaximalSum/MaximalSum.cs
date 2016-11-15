namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int rows = int.Parse(numbers[0]);
            int cols = int.Parse(numbers[1]);

            int[,] numArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    numArray[i, j] = int.Parse(input[j]);
                }
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < numArray.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < numArray.GetLength(1) - 2; j++)
                {
                    int sum = numArray[i, j] + numArray[i, j + 1] + numArray[i, j + 2] +
           numArray[i + 1, j] + numArray[i + 1, j + 1] + numArray[i + 1, j + 2] +
           numArray[i + 2, j] + numArray[i + 2, j + 1] + numArray[i + 2, j + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
