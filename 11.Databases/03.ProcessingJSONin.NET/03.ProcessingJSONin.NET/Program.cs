namespace _03.ProcessingJSONin.NET
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            string path = "../../feed.xml";
            string rss = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            WebClient xmlFile = new WebClient();
            xmlFile.DownloadFile(rss, path);

            XDocument document = XDocument.Load(path);
            string jsonFromXml = JsonConvert.SerializeXNode(document, Formatting.Indented);

            var jsonObj = JObject.Parse(jsonFromXml);
            var videoTitles = jsonObj["feed"]["entry"]
                              .Select(t => t["title"]);

            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
