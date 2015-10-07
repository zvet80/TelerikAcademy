namespace _11.ExtractPrices
{
    using System;
    using System.Xml;

    class ExtractPrices
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            XmlNode root = doc.DocumentElement;

            string xPathQuery = "/catalogue/album[year<2010]";
            var albums = root.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
            {
                string price = album.SelectSingleNode("price").InnerText;
                string albumName = album.SelectSingleNode("name").InnerText;
                Console.WriteLine("album: {0} price: {1} ", albumName, price);
            }

        }
    }
}
