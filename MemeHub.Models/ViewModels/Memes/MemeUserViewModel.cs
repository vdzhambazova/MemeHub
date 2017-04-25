using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeUserViewModel
    {
        public int Id { get; set; }

        [Required]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(10), MaxLength(200)]
        public string Caption { get; set; }
    }
}
