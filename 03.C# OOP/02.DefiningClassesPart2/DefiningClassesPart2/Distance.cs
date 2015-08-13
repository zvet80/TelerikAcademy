// Problem 3. Static class
// Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace DefiningClassesPart2
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            double d = Math.Sqrt(Math.Pow(a.X - b.X, 2) +
                       Math.Pow(a.Y - b.Y, 2) +
                       Math.Pow(a.Z - b.Z, 2));
            return d;
        }
    }
}
