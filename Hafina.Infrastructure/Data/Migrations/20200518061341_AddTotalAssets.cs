using Microsoft.EntityFrameworkCore.Migrations;

namespace Hafina.Infrastructure.Data.Migrations
{
    public partial class AddTotalAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalAssets",
                table: "BalanceSheet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAssets",
                table: "BalanceSheet");
        }
    }
}
