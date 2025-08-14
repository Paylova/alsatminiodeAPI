using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "wesiteLogo",
                table: "WebsiteOptions",
                newName: "websiteLogo");

            migrationBuilder.AddColumn<Guid>(
                name: "districtCountryId",
                table: "Districts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Districts_districtCountryId",
                table: "Districts",
                column: "districtCountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Countries_districtCountryId",
                table: "Districts",
                column: "districtCountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Countries_districtCountryId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_districtCountryId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "districtCountryId",
                table: "Districts");

            migrationBuilder.RenameColumn(
                name: "websiteLogo",
                table: "WebsiteOptions",
                newName: "wesiteLogo");
        }
    }
}
