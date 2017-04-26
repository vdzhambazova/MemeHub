using System;
using System.Collections.Generic;
using MemeHub.Models.Models;

namespace MemeHub.Models.ViewModels.Memes
{
    public class MemeDetailsViewModel
    {
        public int Id { get; set; }
        public string MemeImageUrl { get; set; }

        public string Caption { get; set; }

        public DateTime? PostDate { get; set; }

        public int MemePoints { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
