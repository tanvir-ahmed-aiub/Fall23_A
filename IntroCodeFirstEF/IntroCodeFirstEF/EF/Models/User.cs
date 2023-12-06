using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroCodeFirstEF.EF.Models
{
    public class User
    {
        [Key] //primary key
        [Required] //not nullable
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
    }
}