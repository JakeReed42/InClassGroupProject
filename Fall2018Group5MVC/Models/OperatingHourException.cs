using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class OperatingHourException
    {
        [Key]
        [Required]
        public int OperatingHourExceptionID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ExceptionDate { get; set; }

        public string ExceptionComment { get; set; }

    public OperatingHourException()
        { }

    public OperatingHourException(DateTime exceptionDate, string comment)
        {
            this.ExceptionDate = exceptionDate;
            this.ExceptionComment = comment;
        }

    public static List<OperatingHourException> PopulateOfficeHourExecption()
        {
            List<OperatingHourException> operatingExceptionList = new List<OperatingHourException>();
            DateTime dateClosed = new DateTime (2018, 12, 25);

            OperatingHourException operatingHourException = new OperatingHourException(dateClosed, "Chirstmas");
            operatingExceptionList.Add(operatingHourException);

            dateClosed = new DateTime(2019, 01, 12);
            operatingHourException = new OperatingHourException(dateClosed, "Office repainting");
            operatingExceptionList.Add(operatingHourException);


            return operatingExceptionList;
        }

    }
}
