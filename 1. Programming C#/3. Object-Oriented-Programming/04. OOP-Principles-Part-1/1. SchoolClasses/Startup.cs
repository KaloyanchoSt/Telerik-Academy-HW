namespace SchoolClasses
{
    using Data;
    using People;
    using System;
    using System.Collections.Generic;

    class StartProgram
    {
        static void Main(string[] args)
        {

            var nakovDisciplines = new List<Discipline>
            {
                new Discipline(DisciplineName.Biology, 10, 10),
                new Discipline(DisciplineName.English, 20, 20)
            };

            var kiroDisciplines = new List<Discipline>
            {
                new Discipline(DisciplineName.History, 8, 8),
                new Discipline(DisciplineName.Physics, 6, 6)
            };

            var studentsClassA = new List<Student>
            {
                new Student("Pesho", "Peshov", 5),
                new Student("Gosho", "Goshov", 6),
                new Student("Ivo", "Ivov", 7)
            };

            var studentsClassB = new List<Student>
            {
                new Student("Mariika", "Mariikova", 8),
                new Student("Todorka", "Todorkova", 9),
                new Student("Stoyanka", "Stoyankova", 10)
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Svetlin", "Nakov", nakovDisciplines),
                new Teacher("Kiro", "Kirov", kiroDisciplines)
            };

            var classA = new SchoolClass(teachers, studentsClassA);
            var classB = new SchoolClass(teachers, studentsClassB);

            var school = new School(new List<SchoolClass> { classA, classB });

            Console.WriteLine(school);
        }
    }
}
