using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Staff_Scheduled
    {
        [Key]
        [Required]
        public int Staff_ScheduledID { get; set; }



        [Required]
        public int ScheduledID { get; set; }
        [ForeignKey("ScheduledID")]
        public ScheduledToWork ScheduledToWork { get; set; }

        [Required]
        public int StaffRequirementID { get; set; }
        [ForeignKey("StaffRequirementID")]
        public StaffRequirement StaffRequirement { get; set; }

        public Staff_Scheduled()
        { }

        public Staff_Scheduled(int scheduledID, int staffRequirementID)
        {
         
            this.ScheduledID = scheduledID;
            this.StaffRequirementID = staffRequirementID;

        }

        public static List<Staff_Scheduled> PopulateStaff_Scheduled()
        {
            List<Staff_Scheduled> staff_ScheduledList = new List<Staff_Scheduled>();

            Staff_Scheduled staff_Scheduled = new Staff_Scheduled(1, 2);
            staff_ScheduledList.Add(staff_Scheduled);

            staff_Scheduled = new Staff_Scheduled(2, 1);
            staff_ScheduledList.Add(staff_Scheduled);

            staff_Scheduled = new Staff_Scheduled(3, 3);
            staff_ScheduledList.Add(staff_Scheduled);

            return staff_ScheduledList;
        }

    }
}
