namespace _06.CreateNorthwindTwin
{
    using System;
    using _01.CreateDbContext;

    class Program
    {
        static void Main()
        {
            //changed App.config to initial catalog=NorthwindTwin

            using (var db = new NorthwindEntities())
            {
                var result = db.Database.CreateIfNotExists();
                Console.WriteLine(result);
            }
        }
    }
}
