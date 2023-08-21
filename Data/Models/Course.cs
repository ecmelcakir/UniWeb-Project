using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public List<Student>Students { get; set; }

        public Course()
        {
            this.Students = new List<Student>();
        }
    }
}