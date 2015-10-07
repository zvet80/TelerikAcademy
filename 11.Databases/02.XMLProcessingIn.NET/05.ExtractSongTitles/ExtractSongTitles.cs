namespace _05.ExtractSongTitles
{
    using System;
    using System.Xml;

    class ExtractSongTitles
    {
        static void Main()
        {
            Console.WriteLine("Song titles in the catalogue:");
            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
