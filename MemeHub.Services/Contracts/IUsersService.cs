using MemeHub.Models.BindingModels.Users;
using MemeHub.Models.ViewModels.Users;

namespace MemeHub.Services
{
    public interface IUsersService
    {
        void EditUser(UserEditBindingModel uebm, string userName);
        UserEditViewModel GetEditUser(string userName);
        UserProfileViewModel GetProfile(string userName);
    }
}