using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneQuestions_Customers_CustomerId",
                table: "PhoneQuestions");

            migrationBuilder.DropIndex(
                name: "IX_PhoneQuestions_CustomerId",
                table: "PhoneQuestions");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PhoneQuestions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "PhoneQuestions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneQuestions_CustomerId",
                table: "PhoneQuestions",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneQuestions_Customers_CustomerId",
                table: "PhoneQuestions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
