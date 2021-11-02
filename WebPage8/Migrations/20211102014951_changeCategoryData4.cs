using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class changeCategoryData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "Description",
                value: "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "57edd77c-5564-407d-8ff7-e11d363a3b8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "772a5a99-18cf-407c-bc2a-5fcabaf0e236");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "5ae1ca42-bb44-455b-b510-ff0823b76b94");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "263ce618-5843-47e9-9d6d-92492ce067d3", "9178eb6e-bc68-46c1-9ee1-6560183fbafa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ec1538d-6b9b-4d7b-acda-1978caf09261", "b7bc66a1-4396-47da-ae57-fe45f34f1063" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f749c816-b66c-4406-9c7b-9affca68c9ad", "127f4b43-9f9e-4cf4-85cb-6a85c4aa7585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "190cd746-0c1b-4876-8b27-cac1774c1e2d", "6d6cc6db-f11a-4f44-86c0-1d7a8591b7b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f592a85a-a3af-41d4-82ac-a0f9c135711a", "425952cb-edd7-4684-bf12-c560f2aa087e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Description",
                value: "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available. Featuring powerful specs, great battery life, and premium designs, Samsung devices are consistently cutting edge and high quality");
        }
    }
}
