namespace RemoveElementsFromArrayy
{
    using System;

    class RemoveElementsFromArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSubseqLength = 0;
            int[] helperArray = new int[n];
            for (int endPoint = 0; endPoint < array.Length; endPoint++)
            {
                maxSubseqLength = 0;

                for (int startPoint = 0; startPoint < endPoint; startPoint++)
                {
                    if (array[startPoint] <= array[endPoint]
                        && helperArray[startPoint] >= maxSubseqLength)
                    {
                        maxSubseqLength = helperArray[startPoint];
                    }
                }

                helperArray[endPoint] = maxSubseqLength + 1;
            }

            maxSubseqLength = 0;
            for (int i = 0; i < n; i++)
            {
                if (helperArray[i] > maxSubseqLength)
                {
                    maxSubseqLength = helperArray[i];
                }
            }

            Console.WriteLine(n - maxSubseqLength);
        }
    }
}
