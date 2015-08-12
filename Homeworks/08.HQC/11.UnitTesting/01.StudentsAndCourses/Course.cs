namespace _01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudents = 30;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.NameValidator(value);
                this.name = value;
            }
        }

        public List<Student> Students { get; set; }

        public void JoinCourse(Student student)
        {
            Validator.ObjectNotNullValidator(student, "Student");

            if (this.Students.Count > MaxStudents)
            {
                throw new InvalidOperationException("Course is full");
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException(string.Join("Student {0} has already joined {1} course", student.StudentId, this.Name));
            }

            this.Students.Add(student);
        }

        public void LeaveCourse(Student student)
        {
            Validator.ObjectNotNullValidator(student, "Student");

            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException(string.Join("Student {0} has not joined {1} course", student.StudentId, this.Name));
            }

            this.Students.Remove(student);
        }
    }
}
