using Fall2018Group5MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Data
{
    public class DbInitializer
    {
        public async static Task Initialize(IServiceProvider services)
        {
            var database = services.GetRequiredService<ApplicationDbContext>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

      

            // Avoids data re-entry
            if (!database.Offices.Any())
            {
                // Gets data 
                List<Office> officeList = Office.PopulateOffices();
                database.Offices.AddRange(officeList);
                database.SaveChanges();
            }

            // sets up list for data population
            List<Employee> employeeList = Employee.PopulateEmployees();
            List<ApplicationUser> appUserList = ApplicationUser.PopulateUsers();
            List<Manager> managerList = Manager.PopulateManager();
            

            
            // Setting up roles
            string roleEmployee = "Employee";
            string roleExecutive = "Executive";
            string roleManagement = "Manager";
            
            if (!database.Roles.Any())
            {
                IdentityRole role = new IdentityRole(roleExecutive);
                await roleManager.CreateAsync(role);

                role = new IdentityRole(roleEmployee);
                await roleManager.CreateAsync(role);

                role = new IdentityRole(roleManagement);
                await roleManager.CreateAsync(role);
            }

            if (!database.Users.Any())
            {
                foreach(ApplicationUser eachExecutive in appUserList)
                {
                    await userManager.CreateAsync(eachExecutive);
                    await userManager.AddToRoleAsync(eachExecutive, roleExecutive);
                }
            }

            if (!database.Managers.Any())
            {
                foreach (Manager eachManager in managerList)
                {
                    await userManager.CreateAsync(eachManager);
                    await userManager.AddToRoleAsync(eachManager, roleManagement);
                }
            }


            if (!database.Employees.Any())
            {
                // filling employees into roleEmployee
                foreach (Employee eachEmployee in employeeList)
                {
                    // userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    await userManager.CreateAsync(eachEmployee);
                    // userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    await userManager.AddToRoleAsync(eachEmployee, roleEmployee);


                }
            }


               // employee availability population
               if (!database.EmployeeAvailabilities.Any())
                {

                DateTime startTime = DateTime.Parse("10:00 AM");
                DateTime endTime = DateTime.Parse("10:00 PM");


                //List to get all employees from db for data population
                List<Employee> employees = database.Employees.ToList<Employee>();

                EmployeeAvailability employeeAvailability = new EmployeeAvailability("Monday", startTime, endTime, employees[0].EmployeeID);
                List<EmployeeAvailability> availabilityList = new List<EmployeeAvailability>();
                availabilityList.Add(employeeAvailability);

                startTime = DateTime.Parse("9:30 AM");  
                endTime = DateTime.Parse("8:30 PM");
                
                employeeAvailability = new EmployeeAvailability("Tuesday", startTime, endTime, employees[0].EmployeeID);
                availabilityList.Add(employeeAvailability);

                startTime = DateTime.Parse("8:30 AM");
                endTime = DateTime.Parse("10:00 PM");

                employeeAvailability = new EmployeeAvailability("Tuesday", startTime, endTime, employees[1].EmployeeID);
                availabilityList.Add(employeeAvailability);

                startTime = DateTime.Parse("9:30 AM");
                employeeAvailability = new EmployeeAvailability("Wednesday", startTime, endTime, employees[1].EmployeeID);
                availabilityList.Add(employeeAvailability);

                endTime = DateTime.Parse("6:00 PM");
                employeeAvailability = new EmployeeAvailability("Thursday", startTime, endTime, employees[2].EmployeeID);
                availabilityList.Add(employeeAvailability);

                database.EmployeeAvailabilities.AddRange(availabilityList);
                    database.SaveChanges();
                }


               // hospital role population
               if(!database.HospitalRoles.Any())
                {
                List<HospitalRole> hospitalRoleList = HospitalRole.PopulateHospitalRoles();
                database.HospitalRoles.AddRange(hospitalRoleList);
                database.SaveChanges();
                }
            
               // operating hour population
                if(!database.OperatingHours.Any())
                {
                List<OperatingHour> operatingHoursList = OperatingHour.PopulateOperatingHours();
                database.OperatingHours.AddRange(operatingHoursList);
                database.SaveChanges();
                }

                if(!database.OperatingHourExceptions.Any())
                {
                List<OperatingHourException> operatingHourExceptionList = OperatingHourException.PopulateOfficeHourExecption();
                database.OperatingHourExceptions.AddRange(operatingHourExceptionList);
                database.SaveChanges();
                }

                if(!database.Office_OperatingHourExceptions.Any())
                {
                List<Office_OperatingHourException> office_OperatingsList = Office_OperatingHourException.PopulateOffice_Operating();
                database.Office_OperatingHourExceptions.AddRange(office_OperatingsList);
                database.SaveChanges();
                }

            if (!database.TimeClocks.Any())
            {
                List<Employee> employees = database.Employees.ToList<Employee>();

                DateTime timeClockIn = DateTime.Parse("8:00 AM");
                DateTime timeClockOut = DateTime.Parse("5:00 PM");


                TimeClock clock = new TimeClock(timeClockIn, timeClockOut, employees[0].EmployeeID);
                List<TimeClock> clocks = new List<TimeClock>();
                clocks.Add(clock);

                clock = new TimeClock(timeClockIn, timeClockOut, employees[1].EmployeeID);
                clocks.Add(clock);

                clock = new TimeClock(timeClockIn, timeClockOut, employees[2].EmployeeID);
                clocks.Add(clock);

          
                database.TimeClocks.AddRange(clocks);
                database.SaveChanges();


                if (clocks[0].EmployeeID == null)
                {


                    clocks[0].EmployeeID = employees[0].EmployeeID;
                    database.TimeClocks.Update(clocks[0]);

                    clocks[1].EmployeeID = employees[1].EmployeeID;
                    database.TimeClocks.Update(clocks[1]);

                    clocks[2].EmployeeID = employees[2].EmployeeID;
                    database.TimeClocks.Update(clocks[2]);

                    clocks[3].EmployeeID = employees[3].EmployeeID;
                    database.TimeClocks.Update(clocks[3]);

                    clocks[0].EmployeeID = employees[1].EmployeeID;
                    database.TimeClocks.Update(clocks[0]);

                    clocks[2].EmployeeID = employees[3].EmployeeID;
                    database.TimeClocks.Update(clocks[2]);


                    database.SaveChanges();
                }

            }

            //if (!database.TimeClock_Employees.Any())
            //{
            //    //List to get all employees from db for data population
            //    List<Employee> employees = database.Employees.ToList<Employee>();

            //    List<TimeClock_Employee> clock_employeeList = new List<TimeClock_Employee>();

               

            //    TimeClock_Employee clock_employee = new TimeClock_Employee(1, employees[0].EmployeeID);
            //    clock_employeeList.Add(clock_employee);

            //    clock_employee = new TimeClock_Employee(1, employees[1].EmployeeID);
            //    clock_employeeList.Add(clock_employee);

            //    clock_employee = new TimeClock_Employee(2, employees[2].EmployeeID);
            //    clock_employeeList.Add(clock_employee);

            //    clock_employee = new TimeClock_Employee(3, employees[1].EmployeeID);
            //    clock_employeeList.Add(clock_employee);

            //    clock_employee = new TimeClock_Employee(2, employees[0].EmployeeID);
            //    clock_employeeList.Add(clock_employee);

            //    database.TimeClock_Employees.AddRange(clock_employeeList);
            //    database.SaveChanges();
            //}


            if(!database.StaffRequirements.Any())
            {
                List<StaffRequirement> staffRequirementList = StaffRequirement.PopulateStaffRequirement();
                database.StaffRequirements.AddRange(staffRequirementList);
                database.SaveChanges();
            }

           

            if (!database.ScheduledToWorks.Any())
            {
                List<ScheduledToWork> scheduledToWorkList = ScheduledToWork.PopulateScheduledToWork();
                database.ScheduledToWorks.AddRange(scheduledToWorkList);
                database.SaveChanges();
            }


            if (!database.Staff_Scheduleds.Any())
            {
                List<Staff_Scheduled> staff_ScheduledsList = Staff_Scheduled.PopulateStaff_Scheduled();
                database.Staff_Scheduleds.AddRange(staff_ScheduledsList);
                database.SaveChanges();

            }

            if(!database.RequestTypes.Any())
            {
                List<RequestType> requestTypesList = RequestType.PopulateRequestType();
                database.RequestTypes.AddRange(requestTypesList);
                database.SaveChanges();
            }

            if(!database.Requests.Any())
            {
                List<Employee> employees = database.Employees.ToList<Employee>();
                List<Manager> managers = database.Managers.ToList<Manager>();
                List<Request> requestList = Request.PopulateRequest();

                

                foreach(Request eachRequest in requestList)
                {
                    eachRequest.EmployeeID = employees[0].EmployeeID;
                    eachRequest.ManagerID = managers[0].ManagerID;

                    database.Requests.Update(eachRequest);
                    database.SaveChanges();
                }
                
               
                    
                database.Requests.AddRange(requestList);
                database.SaveChanges();

            }

            if(!database.RequestResponses.Any())
            {
                List<RequestResponse> requestResponsesList = RequestResponse.PopulateRequestResponse();
                database.RequestResponses.AddRange(requestResponsesList);
                database.SaveChanges();
            }

            if (!database.Employee_HospitalRoles.Any())
            {
                //List to get all employees from db for data population
                List<Employee> employees = database.Employees.ToList<Employee>();
                List<Employee_HospitalRole> employee_HospitalRoleList = Employee_HospitalRole.PopulateEmployee_HospitalRoles();


                Employee_HospitalRole employee_hospitalrole = new Employee_HospitalRole(1, employees[0].EmployeeID);
                employee_HospitalRoleList.Add(employee_hospitalrole);

                employee_hospitalrole = new Employee_HospitalRole(1, employees[1].EmployeeID);
                employee_HospitalRoleList.Add(employee_hospitalrole);

                employee_hospitalrole = new Employee_HospitalRole(2, employees[2].EmployeeID);
                employee_HospitalRoleList.Add(employee_hospitalrole);




                database.Employee_HospitalRoles.AddRange(employee_HospitalRoleList);
                database.SaveChanges();
            }


            if (!database.Employee_ScheduledToWorks.Any())
            {
                //List to get all employees from db for data population
                List<Employee> employees = database.Employees.ToList<Employee>();
                List<Employee_ScheduledToWork> employee_ScheduledToWorkList = Employee_ScheduledToWork.PopulateEmployee_ScheduledToWorks();


                Employee_ScheduledToWork employee_ScheduledToWork = new Employee_ScheduledToWork(1, employees[0].EmployeeID);
                employee_ScheduledToWorkList.Add(employee_ScheduledToWork);

                employee_ScheduledToWork = new Employee_ScheduledToWork(1, employees[0].EmployeeID);
                employee_ScheduledToWorkList.Add(employee_ScheduledToWork);

                employee_ScheduledToWork = new Employee_ScheduledToWork(2, employees[0].EmployeeID);
                employee_ScheduledToWorkList.Add(employee_ScheduledToWork);

                employee_ScheduledToWork = new Employee_ScheduledToWork(3, employees[0].EmployeeID);
                employee_ScheduledToWorkList.Add(employee_ScheduledToWork);

                employee_ScheduledToWork = new Employee_ScheduledToWork(1, employees[0].EmployeeID);
                employee_ScheduledToWorkList.Add(employee_ScheduledToWork);



                database.Employee_ScheduledToWorks.AddRange(employee_ScheduledToWorkList);
                database.SaveChanges();
            }

        }

    }//end of Intialize Method
     

    }// end of Class

// end of Namespace
