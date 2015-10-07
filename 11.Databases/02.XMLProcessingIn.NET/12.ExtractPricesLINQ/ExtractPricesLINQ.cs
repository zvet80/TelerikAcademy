namespace _12.ExtractPricesLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractPricesLINQ
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../catalogue.xml");

            var prices =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select album.Element("price").Value;

            Console.WriteLine("Album prices in the catalogue with LINQ:");

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
