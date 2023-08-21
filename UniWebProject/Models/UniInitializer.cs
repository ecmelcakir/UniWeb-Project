using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniWebProject.Models
{
    public class UniInitializer : DropCreateDatabaseIfModelChanges<UniContext>
    {

        protected override void Seed(UniContext context)
        {
            List<Lecturer> lecturers = new List<Lecturer>()
            {
                new Lecturer(){LecName= "Cem",Salary=25000,EntryDate=new DateTime(2009,10,15), Job="Professor"}
            };

            context.Lecturers.AddRange(lecturers);

            List<Student> students = new List<Student>()
            {
                new Student(){StuName="Ecmel",Department="EEE",Entrydate=new DateTime(2019,08,16),LecturerId=1}
            };

            context.Students.AddRange(students);

            List<Login> loginpage = new List<Login>() { 

                new Login(){Username="Admin",Password=12345}
            };

            context.Loginpage.AddRange(loginpage);

            List<Course> courses = new List<Course>() {
                new Course(){CourseName="Math"}
            };

            context.Courses.AddRange(courses);
            

            base.Seed(context);
        }
    }
}