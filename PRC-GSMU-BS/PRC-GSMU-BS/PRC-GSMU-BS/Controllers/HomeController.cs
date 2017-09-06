using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRC_GSMU_BS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "User integration for GSMU and BookedScheduler for PRC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Check the contact page.";

            return View();
        }
    }
}