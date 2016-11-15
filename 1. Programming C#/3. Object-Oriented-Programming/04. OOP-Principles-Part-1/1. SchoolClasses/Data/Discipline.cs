namespace SchoolClasses.Data
{
    using System;

    public class Discipline : IComment
    {
        private DisciplineName name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(DisciplineName name, int numOfLectures, int numOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercices = numOfExercises;
        }

        public DisciplineName Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of lectures cannot be nagative number!");
                }
                    
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercices
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises cannot be negative number!");
                }                   

                this.numberOfExercises = value;
            }
        }

        public void Comment()
        {

        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
