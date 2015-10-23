namespace StudentSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<StudentsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentsDbContext";
        }

        protected override void Seed(StudentsDbContext context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

              context.Students.AddOrUpdate(
                s => s.Name,
                new Student { Name = "Andrew Peters" },
                new Student { Name = "Brice Lambson" },
                new Student { Name = "Rowan Miller" }
              );
        }
    }
}
