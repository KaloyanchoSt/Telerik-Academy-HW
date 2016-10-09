namespace SchoolClasses.People
{
    using System;

    public class Student : Human
    {
        private int studentNumber;

        public Student(string firstName, string lastName, int studentNumber)
            : base(firstName, lastName)
        {

            this.StudentNumber = studentNumber;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("#######The student number must be greater than zero.");
                this.studentNumber = value;
            }
        }

        public override void Comment()
        {
            Console.WriteLine("I'm studying");
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + "; Student number: " + this.StudentNumber;
        }
    }
}
