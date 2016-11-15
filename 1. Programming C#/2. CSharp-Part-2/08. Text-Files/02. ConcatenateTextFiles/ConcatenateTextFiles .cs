/*  Problem 2. Concatenate text files
    Write a program that concatenates two text files into another text file.
 */

namespace ConcatenateTextFiles
{
    using System;
    using System.IO;

    class ConcatenateTextFiles
    {
        static void Main()
        {
            using (var output = File.Create("../../Result.txt"))
            {
                foreach (var file in new[] {
                "../../TextFileOne.txt",
                "../../TextFileTwo.txt"})
                {
                    using (var input = File.OpenRead(file))
                    {
                        input.CopyTo(output);
                    }
                }
            }

            StreamReader reader = new StreamReader("../../Result.txt");

            using (reader)
            {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    Console.WriteLine(line);

                    line = reader.ReadLine();
                }
            }

        }
    }
}
