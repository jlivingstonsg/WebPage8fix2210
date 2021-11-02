using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class AddPaidColumnInComputerOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "ComputerOrders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "eca50994-acc7-4096-9010-ec9bdb22fc0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "91c72df3-b2ce-42c2-9748-2ccbed4dd4ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "48dabf1c-e066-4576-93ad-22116316a135");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05053058-d6e0-4089-abe6-ed55db76b42b", "deb8c1c0-869e-4e91-b938-f4aac368cdbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed2ba5b9-014b-4fcb-be2d-3fd94e14f688", "6214b798-4f05-4969-bf88-de3891217d26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5789b81-900a-4c17-bafa-0b0170915ba2", "4d9d60b9-93d6-43e1-ab72-44b87e6ee169" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f078b17a-f2e5-4b97-9f33-8251d51081d6", "62dc13dd-6c44-4380-bf08-71cc1a95962e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41350f0c-71fa-4d52-868e-68686aac5391", "c5d74b42-9b2a-4e9e-b591-172d468f6ab0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "ComputerOrders");

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
        }
    }
}
