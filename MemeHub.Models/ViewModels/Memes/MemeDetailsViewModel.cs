using System;
using System.Collections.Generic;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Comments;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeDetailsViewModel
    {
        public MemeDetailsViewModel()
        {
            this.DisplayComments = new HashSet<CommentDisplayViewModel>();
        }
        public int Id { get; set; }
        public string MemeImageUrl { get; set; }

        public string Caption { get; set; }

        public DateTime? PostDate { get; set; }

        public int MemePoints { get; set; }

        public virtual CommentCreateViewModel CreateComment { get; set; }

        public virtual ICollection<CommentDisplayViewModel> DisplayComments { get; set; }

        public virtual ApplicationUser Poster { get; set; }
    }
}
