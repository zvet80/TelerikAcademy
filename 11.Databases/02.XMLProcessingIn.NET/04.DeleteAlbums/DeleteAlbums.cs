namespace _04.DeleteAlbums
{
    using System;
    using System.Xml;

    class DeleteAlbums
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            XmlNode catalogue = doc.DocumentElement;

            foreach (XmlNode album in catalogue.SelectNodes("album"))
            {
                int albumPrice = int.Parse(album["price"].InnerText);

                if (albumPrice > 20)
                {
                    catalogue.RemoveChild(album);
                }
            }

            doc.Save("../../../catalogueReduced.xml");
            doc.Load("../../../catalogueReduced.xml");
            XmlNode updated = doc.DocumentElement;

            foreach (XmlNode album in updated.ChildNodes)
            {
                Console.WriteLine("album: {0} price: {1} ", album["name"].InnerText, album["price"].InnerText);
            }
        }
    }
}
