namespace _02.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\WINDOWS");
            var files = TraverseDirectory(directory);
            Console.WriteLine("*.exe files are: " + string.Join(",", files));
        }

        private static List<string> TraverseDirectory(DirectoryInfo directory)
        {
            List<string> files = new List<string>();

            try
            {
                foreach (var dir in directory.GetDirectories())
                {
                    files.AddRange(TraverseDirectory(dir));
                }

                foreach (var file in directory.GetFiles("*.exe"))
                {
                    files.Add(file.Name);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return files;
            }

            return files;
        }
    }
}
