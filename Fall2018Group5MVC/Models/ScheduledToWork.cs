using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class ScheduledToWork
    {
        [Key]
        [Required]
        public int ScheduledID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime ScheduledStartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime ScheduledEndTime { get; set; }

        [Required]
        public int HospitalRoleID { get; set; }
        [ForeignKey("HospitalRoleID")]
        public HospitalRole HospitalRole { get; set; }

        public ScheduledToWork() { }

        public ScheduledToWork(DateTime scheduledDate, DateTime scheduledStartTime, 
            DateTime scheduledEndTime, int hospitalRole)
        {
            this.ScheduledDate = scheduledDate;
            this.ScheduledStartTime = scheduledStartTime;
            this.ScheduledEndTime = scheduledEndTime;
            this.HospitalRoleID = hospitalRole;
        }

        public static List<ScheduledToWork> PopulateScheduledToWork()
        {
            List<ScheduledToWork> toWorkList = new List<ScheduledToWork>();

            ScheduledToWork scheduledToWork =
                new ScheduledToWork(new DateTime(2018, 12, 15), DateTime.Parse("9:00 AM"), DateTime.Parse("3:00 PM"), 1);
            toWorkList.Add(scheduledToWork);

            scheduledToWork = new ScheduledToWork(new DateTime(2018, 12, 15), DateTime.Parse("8:30 AM"), DateTime.Parse("3:30 PM"), 2);
            toWorkList.Add(scheduledToWork);

            scheduledToWork = new ScheduledToWork(new DateTime(2018, 12, 15), DateTime.Parse("10:00 AM"), DateTime.Parse("5:00 PM"), 9);
            toWorkList.Add(scheduledToWork);

            return toWorkList;
        }

    }
}
