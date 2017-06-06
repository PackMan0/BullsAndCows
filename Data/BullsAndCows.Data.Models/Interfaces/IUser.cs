namespace BullsAndCows.Data.Models.Interfaces
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Models;

    public interface IUser
    {
        ICollection<IGuess> Guesses { get; set; }
        int Rank { get; set; }

        Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType);
    }
}