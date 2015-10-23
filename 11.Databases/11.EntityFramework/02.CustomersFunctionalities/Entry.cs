namespace _02.CustomersFunctionalities
{
    using _01.CreateDbContext;

    public class Entry
    {
        static void Main()
        {
            //2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.

            Customer pesho = new Customer()
            {
                CustomerID = "test",
                ContactName = "Pesho",
                Country = "BG",
                CompanyName = "Pesho OOD"
            };

            CustomersOperations.InsertCustomer(pesho);
            CustomersOperations.ModifyCustomer("test", "Gosho");
            CustomersOperations.DeleteCustomer("test");
        }
    }
}
