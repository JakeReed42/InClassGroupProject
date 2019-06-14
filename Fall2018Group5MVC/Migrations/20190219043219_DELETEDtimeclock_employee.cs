using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class DELETEDtimeclock_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeClock_Employees");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeID",
                table: "TimeClocks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TimeClocks_EmployeeID",
                table: "TimeClocks",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeClocks_AspNetUsers_EmployeeID",
                table: "TimeClocks",
                column: "EmployeeID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeClocks_AspNetUsers_EmployeeID",
                table: "TimeClocks");

            migrationBuilder.DropIndex(
                name: "IX_TimeClocks_EmployeeID",
                table: "TimeClocks");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "TimeClocks");

            migrationBuilder.CreateTable(
                name: "TimeClock_Employees",
                columns: table => new
                {
                    TimeClock_EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<string>(nullable: true),
                    TimeClockID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeClock_Employees", x => x.TimeClock_EmployeeID);
                    table.ForeignKey(
                        name: "FK_TimeClock_Employees_AspNetUsers_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeClock_Employees_TimeClocks_TimeClockID",
                        column: x => x.TimeClockID,
                        principalTable: "TimeClocks",
                        principalColumn: "TimeClockID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeClock_Employees_EmployeeID",
                table: "TimeClock_Employees",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeClock_Employees_TimeClockID",
                table: "TimeClock_Employees",
                column: "TimeClockID");
        }
    }
}
