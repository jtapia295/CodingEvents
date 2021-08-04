using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Events.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Coding_Events.Models;
using Coding_Events.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Coding_Events.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext _context;

        public EventCategoryController(EventDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<EventCategory> Categories = _context.Categories.ToList();
            return View(Categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            AddEventControllerViewModel Ec = new AddEventControllerViewModel();
            return View(Ec);
        }


        [HttpPost("Create")]
        public IActionResult ProcessCreateEventCategoryForm(AddEventControllerViewModel viewModel)
        {
            
            if(ModelState.IsValid)
            {
                EventCategory category = new EventCategory(viewModel.Name);
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
            else
            {
                return View("Create", viewModel);
            }

            return Redirect("/EventCategory");
        }
    }
}
