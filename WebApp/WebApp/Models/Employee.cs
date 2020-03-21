using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The First name field is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Last name field is required")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage  = "The department field is required")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
