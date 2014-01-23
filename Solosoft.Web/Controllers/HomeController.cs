using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solosoft.Web.Controllers
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

            return View();
        }

        public ContentResult News()
        {
            return Content("Momenteel is er geen nieuws!");
        }

        public ActionResult Chatbox()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }


    }
}