namespace StudentSystem.Data
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public interface IStudentsSystemData
    {
        IGenericRepository<Course> Courses { get; }

        StudentsRepository Students { get; }

        IGenericRepository<Homework> Homeworks { get; }

        IGenericRepository<Test> Tests { get; }

        void SaveChanges();
    }
}
