//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using UniWebProject.Models;

//namespace UniWebProject.Controllers
//{
//    public class StudentController : Controller
//    {
//        private UniContext db = new UniContext();

//        // GET: Student
//        public ActionResult Index()
//        {
//            var students = db.Students.Include(s => s.Lecturer);
//            return View(students.ToList());
//        }

//        // GET: Student/Details/5
//        public ActionResult Details(int? id)
//        {
            
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Student student = db.Students.Include(a=>a.Lecturer).FirstOrDefault(a=>a.Id==id);
//            if (student == null)
//            {
//                return HttpNotFound();
//            }
//            return View(student);
//        }

//        // GET: Student/Create
//        public ActionResult Create()
//        {
//            ViewBag.LecturerId = new SelectList(db.Lecturers, "Id", "LecName");
//            return View();
//        }

//        // POST: Student/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,StuName,Department,Entrydate,LecturerId")] Student student)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Students.Add(student);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.LecturerId = new SelectList(db.Lecturers, "Id", "LecName", student.LecturerId);
//            return View(student);
//        }

//        // GET: Student/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Student student = db.Students.Find(id);
//            if (student == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.LecturerId = new SelectList(db.Lecturers, "Id", "LecName", student.LecturerId);
//            return View(student);
//        }

//        // POST: Student/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,StuName,Department,Entrydate,LecturerId")] Student student)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(student).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.LecturerId = new SelectList(db.Lecturers, "Id", "LecName", student.LecturerId);
//            return View(student);
//        }

//        // GET: Student/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Student student = db.Students.Find(id);
//            if (student == null)
//            {
//                return HttpNotFound();
//            }
//            return View(student);
//        }

//        // POST: Student/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Student student = db.Students.Find(id);
//            db.Students.Remove(student);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }


//        // GET: Course/Create
//        public ActionResult CreateCourse()
//        {
//            ViewBag.StudentId = new SelectList(db.Students, "Id", "StuName");
//            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName");
//            return View();
//        }

//        // POST: Course/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        public ActionResult CreateCourse(StudentCourse courses)
//        {
            
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var std=new StudentCourse() { Course_Id = courses.Course_Id ,Student_Id=courses.Student_Id};
//                    db.StudentCourses.Add(std);
//                    db.SaveChanges();
//                    return RedirectToAction("CreateCourse");
//                }
//                catch (Exception e)
//                {
//                    string xsdf = e.Message;
//                    throw;
//                }
                
//            }
           
//            return View("CreateCourse");
//        }


//        //db bağlantısını koparıyor
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//        public Student GetStudentDetail(int id)
//        {
//            return db.Students.Find(id);
            
//        }
//    }
//}
