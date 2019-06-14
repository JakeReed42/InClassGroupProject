using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class OperatingHour
    {
        [Key]
        [Required]
        public int OperatingHourID { get; set; }

        [Required]
        public string OperatingDay { get; set; }


        [DataType(DataType.Time)]
        public DateTime OperatingStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime OperatingEndTime { get; set; }

        public int OfficeID { get; set; }
        [ForeignKey("OfficeID")]
        public Office Office { get; set; }

        public OperatingHour()
        { }

        public OperatingHour(string day, DateTime startTime, DateTime endTime, int office)
        {
            this.OperatingDay = day;
            this.OperatingStartTime = startTime;
            this.OperatingEndTime = endTime;
            this.OfficeID = office;

        }

        public static List<OperatingHour> PopulateOperatingHours()
        {

            List<OperatingHour> operatingHoursList = new List<OperatingHour>();

            DateTime startTime = DateTime.Parse("8:00 AM");
            DateTime endTime = DateTime.Parse("5:00 PM");

            OperatingHour operatingHours = new OperatingHour("Monday", startTime, endTime, 1);
            operatingHoursList.Add(operatingHours);

            startTime = DateTime.Parse("9:00 AM");
            endTime = DateTime.Parse("6:00 PM");

            operatingHours = new OperatingHour("Tuesday", startTime, endTime, 2);
            operatingHoursList.Add(operatingHours);

            operatingHours = new OperatingHour("Wednesday", startTime, endTime, 2);
            operatingHoursList.Add(operatingHours);

            operatingHours = new OperatingHour("Thursday", startTime, endTime, 2);
            operatingHoursList.Add(operatingHours);

            startTime = DateTime.Parse("9:00 AM");
            endTime = DateTime.Parse("12:00 PM");

            operatingHours = new OperatingHour("Friday", startTime, endTime, 2);
            operatingHoursList.Add(operatingHours);

            return operatingHoursList;
        }


    }//end of class
}// end of namespace
