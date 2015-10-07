namespace _08.CreateAlbumsDataXml
{
    using System;
    using System.Xml;
    using System.Xml.Linq;

    class CreateAlbumsDataXml
    {
        static void Main()
        {
            XElement albums = new XElement("albums");

            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "name")
                    {
                        string name = reader.ReadElementContentAsString();
                        reader.ReadToFollowing("artist");
                        string artist = reader.ReadElementContentAsString();

                        XElement album = new XElement("album",
                            new XElement("name", name),
                                new XElement("author", artist)
                            );
                        albums.Add(album);
                    }
                }
            }
            Console.WriteLine(albums);

            albums.Save("../../../albums.xml");
        }
    }
}
