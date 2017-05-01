using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeHub.Models.BindingModels.Comments;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Comments;

namespace MemeHub.Models.BindingModels.Memes
{
    public class MemeDetailsBindingModel
    {
        public int Id { get; set; }
     
        public virtual CommentCreateBindingModel CreateComment { get; set; }
    }
}
