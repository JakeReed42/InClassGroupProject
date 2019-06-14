using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Manager : ApplicationUser
    {
        public string ManagerID { get; set; }
        
        [ForeignKey("ManagerID")]
        ApplicationUser ApplicationUser { get; set; }

        public int OfficeID { get; set; }
        [ForeignKey("OfficeID")]
        Office Office { get; set; }

        public Manager(string firstname, string lastname, string address, double accrualRate,
           double? salary, double? hourlyPayRate, DateTime startDate, DateTime? stopDate,
           string email, string phone, string password, int officeID) :

         base(firstname, lastname, address, accrualRate,
           salary, hourlyPayRate, startDate, stopDate,
            email, phone, password)

        {
          this.ManagerID = this.Id;
            this.OfficeID = officeID;
                       
        }

        public Manager() { }

        public static List<Manager> PopulateManager()
        {
            List<Manager> managerList = new List<Manager>();

            Manager manager = new Manager("Test", "Manager", "1738 Manger Island", 12, 35000, null, 
                new DateTime(2009,04,07), null, "TestManager@PlsWork", "682-4418-9761", "TestManager", 1);
            managerList.Add(manager);

            manager = new Manager("Kanye", "West", "Big House Lane", 15, 35000, null,
                new DateTime(2007, 07, 21), null, "BestWest@PlsWork", "888-569-7747", "WestManager", 3);
            managerList.Add(manager);

            return managerList;
        }
    }
}
