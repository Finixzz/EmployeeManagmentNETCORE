using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Models.Interfaces;

namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var departmentsInDb = _departmentRepository.GetDepartments().ToList();
            return View(departmentsInDb);
        }

        public IActionResult Details(int id)
        {
            Department department = _departmentRepository.GetDepartment(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        
    }
}