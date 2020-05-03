using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        public List<Employee> empList;
       public MockEmployeeRepository() {
            empList = new List<Employee> {
              new Employee(){empID=1, empName="Prithu",empDepartment="CSE",empEmail="prithu.paul1907@gmail.com"},
              new Employee(){empID=2, empName="Arghya",empDepartment="CSE",empEmail="arghya.paul@gmail.com"},
              new Employee(){empID=3, empName="Subho",empDepartment="IT",empEmail="subhajit.paul1907@gmail.com"},

         };
        }
        public Employee GetEmployee(int id)
        {
            return empList.FirstOrDefault(obj => obj.empID == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return empList;
        }
    }
}
