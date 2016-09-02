/*  Problem 1. Odd lines
    Write a program that reads a text file and prints on the console its odd lines.
 */

namespace OddLines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../TextFile.txt");

            using (reader)
            {
                int lineNuber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNuber++;

                    if (lineNuber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}:{1}", lineNuber, line);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
