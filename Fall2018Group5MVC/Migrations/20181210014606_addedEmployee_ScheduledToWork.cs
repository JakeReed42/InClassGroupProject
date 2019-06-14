using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class addedEmployee_ScheduledToWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_ScheduledToWorks",
                columns: table => new
                {
                    Employee_ScheduledToWorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<string>(nullable: true),
                    ScheduledToWorkID = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_ScheduledToWorks", x => x.Employee_ScheduledToWorkID);
                    table.ForeignKey(
                        name: "FK_Employee_ScheduledToWorks_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_ScheduledToWorks_ScheduledToWorks_ScheduledToWorkID",
                        column: x => x.ScheduledToWorkID,
                        principalTable: "ScheduledToWorks",
                        principalColumn: "ScheduledID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ScheduledToWorks_EmployeeID",
                table: "Employee_ScheduledToWorks",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ScheduledToWorks_ScheduledToWorkID",
                table: "Employee_ScheduledToWorks",
                column: "ScheduledToWorkID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_ScheduledToWorks");
        }
    }
}
