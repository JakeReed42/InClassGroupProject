using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class ColtonWasRightAndThisProvesIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Office_StaffRequirements");

            migrationBuilder.AddColumn<int>(
                name: "OfficeID",
                table: "StaffRequirements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffRequired",
                table: "StaffRequirements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Staff_Scheduleds",
                columns: table => new
                {
                    Staff_ScheduledID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduledID = table.Column<int>(nullable: false),
                    StaffRequirementID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff_Scheduleds", x => x.Staff_ScheduledID);
                    table.ForeignKey(
                        name: "FK_Staff_Scheduleds_ScheduledToWorks_ScheduledID",
                        column: x => x.ScheduledID,
                        principalTable: "ScheduledToWorks",
                        principalColumn: "ScheduledID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Scheduleds_StaffRequirements_StaffRequirementID",
                        column: x => x.StaffRequirementID,
                        principalTable: "StaffRequirements",
                        principalColumn: "StaffRequirementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffRequirements_OfficeID",
                table: "StaffRequirements",
                column: "OfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Scheduleds_ScheduledID",
                table: "Staff_Scheduleds",
                column: "ScheduledID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Scheduleds_StaffRequirementID",
                table: "Staff_Scheduleds",
                column: "StaffRequirementID");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffRequirements_Offices_OfficeID",
                table: "StaffRequirements",
                column: "OfficeID",
                principalTable: "Offices",
                principalColumn: "OfficeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StaffRequirements_Offices_OfficeID",
                table: "StaffRequirements");

            migrationBuilder.DropTable(
                name: "Staff_Scheduleds");

            migrationBuilder.DropIndex(
                name: "IX_StaffRequirements_OfficeID",
                table: "StaffRequirements");

            migrationBuilder.DropColumn(
                name: "OfficeID",
                table: "StaffRequirements");

            migrationBuilder.DropColumn(
                name: "StaffRequired",
                table: "StaffRequirements");

            migrationBuilder.CreateTable(
                name: "Office_StaffRequirements",
                columns: table => new
                {
                    Office_StaffRequirementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfficeID = table.Column<int>(nullable: false),
                    Office_StaffAmountOfEmployeesRequired = table.Column<int>(nullable: false),
                    Office_StaffDateRequired = table.Column<DateTime>(nullable: false),
                    StaffRequirementID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office_StaffRequirements", x => x.Office_StaffRequirementID);
                });
        }
    }
}
