namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Course
    {
        private string courseName;
        private string teacherName;
        private ICollection<string> students;

        public Course(string courseName, string teacherName, ICollection<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Teacher name cannot be null or empty");
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                //Students.Add(string) allows empty values
                foreach (string student in this.students)
                {
                    if (string.IsNullOrEmpty(student))
                    {
                        throw new ArgumentException("Student cannot be null or empty");
                    }
                }  

                return this.students;
            }

            set
            {
                if (value != null)
                {
                    foreach (string student in value)
                    {
                        if (string.IsNullOrEmpty(student))
                        {
                            throw new ArgumentException("Student cannot be null or empty");
                        }
                    }                   
                }
                                
                this.students = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Course Name = " + this.CourseName);
            result.AppendLine("Teacher = " + this.TeacherName);
            result.AppendLine("Students = " + this.GetStudentsAsString());

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}
