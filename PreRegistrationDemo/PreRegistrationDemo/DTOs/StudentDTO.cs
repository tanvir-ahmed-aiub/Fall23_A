using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreRegistrationDemo.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public Nullable<double> Cgpa { get; set; }
        [Required]
        public int DeptId { get; set; }
    }
}