// Problem 4. Path
// Create a static class PathStorage with static methods to save and load paths from a text file.
// Use a file format of your choice.

namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class PathStorage
    {
        public static void LoadPath(string pathDir)
        {
            StreamReader reader = new StreamReader(pathDir);
            Path paths = new Path();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] arr = line
                                   .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(double.Parse)
                                   .ToArray();
                    Point3D point = new Point3D(arr[0], arr[1], arr[2]);
                    paths.AddPoint(point);
                    line = reader.ReadLine();
                }

                Console.WriteLine(paths.ToString());
            }
        }

        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter(@"..\..\ouput.txt");
            using (writer)
            {
                writer.WriteLine(path.ToString());
            }
        }
    }
}
