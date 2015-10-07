namespace _02.ExtractAllArtistsDom
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ExtractAllArtistsDom
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");
            XmlNode root = doc.DocumentElement;

            Dictionary<string, int> artists = new Dictionary<string, int>();

            foreach (XmlNode node in root.ChildNodes)
            {
                string key = node["artist"].InnerText;
                if (artists.ContainsKey(key))
                {
                    artists[key]++;
                }
                else
                {
                    artists.Add(key, 1);
                }
            }

            foreach (var item in artists)
            {
                Console.WriteLine("artist: {0} albums: {1} ", item.Key, item.Value);
            }
        }
    }
}
