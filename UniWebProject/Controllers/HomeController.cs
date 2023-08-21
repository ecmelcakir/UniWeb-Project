using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UniWebProject.Models;

namespace UniWebProject.Controllers
{
    public class HomeController : Controller
    {
        private UniContext context=new UniContext();

        // GET: Home
        public ActionResult Index()
        {
        
            return View();
        }

   
    }
}