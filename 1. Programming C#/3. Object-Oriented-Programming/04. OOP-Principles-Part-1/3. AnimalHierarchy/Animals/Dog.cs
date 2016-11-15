namespace AnimalHierarchy.Animals
{
    using Enumerations;
    using System;

    public class Dog : Animals
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau bau");
        }
    }
}
