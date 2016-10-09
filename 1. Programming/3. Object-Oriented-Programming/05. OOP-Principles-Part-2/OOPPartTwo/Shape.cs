using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPartTwo
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get { return this.width; } private set { this.width = value; } }
        public double Height { get { return this.height; } private set { this.height = value; } }

        public abstract double CalculateSurface();
    }
}
