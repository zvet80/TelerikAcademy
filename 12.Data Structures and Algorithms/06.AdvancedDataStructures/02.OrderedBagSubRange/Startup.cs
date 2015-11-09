namespace _02.OrderedBagSubRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var products = new OrderedBag<Product>();
            var rand = new Random();
            CreateBagOfProducts(products, 500000);

            for (int i = 0; i < 10000; i++)
            {
                var initialPrice = rand.Next(0, 10000);
                var range = GetProductsInRange(products, initialPrice, initialPrice + 100, 20);
                foreach (var prod in range)
                {
                    Console.WriteLine("{0}-> price: {1} in [{2}:{3}]", prod.Name, prod.Price, initialPrice, initialPrice + 100);
                }
            }
        }

        public static OrderedBag<Product> CreateBagOfProducts(OrderedBag<Product> bag, int count)
        {
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                var product = new Product
                {
                    Name = "Product" + (i + 1),
                    Price = rand.Next(i + 1, i + 1000)
                };

                bag.Add(product);
            }

            return bag;
        }

        public static IEnumerable<Product> GetProductsInRange(OrderedBag<Product> bag, int minPrice, int maxPrice, int count)
        {
            var result = bag
                         .Range(new Product("min", minPrice), true, new Product("max", maxPrice), true)
                         .Take(count);

            return result;
        }
    }
}
