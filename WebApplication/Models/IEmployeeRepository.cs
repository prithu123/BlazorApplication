﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
   public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        Employee Add(Employee employee);
    }
}
