using System;
using System.Text;

namespace _05.Parse_tags
{
    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int toUpper = -1;   //checks if we have to enter UPPERCASE MODE

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i++;
                    toUpper = toUpper * (-1); // an opening tag => start UPPER

                    while (text[i] != '>')    // disregard all of the tag's content
                    {
                        i++;
                    }
                }
                else
                {
                    if (toUpper == 1)
                    {
                        sb.Append(text[i].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(text[i]);
                    }

                }
            }
            Console.WriteLine(sb.ToString());

            //other way
            //Console.WriteLine(Regex
            //    .Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
        }
    }
}
