using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PhoneModelPhoneModelImageFile",
                columns: table => new
                {
                    phoneModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneModelImageFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneModelPhoneModelImageFile", x => new { x.phoneModelId, x.phoneModelImageFileId });
                    table.ForeignKey(
                        name: "FK_PhoneModelPhoneModelImageFile_Files_phoneModelImageFileId",
                        column: x => x.phoneModelImageFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneModelPhoneModelImageFile_PhoneModels_phoneModelId",
                        column: x => x.phoneModelId,
                        principalTable: "PhoneModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneModelPhoneModelImageFile_phoneModelImageFileId",
                table: "PhoneModelPhoneModelImageFile",
                column: "phoneModelImageFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneModelPhoneModelImageFile");

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
    }
}
