using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hafina.Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Serilog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "xml", nullable: true),
                    LogEvent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serilog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BalanceSheet",
                columns: table => new
                {
                    BalanceSheetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAndCashEuivalents = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortTermFinancialInvestment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortTermAccountReceivables = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Inventory = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCurrentAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongTermAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongTermAccountReceivable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FixedAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommercialAdvantage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RealEstateInvestment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongTermFinacialInvestments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherLongTermAssets = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortTermLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongTermLiabilities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OwnersEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceSheet", x => x.BalanceSheetId);
                    table.ForeignKey(
                        name: "FK_BalanceSheet_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessResult",
                columns: table => new
                {
                    BusinessResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SalesOfGoodsAndServices = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeductibleRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetSalesOfGoodsAndServices = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CostOfGoodsSold = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GrossProfitOfGoodsAndServices = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RevenueFromFinancialActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinancialExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InterestExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitOrLossInJointVenturesOrAssociates = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SellingExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EnterpriseCostManagement = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetProfitFromBusinessActivities = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OtherProfits = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccountingProfitBeforeTax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrentCorporateIncomeTaxExpense = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeferredCorporateIncomeTaxExpense = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitAfterTaxCorporateIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BenefitsOfMinorityShareholders = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitAfterTaxOfTheParentCompany = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BasicEarningsPerShare = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeclineEarningsPerShare = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dividend = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessResult", x => x.BusinessResultId);
                    table.ForeignKey(
                        name: "FK_BusinessResult_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceSheet_CompanyId",
                table: "BalanceSheet",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessResult_CompanyId",
                table: "BusinessResult",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceSheet");

            migrationBuilder.DropTable(
                name: "BusinessResult");

            migrationBuilder.DropTable(
                name: "Serilog");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
