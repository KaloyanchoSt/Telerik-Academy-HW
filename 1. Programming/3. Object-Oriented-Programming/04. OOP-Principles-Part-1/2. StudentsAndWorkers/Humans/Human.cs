namespace StudentsAndWorkers.Humans
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        //Constructors
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.lastName = value;
            }
        }

        // ToString
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

    }
}
