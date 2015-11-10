namespace _02.OrderedBagSubRange
{
    /*2.Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b].
        Test for 500 000 products and 10 000 price searches.
        Hint: you may use OrderedBag<T> and sub-ranges.*/

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
