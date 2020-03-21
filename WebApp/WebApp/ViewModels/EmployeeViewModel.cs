using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }

        public IEnumerable<Department> Departments { get; set; }
    }
}
