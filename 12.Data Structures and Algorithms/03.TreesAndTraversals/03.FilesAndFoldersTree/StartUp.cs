namespace _03.FilesAndFoldersTree
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Windows");
            Folder root = new Folder("WINDOWS");
            var folder = CreateDirectoryTree(directory, root);
            TraverseFolders(folder);
            Console.WriteLine("Sum of file sizes: " + root.GetSumOfFileSizes());
        }

        private static Folder CreateDirectoryTree(DirectoryInfo directory, Folder folder)
        {
            try
            {
                foreach (var dir in directory.GetDirectories())
                {
                    var childFolder = new Folder(dir.Name);
                    folder.ChildFolders.Add(childFolder);
                    CreateDirectoryTree(dir, childFolder);
                }

                foreach (var file in directory.GetFiles())
                {
                    folder.Files.Add(new File(file.Name, file.Length));
                }
            }
            catch (UnauthorizedAccessException)
            {
                return folder;
            }

            return folder;
        }

        private static void TraverseFolders(Folder folder)
        {
            var folders = folder.ChildFolders;
            foreach (var dir in folders)
            {
                Console.WriteLine("Folder name: " + dir.Name);
                TraverseFolders(dir);
            }

            var files = folder.Files;
            foreach (var file in files)
            {
                Console.WriteLine("      " + file);
            }
        }
    }
}
