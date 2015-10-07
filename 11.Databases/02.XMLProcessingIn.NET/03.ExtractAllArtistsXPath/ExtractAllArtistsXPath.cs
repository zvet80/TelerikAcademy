namespace _03.ExtractAllArtistsXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ExtractAllArtistsXPath
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            XmlNode root = doc.DocumentElement;

            string xPathQuery = "/catalogue/album";
            var artists = root.SelectNodes(xPathQuery);

            Dictionary<string, int> artistsAlbums = new Dictionary<string, int>();

            foreach (XmlNode node in artists)
            {
                string key = node.SelectSingleNode("artist").InnerText;

                if (artistsAlbums.ContainsKey(key))
                {
                    artistsAlbums[key]++;
                }
                else
                {
                    artistsAlbums.Add(key, 1);
                }
            }

            foreach (var item in artistsAlbums)
            {
                Console.WriteLine("artist: {0} albums: {1} ", item.Key, item.Value);
            }
        }
    }
}
