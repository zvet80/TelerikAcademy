namespace StudentSystem.Services.Models
{
    using System;

    public class HomeworkRequestModel
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }        
    }
}