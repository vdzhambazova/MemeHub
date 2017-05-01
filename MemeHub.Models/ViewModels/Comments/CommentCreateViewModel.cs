using System;
using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Models;

namespace MemeHub.Models.ViewModels.Comments
{
    public class CommentCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public virtual Meme Meme { get; set; }

        public ApplicationUser Writer { get; set; }
    }
}
