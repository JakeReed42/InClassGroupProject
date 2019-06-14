using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Fall2018Group5MVC.Models
{

    public class Employee : ApplicationUser
    {
        
            public string EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        ApplicationUser ApplicationUser { get; set; }

        public int OfficeID { get; set; }
        [ForeignKey("OfficeID")]
        Office Office { get; set; }


        ////[Key]
        ////[Required]
        ////public int EmployeeID { get; set; }

        ////[Required]
        ////public string EmployeeFirstName { get; set; }

        ////[Required]
        ////public string EmployeeLastName { get; set; }

        ////[Required]
        ////public string EmployeePhone { get; set; }

        //[Required]
        //public string EmployeeAddress { get; set; }

        //// changed accrual and Pay rates to be doubles. Easier for computations on them and allows for decimals
        //[Required]
        //public double EmployeeAccrualRate { get; set; }

        //[Required]
        //public double EmployeePayRate { get; set; }

        //[Required]
        //public string EmployeeStartDate { get; set; }


        //public string EmployeeStopDate { get; set; }

        // added managerID can be null (for managers) other option is child table... see how this runs first. 
        // how do we make this a foriegn key so that it has to reference a previous EmployeeID?
        // [Required]
        //public int? ManagerID { get; set; }
        //[ForeignKey("ManagerID")]
        //public Employee Manager { get; set; }


        //Constructor
        public Employee(string firstname, string lastname, string address, double accrualRate,
            double? salary, double? hourlyPayRate, DateTime startDate, DateTime? stopDate,
            string email, string phone, string password, int officeID):
        
          base( firstname,  lastname,  address,  accrualRate,
            salary,  hourlyPayRate,  startDate,  stopDate,
             email, phone,  password)
        {
           
          
            this.EmployeeID = this.Id;
            this.OfficeID = officeID;
           


        }
        public Employee()
        {
        }

        public static List<Employee> PopulateEmployees() // used to enter data into the Employee Table. 
        {

            List<Employee> employeeList = new List<Employee>();

            Employee employee = new Employee("Mike","Messenger", "252 Overlook Road, Grafton WV 26304", 15, null, 20, 
                new DateTime(2016, 05, 07), null,  "MikeyMessanger@plswork", "304-677-7777", "Password1", 1);
            // need to enter 
            employeeList.Add(employee); // adds the first employee to the list of employee

            employee = new Employee("Jazzie", "Casto", "123 Magnolia Lane, Bridgeport WV 26330", 8, null, 15, 
                new DateTime(2012, 12,20), null, "JazzieTheLoser@plswork", "304-203-2423", "JazziesPassword1", 2);
            employeeList.Add(employee);

            employee = new Employee("Steven", "Segull", "46 KungFu Drive, Morgantown WV 26501", 9.50, null, 18,
                new DateTime(2001-09-12), null, "FlockOfSegull@plswork", "800-226-9481","KarateDude1", 2);
            employeeList.Add(employee);

            return employeeList;
        }

    }//end class

}//end namespace
