namespace BullsAndCows.Data.Models.Interfaces
{
    using System;
    using Models;

    public interface IGuess
    {
        int BullsCount { get; set; }
        int CowsCount { get; set; }
        DateTime DateMade { get; set; }
        IGame IGame { get; set; }
        int GameId { get; set; }
        int Id { get; set; }
        string Number { get; set; }
        User User { get; set; }
        string UserId { get; set; }
    }
}