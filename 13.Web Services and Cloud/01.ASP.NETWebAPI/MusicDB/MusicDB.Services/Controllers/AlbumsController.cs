namespace MusicDB.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using MusicDB.Models;    

    public class AlbumsController : ApiController
    {
        private IMusicDbData db;

        public AlbumsController()
            : this(new MusicDbData())
        {
        }

        public AlbumsController(IMusicDbData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Albums
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var album =
                this.db
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (album == null)
            {
                return this.NotFound();
            }

            return this.Ok(album);
        }

        public IHttpActionResult Post(AlbumRequestModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var albumToPost = new Album()
            {
                Title = album.Title,
                Year = album.Year,
                Producer = album.Producer
            };

            this.db.Albums.Add(albumToPost);
            this.db.SaveChanges();

            return this.Ok(album);
        }

        public IHttpActionResult Put(int id, AlbumRequestModel album)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var albumToUpdate =
                this.db
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            albumToUpdate.Title = album.Title;
            albumToUpdate.Year = album.Year;
            albumToUpdate.Producer = album.Producer;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var album =
                this.db
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (album == null)
            {
                return this.NotFound();
            }

            this.db.Albums.Delete(album);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}