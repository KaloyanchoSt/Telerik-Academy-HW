namespace BooleanToStringConverter
{
    using System;

    public class BooleanToString
    {
        public void BooleanToStringConverter(bool isTrue)
        {
            string booleanAsString = isTrue.ToString();

            Console.WriteLine(booleanAsString);
        }

        public static void Main()
        {
            BooleanToString converter = new BooleanToString();

            converter.BooleanToStringConverter(true);
        }
    }
}