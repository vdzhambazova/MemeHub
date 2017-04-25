using System;
using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Attributes;

namespace MemeHub.Models.BindingModels
{
    public class UserEditBindingModel
    {
        public string Id { get; set; }

        [Required]
        [BirthDate]
        public DateTime? BirthDate { get; set; }

        [Required]
        public string ProiflePictureUrl { get; set; }
    }
}
