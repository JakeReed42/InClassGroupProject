using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2018Group5MVC.Data;
using Fall2018Group5MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fall2018Group5MVC.Controllers
{
    public class ManualEmployeeController : Controller
    {
        private ApplicationDbContext database;

        public ManualEmployeeController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;

        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> employeeList = database.Employees.ToList<Employee>();

            return View(employeeList);
        }


        [HttpGet]
        public IActionResult AddEmployee()
        {
            ViewData["Employees"] = new SelectList(database.Employees);
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee ([Bind("FirstName, LastName, Email, EmployeeID")]Employee employee)
        {
            database.Employees.Add(employee);
            database.SaveChanges();
            return RedirectToAction("GetAllEmployees");
        }

        public IActionResult DeleteEmployee(int? id)
        {
            Employee employee = database.Employees.Find(id);
            try
            {
                database.Employees.Remove(employee);
                database.SaveChanges();
            }

            catch (Exception e)
            {

            }
            return RedirectToAction("GetAllEmployees");

        }


    }
}