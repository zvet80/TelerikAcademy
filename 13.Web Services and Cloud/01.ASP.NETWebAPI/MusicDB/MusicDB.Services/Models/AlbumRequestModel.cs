namespace MusicDB.Services.Models
{    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using MusicDB.Models;

    public class AlbumRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}