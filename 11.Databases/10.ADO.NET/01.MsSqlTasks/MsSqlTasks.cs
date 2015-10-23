namespace _01.MsSqlTasks
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class MsSqlTasks
    {
        private SqlConnection dbConnection;

        static void Main()
        {
            MsSqlTasks example = new MsSqlTasks();
            example.ConnectToDB("Northwind");

            using (example.dbConnection)
            {
                example.GetRowsCount("Categories"); //Task 1
                example.GetAllCategories(); //Task 2
                example.GetAllProducts(); //Task 3
                example.AddNewProduct("pancakes", 1, 3, "3 pancakes", 3.6M, 60, 3, 0, 0); //Task 4
                example.GetProductsByString("cha"); //Task 8
            }
        }


        //1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.

        private void GetRowsCount(string table)
        {
            SqlCommand cmdCount = new SqlCommand(
                "SELECT COUNT(*) FROM " + table, dbConnection);
            int categoriesCount = (int)cmdCount.ExecuteScalar();
            Console.WriteLine("Task 1.Number of rows in the Categories table: {0} ", categoriesCount);

        }

        //2.Write a program that retrieves the name and description of all categories in the Northwind DB.

        private void GetAllCategories()
        {
            Console.WriteLine("Task 2.All categories are:");

            SqlCommand cmdAllCategories = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConnection);
            SqlDataReader reader = cmdAllCategories.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0}: {1}", categoryName, description);
                }
            }
        }

        //3.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.Can you do this with a single SQL query(with table join)?

        private void GetAllProducts()
        {
            Console.WriteLine("Task 3.All products are:");

            SqlCommand cmdAllCategories = new SqlCommand("SELECT ProductName,CategoryName FROM Products p, Categories c where p.CategoryID = c.CategoryID order by CategoryName", dbConnection);
            SqlDataReader reader = cmdAllCategories.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string products = (string)reader["ProductName"];
                    string categories = (string)reader["CategoryName"];
                    Console.WriteLine("{0}: {1}", products, categories);
                }
            }
        }

        //4.Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.
        private void AddNewProduct(
            string productName,
            int supplierID,
            int categoryID,
            string quantityPerUnit,
            decimal unitPrice,
            int unitsInStock,
            int unitsOnOrder,
            int reorderLevel,
            byte discontinued
            )
        {
            SqlCommand cmdInsertProduct = new SqlCommand(
                "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                "VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", dbConnection);
            cmdInsertProduct.Parameters.AddWithValue("@productName", productName);
            cmdInsertProduct.Parameters.AddWithValue("@supplierID", supplierID);
            cmdInsertProduct.Parameters.AddWithValue("@categoryID", categoryID);
            cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmdInsertProduct.Parameters.AddWithValue("@unitPrice", unitPrice);
            cmdInsertProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            cmdInsertProduct.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            cmdInsertProduct.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmdInsertProduct.Parameters.AddWithValue("@discontinued", discontinued);
            cmdInsertProduct.ExecuteNonQuery();
            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbConnection);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
            Console.WriteLine("Task 4. Product added! ProductId: {0}", insertedRecordId);
        }



        //8.Write a program that reads a string from the console and finds all products that contain this string.Ensure you handle correctly characters like ', %, ", \ and _.
        private void GetProductsByString(string input)
        {
            Console.WriteLine("Task 8.All products, containing the string are:");

            SqlCommand cmdAllProducts = new SqlCommand("SELECT ProductName FROM Products where ProductName like \'%" + input + "%\'", dbConnection);
            SqlDataReader reader = cmdAllProducts.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string product = (string)reader["ProductName"];
                    Console.WriteLine(product);
                }
            }
        }

        private void ConnectToDB(string db)
        {
            dbConnection = new SqlConnection("Server=.; " +
            "Database=" + db + "; Integrated Security=true");
            dbConnection.Open();
        }
    }
}
