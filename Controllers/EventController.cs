using Coding_Events.Models;
using Coding_Events.Data;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.Controllers
{
    
    public class EventController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Events = EventData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Event/Add")]
        public IActionResult AddEvent(Event newEvent)
        {
            EventData.Add(newEvent);
            return Redirect("/Event");
        }

        [HttpPost]
        public IActionResult Delete(int[]eventIds)
        {
            foreach(var item in eventIds)
            {
                EventData.Remove(item);
            }
            return Redirect("/Event");
        }


        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        
    }
}
