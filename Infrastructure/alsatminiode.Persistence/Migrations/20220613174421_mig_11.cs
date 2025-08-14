using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HighPrice",
                table: "PhoneQuestions");

            migrationBuilder.DropColumn(
                name: "LowPrice",
                table: "PhoneQuestions");

            migrationBuilder.CreateTable(
                name: "PhoneCosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneQuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneCost = table.Column<short>(type: "smallint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneCosts_PhoneModels_phoneModelId",
                        column: x => x.phoneModelId,
                        principalTable: "PhoneModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PhoneCosts_PhoneQuestions_phoneQuestionId",
                        column: x => x.phoneQuestionId,
                        principalTable: "PhoneQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneCosts_phoneModelId",
                table: "PhoneCosts",
                column: "phoneModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneCosts_phoneQuestionId",
                table: "PhoneCosts",
                column: "phoneQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneCosts");

            migrationBuilder.AddColumn<long>(
                name: "HighPrice",
                table: "PhoneQuestions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LowPrice",
                table: "PhoneQuestions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
