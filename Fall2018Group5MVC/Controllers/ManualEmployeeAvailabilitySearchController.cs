using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2018Group5MVC.Data;
using Fall2018Group5MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fall2018Group5MVC.Controllers
{
    public class ManualEmployeeAvailabilitySearchController : Controller //Could not get this controller/view to work. Couldnt access EmployeeID
    {

        private ApplicationDbContext database;

        public ManualEmployeeAvailabilitySearchController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }


        public IActionResult SearchAvailabilityByEmployee()
        {
            List<Employee> employees = database.Employees.ToList<Employee>();

            ViewData["Employees"] = new SelectList(employees, "EmployeeID", "EmployeeFirstName");

            return View();
        }

        [HttpPost]
        public IActionResult SearchResult(string EmployeeID)
        {
            List<EmployeeAvailability> availabilityList =
                database.EmployeeAvailabilities.Include(ea => ea.EmployeeID).ToList<EmployeeAvailability>();

            if (EmployeeID != null)
            {
                availabilityList =
                    availabilityList.Where(ea => ea.EmployeeID == EmployeeID).ToList<EmployeeAvailability>();
            }

            return View(availabilityList);
        }



    }
}