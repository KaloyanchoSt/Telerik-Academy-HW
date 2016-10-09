namespace AnimalHierarchy.Animals
{
    using System;
    using Enumerations;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Tomcat says miao too");
        }
    }
}
