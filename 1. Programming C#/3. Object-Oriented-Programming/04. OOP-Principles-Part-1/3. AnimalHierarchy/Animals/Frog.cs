namespace AnimalHierarchy.Animals
{
    using Enumerations;
    using System;

    public class Frog : Animals
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kwak");
        }
    }
}
