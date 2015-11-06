﻿namespace _03.FilesAndFoldersTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public long GetSumOfFileSizes()
        {
            return this.Files.Sum(f => f.Size) + this.ChildFolders.Sum(f => f.GetSumOfFileSizes());
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
