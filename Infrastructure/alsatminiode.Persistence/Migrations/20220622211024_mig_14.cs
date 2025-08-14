using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_14 : Migration
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

            migrationBuilder.AddColumn<Guid>(
                name: "phoneBrandId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "phoneModelId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_phoneBrandId",
                table: "Customers",
                column: "phoneBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_phoneModelId",
                table: "Customers",
                column: "phoneModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PhoneBrands_phoneBrandId",
                table: "Customers",
                column: "phoneBrandId",
                principalTable: "PhoneBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PhoneModels_phoneModelId",
                table: "Customers",
                column: "phoneModelId",
                principalTable: "PhoneModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PhoneBrands_phoneBrandId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PhoneModels_phoneModelId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_phoneBrandId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_phoneModelId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "phoneBrandId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "phoneModelId",
                table: "Customers");

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
