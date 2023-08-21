using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniWebProject.Models;

namespace UniWebProject.Controllers
{
    public class LoginController : Controller
    {
        public LoginController()
        {
            db=new UniContext();
        }

        private UniContext db =new UniContext();
        // GET: Login
        public ActionResult Index()
        {
            db.Loginpage.Count();
        
            return View();
        }
        public ActionResult login(Login entity) 
        {
            string username=entity.Username;
            int password=entity.Password;   

            if (entity.Username == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login login = db.Loginpage.Find(entity.Username);
            if (login == null)
            {
                return HttpNotFound();
            }
            if (login.Password == entity.Password)
            {
                return RedirectToAction("Index","Home");
            }
            return HttpNotFound();



            return View();
        }

    }
}