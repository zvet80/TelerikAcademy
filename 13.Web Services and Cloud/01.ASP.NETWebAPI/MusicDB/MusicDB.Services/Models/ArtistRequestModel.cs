namespace MusicDB.Services.Models
{    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using MusicDB.Models;

    public class ArtistRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}