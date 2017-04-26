using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.BindingModels.Memes
{
    public class MemeEditBindingModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(200)]
        public string Caption { get; set; }
    }
}
