using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                            name: "companyDealCode",
                            table: "shippingCompanies",
                            type: "nvarchar(max)",
                            nullable: false,
                            defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ShippingCompanyShippingCompanyImageFile",
                columns: table => new
                {
                    shippingCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    shippingCompanyImageFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingCompanyShippingCompanyImageFile", x => new { x.shippingCompanyId, x.shippingCompanyImageFileId });
                    table.ForeignKey(
                        name: "FK_ShippingCompanyShippingCompanyImageFile_Files_shippingCompanyImageFileId",
                        column: x => x.shippingCompanyImageFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ShippingCompanyShippingCompanyImageFile_shippingCompanies_shippingCompanyId",
                        column: x => x.shippingCompanyId,
                        principalTable: "shippingCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShippingCompanyShippingCompanyImageFile_shippingCompanyImageFileId",
                table: "ShippingCompanyShippingCompanyImageFile",
                column: "shippingCompanyImageFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
