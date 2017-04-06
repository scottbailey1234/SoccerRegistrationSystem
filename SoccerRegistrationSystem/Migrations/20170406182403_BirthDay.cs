using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerRegistrationSystem.Migrations
{
    public partial class BirthDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Persons");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Persons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Persons",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Persons",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Persons",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Persons",
                maxLength: 5,
                nullable: true);
        }
    }
}
