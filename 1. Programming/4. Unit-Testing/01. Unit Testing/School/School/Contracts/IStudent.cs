namespace School.Contracts
{
    using System.Collections.Generic;

    public interface IStudent
    {
        string Name { get; }

        int UniqueNumber { get; }

        ICollection<ICourse> CoursesList { get; }

        void JoinCourse(ICourse course);

        void LeaveCourse(ICourse course);
    }
}
