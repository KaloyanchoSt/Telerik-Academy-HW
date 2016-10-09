namespace School
{
    using System;
    using System.Collections.Generic;

    using Common;
    using Contracts;

    public class School : ISchool
    {
        private string schoolName;
        private ICollection<IStudent> students;
        private ICollection<ICourse> courses;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.students = new List<IStudent>();
            this.courses = new List<ICourse>();
        }

        public IEnumerable<ICourse> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }

            set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, string.Format(Constants.SchoolNameCannotBeNullOrEmpty));

                this.schoolName = value;
            }
        }

        public IEnumerable<IStudent> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddCourse(ICourse course)
        {
            Validator.ValidateIfNull(course, Constants.CourseCannotBeNull);

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                throw new InvalidOperationException($"{course} is already added in {this}");
            }
            else
            {
                this.courses.Add(course);
            }
        }

        public void AddStudent(IStudent student)
        {
            Validator.ValidateIfNull(student, Constants.StudentCannotBeNull);

            if (Validator.IsPartOfCollection(this.students, student))
            {
                throw new InvalidOperationException($"{student} is already added in {this}");
            }
            else
            {
                this.students.Add(student);
            }
        }

        public int GenerateStudentId()
        {
            if (this.students.Count >= Constants.MaxStudentsInCourse)
            {
                throw new InvalidOperationException($"{this} is overpopulated!");
            }

            var id = Constants.MinUniqueNumber + this.students.Count;

            return id;
        }

        public void RemoveCourse(ICourse course)
        {
            Validator.ValidateIfNull(course, Constants.CourseCannotBeNull);

            if (Validator.IsPartOfCollection(this.courses, course))
            {
                this.courses.Remove(course);
            }
            else
            {
                throw new InvalidOperationException($"{course} is not added in {this}");
            }
        }

        public void RemoveStudent(IStudent student)
        {
            Validator.ValidateIfNull(student, Constants.CourseCannotBeNull);

            if (Validator.IsPartOfCollection(this.students, student))
            {
                this.students.Remove(student);
            }
            else
            {
                throw new InvalidOperationException($"{student} is not part of {this}");
            }
        }
    }
}
