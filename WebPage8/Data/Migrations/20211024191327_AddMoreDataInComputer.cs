using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class AddMoreDataInComputer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 5,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 6,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 7,
                column: "ImageUrl",
                value: "../images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 8,
                column: "ImageUrl",
                value: "../images/pro2.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 5,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 6,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 7,
                column: "ImageUrl",
                value: "images/pro2.png");

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 8,
                column: "ImageUrl",
                value: "images/pro2.png");
        }
    }
}
