using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeHub.Models.Models;

namespace MemeHub.Models.BindingModels.Comments
{
    public class CommentCreateBindingModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public virtual Meme Meme { get; set; }
    }
}
