namespace StudentsAndWorkers.Humans
{
    using System;

    public class Student : Human
    {
        private const int MaxGrade = 6;
        private const int MinGrade = 2;

        public double grade;

        // Constructor
        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // Properties
        public double Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < MinGrade || value > MaxGrade)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 2 and 6");
                }

                this.grade = value;
            }
        }

        // ToString
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", FirstName, LastName, Grade);
        }
    }
}
