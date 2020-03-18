using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Dtos;
using WebApp.Models;

namespace WebApp.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
        }
    }
}
