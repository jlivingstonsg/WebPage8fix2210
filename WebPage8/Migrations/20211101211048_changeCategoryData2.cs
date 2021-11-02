using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class changeCategoryData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "f1394caf-e880-45be-ab9b-1e4f7d6a97de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "036c5033-2d73-4746-9504-929050fb5212");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "a9166162-238a-4a27-a2c3-d661e06dd018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6fa531c-8295-45e0-8d9d-2edc6c86e850", "f4f93861-4652-4ef2-b411-70b8806bcf9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15f8385f-a078-494e-a562-0836b50f2b1a", "e62e15ea-d977-47c0-ad53-b1eb31dedf25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1f93961-0ac0-4c64-9015-b969f6085832", "84c8c7d4-8536-4182-9a1f-573be3175c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ff85c77-54b0-4aa5-b820-5e906af1392b", "d7df77d1-4963-491e-9bc9-8d1532f465c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16739cc3-dce1-4b41-b255-6ab2090df1d2", "2fbd3f1a-e41e-4d49-939c-9ac2473952ba" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "966fff2a-652c-421a-9483-f83be78b4f53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "a6faea14-79d4-4b9a-ae2b-7b79948bbbd0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d7700-3ae8-11ec-8d3d-0242ac130003",
                column: "ConcurrencyStamp",
                value: "c246a541-1439-471f-a524-e5e1a3a16dd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c561858-387d-4116-8555-cddcdf67069d", "d43b7bc1-0590-4264-8070-1cce40b82ba5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f2fab7f-1a49-4106-996c-6d4e2d58cac3", "902d9a03-9c0a-4378-b9ac-527516408838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d303f8d-9fca-499b-942b-d4c722f24998", "1c0eb4c2-977b-4ee2-97fb-3a164d1bef43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d0be965-b923-4c21-8daf-61c5abefab6b", "5f06c74b-55d7-4b66-85f6-2d35aed73208" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "860156dd-b0e1-4912-ba6b-5a4bdc25e6fa", "ee3dce35-5ab4-46a6-9831-e9afceb29bef" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "Description",
                value: "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world. Customer support options place HP in the top five of all manufacturers.");
        }
    }
}
