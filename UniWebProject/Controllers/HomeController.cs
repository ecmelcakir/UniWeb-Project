using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace UniWebProject.Controllers
{
    public class HomeController : Controller
    {
        //private UniContext context=new UniContext();
        private readonly IStudentService _studentService;
        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: Home
        public ActionResult Index()
        {
            
            return Json(_studentService.GetStudent(1));
        }

   
    }
}