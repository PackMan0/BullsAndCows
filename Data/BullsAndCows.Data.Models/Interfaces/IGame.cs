namespace BullsAndCows.Data.Models.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Models;

    public interface IGame
    {
        User BlueUser { get; set; }
        string BlueUserId { get; set; }
        string BlueUserNumber { get; set; }
        DateTime DateCreated { get; set; }
        GameResultType GameResult { get; set; }
        GameState GameState { get; set; }
        ICollection<IGuess> Guesses { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        User RedUser { get; set; }
        string RedUserId { get; set; }
        string RedUserNumber { get; set; }
    }
}