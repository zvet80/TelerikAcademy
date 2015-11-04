namespace MusicDB.Data
{
    using Models;
    using Repositories;

    public interface IMusicDbData
    {
        IRepository<Artist> Artists { get; }

        IRepository<Album> Albums { get; }

        IRepository<Song> Songs { get; }

        void SaveChanges();
    }
}
