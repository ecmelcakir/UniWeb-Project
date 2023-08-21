using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniWebProject.Models
{
    public class Login
    {
        [Key]
        public string Username { get; set; }
        public int Password { get; set; }
    }
}