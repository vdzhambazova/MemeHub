using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [MinLength(6), MaxLength(200)]
        public string MemeImageUrl { get; set; }

        [Required]
        [MinLength(3), MaxLength(100)]
        public string Caption { get; set; }

        public DateTime? PostDate { get; set; }

        [Range(0, 1000000)]
        public int MemePoints { get; set; }

        public Category Category { get; set; }

        public virtual ApplicationUser OriginalPoster { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
    