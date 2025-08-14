using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneModelCapacity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneModelCapacityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneModelCapacityPrice = table.Column<int>(type: "int", nullable: false),
                    phoneModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneModelCapacity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneModelCapacity_PhoneModels_phoneModelId",
                        column: x => x.phoneModelId,
                        principalTable: "PhoneModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneModelCapacity_phoneModelId",
                table: "PhoneModelCapacity",
                column: "phoneModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneModelCapacity");
        }
    }
}
