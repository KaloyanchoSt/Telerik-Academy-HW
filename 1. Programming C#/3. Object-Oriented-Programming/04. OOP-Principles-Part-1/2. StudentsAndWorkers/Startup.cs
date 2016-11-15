namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Humans;

    public class StartProgram
    {
        static void Main()
        {
            // 2.Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>
        {
            new Student("Aleksi", "Sokachev", 6),
            new Student("Moci", "Moci", 5),
            new Student("Mocii", "Mocii", 6),
            new Student("Mociii", "Mociii", 2),
            new Student("Stamat", "Geshov", 3),
            new Student("Ivan", "Ivanov", 3),
            new Student("Gosho", "Petrov", 4),
            new Student("Statul", "Ivanov", 4),
            new Student("Gosho", "Geshov", 5),
            new Student("Tosho", "Toshev", 3),
        };

            Console.WriteLine("Students ordered by Grade: ");
            var sortedStudents = students
                .OrderBy(st => st.Grade)
                .ToList();

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            // 2.Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>
        {
            new Worker("Gosho", "One",300, 6),
            new Worker("Ivan", "Two", 400, 5),
            new Worker("Tosho", "Three", 500, 6),
            new Worker("Moci", "Mociii",150, 2),
            new Worker("Statul", "Geshov", 650, 3),
            new Worker("Gosho", "Ivanov", 300, 3),
            new Worker("Aleksi", "Petrov", 200, 4),
            new Worker("Worker", "Ivanov", 700, 4),
            new Worker("Tosho", "Geshov", 900, 5),
            new Worker("Ivan", "Toshev", 100, 3),
        };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Workers ordered by MoneyPerHour: ");
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + " - Money per hour: " + worker.MoneyPerHour());
            }

            //2.Merge the lists and sort them by first name and last name.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Merged and sorted by first and last name: ");
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var sortedHumans =
                from h in humans
                orderby h.FirstName ascending
                , h.LastName ascending
                select h;            
            foreach (var h in sortedHumans)
            {
                Console.WriteLine(h);
            }

        }
    }
}
