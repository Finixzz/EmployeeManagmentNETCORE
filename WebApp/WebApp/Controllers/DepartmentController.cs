using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
                return View("404");

            return View(department);
        }

        public IActionResult New()
        {
            Department department = new Department();
            return View(department);
        }
        
        [HttpPost]
        public IActionResult Save(Department department)
        {
            ModelState.Remove("department.Id");
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                if (department.Id == 0)
                {
                    return RedirectToAction("Details", new { id = _departmentRepository.CreateDepartment(department).Id });
                }
                else
                {

                    return RedirectToAction("Details", new { id = _departmentRepository.EditDepartment(department,department.Id).Id });
                }
            }
        }

        public IActionResult Edit(int id)
        {
            Department departmentInDb = _departmentRepository.GetDepartment(id);
            if (departmentInDb == null)
                return View("404");

            return View(departmentInDb);

        }
    }
}