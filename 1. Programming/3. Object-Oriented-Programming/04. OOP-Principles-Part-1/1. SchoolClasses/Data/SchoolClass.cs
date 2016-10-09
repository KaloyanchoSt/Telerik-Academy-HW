namespace SchoolClasses.Data
{
    using People;
    using System;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        private string classIdentifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public SchoolClass(string identifier)
        {
            this.ClassIdentifier = identifier;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }

        public string ClassIdentifier
        {
            get
            {
                return this.classIdentifier;
            }

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("#######The class identifier must not be null or empty");
                }                   

                this.classIdentifier = value;
            }
        }

        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        public void Comment()
        {
            throw new NotImplementedException();
        }
    }
}

