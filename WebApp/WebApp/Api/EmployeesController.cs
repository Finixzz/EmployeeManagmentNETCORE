using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.DbContext;
using WebApp.Models.Interfaces;
using WebApp.Dtos;
using WebApp.Models;

namespace WebApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
        private IMapper _mapper;

        public EmployeesController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        //GET /api/employees
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employeeDtos = _employeeRepository.GetEmployees()
                .Select(_mapper.Map<Employee, EmployeeDto>);
            return Ok(employeeDtos);
        }

        //GET /api/employees/1
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            Employee employeeInDb = _employeeRepository.GetEmployee(id);

            if (employeeInDb == null)
                return NotFound();

            return Ok(_mapper.Map<Employee, EmployeeDto>(employeeInDb));
        }

        //CREATE /api/employees
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            ModelState.Remove("employeeDto.Id");
            if (!ModelState.IsValid)
                return BadRequest();

            Employee createdEmployee = _employeeRepository.
                CreateEmployee(_mapper.Map<EmployeeDto, Employee>(employeeDto));

            employeeDto.Id = createdEmployee.Id;

            return CreatedAtAction(nameof(employeeDto), new { id = employeeDto.Id }, employeeDto);
        }

        //PUT /api/employees/1
        [HttpPut("{id}")]
        public IActionResult EditEmployee(EmployeeDto employeeDto,int id)
        {
            ModelState.Remove("employeeDto.Id");
            if (!ModelState.IsValid)
                return BadRequest();

            Employee empInDb = _employeeRepository.GetEmployee(id);
            if (empInDb == null)
                return NotFound();

            _mapper.Map(employeeDto, empInDb);
            employeeDto=_mapper.Map<Employee,EmployeeDto>(
                _employeeRepository.EditEmployee(empInDb,empInDb.Id)
                );

            return Ok(employeeDto);
        }

        //DELETE /api/employees/1
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            Employee empInDb = _employeeRepository.GetEmployee(id);
            if (empInDb == null)
                return NotFound();

            return Ok(_mapper.Map<Employee, EmployeeDto>(_employeeRepository.DeleteEmployee(id)));
        }
    }
}