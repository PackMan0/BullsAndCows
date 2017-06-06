namespace BullsAndCows.Services.Data.Contracts
{
    using BullsAndCows.Data.Models;
    using System.Linq;
    using BullsAndCows.Data.Models.Interfaces;
    using BullsAndCows.Data.Models.Models;

    public interface IGamesService
    {
        IQueryable<IGame> GetPublicGames(int page = 0, string userId = null);

        IGame CreateGame(string name, string number, string userId);

        IQueryable<IGame> GetGameDetails(int id);

        bool GameCanBeJoinedByUser(int id, string userId);

        string JoinGame(int id, string number, string userId);

        bool CanMakeGuess(int id, string userId);

        bool UserIsPartOfGame(int id, string userId);

        void ChangeGameState(int id, bool finished);
    }
}
