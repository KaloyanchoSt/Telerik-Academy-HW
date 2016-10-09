using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPartTwo
{
    public class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
