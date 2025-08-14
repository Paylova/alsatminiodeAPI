using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneBrandPhoneBrandImageFile",
                columns: table => new
                {
                    phoneBrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneBrandImageFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBrandPhoneBrandImageFile", x => new { x.phoneBrandId, x.phoneBrandImageFileId });
                    table.ForeignKey(
                        name: "FK_PhoneBrandPhoneBrandImageFile_Files_phoneBrandImageFileId",
                        column: x => x.phoneBrandImageFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PhoneBrandPhoneBrandImageFile_PhoneBrands_phoneBrandId",
                        column: x => x.phoneBrandId,
                        principalTable: "PhoneBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneBrandPhoneBrandImageFile_phoneBrandImageFileId",
                table: "PhoneBrandPhoneBrandImageFile",
                column: "phoneBrandImageFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneBrandPhoneBrandImageFile");
        }
    }
}
