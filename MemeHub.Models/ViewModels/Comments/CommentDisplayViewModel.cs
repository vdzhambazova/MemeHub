using MemeHub.Models.Models;

namespace MemeHub.Models.ViewModels.Comments
{
    public class CommentDisplayViewModel
    {
        public string Content { get; set; }

        public virtual ApplicationUser Writer { get; set; }
    }
}