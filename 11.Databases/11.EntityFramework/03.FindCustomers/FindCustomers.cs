namespace _03.FindCustomers
{
    using System;
    using System.Linq;
    using _01.CreateDbContext;

    class FindCustomers
    {
        static void Main()
        {
            //3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

            FindCustomersByOrder("Canada", 1997);
        }

        private static void FindCustomersByOrder(string country, int year)
        {
            using (var db = new NorthwindEntities())
            {
                db.Orders
                    .Where(o => o.ShipCountry == country && o.ShippedDate.Value.Year == year)
                    .Select(c => c.Customer.ContactName)
                    .Distinct()
                    .ToList()
                    .ForEach(c => Console.WriteLine(c));
            }
        }
    }
}
