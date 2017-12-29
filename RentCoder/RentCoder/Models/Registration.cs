using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCoder.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "Org/Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        [RegularExpression("^[-_, @.A-Za-z0-9]*$", ErrorMessage = "Name contains Invalid characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Technology")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Technology { get; set; }

        [Required]
        [Display(Name = "Experience")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
        public string Experiance { get; set; }

        [Display(Name = "Contact No")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Contact number")]
        public string Contact { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
      ErrorMessage = "Please enter valid email id.")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Employement Type")]
        public string EmployementType { get; set; }
        public List<EmployementTypes> EmployementTypes { get; set; }
        public List<int> Years { get; set; }
    }

    public class EmployementTypes
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}