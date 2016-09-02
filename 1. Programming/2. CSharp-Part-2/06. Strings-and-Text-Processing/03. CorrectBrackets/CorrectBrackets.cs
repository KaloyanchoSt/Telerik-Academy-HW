namespace CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            int brackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets++;
                }
                else if (expression[i] == ')')
                {
                    brackets--;
                }

                if (brackets < 0)
                {
                    break;
                }
            }

            if (brackets == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}