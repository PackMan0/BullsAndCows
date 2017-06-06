namespace BullsAndCows.Data
{
    using Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models.Interfaces;
    using Models.Models;

    public interface IBullsAndCowsDbContext
    {
        IDbSet<IUser> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}
