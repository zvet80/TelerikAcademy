using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Program
    {
        static void Main()
        {
            Point3D p1 = new Point3D(2, 3.5, 6);
            Point3D p2 = new Point3D(2.1, 4, 41);
            Point3D p3 = new Point3D(0, 8.8, -5);

            Console.WriteLine("The center of the coordinate system {0}", Point3D.O.ToString());
            Console.WriteLine("A point {0}", p3.ToString());
            Console.WriteLine("The distance between points p1 {0} and p2 {1} is: {2:F2}",
                p1.ToString(), p2.ToString(), Distance.CalculateDistance(p1, p2));

            Path path = new Path();
            path.AddPoint(p1);
            path.AddPoint(p2);
            path.AddPoint(p3);
            Console.WriteLine("A path from 3 points: {0}", path.ToString());
            Console.Write("Loaded point from file:");
            PathStorage.LoadPath(@"..\..\points.txt");
            Console.WriteLine("Points p1,p2,p3 are saved in file.");
            PathStorage.SavePath(path);
        }
    }
}
