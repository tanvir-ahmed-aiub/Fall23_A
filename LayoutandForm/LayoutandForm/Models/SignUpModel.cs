using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutandForm.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage ="Please Put your name")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
    }
}