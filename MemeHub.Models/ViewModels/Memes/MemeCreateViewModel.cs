using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Enums;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeCreateViewModel
    {
        [Required]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(10), MaxLength(200)]
        public string Caption { get; set; }

        public Category Category { get; set; }
    }
}
