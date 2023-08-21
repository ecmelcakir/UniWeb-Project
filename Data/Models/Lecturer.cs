using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models
{
    public class Lecturer
    {

        public int Id { get; set; }
        public string LecName { get; set; }
        public double Salary { get; set; }
        public DateTime EntryDate { get; set; }
        public string Job { get; set; }

        public List<Student> Students { get; set; }
        
    }
}