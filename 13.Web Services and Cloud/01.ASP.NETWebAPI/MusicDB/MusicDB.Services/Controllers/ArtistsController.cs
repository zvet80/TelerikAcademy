namespace MusicDB.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using MusicDB.Models;    

    public class ArtistsController : ApiController
    {
        private IMusicDbData db;

        public ArtistsController()
            : this(new MusicDbData())
        {
        }

        public ArtistsController(IMusicDbData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Artists
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var artist =
                this.db
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (artist == null)
            {
                return this.NotFound();
            }

            return this.Ok(artist);
        }

        public IHttpActionResult Post(ArtistRequestModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var artistToPost = new Artist()
            {
                Name = artist.Name,
                DateOfBirth = artist.DateOfBirth,
                Country = artist.Country
            };

            this.db.Artists.Add(artistToPost);
            this.db.SaveChanges();

            return this.Ok(artist);
        }

        public IHttpActionResult Put(int id, ArtistRequestModel artist)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var artistToUpdate =
                this.db
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            artistToUpdate.Name = artist.Name;
            artistToUpdate.DateOfBirth = artist.DateOfBirth;
            artistToUpdate.Country = artist.Country;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var artist =
                this.db
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (artist == null)
            {
                return this.NotFound();
            }

            this.db.Artists.Delete(artist);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}