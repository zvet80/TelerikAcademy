namespace StudentSystem.Data
{
    using System.Data.Entity;
    using Models;

    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext()
            :base("StudentsDb")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Homework> Homework { get; set; }
    }
}
