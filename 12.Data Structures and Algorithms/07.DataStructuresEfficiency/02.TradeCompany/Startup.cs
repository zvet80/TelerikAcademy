namespace _02.TradeCompany
{
    /*2.A large trade company has millions of articles, each described by barcode, vendor, title and price.
        Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
        Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET.*/

    using System;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);
            CreateArticles(articles, 100000);
            GetArticlesInPriceRange(articles, 50, 150);
        }

        public static void GetArticlesInPriceRange(OrderedMultiDictionary<double, Article> articles, double min, double max)
        {
            articles
                .Range(min, true, max, true)               
                .ForEach(x =>
                {
                    foreach (var item in x.Value)
                    {
                        Console.WriteLine(item);
                    }
                });
        }

        public static void CreateArticles(OrderedMultiDictionary<double, Article> articles, int count)
        {
            var generator = new RandomGenerator();
            var barcodes = generator.GetRandomBarcodes(count);

            foreach (var barcode in barcodes)
            {
                string title = generator.GetRandomString(10);
                string vendor = generator.GetRandomString(5);
                double price = generator.GetRandomPrice(0.01, 1000);
                var article = new Article(barcode, title, vendor, price);
                articles.Add(price, article);
            }
        }
    }
}
