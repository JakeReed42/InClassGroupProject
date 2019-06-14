using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class updatedAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ScheduledToWorkID",
                table: "ScheduledToWorks",
                newName: "ScheduledID");

            migrationBuilder.RenameColumn(
                name: "DateRequired",
                table: "Office_StaffRequirements",
                newName: "Office_StaffDateRequired");

            migrationBuilder.AddColumn<int>(
                name: "Office_StaffAmountOfEmployeesRequired",
                table: "Office_StaffRequirements",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Office_StaffAmountOfEmployeesRequired",
                table: "Office_StaffRequirements");

            migrationBuilder.RenameColumn(
                name: "ScheduledID",
                table: "ScheduledToWorks",
                newName: "ScheduledToWorkID");

            migrationBuilder.RenameColumn(
                name: "Office_StaffDateRequired",
                table: "Office_StaffRequirements",
                newName: "DateRequired");
        }
    }
}
