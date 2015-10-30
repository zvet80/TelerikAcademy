namespace _01.StudentsAndCourses
{
    using System;

    public class Student
    {
        private const int MinId = 10000;
        private const int MaxId = 99999;
        private string name;
        private int studentId;

        public Student(string name, int id)
        {
            this.Name = name;
            this.StudentId = id;
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

        public int StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                Validator.IdRangeValidator(value, MinId, MaxId);
                this.studentId = value;
            }
        }
    }
}
