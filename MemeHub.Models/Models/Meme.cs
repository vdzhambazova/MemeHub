using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MemeHub.Models.Enums;

namespace MemeHub.Models.Models
{
    public class Meme
    {
        public Meme()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] MemeImage { get; set; }

        [Required]
        [MinLength(10), MaxLength(200)]
        public string Caption { get; set; }

        public DateTime? PostDate { get; set; }

        [Range(-1000000, 1000000)]
        public int MemePoints { get; set; }

        public Category Category { get; set; }

        public virtual ApplicationUser OriginalPoster { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
