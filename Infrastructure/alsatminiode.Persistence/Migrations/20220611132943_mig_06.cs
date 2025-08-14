using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "modelPhoto",
                table: "PhoneModels");

            migrationBuilder.AddColumn<Guid>(
                name: "phoneModelId",
                table: "Files",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Files_phoneModelId",
                table: "Files",
                column: "phoneModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_PhoneModels_phoneModelId",
                table: "Files",
                column: "phoneModelId",
                principalTable: "PhoneModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_PhoneModels_phoneModelId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_phoneModelId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "phoneModelId",
                table: "Files");

            migrationBuilder.AddColumn<byte[]>(
                name: "modelPhoto",
                table: "PhoneModels",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
