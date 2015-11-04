namespace MusicDB.Data
{
    using System.Data.Entity;
    using Models;    

    public class MusicDbContext : DbContext
    {
        public MusicDbContext()
            : base("MusicDb")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }

        public virtual DbSet<Artist> Artists { get; set; }

        public virtual DbSet<Song> Songs { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
