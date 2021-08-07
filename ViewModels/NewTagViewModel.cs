using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.ViewModels
{
    public class NewTagViewModel
    {
        [Required(ErrorMessage = "Must not be empty")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 Characters")]
        public string Name { get; set; }
    }
}
