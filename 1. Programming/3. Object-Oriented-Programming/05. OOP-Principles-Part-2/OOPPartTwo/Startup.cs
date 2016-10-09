using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPartTwo
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle(4, 5),
                new Square (2, 2),
                new Triangle(1,2),
                new Rectangle(4,5),
                new Triangle (3,1)
             };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
           
        }
    }
}
