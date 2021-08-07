using Coding_Events.Models;
using Coding_Events.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Events.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Coding_Events.Controllers
{

    public class TagController : Controller
    {
        private EventDbContext _context;

        public TagController(EventDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            List<Tag> tags = _context.Tags.ToList();
            return View(tags);
        }



        //Add tag to event
        [HttpGet]
        public IActionResult AddEvent(int id)
        {
            Event theEvent = _context.Events.Find(id);
            AddEventTagViewModel addEventTagViewModel = new AddEventTagViewModel(theEvent, _context.Tags.ToList()); ;
            return View(addEventTagViewModel);
        }

        [HttpPost]
        public IActionResult AddEvent(AddEventTagViewModel addEventTagViewModel)
        {
            if (ModelState.IsValid)
            {
                List<EventTag> eventTags = _context.EventTags.Where(et => et.EventId == addEventTagViewModel.EventId).Where(et => et.TagId == addEventTagViewModel.TagId).ToList();

                if (eventTags.Count == 0)
                {
                    EventTag eventTag = new EventTag
                    {
                        TagId = addEventTagViewModel.TagId,
                        EventId = addEventTagViewModel.EventId
                    };
                    _context.EventTags.Add(eventTag);
                    _context.SaveChanges();

                }

                return Redirect("/Event/Details/" + addEventTagViewModel.EventId);
            }
            return View(addEventTagViewModel);
        }





        //Delete Tag
        [HttpPost]
        public IActionResult Delete(int[] tagIds)
        {
            foreach (var item in tagIds)
            {
                Tag theTag = _context.Tags.Find(item);
                _context.Tags.Remove(theTag);
            }
            _context.SaveChanges();
            return Redirect("/Tag");
        }


        public IActionResult Delete()
        {
            ViewBag.events = _context.Tags.ToList();
            return View();
        }



        //Create Tag
        [HttpGet]
        public IActionResult Create()
        {
            NewTagViewModel tagModel = new NewTagViewModel();
            return View(tagModel);
        }


        [HttpPost]
        public IActionResult Create1(NewTagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Tag currentTag = new Tag(viewModel.Name);
                _context.Tags.Add(currentTag);
                _context.SaveChanges();
            }
            else
            {
                return View("Create", viewModel);
            }

            return Redirect("/Tag");
        }


        public IActionResult Details(int id)
        {
            Tag theTag = _context.Tags.Where(t => t.Id == id).Single();
            List<EventTag> eventTags = _context.EventTags.Where(et => et.TagId == id).Include(t => t.Tag).Include(e => e.Event).ToList();

            TagDetailViewModel details = new TagDetailViewModel(theTag, eventTags);
            return View(details);
        }






    }
}
