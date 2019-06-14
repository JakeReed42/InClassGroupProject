using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class addedEMployee_HospitalRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_HospitalRoles",
                columns: table => new
                {
                    Employee_HospitalRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<string>(nullable: true),
                    HospitalRoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_HospitalRoles", x => x.Employee_HospitalRoleID);
                    table.ForeignKey(
                        name: "FK_Employee_HospitalRoles_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_HospitalRoles_HospitalRoles_HospitalRoleID",
                        column: x => x.HospitalRoleID,
                        principalTable: "HospitalRoles",
                        principalColumn: "HospitalRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_HospitalRoles_EmployeeID",
                table: "Employee_HospitalRoles",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_HospitalRoles_HospitalRoleID",
                table: "Employee_HospitalRoles",
                column: "HospitalRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_HospitalRoles");
        }
    }
}
