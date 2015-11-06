namespace _03.FilesAndFoldersTree
{
    public class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }

        public long Size { get; set; }

        public override string ToString()
        {
            return string.Format("file name: {0}; size: {1}", this.Name, this.Size);
        }
    }
}
