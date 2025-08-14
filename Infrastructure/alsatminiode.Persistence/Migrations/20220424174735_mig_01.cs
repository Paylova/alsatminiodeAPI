using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alsatminiode.Persistence.Migrations
{
    public partial class mig_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    adminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminGSM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adminMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    adminLastSign = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    countryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    countryIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneSituations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneSituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneSituations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    mailHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mailUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mailPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mailPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mailReplyMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    giftCouponRate = table.Column<float>(type: "real", nullable: false),
                    wesiteLogo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityIsActive = table.Column<bool>(type: "bit", nullable: false),
                    cityCountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_cityCountryId",
                        column: x => x.cityCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    modelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelIsActive = table.Column<bool>(type: "bit", nullable: false),
                    modelFirstPrice = table.Column<int>(type: "int", nullable: false),
                    modelLastPrice = table.Column<int>(type: "int", nullable: false),
                    modelPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    modelBrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneModels_PhoneBrands_modelBrandId",
                        column: x => x.modelBrandId,
                        principalTable: "PhoneBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    districtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    districtIsActive = table.Column<bool>(type: "bit", nullable: false),
                    districtCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_districtCityId",
                        column: x => x.districtCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowPrice = table.Column<long>(type: "bigint", nullable: false),
                    HighPrice = table.Column<long>(type: "bigint", nullable: false),
                    PhoneModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneQuestions_PhoneModels_PhoneModelId",
                        column: x => x.PhoneModelId,
                        principalTable: "PhoneModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerGSM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhoneIMEI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerIBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhoneDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPaymentChoose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerTotalCost = table.Column<int>(type: "int", nullable: false),
                    customerPhoneCost = table.Column<int>(type: "int", nullable: false),
                    customerCountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerDistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    customerPhoneSituationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_customerCityId",
                        column: x => x.customerCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_customerCountryId",
                        column: x => x.customerCountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customers_Districts_customerDistrictId",
                        column: x => x.customerDistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customers_PhoneSituations_customerPhoneSituationId",
                        column: x => x.customerPhoneSituationId,
                        principalTable: "PhoneSituations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_cityCountryId",
                table: "Cities",
                column: "cityCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerCityId",
                table: "Customers",
                column: "customerCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerCountryId",
                table: "Customers",
                column: "customerCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerDistrictId",
                table: "Customers",
                column: "customerDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_customerPhoneSituationId",
                table: "Customers",
                column: "customerPhoneSituationId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_districtCityId",
                table: "Districts",
                column: "districtCityId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneModels_modelBrandId",
                table: "PhoneModels",
                column: "modelBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneQuestions_PhoneModelId",
                table: "PhoneQuestions",
                column: "PhoneModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PhoneQuestions");

            migrationBuilder.DropTable(
                name: "WebsiteOptions");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "PhoneSituations");

            migrationBuilder.DropTable(
                name: "PhoneModels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "PhoneBrands");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
