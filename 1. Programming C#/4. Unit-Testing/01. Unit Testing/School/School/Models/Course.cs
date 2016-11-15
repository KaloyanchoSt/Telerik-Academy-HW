namespace School
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Contracts;


    public class Course : ICourse
    {
        private string courseName;

        private ICollection<IStudent> studentsList;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.studentsList = new List<IStudent>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            private set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, Constants.CourseNameCannotBeNullOrEmpty);

                this.courseName = value;
            }
        }

        public ICollection<IStudent> StudentsList
        {
            get
            {
                return new List<IStudent>(this.studentsList);
            }
        }

        public void AddStudent(IStudent student)
        {
            Validator.ValidateIfNull(student, string.Format(Constants.StudentCannotBeNull));

            if (this.StudentsList.Count >= Constants.MaxStudentsInCourse)
            {
                throw new InvalidOperationException(string.Format(Constants.StudentListIsFull, Constants.MaxStudentsInCourse));
            }

            if (this.StudentsList.Contains(student))
            {
                throw new InvalidOperationException(Constants.StudentListContainsSameStudent);
            }

            this.studentsList.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            Validator.ValidateIfNull(student, string.Format(Constants.StudentCannotBeNull));

            this.studentsList.Remove(student);
        }

        public override string ToString()
        {
            return this.CourseName;
        }
    }
}
