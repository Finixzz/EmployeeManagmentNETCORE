using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Models.Interfaces;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        private IDepartmentRepository _departmentRepository;
        private IMapper _mapper;

        public EmployeeController(IEmployeeRepository employeeRepository,IDepartmentRepository departmentRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            var employeesInDb = _employeeRepository.GetEmployees();
            return View(employeesInDb);
        }

        public IActionResult New()
        {
            EmployeeViewModel empViewModel = new EmployeeViewModel()
            {
                Employee=new Employee(),
                Departments = _departmentRepository.GetDepartments().ToList()
            };
            return View(empViewModel);
        }

        
        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            ModelState.Remove("employee.Id");
            if (!ModelState.IsValid)
                return BadRequest();

            if (employee.Id == 0)
                return RedirectToAction("Details", new { id = _employeeRepository.CreateEmployee(employee).Id });           
            else
                return RedirectToAction("Details", new { id = _employeeRepository.EditEmployee(employee,employee.Id).Id});
            
        }
        public IActionResult Details(int id)
        {
            Employee empInDb = _employeeRepository.GetEmployee(id);
            if (empInDb == null)
                return View("404");

            EmployeeViewModel empViewModel = new EmployeeViewModel()
            {
                Employee = empInDb,
                Departments = _departmentRepository.GetDepartments().ToList()
            };
            return View(empViewModel);  
        }

        public IActionResult Edit(int id)
        {
            Employee empInDb = _employeeRepository.GetEmployee(id);
            if (empInDb == null)
                return View("404");

            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                Employee = empInDb,
                Departments = _departmentRepository.GetDepartments().ToList()
            };
            return View(employeeViewModel);
        }
    }
}