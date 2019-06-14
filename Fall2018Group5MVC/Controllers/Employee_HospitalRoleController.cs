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
    public class Employee_HospitalRoleController : Controller
    {

        private ApplicationDbContext database;

        public Employee_HospitalRoleController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }


        public IActionResult SearchEmployeeByRole()
        {


            ViewData["HospitalRoles"] = new SelectList(database.HospitalRoles, "HospitalRoleID", "HospitalRoleName");

            return View();
        }

        [HttpPost]
        public IActionResult SearchResult(int? HospitalRoleID)
        {
            List<Employee_HospitalRole> employeeHospitalRoleList =
                database.Employee_HospitalRoles.Include(ehr => ehr.HospitalRole).Include(ehr => ehr.Employee).Include(ehr => ehr.Employee).ToList<Employee_HospitalRole>();

            if (HospitalRoleID != null)
            {
                employeeHospitalRoleList =
                    employeeHospitalRoleList.Where(ehr => ehr.HospitalRoleID == HospitalRoleID).ToList<Employee_HospitalRole>();
            }

            return View(employeeHospitalRoleList);
        }


    }
}