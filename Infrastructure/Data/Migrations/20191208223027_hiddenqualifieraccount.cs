using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceApp.Infrastructure.Data.Migrations
{
    public partial class hiddenqualifieraccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Accounts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Accounts");
        }
    }
}
