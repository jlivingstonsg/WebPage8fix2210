using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class AddReviwData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ComputerId", "CustomerId", "Rating", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, 5, "Bla bla bla" },
                    { 2, 2, 2, 3, "Bla bla bla" },
                    { 3, 3, 3, 5, "Bla bla bla" },
                    { 4, 4, 4, 3, "Bla bla bla" },
                    { 5, 1, 1, 1, "Bla bla bla" },
                    { 6, 2, 2, 1, "Bla bla bla" },
                    { 7, 3, 3, 4, "Bla bla bla" },
                    { 8, 4, 4, 2, "Bla bla bla" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
