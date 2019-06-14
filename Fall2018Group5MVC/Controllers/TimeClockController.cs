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
    public class TimeClockController : Controller
    {

        private ApplicationDbContext database;

        //Dependency Inversion
        public TimeClockController (ApplicationDbContext dbContext)
        {
            this.database = dbContext;

        }



        public IActionResult ListAllTimeClocks()
        {
            List<TimeClock> clocks = database.TimeClocks.Include(I => I.Employee).ToList<TimeClock>();

            return View(clocks);
        }

        //add and edit: two methods for each, (one get, and one post)

        [HttpGet]
        public IActionResult AddClockInstance()
        {
            ViewData["Employees"] = new SelectList(database.Employees, "EmployeeID", "FirstName");
            return View();
        }

        //[HttpPost]
        //public IActionResult AddInstructor([Bind("InsructorID, InstructorFirstName, InstructorLastName, InstructorEmail, DepartmentID")]Instructor instructor)
        //{
        //    database.Instructors.AddAsync(instructor);
        //    database.SaveChangesAsync();
        //    return RedirectToAction("ListAllInstructors");
        //}

        //public IActionResult DeleteInstructor(int? id)
        //{
        //    Instructor instructor = database.Instructors.Find(id);
        //    try
        //    {
        //        database.Instructors.Remove(instructor);
        //        database.SaveChangesAsync();
        //    }

        //    catch (Exception e)
        //    {

        //    }
        //    return RedirectToAction("ListAllInstructors");

        //}



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}