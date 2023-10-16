using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreRegistrationDemo.DTOs
{
    public class CourseStudentDTO : CourseDTO
    {
        public List<StudentDTO> Students { get; set; }
        public CourseStudentDTO() { 
            StudentDTO student = new StudentDTO();
        }
    }
}