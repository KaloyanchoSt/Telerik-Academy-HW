namespace IntDoubleAndString
{
    using System;

    class IntDoubleAndString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "text":
                {
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
                }

            case "integer":
                {
                    int newValue = int.Parse(Console.ReadLine());
                    Console.WriteLine(newValue + 1);
                    break;
                }

            case "real":
                {
                    double newValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:N2}", newValue + 1);
                    break;
                }
            }
        }
    }
}
