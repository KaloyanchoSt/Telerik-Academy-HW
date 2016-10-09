namespace SchoolClasses.People
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using Data;

    public class Teacher : Human
    {
        private List<Discipline> disciplinesList;

        public Teacher(string firstName, string lastName, List<Discipline> disciplinesList) : base(firstName, lastName)
        {
            this.DisciplinesList = new List<Discipline>();
        }

        public List<Discipline> DisciplinesList
        {
            get
            {
                return this.disciplinesList;
            }

            private set
            {
                this.disciplinesList = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.DisciplinesList.Add(discipline);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + "; Teaches: " + String.Join(", ", this.DisciplinesList.ToList());
        }

        public override void Comment()
        {
            Console.WriteLine("I'm teaching");
        }
    }
}
