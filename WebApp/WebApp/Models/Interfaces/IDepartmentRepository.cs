using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Interfaces
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int id);

        IEnumerable<Department> GetDepartments();

        Department CreateDepartment(Department department);

        Department EditDepartment(Department department,int id);

        Department DeleteDepartment(int id);
    }
}
