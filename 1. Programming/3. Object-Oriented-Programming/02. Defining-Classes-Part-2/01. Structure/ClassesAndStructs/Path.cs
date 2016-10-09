namespace DefiningClassesPart2.ClassesAndStructs
{
    using System.Collections.Generic;

    public class Path
    {
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points { get; set; }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.Points.Remove(point);
        }
    }
}
