namespace BullsAndCows.Data.Models.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Interfaces;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using IUser = Interfaces.IUser;

    public class User : IdentityUser, IUser
    {
        private ICollection<IGuess> guesses;

        public User()
        {
            guesses = new HashSet<IGuess>();
        }

        public int Rank { get; set; }

        public virtual ICollection<IGuess> Guesses
        {
            get { return guesses; }
            set { guesses = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}