using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Web;
using System.Web.Mvc;
using UniWebProject.Models;

namespace UniWebProject.Controllers
{
    public class LecturerController : Controller
    {
        private UniContext db = new UniContext();

        // GET: Lecturer
        public ActionResult Index()
        {
            return View(db.Lecturers.ToList());
        }

        // GET: Lecturer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecturer lecturer = db.Lecturers.Find(id);
            if (lecturer == null)
            {
                return HttpNotFound();
            }
            return View(lecturer);
        }

        // GET: Lecturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecturer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LecName,Salary,EntryDate,Job")] Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                db.Lecturers.Add(lecturer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lecturer);
        }

        // GET: Lecturer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecturer lecturer = db.Lecturers.Find(id);
            if (lecturer == null)
            {
                return HttpNotFound();
            }
            return View(lecturer);
        }

        // POST: Lecturer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LecName,Salary,EntryDate,Job")] Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecturer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lecturer);
        }

        // GET: Lecturer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecturer lecturer = db.Lecturers.Find(id);
            if (lecturer == null)
            {
                return HttpNotFound();
            }
            return View(lecturer);
        }

        // POST: Lecturer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lecturer lecturer = db.Lecturers.Find(id);
            db.Lecturers.Remove(lecturer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Merged()
        { 
        
        
        return View();
        }
        [HttpPost, ActionName("Merged")]
        public ActionResult LectureCourses()
        {
            var list = new List<LectureCourseViewModel>();
            var query = from lecturer in  db.Lecturers
                        join course in db.Courses on lecturer.Id equals course.Id
                        select new
                        {
                            LecturerName = lecturer.LecName,
                            CourseName = course.CourseName
                        };

            var data = query.ToList(); // Sorguyu veritabanında çalıştırın
            foreach ( var item in data )
            {
                list.Add(new LectureCourseViewModel
                {
                    CourseName= item.CourseName,
                    LecturerName=item.LecturerName
                });

            }
            return Json(list, JsonRequestBehavior.AllowGet);

        }
        ///**********************   

        //GET
        public ActionResult Complex()
        {

            return View();
        }
        [HttpPost, ActionName("Complex")]
        public ActionResult LecturesCoursesStudents()
        {
            var list = new List<LCSViewModel>();
            var query = from lecturer in db.Lecturers
                        join course in db.Courses 
                        on lecturer.Id equals course.Id
                        join student in db.Students 
                        on lecturer.Id equals student.Id
                       
                        select new
                        {
                            LecturerName = lecturer.LecName,
                            CourseName = course.CourseName,
                            StudentName=student.StuName
                        };

            var data = query.ToList(); // Sorguyu veritabanında çalıştırın
            foreach (var item in data)
            {
                list.Add(new LCSViewModel
                {
                    CourseName = item.CourseName,
                    LecturerName = item.LecturerName,
                    StudentName= item.StudentName
                });

            }
            return Json(list, JsonRequestBehavior.AllowGet);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
