/*  Problem 3. Line numbers
    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
 */

namespace LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../TextFile.txt");

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                StreamWriter writer = new StreamWriter("../../Result.txt");
                using (writer)
                {
                    while (line != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            writer.WriteLine("{0} : {1}", lineNumber, line);
                            lineNumber++;
                        }
                        line = reader.ReadLine();
                    }
                }
            }

            StreamReader readerResult = new StreamReader("../../Result.txt");

            using (readerResult)
            {
                int lineNumber = 0;

                string line = readerResult.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    Console.WriteLine(line);

                    line = readerResult.ReadLine();
                }
            }
        }
    }
}
