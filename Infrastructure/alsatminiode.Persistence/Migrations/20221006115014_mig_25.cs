using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
               name: "shippingCompanies",
               columns: table => new
               {
                   Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_shippingCompanies", x => x.Id);
               });

            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reviewOffer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rewierDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isItApproved = table.Column<bool>(type: "bit", nullable: false),
                    shippingCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    trackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInfos_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomerInfos_shippingCompanies_shippingCompanyId",
                        column: x => x.shippingCompanyId,
                        principalTable: "shippingCompanies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfos_customerId",
                table: "CustomerInfos",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfos_shippingCompanyId",
                table: "CustomerInfos",
                column: "shippingCompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
