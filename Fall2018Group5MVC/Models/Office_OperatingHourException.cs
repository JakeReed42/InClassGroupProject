using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Office_OperatingHourException
    {
        [Key]
        [Required]
        public int Office_OperatingHourExecptionID { get; set; }

     
        public int OfficeID { get; set; }
        [ForeignKey("OfficeID")]
        public Office Office { get; set; }

        public int OperatingHourExceptionID { get; set; }
        [ForeignKey("OperatingHourExceptionID")]
        public OperatingHourException OperatingHourException { get; set; }
        public Office_OperatingHourException()
        { }

        public Office_OperatingHourException(int officeID, int exceptionID)
        {
            this.OfficeID = officeID;
            this.OperatingHourExceptionID = exceptionID;
        }

        public static List<Office_OperatingHourException> PopulateOffice_Operating()
        {
            List<Office_OperatingHourException> office_OperatingList = new List<Office_OperatingHourException>();

            Office_OperatingHourException office_Operating = new Office_OperatingHourException(1, 1);
            office_OperatingList.Add(office_Operating);

            office_Operating = new Office_OperatingHourException(2, 1);
            office_OperatingList.Add(office_Operating);

            office_Operating = new Office_OperatingHourException(3, 1);
            office_OperatingList.Add(office_Operating);

            office_Operating = new Office_OperatingHourException(4, 1);
            office_OperatingList.Add(office_Operating);

            office_Operating = new Office_OperatingHourException(2, 2);
            office_OperatingList.Add(office_Operating);

            return office_OperatingList;
        }// end of populate

    }// end class
}// end of namespace
