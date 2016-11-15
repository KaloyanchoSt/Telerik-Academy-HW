namespace AnimalHierarchy.Animals
{
    using System;
    using Enumerations;

    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten says miao too");
        }
    }
}
