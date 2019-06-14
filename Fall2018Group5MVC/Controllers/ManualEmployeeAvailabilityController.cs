using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2018Group5MVC.Data;
using Fall2018Group5MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fall2018Group5MVC.Controllers
{
    public class ManualEmployeeAvailabilityController : Controller
    {
        private ApplicationDbContext database;

        // Constructor
        public ManualEmployeeAvailabilityController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }

        public IActionResult GetAllAvailabilities()
        {
            List<EmployeeAvailability> availabilityList = database.EmployeeAvailabilities.Include(ea => ea.ApplicationUser).ToList<EmployeeAvailability>();

            return View(availabilityList);
        }
    }
}