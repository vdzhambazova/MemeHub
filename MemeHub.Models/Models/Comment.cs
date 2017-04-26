using System;
using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public virtual ApplicationUser Writer { get; set; }

        public DateTime PostDate { get; set; }

        public virtual Meme Meme { get; set; }
    }
}
