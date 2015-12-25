using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HereWeApp.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 30, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            ViewBag.Title = "HereWeApp";
            return View();
        }
    }
}