namespace MusicDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        public Artist()
        {
            this.Albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
