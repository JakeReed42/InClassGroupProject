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
    public class ManualOfficeController : Controller
    {
        // attribute of this class
        private ApplicationDbContext database;

        // Constructor
        public ManualOfficeController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;

        }

        public IActionResult GetAllOffices()
        {
           List<Office> officeList = database.Offices.ToList<Office>();

            return View(officeList);
        }

        [HttpGet]
        public IActionResult AddOffice()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddOffice([Bind("OfficeID, OfficeName, OfficeAddress, OfficePhoneNumber")] Office office)
        {

            database.Offices.Add(office);
            database.SaveChanges();
            return RedirectToAction("GetAllOffices");
        }
        

    }
}