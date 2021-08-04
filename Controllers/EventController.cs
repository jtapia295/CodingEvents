using Coding_Events.Models;
using Coding_Events.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Events.ViewModels;

namespace Coding_Events.Controllers
{

    public class EventController : Controller
    {
        private EventDbContext _context;
        public EventController(EventDbContext dbContext)        {            _context = dbContext;        }

        public IActionResult Index()
        {
            List<Event> events = _context.Events.ToList();
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    EventLocation = addEventViewModel.EventLocation,
                    Attendees = addEventViewModel.Attendees,
                    RegistrationRequired = addEventViewModel.RegistrationRequired,
                    Type = addEventViewModel.Type
                };
                _context.Events.Add(newEvent);
                _context.SaveChanges();

                return Redirect("/Event");
            }
            return View(addEventViewModel);


        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (var item in eventIds)
            {
                Event theEvent = _context.Events.Find(item);
			    _context.Events.Remove(theEvent);
		    }
            _context.SaveChanges();
            return Redirect("/Event");
        }


        public IActionResult Delete()
        {
            ViewBag.events = _context.Events.ToList();
            return View();
        }


        //[Route("Event/Edit/{eventId}")]
        //public IActionResult Edit(int eventId)
        //{
        //    ViewBag.eventData = _context.Events.Find(eventId);
        //    return View();
        //}

        //[HttpPost("Event/Edit")]
        //public IActionResult SubmitEditEventForm(int eventId, string Name, string Description)
        //{
        //    EventData.Update(eventId, Name, Description);
        //    return Redirect("/Event");
        //}


    }
}
