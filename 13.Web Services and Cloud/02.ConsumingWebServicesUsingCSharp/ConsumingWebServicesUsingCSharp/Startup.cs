namespace ConsumingWebServicesUsingCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json;

    public class Startup
    {
        public static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(@"http://jsonplaceholder.typicode.com");

            Console.WriteLine("Enter count of items: ");
            int itemsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter query string: ");
            string queryString = Console.ReadLine();
            //int itemsCount = 5;
            //string queryString = "quas";

            PrintComments(httpClient, itemsCount, queryString);

            Console.WriteLine("Wait...");
            Console.ReadLine();
        }

        static async void PrintComments(HttpClient httpClient, int count, string query)
        {
            var response = await httpClient.GetAsync("comments");

            var info = response.Content.ReadAsStringAsync().Result;
            var comments = JsonConvert.DeserializeObject<List<Comment>>(info);

            var result = comments
                .Where(c => c.Body.Contains(query))
                .Take(count)
                .ToList();

            if (result.Count != 0)
            {
                result.ForEach(c => Console.WriteLine(c));
            }
            else
            {
                Console.WriteLine("No comment matches your string query");
            }
        }
    }
}
