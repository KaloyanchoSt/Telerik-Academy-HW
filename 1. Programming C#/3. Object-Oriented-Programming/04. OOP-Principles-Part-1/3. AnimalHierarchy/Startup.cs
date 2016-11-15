namespace AnimalHierarchy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Enumerations;
    using Animals;

    public class StartProgram
    {
        static void Main()
        {
            // 3.Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
            var cats = new List<Cat>
            {
                new Tomcat("Kotaran", 3),
                new Tomcat("Tom the cat", 4),
                new Kitten("Oi kotio", 1),
                new Tomcat("Maca", 13),
                new Tomcat("Dinko", 3),
                new Kitten("Lucifer", 13)
            };

            var catsAvarageAge = cats.Sum(x => x.Age) / (double)cats.Count;
            Console.WriteLine("Avarage age of the Cats is: {0:F2} ", catsAvarageAge);

            var dogs = new List<Dog>
            {
                new Dog("Pesho", 15, Gender.Male),
                new Dog("Balkanka", 5, Gender.Female),
                new Dog("Petrohan", 7, Gender.Male),
                new Dog("Sheitana", 2, Gender.Female),
                new Dog("Dobrinka",17,Gender.Female)
            };

            var dogsAvarageAge = dogs.Sum(x => x.Age) / (double)dogs.Count;
            Console.WriteLine("Avarage age of the Dogs is: {0} ", dogsAvarageAge);

            var frogs = new List<Frog>
            {
                new Frog("Veneta Raikova",70, Gender.Female),
                new Frog("Nikoleta Lozanova", 100, Gender.Female),
                new Frog("Drisko",10, Gender.Male),
                new Frog("Sashka Vaseva",17, Gender.Female)
            };

            var frogsAvarageAge = frogs.Sum(x => x.Age) / (double)frogs.Count;
            Console.WriteLine("Avarage age of the Frogs is: {0}", frogsAvarageAge);
        }
    }

}
