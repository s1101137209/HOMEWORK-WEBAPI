using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class EmployeeController : Spring.Web.Mvc.SpringMvcApplication
    {
        // GET: Employee

        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        public Employee GetEmployeeById(string id)
        {
            return EmployeeService.GetEmployeeById(id);
        }

        [HttpGet]
        public Employee GetEmployeeByName(string name)
        {
            return EmployeeService.GetEmployeeByName(name);
        }
    }
}