namespace _01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
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

        public List<Course> Courses { get; set; }

        public void JoinSchool(Student student)
        {
            Validator.ObjectNotNullValidator(student, "Student");

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException(string.Join("Student {0} has already been enrolled", student.StudentId, this.Name));
            }

            this.Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            Validator.ObjectNotNullValidator(course, "Course");

            if (this.Courses.Contains(course))
            {
                throw new InvalidOperationException("Course has already been added");
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Validator.ObjectNotNullValidator(course, "Course");

            if (!this.Courses.Contains(course))
            {
                throw new InvalidOperationException("Course has not been added");
            }

            this.Courses.Remove(course);
        }
    }
}
