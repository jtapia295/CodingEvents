using System;
using Coding_Events.Models;

namespace Coding_Events.ViewModels
{
	public class EventDetailViewModel
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string ContactEmail { get; set; }
		public string CategoryName { get; set; }
		public EventDetailViewModel(Event theEvent)
		{
			Name = theEvent.Name;
			Description = theEvent.Description;
			ContactEmail = theEvent.ContactEmail;
			CategoryName = theEvent.Category.Name;
		}
	}
}
