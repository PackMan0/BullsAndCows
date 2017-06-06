namespace BullsAndCows.Services.Data.Contracts
{
    using System.Linq;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Data.Models.Interfaces;
    using BullsAndCows.Data.Models.Models;

    public interface IHighScoreService
    {
        void UpdateRank(string userId, bool won);

        IQueryable<User> GetLatest();
    }
}
