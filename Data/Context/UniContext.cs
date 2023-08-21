using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Data.Context
{
    public class UniContext : DbContext
    {
        public UniContext(): base("UniDb")
        {
            Database.SetInitializer(new UniInitializer());
        }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet <Login> Loginpage { get; set; }
        public DbSet <Course> Courses { get; set; }
        public DbSet <StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           //key veya ilişkilerin yönetilebileceği method
            base.OnModelCreating(modelBuilder);
        }
    }
}