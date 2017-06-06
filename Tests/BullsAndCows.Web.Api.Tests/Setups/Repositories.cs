namespace BullsAndCows.Web.Api.Tests.Setups
{
    using Data.Models;
    using BullsAndCows.Data.Repositories;
    using Moq;
    using System.Collections.Generic;
    using System.Linq;
    using Data.Models.Enums;
    using Data.Models.Models;

    public static class Repositories
    {
        public static IRepository<IGame> GetGamesRepository()
        {
            var repository = new Mock<IRepository<IGame>>();

            repository.Setup(r => r.All()).Returns(() =>
            {
                return new List<IGame>
                {
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "B", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "C", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" }},
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.WaitingForOpponent, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                    new IGame { GameState = GameState.Finished, Name = "A", RedUser = new IUser { Email = "Red" }, BlueUser = new IUser { UserName = "Blue" } },
                }.AsQueryable();
            });

            return repository.Object;
        }

        public static IRepository<IUser> GetUsersRepository()
        {
            var repository = new Mock<IRepository<IUser>>();

            repository.Setup(r => r.All()).Returns(() =>
            {
                return new List<IUser>
                {
                    new IUser { Email = "TestUser 1", Rank = 100 },
                    new IUser { Email = "TestUser 2", Rank = 50 },
                    new IUser { Email = "TestUser 4", Rank = 4500 },
                    new IUser { Email = "TestUser 3", Rank = 200 },
                    new IUser { Email = "TestUser 1", Rank = 100 },
                    new IUser { Email = "TestUser 2", Rank = 80 },
                    new IUser { Email = "TestUser 4", Rank = 3510 },
                    new IUser { Email = "TestUser 3", Rank = 200 },
                    new IUser { Email = "TestUser 1", Rank = 13450 },
                    new IUser { Email = "TestUser 2", Rank = 50 },
                    new IUser { Email = "TestUser 4", Rank = 3500 },
                    new IUser { Email = "TestUser 3", Rank = 500 },
                }.AsQueryable();
            });

            return repository.Object;
        }
    }
}
