namespace School
{
    using System.Collections.Generic;

    using Common;
    using Contracts;

    public class Student : IStudent
    {
        private string name;
        private int uniqueNumber;
        private ICollection<ICourse> coursesList;

        public Student(string name, ISchool school)
        {
            this.Name = name;
            this.UniqueNumber = school.GenerateStudentId();
            this.coursesList = new List<ICourse>();
            school.AddStudent(this);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateIfStringIsNullOrEmpty(value, string.Format(Constants.StudentNameCannotBeNullOrEmpty));

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                Validator.ValidateIfNull(value, Constants.UniqueNumberCannotBeNull);

                Validator.ValidateIfInRange(value, Constants.MaxUniqueNumber, Constants.MinUniqueNumber, string.Format(Common.Constants.NumberMustBeBetweenMinAndMax, Constants.UniqueNumber, Constants.MinUniqueNumber, Constants.MaxUniqueNumber));

                this.uniqueNumber = value;
            }
        }

        public ICollection<ICourse> CoursesList
        {
            get
            {
                return new List<ICourse>(this.coursesList);
            }
        }

        public void JoinCourse(ICourse course)
        {
            Validator.ValidateIfNull(course, Constants.CourseCannotBeNull);

            this.coursesList.Add(course);
        }

        public void LeaveCourse(ICourse course)
        {
            Validator.ValidateIfNull(course, Constants.CourseCannotBeNull);

            this.coursesList.Remove(course);
        }

        public override string ToString()
        {
            return $"{this.name} {this.uniqueNumber}";
        }
    }
}
