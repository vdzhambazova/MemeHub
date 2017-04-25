using System;
using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Attributes;

namespace MemeHub.Models.ViewModels.Users
{
    public class UserEditViewModel
    {
        public string Id { get; set; }

        [BirthDate]
        [Required]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [Required]
        [Display(Name="Profile Picture Url")]
        public string ProiflePictureUrl { get; set; }
    }
}
