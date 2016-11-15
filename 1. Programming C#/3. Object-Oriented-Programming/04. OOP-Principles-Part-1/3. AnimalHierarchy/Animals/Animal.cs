namespace AnimalHierarchy.Animals
{
    using Enumerations;
    using Interfaces;
    using System;

    public abstract class Animals : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        // Constructors
        public Animals(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        // Properties
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be less than 0");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
            }
        }
        public Gender Gender { get { return gender; } set { this.gender = value; } }


        public abstract void MakeSound();
    }
}
