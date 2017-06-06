namespace BullsAndCows.Services.Data
{
    using System.Linq;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Data.Models.Interfaces;
    using BullsAndCows.Data.Models.Models;
    using BullsAndCows.Services.Data.Contracts;
    using BullsAndCows.Data.Repositories;
    using Common.Constants;

    public class HighScoreService : IHighScoreService
    {
        private readonly IRepository<IUser> users;

        public HighScoreService(IRepository<IUser> users)
        {
            this.users = users;
        }

        public void UpdateRank(string userId, bool won)
        {
            var user = this.users.GetById(userId);

            if (won)
            {
                user.Rank += GameConstants.ScorePerWin;
            }
            else
            {
                user.Rank += GameConstants.ScorePerLose;
            }

            this.users.SaveChanges();
        }

        public IQueryable<IUser> GetLatest()
        {
            return this.users
                .All()
                .OrderByDescending(u => u.Rank)
                .Take(GameConstants.HighScoreUsersCount);
        }
    }
}
