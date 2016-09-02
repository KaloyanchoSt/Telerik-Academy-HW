namespace InheritanceAndPolymorphism.Contracts
{
    using System.Collections.Generic;

    interface ICourse
    {
        string CourseName { get; set; }

        string TeacherName { get; set; }

        IList<string> Students { get; set; }

        string GetStudentsAsString();
    }
}
