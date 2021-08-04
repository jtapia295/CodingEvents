using System;
using System.ComponentModel.DataAnnotations;

namespace Coding_Events.ViewModels
{
    public class AddEventControllerViewModel
    {
        [Required(ErrorMessage = "Must not be empty")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        public AddEventControllerViewModel()
        {
        }
    }
}
