namespace BonusScore
{
    using System;

    class BonusScore
    {
        static void Main()
        {
            int theScore = int.Parse(Console.ReadLine());

            if (1 <= theScore && theScore <= 3)
            {
                Console.WriteLine(theScore * 10);
            }
            else if (4 <= theScore && theScore <= 6)
            {
                Console.WriteLine(theScore * 100);
            }
            else if (7 <= theScore && theScore <= 9)
            {
                Console.WriteLine(theScore * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
