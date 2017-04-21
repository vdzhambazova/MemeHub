using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.Models
{
    public class Poster
    {
        public Poster()
        {
            this.Comments = new HashSet<Comment>();
            this.Memes = new HashSet<Meme>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Meme> Memes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
