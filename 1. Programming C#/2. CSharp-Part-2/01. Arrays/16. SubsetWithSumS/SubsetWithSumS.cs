namespace SubsetWithSumS
{
    using System;

    class SubsetWithSumS
    {
        static void Main()
        {
            // Input array
            string digits = Console.ReadLine();

            // Split the elements into an array
            string[] arrayDigits = digits.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Fill an integer array from string array
            int[] array = new int[arrayDigits.Length];
            for (int i = 0; i < arrayDigits.Length; i++)
            {
                array[i] = int.Parse(arrayDigits[i]);
            }

            // Input S
            int s = int.Parse(Console.ReadLine());

            long currentSum = 0;
            int counter = 0;

            for (int i = 1; i <= (int)Math.Pow(2, array.Length) - 1; i++)
            {
                currentSum = 0;
                string template = Convert.ToString(i, 2).PadLeft(array.Length, '0');

                for (int j = 0; j < template.Length; j++)
                {
                    if (template[j].ToString() == "1")
                    {
                        currentSum += array[j];
                    }
                }

                if (currentSum == s)
                {
                    counter++;
                }
            }
            // Output
            if (counter > 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
