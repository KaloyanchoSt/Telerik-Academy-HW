namespace CompareCharArrays
{
    using System;

    class CompareCharArrays // Zadachata predstavlqva sravnenie na duljina na indexi  7678 <>= 4324 i suhto taka obache proverka na bukva po bukva
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().ToCharArray();
            char[] secondArray = Console.ReadLine().ToCharArray();

            int arraysLength; // Used to 
            int minArray = 0; // Used to declare later which array of the two is the smaller one

            // first checking for the smaller arrayLength
            if (firstArray.Length >= secondArray.Length) 
            {
                arraysLength = secondArray.Length;  
            }
            else
            {
                arraysLength = firstArray.Length;
            }

            // Checking which one is the bigger one
            for (int i = 0; i < arraysLength; i++) 
            {
                if (firstArray[i] < secondArray[i])
                {
                    minArray = 1; // the smaller array is the first one
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    minArray = 2; // the smaller array is the second one
                    break;
                }
            }

            if (minArray == 1)
            {
                Console.WriteLine("<");
            }
            else if (minArray == 2)
            {
                Console.WriteLine(">");
            }

            //// Used this to check if the arrays are equal
            else
            {
                if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine(">");
                }
                else if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
