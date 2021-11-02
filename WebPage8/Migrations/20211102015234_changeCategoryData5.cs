using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class changeCategoryData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "fca0404b-90a9-4221-9050-82c661381348");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "f906437f-323e-4a11-bf10-b0f030d28305");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "eaf5560c-b391-4557-b30c-a3607bb416e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75357478-abcc-42b6-b2d6-7beeebe216d9", "75067566-e487-4a3f-bb1f-340c44c95f5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5f95895-37f0-4808-9dd0-37378e7bc6a2", "aa08b69d-384c-4155-bfda-463e993968c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6490c3c-b20a-4d29-b61f-6bcaf3da3121", "bdc5874f-6463-4c11-9805-3fc8cde44275" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "531d5eca-b25c-4ba1-8814-3520d3fd1da6", "3cb80b90-a9c6-4e12-a95a-2bba9aa0e96b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97f55461-fd60-4392-a28c-ebe0a502de49", "bc4e62c8-3df5-4b46-b4a1-7961bf7ed1f9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable computers.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "8f896ede-8b50-4a83-b7ab-452f296ec777");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "1b182b20-5166-466e-85d8-b720b9c3d675");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "2575ac0f-e118-4913-812b-7ae91982d699");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0244daa-ec76-4b66-9cff-5822d2cb9a4d", "f48dc2fc-d89c-4b4b-9957-2ec13ee116b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e0f3c91-4cbe-4b72-993f-422cfd2dfc43", "01eced53-6f2b-4a94-a902-386afa504a14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2756f5f8-39d9-4020-9704-caa4edd93622", "b7b75eb5-8711-4f9a-9751-09ff7b5b68c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fecb42c-2908-44e4-b85f-ee9a987d46b0", "3f60f009-bf6b-40da-a795-60ddd0fabf4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b656904a-07b1-4e94-bf24-f1752fd1e0eb", "a28fe303-27dc-4cc7-92d3-7a209be301d5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable laptop computers.");
        }
    }
}
