namespace BullsAndCows.Data.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Common.Constants;
    using Enums;
    using Interfaces;

    public class Game : IGame
    {
        private ICollection<IGuess> guesses;

        public Game()
        {
            guesses = new HashSet<IGuess>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GameConstants.GameNameMaxLength)]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        [Index]
        public GameState GameState { get; set; }

        public GameResultType GameResult { get; set; }

        public string RedUserNumber { get; set; }

        public string BlueUserNumber { get; set; }

        public string RedUserId { get; set; }

        public virtual User RedUser { get; set; }

        public string BlueUserId { get; set; }

        public virtual User BlueUser { get; set; }

        public virtual ICollection<IGuess> Guesses
        {
            get { return guesses; }
            set { guesses = value; }
        }
    }
}