using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class HospitalRole
    {
        [Key]
        [Required]
        public int HospitalRoleID { get; set; }

        [Required]
        public string HospitalRoleName { get; set; }


        public HospitalRole()
        { }

        public HospitalRole(string hospitalRoleName)
        {
            this.HospitalRoleName = hospitalRoleName;

        }// end of constructor

        public static List<HospitalRole> PopulateHospitalRoles()
        {
            // All the roles an Employee could be, sometimes the role may change for an employee
            List<HospitalRole> hospitalRolesList = new List<HospitalRole>();

            HospitalRole hospitalRole = new HospitalRole("Nurse");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Nurse Reception");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Check In");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Check Out");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole( "Call Center");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Medical Records");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Janitor");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("Maintenance");
            hospitalRolesList.Add(hospitalRole);

            hospitalRole = new HospitalRole("IT");
            hospitalRolesList.Add(hospitalRole);

            return hospitalRolesList;
        }

    }// end of class
}// end of namespace
