using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.Controllers
{
    [Route("/Events")]
    public class EventController : Controller
    {
        static private Dictionary<string, string> Events = new Dictionary<string, string> { };
        public IActionResult Index()
        {
            ViewBag.Events = Events;
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddEvent(string EventName, string EventDescription)
        {
            if (!String.IsNullOrEmpty(EventName))
            {
                Events.Add(EventName, EventDescription);
            }
            return Redirect("/Events");
        }
    }
}
