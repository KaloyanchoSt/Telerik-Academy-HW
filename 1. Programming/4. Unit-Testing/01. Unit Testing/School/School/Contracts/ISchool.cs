namespace School.Contracts
{
    using System.Collections.Generic;

    public interface ISchool
    {
        string SchoolName { get; }

        IEnumerable<IStudent> Students { get; }

        IEnumerable<ICourse> Courses { get; }

        int GenerateStudentId();

        void AddStudent(IStudent student);

        void RemoveStudent(IStudent student);

        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}