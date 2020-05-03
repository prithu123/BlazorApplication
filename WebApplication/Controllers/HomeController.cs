using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.NewFolder
{
    public class HomeController :Controller
    {
        private IEmployeeRepository _employeeRepository;

       public  HomeController(IEmployeeRepository employeeRepository ) {
            _employeeRepository = employeeRepository;
        }
        public ViewResult index() {
            return View(_employeeRepository.GetEmployees());
              ;

        }
    }
}
