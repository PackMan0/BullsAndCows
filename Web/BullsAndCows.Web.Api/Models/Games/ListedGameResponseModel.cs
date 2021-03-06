﻿namespace BullsAndCows.Web.Api.Models.Games
{
    using System;
    using AutoMapper;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Web.Api.Infrastructure.Mappings;
    using Data.Models.Interfaces;
    using Data.Models.Models;

    public class ListedGameResponseModel : IMapFrom<IGame>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Blue { get; set; }

        public string Red { get; set; }

        public string GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<IGame, ListedGameResponseModel>()
                .ForMember(g => g.Blue, opts => opts.MapFrom(g => g.BlueUser == null ? "No blue player yet" : g.BlueUser.Email))
                .ForMember(g => g.Red, opts => opts.MapFrom(g => g.RedUser.Email))
                .ForMember(g => g.GameState, opts => opts.MapFrom(g => g.GameState.ToString()));
        }
    }
}
