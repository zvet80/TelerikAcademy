namespace _01.StudentSystem
{
    using global::StudentSystem.Data;
    using System.Data.Entity;
    using global::StudentSystem.Data.Migrations;

    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentsDbContext, Configuration>());

            var db = new StudentsDbContext();
            var generator = new DataGenerator();

            generator.GenerateCourses(db, 20);
            generator.GenerateStudents(db, 100);
            db.SaveChanges();
            generator.GenerateHomeworks(db, 250);
            db.SaveChanges();
        }
    }
}
