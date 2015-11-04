namespace MusicDB.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    
    public class SongRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public int ArtistId { get; set; }
    }
}