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

        public ViewResult detail(int id) {
            return View(_employeeRepository.GetEmployee(id));
        
        }

        [HttpGet]
        public ViewResult create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("detail", new { id = newEmployee.ID });
            }
            return View();

        }
    }
}
