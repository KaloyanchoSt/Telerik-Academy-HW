namespace MakeHuman
{
    public class Human
    {
        private string name;
        private int age;
        private GenderType gendetType;

        public Human()
        {
        }

        public GenderType GenderType
        {
            get
            {
                return this.gendetType;
            }

            set
            {
                this.gendetType = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
    }
}
