namespace _09.TraverseDirXmlWriter
{
    using System.IO;
    using System.Text;
    using System.Xml;

    class TraverseDirXmlWriter
    {
        static void Main()
        {
            DirectoryInfo directory = new DirectoryInfo(@"../../../../02.XMLProcessingIn.NET");

            using (XmlTextWriter writer = new XmlTextWriter("../../../dirs.xml", Encoding.Unicode))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directory");
                TraverseDirectory(writer, directory);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDirectory(XmlWriter writer, DirectoryInfo directory)
        {
            foreach (var dir in directory.GetDirectories())
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", dir.Name);
                TraverseDirectory(writer, dir);
                writer.WriteEndElement();
            }

            foreach (var file in directory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }
        }
    }
}
