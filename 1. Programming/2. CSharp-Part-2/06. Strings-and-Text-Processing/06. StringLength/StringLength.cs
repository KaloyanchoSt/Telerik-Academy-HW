namespace StringLength
{
    using System;

    class StringLength
    {
        static void Main()
        {
            string str = Console.ReadLine().Replace("\\", string.Empty);
            ////string str = Console.ReadLine().Replace(@"\", string.Empty);

            //// first way
            /* Returns a new string that left-aligns the characters in this string
               by padding them on the right with a specified Unicode character, for a specified total length. */
            str = str.PadRight(20, '*');
            Console.WriteLine(str);

            //// second way
            ////StringBuilder sb = new StringBuilder();

            ////for (int i = 0; i < str.Length; i++)    // copy the str in sb
            ////{
            ////    sb.Append(str[i]);
            ////}

            //////int counter = 0;                      // other way for copy the str in sb
            //////while (counter < str.Length)
            //////{
            //////    sb.Append(str[counter]);
            //////    counter++;
            //////}

            ////if (sb.Length < 20)
            ////{
            ////    sb.Append(new string('*', 20 - sb.Length));
            ////}
            ////Console.WriteLine(sb.ToString());
        }
    }
}
