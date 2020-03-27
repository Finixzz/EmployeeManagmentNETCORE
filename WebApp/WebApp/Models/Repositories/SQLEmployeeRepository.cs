using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DbContext;
using WebApp.Models.Interfaces;


namespace WebApp.Models.Repositories
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public SQLEmployeeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee empInDb = _context.Employees.SingleOrDefault(e => e.Id == id);
            _context.Employees.Remove(empInDb);
            _context.SaveChanges();
            return empInDb;
        }

        public Employee EditEmployee(Employee employee, int id)
        {
            Employee empInDb = _context.Employees.SingleOrDefault(e => e.Id == id);
            empInDb.FirstName = employee.FirstName;
            empInDb.LastName = employee.LastName;
            empInDb.Email = employee.Email;
            empInDb.DepartmentId = employee.DepartmentId;
            _context.SaveChanges();
            return empInDb;
        }

        public Employee GetEmployee(int id)
        {
            Employee empInDb = _context.Employees.SingleOrDefault(e => e.Id == id);
            return empInDb;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var employeesInDb = _context.Employees
                .Include(e => e.Department);
            return employeesInDb;
        }
    }
}
