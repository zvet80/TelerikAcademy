namespace StudentSystem.Data
{    
    using System;
    using System.Linq;
    using Models;

    public class DataGenerator
    {
        private RandomGenerator random = new RandomGenerator();

        public void GenerateStudents(StudentsDbContext data, int count)
        {            
            for (int i = 0; i < count; i++)
            {
                var student = new Student
                {
                    Name = random.GetRandomString(random.GetRandomNumber(5, 50)),
                    Number = random.GetRandomNumber(10, 1000)
                };

                data.Students.Add(student);
            }
        }

        public void GenerateCourses(StudentsDbContext data, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var course = new Course
                {
                    Name = random.GetRandomString(random.GetRandomNumber(5, 50)),
                    Description = random.GetRandomString(random.GetRandomNumber(5, 50))
                };

                data.Courses.Add(course);
            }
        }

        public void GenerateHomeworks(StudentsDbContext data, int count)
        {
            var studentsIds = data.Students.Select(s => s.StudentId).ToList();
            var coursesIds = data.Courses.Select(c => c.CourseId).ToList();

            for (int i = 0; i < count; i++)
            {
                var homework = new Homework
                {
                    Content = random.GetRandomString(random.GetRandomNumber(5, 50)),
                    TimeSent = DateTime.Now.AddDays(-random.GetRandomNumber(60, 360)),
                    StudentId = studentsIds[random.GetRandomNumber(0, studentsIds.Count - 1)],
                    CourseId = coursesIds[random.GetRandomNumber(0, coursesIds.Count - 1)]
                };

                data.Homework.Add(homework);
            }
        }
    }
}
