using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeHub.Models.Enums;

namespace MemeHub.Models.ViewModels.Memes
{
    public class UserMemeViewModel
    {
        public int Id { get; set; }

        [Required]
        public byte[] MemeImage { get; set; }

        [Required]
        [MinLength(10), MaxLength(200)]
        public string Caption { get; set; }
    }
}
