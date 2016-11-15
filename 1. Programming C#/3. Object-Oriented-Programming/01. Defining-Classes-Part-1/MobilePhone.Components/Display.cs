using System.Text;

namespace MobilePhone.Components
{
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, int numberOfColors) : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("GSM Display Size: {0} inches, Colors: {1}", this.Size, this.NumberOfColors));

            return result.ToString(); 
        }
    }
}
