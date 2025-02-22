﻿using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Enums;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeCreateViewModel
    {
        [Required]
        [Display(Name="Image URL")]
        [MinLength(6), MaxLength(200)]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(3), MaxLength(100)]
        public string Caption { get; set; }

        public Category Category { get; set; }
    }
}
