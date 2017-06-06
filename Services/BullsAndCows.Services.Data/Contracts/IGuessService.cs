namespace BullsAndCows.Services.Data.Contracts
{
    using System.Linq;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Data.Models.Interfaces;
    using BullsAndCows.Data.Models.Models;

    public interface IGuessService
    {
        IGuess MakeGuess(int gameId, string number, string userId);

        IQueryable<IGuess> GetGuessDetails(int id);
    }
}
