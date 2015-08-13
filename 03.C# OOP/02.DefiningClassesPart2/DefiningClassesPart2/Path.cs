// Problem 4. Path
// Create a class Path to hold a sequence of points in the 3D space.

namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> paths = new List<Point3D>();
                
        public Path()
        {
            this.Paths = new List<Point3D>();
        }

        public List<Point3D> Paths
        {
            get { return this.paths; }
            set { this.paths = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.paths.Add(point);
        }

        public override string ToString()
        {
            return string.Join(",", this.Paths);
        }
    }
}
