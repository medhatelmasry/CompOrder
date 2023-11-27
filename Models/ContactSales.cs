using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Comp1170mvc.Models
{
    public class ContactSales
    {
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}