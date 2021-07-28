using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 Characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Required")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters")]
        public string Description { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string ContactEmail { get; set; }
    }
}
