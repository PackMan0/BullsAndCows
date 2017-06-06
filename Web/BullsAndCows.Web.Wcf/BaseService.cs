namespace BullsAndCows.Web.Wcf
{
    using Data.Models;
    using BullsAndCows.Data.Repositories;
    using Data;
    using Data.Models.Interfaces;
    using Data.Models.Models;

    public abstract class BaseService
    {
        protected BaseService()
        {
            var db = new BullsAndCowsDbContext();
            this.Users = new GenericRepository<IUser>(db);
        }

        protected IRepository<IUser> Users { get; private set; }
    }
}
