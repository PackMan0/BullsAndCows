namespace BullsAndCows.Web.Api.Models.HighScore
{
    using System;
    using AutoMapper;
    using BullsAndCows.Data.Models;
    using BullsAndCows.Web.Api.Infrastructure.Mappings;
    using Data.Models.Models;

    public class HighScoreResponseModel : IMapFrom<IUser>, IHaveCustomMappings
    {
        public string Username { get; set; }

        public int Rank { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<IUser, HighScoreResponseModel>()
                .ForMember(u => u.Username, opts => opts.MapFrom(u => u.Email));
        }
    }
}
