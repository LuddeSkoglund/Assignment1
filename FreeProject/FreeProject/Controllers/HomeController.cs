using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView("_Contact");
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView("_Services");
        }
        public ActionResult Team()
        {
            ViewBag.Message = "YTEam";

            return PartialView("_Team");
        }
    }
}