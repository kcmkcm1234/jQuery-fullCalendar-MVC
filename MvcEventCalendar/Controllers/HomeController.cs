using MvcEventCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEventCalendar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            List<Event> events = new List<Event> {
                new Event
                {
                    Name="Rakesh",
                    StartDate="2017-08-15",
                    EndDate="2017-08-17",
                    ThemeColor="red",
                    IsFullDay=true
                },
                new Event
                {
                    Name="Vikash",
                    StartDate="2017-08-10",
                    EndDate="2017-08-11",
                    ThemeColor="green",
                    IsFullDay=true
                }

            };
            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}