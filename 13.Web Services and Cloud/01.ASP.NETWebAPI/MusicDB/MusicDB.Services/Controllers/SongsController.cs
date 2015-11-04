namespace MusicDB.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using MusicDB.Models;    

    public class SongsController : ApiController
    {
        private IMusicDbData db;

        public SongsController()
            : this(new MusicDbData())
        {
        }

        public SongsController(IMusicDbData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Songs
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var song =
                this.db
                .Songs
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (song == null)
            {
                return this.NotFound();
            }

            return this.Ok(song);
        }

        public IHttpActionResult Post(SongRequestModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var songToPost = new Song()
            {
                Title = song.Title,
                Year = song.Year,
                Genre = song.Genre,
                ArtistId = song.ArtistId
            };

            this.db.Songs.Add(songToPost);
            this.db.SaveChanges();

            return this.Ok(song);
        }

        public IHttpActionResult Put(int id, SongRequestModel song)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var songToUpdate =
                this.db
                .Songs
                .All()
                .FirstOrDefault(s => s.Id == id);

            songToUpdate.Title = song.Title;
            songToUpdate.Year = song.Year;
            songToUpdate.Genre = song.Genre;
            songToUpdate.ArtistId = song.ArtistId;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var song =
                this.db
                .Songs
                .All()
                .FirstOrDefault(s => s.Id == id);

            if (song == null)
            {
                return this.NotFound();
            }

            this.db.Songs.Delete(song);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}