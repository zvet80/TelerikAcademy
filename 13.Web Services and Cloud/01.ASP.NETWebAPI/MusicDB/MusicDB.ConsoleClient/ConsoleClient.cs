namespace MusicDB.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using Data;
    using Data.Migrations;
    using Models;

    public class ConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MusicDbContext, Configuration>());

            var db = new MusicDbContext();
            var artist = new Artist()
            {
                Name = "Someone",
                Country = "UK",
                DateOfBirth = new DateTime(1977, 05, 06)
            };

            db.Artists.Add(artist);

            db.SaveChanges();
        }
    }
}
