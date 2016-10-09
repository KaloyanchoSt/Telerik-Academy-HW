namespace SchoolClasses.People
{
    using SchoolClasses.Data;
    using System;

    public abstract class Human : IComment
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter a name!");
                }

                if (value.Length < 6)
                {
                    throw new ArgumentException("First name cannot be less than 6 characters!");
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

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter a name!");
                }

                if (value.Length < 6)
                {
                    throw new ArgumentException("First name cannot be less than 6 characters!");
                }

                this.lastName = value;
            }
        }

        public virtual void Comment()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
