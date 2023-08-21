using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data.Models
{
    public class StudentCourse
    {
      
        public int Id { get; set; }
        public int Student_Id { get; set; }
        
        public int Course_Id { get; set; }
        
    }
}