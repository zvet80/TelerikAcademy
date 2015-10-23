namespace _02.CustomersFunctionalities
{
    using System;
    using System.Linq;
    using _01.CreateDbContext;

    public class CustomersOperations
    {
        public static void InsertCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                if (customer==null)
                {
                    throw new ArgumentNullException("Customer cannot be null");
                }
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            Console.WriteLine("Customer added");
        }

        public static void ModifyCustomer(string customerId, string name)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            customer.ContactName = name;
            northwindEntities.SaveChanges();
            Console.WriteLine("Customer modified");
        }

        public static void DeleteCustomer(string customerId)
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();
            Customer customer = GetCustomerById(northwindEntities, customerId);
            northwindEntities.Customers.Remove(customer);
            northwindEntities.SaveChanges();
            Console.WriteLine("Customer deleted");
        }

        public static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(
                c => c.CustomerID == customerId);
            return customer;
        }
    }
}
