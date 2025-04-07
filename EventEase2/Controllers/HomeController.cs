using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventEase2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Event()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: LandingPage
        public ActionResult LandingPage()
        {
            return View();
        }
    }
}