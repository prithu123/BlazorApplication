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
              new Employee(){ID=1, Name="Prithu",Department=Dept.CSE,Email="prithu.paul1907@gmail.com"},
              new Employee(){ID=2, Name="Arghya",Department=Dept.HR,Email="arghya.paul@gmail.com"},
              new Employee(){ID=3, Name="Subho",Department=Dept.IT,Email="subhajit.paul1907@gmail.com"},

         };
        }

        public Employee Add(Employee employee)
        {
            employee.ID = empList.Max(e => e.ID) + 1;
            empList.Add(employee);
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            return empList.FirstOrDefault(obj => obj.ID == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return empList;
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
