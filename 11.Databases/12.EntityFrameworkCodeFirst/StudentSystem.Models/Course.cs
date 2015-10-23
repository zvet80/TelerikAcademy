namespace StudentSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homework;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homework = new HashSet<Homework>();
        }

        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public string Materials { get; set; }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homework; }
            set { this.homework = value; }
        }

        public virtual ICollection<Student> Courses
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
