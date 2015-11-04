namespace StudentSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StudentRequestModel
    {
        public int StudentIdentification { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}