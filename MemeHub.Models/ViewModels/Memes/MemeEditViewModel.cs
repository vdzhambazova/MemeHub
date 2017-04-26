using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(200)]
        public string Caption { get; set; }
    }
}
