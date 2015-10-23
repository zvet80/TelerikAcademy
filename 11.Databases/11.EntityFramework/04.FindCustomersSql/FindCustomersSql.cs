namespace _04.FindCustomersSql
{
    using System;
    using System.Linq;
    using _01.CreateDbContext;

    class FindCustomersSql
    {
        static void Main()
        {
            //4.Implement previous by using native SQL query and executing it through the DbContext.
            FindCustomersByOrder("Canada", 1997);
        }

        private static void FindCustomersByOrder(string country, int year)
        {
            using (var db = new NorthwindEntities())
            {
                string sql = "SELECT distinct[ContactName] FROM Customers c, Orders o where c.[CustomerID]=o.CustomerID and o.[ShipCountry]='" + country + "' and year([ShippedDate])=" + year;

                db.Database
                  .SqlQuery<string>(sql)
                  .ToList()
                  .ForEach(c => Console.WriteLine(c));
            }
        }
    }
}
