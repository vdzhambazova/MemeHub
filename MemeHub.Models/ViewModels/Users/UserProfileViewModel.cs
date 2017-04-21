using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MemeHub.Models.ViewModels.Memes;

namespace MemeHub.Models.ViewModels.Users
{
    public class UserProfileViewModel
    {
        public string Username { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        public string ProiflePictureUrl { get; set; }

        public ICollection<UserMemeViewModel> Memes { get; set; }
    }
}
