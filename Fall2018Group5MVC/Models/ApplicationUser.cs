using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Fall2018Group5MVC.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }

        public double AccrualRate { get; set; }

        public double? Salary { get; set; }

        public double? HourlyPayRate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StopDate { get; set; }

        public ApplicationUser() { }

        //constructor method to construct objects of the class, no return type
        public ApplicationUser(string firstname, string lastname, string address, double accrualRate, 
            double? salary, double? hourlyPayRate, DateTime startDate, DateTime? stopDate, 
            string email, string phone, string password)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.AccrualRate = accrualRate;
            this.Salary = salary;
            this.HourlyPayRate = hourlyPayRate;
            this.StartDate = startDate;
            this.StopDate = stopDate;
            this.Email = email;
            this.PhoneNumber = phone;
            PasswordHasher<ApplicationUser> passwordHasher
                = new PasswordHasher<ApplicationUser>();
            this.PasswordHash = passwordHasher.HashPassword(this, password);

            this.SecurityStamp = Guid.NewGuid().ToString();
            this.UserName = email;
         

        }

        public static List<ApplicationUser> PopulateUsers()
        {

            List<ApplicationUser> listUsers = new List<ApplicationUser>();

           
            ApplicationUser applicationUser = new ApplicationUser("Test", "Executive1","2424 Place Drive", 25.00,
                60000, null, new DateTime(2005, 09, 07), null,
                "TestExecutive1@mix.wvu.edu", "304-444-4444", "TestExecutive1");
            listUsers.Add(applicationUser);

            applicationUser = new ApplicationUser("Test","Executive2","30 RockBottom Road", 17.00,
                70000, null, new DateTime(2001, 02, 03), null, "TestExecutive2@mix.wvu.edu",
                "304-498-3211", "TestExecutive2");
            listUsers.Add(applicationUser);

            return listUsers;

        }
    }
}
