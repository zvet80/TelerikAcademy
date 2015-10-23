namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        public int HomeworkId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Content { get; set; }

        [Required]
        public DateTime TimeSent { get; set; }
        
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
