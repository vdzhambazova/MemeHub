using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Models.ViewModels.Users;

namespace MemeHub.Services
{
    public class UsersService : Service
    {
        public UserProfileViewModel GetProfile(string userName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(u => u.UserName == userName);
            UserProfileViewModel upvm = Mapper.Map<ApplicationUser, UserProfileViewModel>(user);
            Poster poster = this.Context.Posters.FirstOrDefault(p => p.User.UserName == user.UserName);
            upvm.Memes = Mapper.Map<IEnumerable<Meme>, IEnumerable<UserMemeViewModel>>(poster.Memes);
            return upvm;
        }
    }
}
