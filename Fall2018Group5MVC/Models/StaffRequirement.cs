using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class StaffRequirement
    {
        [Key]
        [Required]
        public int StaffRequirementID { get; set; }

        [DataType(DataType.Time)]
        public DateTime RequiredStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime RequiredEndTime { get; set; }

        [Required]
        public int StaffRequired { get; set; } 

        [Required]
        public int HospitalRoleID { get; set; }
        [ForeignKey("HospitalRoleID")]
        public HospitalRole HospitalRole { get; set; }

        [Required]
        public int OfficeID { get; set; }
        [ForeignKey("OfficeID")]
        public Office Office { get; set; }

        public StaffRequirement()
        { }

        public StaffRequirement(DateTime requiredStartTime, DateTime requiredEndTime,int staffRequired, int requiredRole, int officeID)
        {
            this.RequiredStartTime = requiredStartTime;
            this.RequiredEndTime = requiredEndTime;
            this.StaffRequired = staffRequired;
            this.HospitalRoleID = requiredRole;
            this.OfficeID = officeID;
        }

        public static List<StaffRequirement> PopulateStaffRequirement()
        {
            List<StaffRequirement> staffRequirementList = new List<StaffRequirement>();

            StaffRequirement staffRequirement =
                new StaffRequirement(DateTime.Parse("9:00 AM"), DateTime.Parse("3:00 PM"), 4, 1, 2);
            staffRequirementList.Add(staffRequirement);

            staffRequirement = new StaffRequirement(DateTime.Parse("8:30 AM"), DateTime.Parse("3:30 PM"), 2, 7, 1);
            staffRequirementList.Add(staffRequirement);

            staffRequirement = new StaffRequirement(DateTime.Parse("10:00 AM"), DateTime.Parse("5:00 PM"), 1, 9, 3);
            staffRequirementList.Add(staffRequirement);

            return staffRequirementList;
        }

    }
}
