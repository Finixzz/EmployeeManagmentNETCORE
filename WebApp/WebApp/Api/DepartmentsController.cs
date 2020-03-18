using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Interfaces;
using WebApp.Models;
using WebApp.Dtos;
namespace WebApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private IDepartmentRepository _departmentRepository;
        private IMapper _mapper;

        public DepartmentsController(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        //GET /api/departments
        [HttpGet]
        public IActionResult GetDepartments()
        {
            var departmentDtos = _departmentRepository.GetDepartments()
                .Select(_mapper.Map<Department, DepartmentDto>);
            return Ok(departmentDtos);
        }

        //GET /api/departments/1
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            Department departmentInDb = _departmentRepository.GetDepartment(id);

            if (departmentInDb == null)
                return NotFound();

            return Ok(_mapper.Map<Department, DepartmentDto>(departmentInDb));
        }

        //CREATE /api/departments
        [HttpPost]
        public IActionResult CreateDepartment(DepartmentDto departmentDto)
        {
            ModelState.Remove("departmentDto.Id");
            if (!ModelState.IsValid)
                return BadRequest();

            Department createdDepartment = _departmentRepository.
                CreateDepartment(_mapper.Map<DepartmentDto, Department>(departmentDto));

            departmentDto.Id = createdDepartment.Id;

            return CreatedAtAction(nameof(departmentDto), new { id = departmentDto.Id }, departmentDto);
        }

        //PUT /api/departments/1
        [HttpPut("{id}")]
        public IActionResult EditDepartment(DepartmentDto departmentDto, int id)
        {
            ModelState.Remove("departmentDto.Id");
            if (!ModelState.IsValid)
                return BadRequest();

            Department departmentInDb = _departmentRepository.GetDepartment(id);
            if (departmentInDb == null)
                return NotFound();

            _mapper.Map(departmentDto, departmentInDb);
            departmentDto = _mapper.Map<Department, DepartmentDto>(
                _departmentRepository.EditDepartment(departmentInDb, departmentInDb.Id)
                );

            return Ok(departmentDto);
        }

        //DELETE /api/departments/1
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            Department departmentInDb = _departmentRepository.GetDepartment(id);
            if (departmentInDb == null)
                return NotFound();
            
            return Ok(_mapper.Map<Department, DepartmentDto>(_departmentRepository.DeleteDepartment(id)));
        }
    }
}