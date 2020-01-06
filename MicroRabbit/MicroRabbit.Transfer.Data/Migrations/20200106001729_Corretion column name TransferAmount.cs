using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class CorretioncolumnnameTransferAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrsnferAmount",
                table: "TranferLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "TransferAmount",
                table: "TranferLogs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferAmount",
                table: "TranferLogs");

            migrationBuilder.AddColumn<decimal>(
                name: "TrsnferAmount",
                table: "TranferLogs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
