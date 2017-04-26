using MemeHub.Models.Models;

namespace MemeHub.Services.Contracts
{
    public interface IAccountService
    {
        void CreateUser(ApplicationUser user);
    }
}