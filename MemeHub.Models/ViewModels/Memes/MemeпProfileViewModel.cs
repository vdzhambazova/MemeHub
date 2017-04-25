using System.Collections.Generic;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Comments;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeпProfileViewModel
    {
        public int Id { get; set; }

        public string MemeImageUrl { get; set; }

        public string Caption { get; set; }

        public int MemePoints { get; set; }

        public virtual ApplicationUser OriginalPoster { get; set; }

        public virtual IEnumerable<CommentDisplayViewModel> Comments { get; set; }
    }
}
