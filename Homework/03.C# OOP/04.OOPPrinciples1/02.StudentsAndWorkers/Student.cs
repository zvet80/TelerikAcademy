﻿
namespace _02.StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between [2, 6]");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, grade: {2}",
                this.FirstName, this.LastName, this.Grade);
        }
    }
}
