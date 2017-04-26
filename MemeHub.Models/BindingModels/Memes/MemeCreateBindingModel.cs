using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Enums;
using MemeHub.Models.Models;

namespace MemeHub.Models.BindingModels.Memes
{
    public class MemeCreateBindingModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [MinLength(6), MaxLength(200)]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(3), MaxLength(200)]
        public string Caption { get; set; }

        public Category Category { get; set; }

        public ApplicationUser OriginalPoster { get; set; }
    }
}
