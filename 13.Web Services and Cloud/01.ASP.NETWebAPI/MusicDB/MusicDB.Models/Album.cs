namespace MusicDB.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
            this.Artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
