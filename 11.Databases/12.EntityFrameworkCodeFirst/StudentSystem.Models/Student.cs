namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homework;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homework = new HashSet<Homework>();
        }

        public int StudentId { get; set; }

        [Required]
        [MaxLength (50)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homework; }
            set { this.homework = value; }
        }
    }
}
