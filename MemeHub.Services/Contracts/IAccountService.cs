using MemeHub.Models.Models;

namespace MemeHub.Services
{
    public interface IAccountService
    {
        void CreateUser(ApplicationUser user);
    }
}