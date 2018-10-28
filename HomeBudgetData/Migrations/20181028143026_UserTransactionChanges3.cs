using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeBudgetData.Migrations
{
    public partial class UserTransactionChanges3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
