using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Office
    {
        [Key]
        [Required]
        public int OfficeID { get; set; }

        [Required]
        public string OfficeName { get; set; }

        [Required]
        public string OfficeAddress { get; set; }

        [Required]
        public string OfficePhoneNumber { get; set; }

        //Constructor
        public Office(string officeName, string officeAddress, string officePhoneNumber)
        {
            this.OfficeName = officeName;
            this.OfficeAddress = officeAddress;
            this.OfficePhoneNumber = officePhoneNumber;
        }

        public Office() // secondary that is required. 
        {


        }

        public static List<Office> PopulateOffices() // used to enter data into the Office Table. 
        {
            
            List<Office> officeList = new List<Office>();

            Office office = new Office("Bridgeport", "120 Medical Park Dr. Bridgeport, WV - 26330", "304-624-7200"); // need to enter OfficeName, Address, and Phone# (in that order)
            officeList.Add(office); // adds the first office to the list of offices

            office = new Office("Morgantown", "165 Scott Ave. Morgantown, WV 26505", "304-554-0440"); 
            // ^ this allows for the second office to be entered and overwrite old office which is in the list (rinse and repeat)
            officeList.Add(office);

            office = new Office("Woofter Family Medicine", "1664 East Pike St. Clarksburg, WV 26301", "304-709-7000");
            officeList.Add(office);

            office = new Office("Elkins", "100 Seneca Road, Elkins, WV 26241", "304-637-2777");
            officeList.Add(office);

            return officeList;
        }

    }// end of class 

}// end of Namespace
