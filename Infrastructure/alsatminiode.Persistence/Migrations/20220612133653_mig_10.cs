using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "websiteLogo",
                table: "WebsiteOptions");

            migrationBuilder.DropColumn(
                name: "modelIsActive",
                table: "PhoneModels");

            migrationBuilder.DropColumn(
                name: "districtIsActive",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "countryIsActive",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "cityIsActive",
                table: "Cities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "websiteLogo",
                table: "WebsiteOptions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<bool>(
                name: "modelIsActive",
                table: "PhoneModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "districtIsActive",
                table: "Districts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "countryIsActive",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "cityIsActive",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
