using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeHub.Models.ViewModels.Memes;

namespace MemeHub.Models.ViewModels
{
    public class UserProfileViewModel
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<UserMemeViewModel> Memes { get; set; }
    }
}
