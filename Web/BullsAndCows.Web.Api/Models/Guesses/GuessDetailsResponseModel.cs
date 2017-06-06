﻿namespace BullsAndCows.Web.Api.Models.Guesses
{
    using System;
    using AutoMapper;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Web.Api.Infrastructure.Mappings;
    using Data.Models.Models;

    public class GuessDetailsResponseModel : IMapFrom<IGuess>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Username { get; set; }

        public int GameId { get; set; }

        public string Number { get; set; }

        public DateTime DateMade { get; set; }

        public int CowsCount { get; set; }

        public int BullsCount { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<IGuess, GuessDetailsResponseModel>()
                .ForMember(g => g.Username, opts => opts.MapFrom(g => g.IUser.Email));
        }
    }
}
