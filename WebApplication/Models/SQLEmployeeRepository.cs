using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public SQLEmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Employee Add(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            appDbContext.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            Employee emp = appDbContext.Employees.Find(employee);
            if (emp != null) {
                appDbContext.Employees.Remove(employee);
                appDbContext.SaveChanges();

            }
            return emp;
        }

        public Employee GetEmployee(int id)
        {
            return appDbContext.Employees.Find(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return appDbContext.Employees;
        }

        public Employee Update(Employee employee)
        {
            var emp = appDbContext.Employees.Attach(employee);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            appDbContext.SaveChanges();
            return employee;

        }
    }
}
