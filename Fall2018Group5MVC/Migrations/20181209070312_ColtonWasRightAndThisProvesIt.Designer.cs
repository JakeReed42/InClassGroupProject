﻿// <auto-generated />
using Fall2018Group5MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Fall2018Group5MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181209070312_ColtonWasRightAndThisProvesIt")]
    partial class ColtonWasRightAndThisProvesIt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fall2018Group5MVC.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<double>("AccrualRate");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname");

                    b.Property<double?>("HourlyPayRate");

                    b.Property<string>("Lastname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<double?>("Salary");

                    b.Property<string>("SecurityStamp");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime?>("StopDate");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.EmployeeAvailability", b =>
                {
                    b.Property<int>("EmployeeAvailabilityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailabilityDay")
                        .IsRequired();

                    b.Property<DateTime>("EmployeeEndTime");

                    b.Property<string>("EmployeeID")
                        .IsRequired();

                    b.Property<DateTime>("EmployeeStartTime");

                    b.HasKey("EmployeeAvailabilityID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmployeeAvailabilities");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.HospitalRole", b =>
                {
                    b.Property<int>("HospitalRoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HospitalRoleName")
                        .IsRequired();

                    b.HasKey("HospitalRoleID");

                    b.ToTable("HospitalRoles");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Office", b =>
                {
                    b.Property<int>("OfficeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OfficeAddress")
                        .IsRequired();

                    b.Property<string>("OfficeName")
                        .IsRequired();

                    b.Property<string>("OfficePhoneNumber")
                        .IsRequired();

                    b.HasKey("OfficeID");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Office_OperatingHourException", b =>
                {
                    b.Property<int>("Office_OperatingHourExecptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OfficeID");

                    b.Property<int>("OperatingHourExceptionID");

                    b.HasKey("Office_OperatingHourExecptionID");

                    b.HasIndex("OfficeID");

                    b.HasIndex("OperatingHourExceptionID");

                    b.ToTable("Office_OperatingHourExceptions");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.OperatingHour", b =>
                {
                    b.Property<int>("OperatingHourID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OfficeID");

                    b.Property<string>("OperatingDay")
                        .IsRequired();

                    b.Property<DateTime>("OperatingEndTime");

                    b.Property<DateTime>("OperatingStartTime");

                    b.HasKey("OperatingHourID");

                    b.HasIndex("OfficeID");

                    b.ToTable("OperatingHours");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.OperatingHourException", b =>
                {
                    b.Property<int>("OperatingHourExceptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ExceptionComment");

                    b.Property<DateTime>("ExceptionDate");

                    b.HasKey("OperatingHourExceptionID");

                    b.ToTable("OperatingHourExceptions");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.ScheduledToWork", b =>
                {
                    b.Property<int>("ScheduledID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HospitalRoleID");

                    b.Property<DateTime>("ScheduledDate");

                    b.Property<DateTime>("ScheduledEndTime");

                    b.Property<DateTime>("ScheduledStartTime");

                    b.HasKey("ScheduledID");

                    b.HasIndex("HospitalRoleID");

                    b.ToTable("ScheduledToWorks");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Staff_Scheduled", b =>
                {
                    b.Property<int>("Staff_ScheduledID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ScheduledID");

                    b.Property<int>("StaffRequirementID");

                    b.HasKey("Staff_ScheduledID");

                    b.HasIndex("ScheduledID");

                    b.HasIndex("StaffRequirementID");

                    b.ToTable("Staff_Scheduleds");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.StaffRequirement", b =>
                {
                    b.Property<int>("StaffRequirementID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HospitalRoleID");

                    b.Property<int>("OfficeID");

                    b.Property<DateTime>("RequiredEndTime");

                    b.Property<DateTime>("RequiredStartTime");

                    b.Property<int>("StaffRequired");

                    b.HasKey("StaffRequirementID");

                    b.HasIndex("HospitalRoleID");

                    b.HasIndex("OfficeID");

                    b.ToTable("StaffRequirements");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.TimeClock", b =>
                {
                    b.Property<int>("TimeClockID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TimeClockIn");

                    b.Property<DateTime>("TimeClockOut");

                    b.HasKey("TimeClockID");

                    b.ToTable("TimeClocks");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.TimeClock_Employee", b =>
                {
                    b.Property<int>("TimeClock_EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmployeeID");

                    b.Property<int>("TimeClockID");

                    b.HasKey("TimeClock_EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TimeClockID");

                    b.ToTable("TimeClock_Employees");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Employee", b =>
                {
                    b.HasBaseType("Fall2018Group5MVC.Models.ApplicationUser");

                    b.Property<string>("EmployeeID");

                    b.ToTable("Employee");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Manager", b =>
                {
                    b.HasBaseType("Fall2018Group5MVC.Models.ApplicationUser");

                    b.Property<string>("ManagerID");

                    b.Property<int>("OfficeID");

                    b.ToTable("Manager");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.EmployeeAvailability", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Office_OperatingHourException", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2018Group5MVC.Models.OperatingHourException", "OperatingHourException")
                        .WithMany()
                        .HasForeignKey("OperatingHourExceptionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.OperatingHour", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.ScheduledToWork", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.HospitalRole", "HospitalRole")
                        .WithMany()
                        .HasForeignKey("HospitalRoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.Staff_Scheduled", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.ScheduledToWork", "ScheduledToWork")
                        .WithMany()
                        .HasForeignKey("ScheduledID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2018Group5MVC.Models.StaffRequirement", "StaffRequirement")
                        .WithMany()
                        .HasForeignKey("StaffRequirementID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.StaffRequirement", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.HospitalRole", "HospitalRole")
                        .WithMany()
                        .HasForeignKey("HospitalRoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2018Group5MVC.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fall2018Group5MVC.Models.TimeClock_Employee", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("Fall2018Group5MVC.Models.TimeClock", "TimeClock")
                        .WithMany()
                        .HasForeignKey("TimeClockID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Fall2018Group5MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Fall2018Group5MVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
