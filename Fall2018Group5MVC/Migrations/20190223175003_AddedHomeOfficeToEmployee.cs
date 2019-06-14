using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fall2018Group5MVC.Migrations
{
    public partial class AddedHomeOfficeToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OfficeID",
                table: "AspNetUsers",
                newName: "Manager_OfficeID");

            migrationBuilder.AddColumn<int>(
                name: "OfficeID",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Manager_OfficeID",
                table: "AspNetUsers",
                newName: "OfficeID");
        }
    }
}
