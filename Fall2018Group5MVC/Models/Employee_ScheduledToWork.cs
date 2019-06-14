using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Employee_ScheduledToWork
    {

        [Key]

        public int Employee_ScheduledToWorkID { get; set; }

        public int Status { get; set; }

        public int ScheduledToWorkID { get; set; }

        [ForeignKey("ScheduledToWorkID")]
        public ScheduledToWork ScheduledToWork { get; set; }

        public string EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }


        public Employee_ScheduledToWork()
        { }

        public Employee_ScheduledToWork(int scheduledToWorkID, string employeeID)
        {
            this.ScheduledToWorkID = scheduledToWorkID;
            this.EmployeeID = employeeID;
        }


        public static List<Employee_ScheduledToWork> PopulateEmployee_ScheduledToWorks()
        {
            List<Employee_ScheduledToWork> employee_ScheduledToWorkList = new List<Employee_ScheduledToWork>();



            return employee_ScheduledToWorkList;

        }
    }
}
