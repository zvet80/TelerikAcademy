namespace _10.TraverseDirX
{
    using System.IO;
    using System.Xml.Linq;

    class TraverseDirX
    {
        static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"../../../../02.XMLProcessingIn.NET");
            XElement dirXml = new XElement("directory");
            dirXml.Add(TraverseDirectory(directory));
            dirXml.Save("../../../dirsX.xml");            
        }

        private static XElement TraverseDirectory(DirectoryInfo directory)
        {
            XElement dirElement = new XElement("dir",
                    new XAttribute("name", directory.Name));

            foreach (var dir in directory.GetDirectories())
            {
                dirElement.Add(TraverseDirectory(dir));
            }

            foreach (var file in directory.GetFiles())
            {
                dirElement.Add(new XElement("file",
                    new XAttribute("name", file.Name)));
            }

            return dirElement;
        }

    }
}

