using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOT.BackendSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the new connected world of intelligent devices";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
