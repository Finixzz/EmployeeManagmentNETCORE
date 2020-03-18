using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetEmployees();

        Employee CreateEmployee(Employee employee);

        Employee EditEmployee(Employee employee,int id);

        Employee DeleteEmployee(int id);
    }
}
