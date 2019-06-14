using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class TimeClock
    {
        [Key]
        [Required]
        public int TimeClockID { get; set; }

        public DateTime TimeClockIn { get; set; }

        public DateTime TimeClockOut { get; set; }

        
        [Required]
        public string EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }



        public TimeClock()
        { }

        public TimeClock(DateTime timeClockIn, DateTime timeClockOut, string employeeID)
        {
            this.TimeClockIn = timeClockIn;
            this.TimeClockOut = timeClockOut;
            this.EmployeeID = employeeID;

        }

        public static List<TimeClock> PopulateTimeClocks()
        {

            List<TimeClock> clockList = new List<TimeClock>();

            //DateTime timeClockIn = DateTime.Parse("8:00 AM");
            //DateTime timeClockOut = DateTime.Parse("5:00 PM");



            //TimeClock clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("8:01 AM");
            //timeClockOut = DateTime.Parse("4:50 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("8:05 AM");
            //timeClockOut = DateTime.Parse("5:05 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            // timeClockIn = DateTime.Parse("8:03 AM");
            // timeClockOut = DateTime.Parse("5:10 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("8:02 AM");
            //timeClockOut = DateTime.Parse("5:02 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("8:06 AM");
            //timeClockOut = DateTime.Parse("4:58 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("7:50 AM");
            //timeClockOut = DateTime.Parse("4:30 PM");

            //clock = new TimeClock(timeClockIn, timeClockOut);
            //clockList.Add(clock);

            //timeClockIn = DateTime.Parse("8:00 AM");
            //timeClockOut = DateTime.Parse("5:30 PM");

            return clockList;

        }

    }
}
