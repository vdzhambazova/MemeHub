using MemeHub.Models.Models;

namespace MemeHub.Services
{
    public class AccountService : Service
    {
        public void CreateUser(ApplicationUser user)
        {
            Poster poster = new Poster();
            ApplicationUser currentUser = this.Context.Users.Find(user.Id);
            poster.User = currentUser;
            this.Context.Posters.Add(poster);
            this.Context.SaveChanges();
        }
    }
}
