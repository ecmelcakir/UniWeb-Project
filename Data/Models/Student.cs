using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StuName { get; set; }
        public string Department { get; set; }
        public DateTime Entrydate { get; set; }

        //soru isareti nullable yapıyor
        public int? LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public List<Course>Courses { get; set; }

        public Student()
        {
            this.Courses = new List<Course>();
        }
    }
}