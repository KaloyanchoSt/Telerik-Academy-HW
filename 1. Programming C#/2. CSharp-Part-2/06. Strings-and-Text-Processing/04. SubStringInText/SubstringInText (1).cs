namespace SubStringInText
{
    using System;

    class SubStringInText
    {
        static void Main()
        {
            string subString = Console.ReadLine();
            string inputString = Console.ReadLine();

            // to perform insensitive search
            subString = subString.ToLower();
            inputString = inputString.ToLower();

            int counter = 0;
            int index = 0;

            while (true)
            {
                //// searching for the targerSubStr in str starting from index, return index or -1 if no found
                int found = inputString.IndexOf(subString, index);
                if (found < 0)  //// (found == -1)
                {
                    break;
                }

                counter++;
                index = found + 1;
            }

            Console.WriteLine(counter);
        }
    }
}