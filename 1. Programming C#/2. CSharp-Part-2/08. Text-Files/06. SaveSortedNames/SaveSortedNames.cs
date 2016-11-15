/*  Problem 6. Save sorted names
    Write a program that reads a text file containing a list of strings, 
    sorts them and saves them to another text file.
    Example:
            input.txt 	    output.txt
            Ivan            George
            Peter           Ivan
            Maria           Maria
            George 	        Peter
 */

namespace SaveSortedNames
{
    using System;
    using System.IO;

    class SaveSortedNames
    {
        static void Main()
        {
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
