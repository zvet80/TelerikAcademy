namespace _06.ExtractSongsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractSongsLINQ
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../catalogue.xml");
            var titles =
                from song in xmlDoc.Descendants("song")
                select song.Element("title").Value;

            Console.WriteLine("Song titles in the catalogue with LINQ:");
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
