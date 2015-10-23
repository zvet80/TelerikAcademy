namespace _05.FindSales
{
    using System;
    using System.Linq;
    using _01.CreateDbContext;

    public class FindSales
    {
        static void Main()
        {
            //5.Write a method that finds all the sales by specified region and period (start / end dates).
            FindOrdersByDateAndRegion("RJ", new DateTime(1996, 07, 01), new DateTime(1996, 07, 31));
        }

        private static void FindOrdersByDateAndRegion(string region, DateTime start, DateTime end)
        {
            using (var db = new NorthwindEntities())
            {
                db.Orders
                    .Where(o => o.ShipRegion == region && o.ShippedDate > start && o.ShippedDate < end)
                    .OrderBy(o => o.ShippedDate)
                    .ToList()
                    .ForEach(o => Console.WriteLine("Order {0} shipped to {1} on {2}", o.OrderID, o.ShipAddress, o.ShippedDate));
            }
        }
    }
}
