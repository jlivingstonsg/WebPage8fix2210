using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class AddRemoveOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOrders_Orders_OrderId",
                table: "ComputerOrders");

            migrationBuilder.DropIndex(
                name: "IX_ComputerOrders_OrderId",
                table: "ComputerOrders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ComputerOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ComputerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOrders_OrderId",
                table: "ComputerOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOrders_Orders_OrderId",
                table: "ComputerOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
