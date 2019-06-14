using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fall2018Group5MVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fall2018Group5MVC.Controllers
{
    public class RequestController : Controller
    {

        private ApplicationDbContext database;

        public RequestController(ApplicationDbContext dbContext)
        {
            this.database = dbContext;
        }

        [HttpGet]
        public IActionResult SelectRequest()
        {
            ViewData["RequestType"] = new SelectList(database.RequestTypes, "RequestTypeID", "RequestTypeName");

            return View();
        }

        //[HttpPost]
        //public IActionResult SelectRequest([Bind("")])
        //{


        //    return View();
        //}
    }
}