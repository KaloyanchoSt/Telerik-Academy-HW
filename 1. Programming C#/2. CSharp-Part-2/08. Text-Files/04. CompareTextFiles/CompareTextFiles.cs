/*  Problem 4. Compare text files
    Write a program that compares two text files line by line and 
    prints the number of lines that are the same and the number of lines that are different.
    Assume the files have equal number of lines.
 */

namespace CompareTextFiles
{
    using System;
    using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            string[] textFileOneLines = File.ReadAllLines("../../TextFileOne.txt");
            string[] textFileTwoLines = File.ReadAllLines("../../TextFileTwo.txt");

            int maxLength = Math.Max(textFileOneLines.Length, textFileTwoLines.Length);
            int minLength = Math.Min(textFileOneLines.Length, textFileTwoLines.Length);

            for (int line = 0; line < maxLength; line++)
            {
                if (line < minLength)
                {
                    if (textFileOneLines[line].Equals(textFileTwoLines[line]))
                    {
                        Console.WriteLine("At line {0} : lines from both files are the same.", line);
                    }
                    else
                    {
                        Console.WriteLine("At line {0} : lines are not the same.", line);
                    }
                }
                else
                {
                    Console.WriteLine("Line {0} : doesnt exists in {1} file.", line, textFileOneLines.Length == minLength ? "first" : "second");
                }
            }
        }
    }
}
