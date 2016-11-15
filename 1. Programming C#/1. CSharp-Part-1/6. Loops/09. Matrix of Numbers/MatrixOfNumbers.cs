namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int num = row; num < row + n; num++)
                {
                    Console.Write("{0} ", num);
                }

                Console.WriteLine();
            }
        }
    }
}
