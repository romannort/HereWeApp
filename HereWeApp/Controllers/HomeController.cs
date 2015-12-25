using EventModels;
using HereWeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HereWeApp.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 30, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            DateTime toDate = DateTime.Now;
            List<SomeEventViewModel> nextEvents = EventService.Instance.GetNextEvents(toDate)
                .Select(e => new SomeEventViewModel()
                {
                    Description = e.Description,
                    Countdown = e.When.Subtract(toDate)
                })
                .ToList();
            
            ViewBag.Title = "HereWeApp";
            ViewData.Model = nextEvents;

            return View();
        }
    }
}