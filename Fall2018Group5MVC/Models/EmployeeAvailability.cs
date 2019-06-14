using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fall2018Group5MVC.Models
{
    public class EmployeeAvailability
    {
        [Key]
        [Required]
        public int EmployeeAvailabilityID { get; set; }

        [Required]
        public string AvailabilityDay { get; set; }


        [Required]
        [DataType(DataType.Time)]
        public DateTime EmployeeStartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime EmployeeEndTime { get; set; }

        //was Employee Employee
        [Required]
           public string EmployeeID { get; set; }
           [ForeignKey("EmployeeID")] // this was intially put as employeeID
            public ApplicationUser ApplicationUser { get; set; }

        // Constructor 
        public EmployeeAvailability()
        {

        }

        public EmployeeAvailability(string availabilityDay, DateTime employeeStartTime, DateTime employeeEndTime, string employeeID) // took out employeeID
        {
            this.EmployeeID = employeeID;
            this.AvailabilityDay = availabilityDay;
            this.EmployeeStartTime = employeeStartTime;
            this.EmployeeEndTime = employeeEndTime;
            

        }// end of constructor

       



    }// end of class
}// end of namespace