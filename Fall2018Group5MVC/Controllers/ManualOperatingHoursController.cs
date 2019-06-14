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
    public class ManualOperatingHoursController : Controller
    {
        // needed to access Database
        private ApplicationDbContext database;

        public ManualOperatingHoursController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }


        public IActionResult SearchHoursByOffice()
        {
           

            ViewData["Offices"] = new SelectList(database.Offices, "OfficeID", "OfficeName");

            return View();
        }

        [HttpPost]
        public IActionResult SearchResult(int? OfficeID)
            {
            List < OperatingHour > operatinghourList =
                database.OperatingHours.Include(oh => oh.Office).ToList<OperatingHour>();

            if(OfficeID != null)
            {
                operatinghourList =
                    operatinghourList.Where(oh => oh.OfficeID == OfficeID).ToList<OperatingHour>();
            }

                return View(operatinghourList);
            }

        //[HttpGet]
        //public IActionResult AddOfficeHours()
        //{
        //    ViewData["Offices"] =
        //        new SelectList(database.Offices, "OfficeID", "OfficeName", "OfficeAddress", "OfficePhoneNumber");

        //    return View();
        //}
         

    }// end of class
}// end of namespace