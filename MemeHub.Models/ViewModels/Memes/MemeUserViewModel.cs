using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeUserViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [MinLength(6), MaxLength(200)]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(3), MaxLength(100)]
        public string Caption { get; set; }
    }
}
