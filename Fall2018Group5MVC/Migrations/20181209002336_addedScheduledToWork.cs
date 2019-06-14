using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class addedScheduledToWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduledToWorks",
                columns: table => new
                {
                    ScheduledToWorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HospitalRoleID = table.Column<int>(nullable: false),
                    ScheduledDate = table.Column<DateTime>(nullable: false),
                    ScheduledEndTime = table.Column<DateTime>(nullable: false),
                    ScheduledStartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledToWorks", x => x.ScheduledToWorkID);
                    table.ForeignKey(
                        name: "FK_ScheduledToWorks_HospitalRoles_HospitalRoleID",
                        column: x => x.HospitalRoleID,
                        principalTable: "HospitalRoles",
                        principalColumn: "HospitalRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledToWorks_HospitalRoleID",
                table: "ScheduledToWorks",
                column: "HospitalRoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduledToWorks");
        }
    }
}
