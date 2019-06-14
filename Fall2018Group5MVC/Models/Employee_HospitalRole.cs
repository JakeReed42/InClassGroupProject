using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Employee_HospitalRole
    {

        [Key]
        public int Employee_HospitalRoleID { get; set; }

        public int HospitalRoleID { get; set; }
        public string EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }  

        [ForeignKey("HospitalRoleID")]
        public HospitalRole HospitalRole { get; set; }

        public Employee_HospitalRole()
        { }

        public Employee_HospitalRole(int hospitalroleID, string employeeID)
        {
            this.HospitalRoleID = hospitalroleID;
            this.EmployeeID = employeeID;
        }

        public static List<Employee_HospitalRole> PopulateEmployee_HospitalRoles()
        {
            List<Employee_HospitalRole> employee_HospitalRoleList = new List<Employee_HospitalRole>();

            return employee_HospitalRoleList;

        }
    }
}
