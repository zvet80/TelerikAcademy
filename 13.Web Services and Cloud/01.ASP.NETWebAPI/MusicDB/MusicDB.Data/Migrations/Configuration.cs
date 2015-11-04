namespace MusicDB.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<MusicDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "MusicDB.Data.MusicDbContext";
        }

        protected override void Seed(MusicDbContext context)
        {
            /*  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.*/

            context.Artists.AddOrUpdate(
              a => a.Name,
              new Artist { Name = "Andrew Peters" },
              new Artist { Name = "Brice Lambson" },
              new Artist { Name = "Rowan Miller" });
        }
    }
}
