using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Web_Proto.Controllers
{
    public class DemoAppsController : Controller
    {
        // GET: DemoApps
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RPGCharacterCreator()
        {
            ViewBag.Message = "RPG Character Creator";
            return View();
        }
    }
}