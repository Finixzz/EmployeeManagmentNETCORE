using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DbContext;
using WebApp.Models.Interfaces;

namespace WebApp.Models.Repositories
{
    public class SQLDepartmentRepository : IDepartmentRepository
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public SQLDepartmentRepository(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Department CreateDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public Department DeleteDepartment(int id)
        {
            Department deptInDb = _context.Departments.SingleOrDefault(d => d.Id == id);
            _context.Departments.Remove(deptInDb);
            _context.SaveChanges();
            return deptInDb;
        }

        public Department EditDepartment(Department department, int id)
        {
            Department deptInDb = _context.Departments.SingleOrDefault(d => d.Id == id);
            deptInDb.Name = department.Name;
            deptInDb.GroupName = department.GroupName;
            _context.SaveChanges();
            return deptInDb;
        }

        public Department GetDepartment(int id)
        {
            Department deptInDb = _context.Departments.SingleOrDefault(d => d.Id == id);
            return deptInDb;
        }

        public IEnumerable<Department> GetDepartments()
        {
            var departmentsInDb = _context.Departments;
            return departmentsInDb;  
        }
    }
}
