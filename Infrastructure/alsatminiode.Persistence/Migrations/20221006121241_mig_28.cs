using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "customerShippingCompanyName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
    name: "customerRandomPassword",
    table: "Customers",
    type: "nvarchar(max)",
    nullable: false,
    defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customerShippingCompanyName",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "shippingCompanyName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
