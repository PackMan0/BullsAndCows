namespace BullsAndCows.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models.Interfaces;
    using Models.Models;

    public class BullsAndCowsDbContext : IdentityDbContext<User>, IBullsAndCowsDbContext
    {
        public BullsAndCowsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<User> Users { get; set; }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
           
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
