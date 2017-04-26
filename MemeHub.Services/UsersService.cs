using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MemeHub.Models.BindingModels.Users;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Models.ViewModels.Users;

namespace MemeHub.Services
{
    public class UsersService : Service, IUsersService
    {
        public UserProfileViewModel GetProfile(string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            UserProfileViewModel upvm = Mapper.Map<ApplicationUser, UserProfileViewModel>(user);
            Poster poster = this.Context.Posters.FirstOrDefault(p => p.User.UserName == user.UserName);
            upvm.Memes = Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeUserViewModel>>(poster.Memes);

            return upvm;
        }

        public UserEditViewModel GetEditUser(string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            UserEditViewModel uevm = Mapper.Map<ApplicationUser, UserEditViewModel>(user);

            return uevm;
        }

        public void EditUser(UserEditBindingModel uebm, string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            user.BirthDate = uebm.BirthDate;
            user.ProiflePictureUrl = uebm.ProiflePictureUrl;

            this.Context.SaveChanges();
        }
    }
}
