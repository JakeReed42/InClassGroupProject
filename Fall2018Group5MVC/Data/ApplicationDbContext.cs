using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fall2018Group5MVC.Models;

namespace Fall2018Group5MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }// end method 

        public DbSet<Office> Offices { get; set; }

        public DbSet<Manager> Managers { get; set; }
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeAvailability> EmployeeAvailabilities { get; set; }

        public DbSet<HospitalRole> HospitalRoles { get; set; }

        public DbSet<OperatingHour> OperatingHours { get; set; }

        public DbSet<OperatingHourException> OperatingHourExceptions { get; set; } 

        public DbSet<Office_OperatingHourException> Office_OperatingHourExceptions { get; set; }

        public DbSet<TimeClock> TimeClocks { get; set; }

        public DbSet<StaffRequirement> StaffRequirements { get; set; }
                
        public DbSet<ScheduledToWork> ScheduledToWorks { get; set; }

        public DbSet<Staff_Scheduled> Staff_Scheduleds { get; set; }

        public DbSet<RequestType> RequestTypes { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<RequestResponse> RequestResponses { get; set; }

        public DbSet<Employee_HospitalRole> Employee_HospitalRoles { get; set; }

        public DbSet<Employee_ScheduledToWork> Employee_ScheduledToWorks { get; set; }
    }// end of class

}// end of namespace
