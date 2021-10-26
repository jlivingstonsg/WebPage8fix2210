using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class AddShpingCartInComputerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "ComputerOrders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "ComputerOrders");
        }
    }
}
