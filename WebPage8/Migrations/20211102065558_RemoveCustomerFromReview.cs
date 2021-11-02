using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class RemoveCustomerFromReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0948bea6-fb82-49c9-8cd8-fec213fe8e8a",
                column: "ConcurrencyStamp",
                value: "33bfec13-505f-4d93-9ac3-d1f995fd8d30");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                column: "ConcurrencyStamp",
                value: "1f82800b-2966-4e38-b44a-7de5bbd7602e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "901801d9-556c-4814-a094-829fd3342b14");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "773367d1-cff7-4725-9a92-353a3f635696", "AQAAAAEAACcQAAAAEAgfrsHjRBhWNcaIJvGBHfHGGSaTyQ+hU0m8LDNvn0xU1TtayQA7VqeBjdtECWaeGg==", "eb672dcb-9bde-44f4-af17-1d6f6fe929aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09749a28-8ce6-44da-b347-99ae89c6010f", "479be3c5-4305-44b3-85d8-267c9d07485f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca248b4-6be8-4eca-88c8-ae952f3be531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87fe92a3-7b2f-4bc4-a8f8-4291adc8bb82", "AQAAAAEAACcQAAAAEJmMvFG3K7eOtNtuXzWHxHjHHULWRTaw+agM5fGZbL6Mp1nB4cpq4VcHUZBkVEgbSw==", "6623436d-770b-4756-8793-3961165f912a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b76fa86-a244-4da9-b476-a2cac2e66272", "3fc20311-9119-4a03-b825-534a423edd59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040fa57f-a948-4a10-9efc-6cfa30547e15", "AQAAAAEAACcQAAAAEHZCdNUlFiKE+JysDOwp+MtPn0N/+xzY7DiiOv4hY5Z/PXZmkMGi6yc4SBTbCIPixA==", "5597e40c-831f-4083-8248-a9ddbc770831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "692a43bb-6921-44be-bae3-61e9bbd37a68", "963a8260-2396-4fcb-96d8-f111723a4c69" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8,
                column: "CustomerId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0948bea6-fb82-49c9-8cd8-fec213fe8e8a",
                column: "ConcurrencyStamp",
                value: "f4516149-a068-44f8-8cd9-b47a3ae7cbfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                column: "ConcurrencyStamp",
                value: "6bc2aa57-6acc-4fa8-b79c-fa2fe7a44107");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "da1bad01-e0a7-4f65-b91a-6d0fe4273c58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa5ef009-86e8-434c-a326-954f85f3044e", "AQAAAAEAACcQAAAAEANC8tsgvflfbRQLgMj8dyrUQA5GPPZhXaO2CEFHFP/ofTGd43dfiKSvmbXMM/Rw3A==", "7cd1d395-b755-47a0-86f1-d8ddd5367be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03e16f9f-fad7-402c-964a-a0b9a018cca1", "c8ed34dc-d391-4202-b6b3-82a54ad78e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca248b4-6be8-4eca-88c8-ae952f3be531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff8d651-6d9a-4e92-99a3-36338c5f23ae", "AQAAAAEAACcQAAAAEBjLAFaF3byTK1LPRuq1Vm2Pe7i7ebHRr3miXVk+3w2nPgovZNFlEMbJ+A32OdwrWw==", "a987c1f0-c55b-4fa1-afde-75a1d95d0b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "079719a2-ffd2-4110-b894-ee751d8c5c36", "ec6ca709-de93-45dc-9ecf-7b40c2cc943f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe92eb73-5c4e-40f1-a056-cfd8fe05d92c", "AQAAAAEAACcQAAAAEI/0liF4BFeraeF32Q90XgkSEHzfWE15Ft5igJS9VbVQMsJsjQj3zGs9yOdaASiCyQ==", "faef3438-b988-40ae-aea0-027dc9b185a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2229f4a1-b244-4f81-8064-af33d7614b4c", "758e993d-64dd-47f5-93b2-55879baf5092" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "CustomerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "CustomerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7,
                column: "CustomerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8,
                column: "CustomerId",
                value: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
