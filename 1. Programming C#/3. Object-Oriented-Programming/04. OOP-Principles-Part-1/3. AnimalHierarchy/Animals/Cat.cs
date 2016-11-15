namespace AnimalHierarchy.Animals
{
    using Enumerations;
    using System;

    public abstract class Cat : Animals
    {
        public Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("miao");
        }
    }
}