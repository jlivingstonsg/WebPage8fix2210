using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class New1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fc4ad81-7585-4e8a-b782-d1fa339cbd94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f873b4e-9e0a-4457-81fd-3a1201908d5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20a4e501-ac20-4e2b-9fc2-ae8da57b57e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a464b29e-7ad5-4de0-bdf5-4773c25a5939");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a",
                column: "ConcurrencyStamp",
                value: "2858b08a-f39d-4e09-a2a8-89ef0e78c31e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4334345c8-1311-32a0-aa4c-cd334c4e5a52",
                column: "ConcurrencyStamp",
                value: "06a56ba2-806f-4315-a45e-80560d19fbed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "538dd5c8-1563-43b0-8a4c-cd496c4b3a52",
                column: "ConcurrencyStamp",
                value: "4eb383dc-3ee8-4384-af8c-dc31aab7c988");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "05bff8a9-6631-47f9-b943-365dc71ea489", 0, "9b9fb3f6-bfdc-4430-b017-92fdc621c448", "ApplicationUser", "Super@gmail.com", false, false, null, null, null, "Abc123+", null, false, "73e29040-c9e3-4937-a9b1-f2c874e94caf", false, null, "Jonan", "Eriksson" },
                    { "a79321df-cdae-40b9-bece-d2286b5f6381", 0, "bbe7b047-328a-40e4-a6ca-9bd7f5068557", "ApplicationUser", "Admin1@gmail.com", false, false, null, null, null, "Abc123+", null, false, "cbdbf6dd-0faa-4642-ad52-e6e902d78d42", false, null, "Admin1", "Adminsson" },
                    { "118ac7d8-c872-48ef-8729-d70ca7b9ae66", 0, "5b5486bd-7438-4276-a4c4-de0d068fb235", "ApplicationUser", "Admin2@gmail.com", false, false, null, null, null, "Abc123+", null, false, "233cadf5-958f-4b70-80bb-ba2f82e73f02", false, null, "Admin2", "Adminsson" },
                    { "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba", 0, "47fe63fd-7618-456f-ba90-1138a4d6db9c", "ApplicationUser", "SuperAdmin@gmail.com", false, false, null, null, null, "Abc123+", null, false, "4f36aea9-0579-43ee-bf9a-b48e54017f2b", false, null, "SuperAdmin", "Adminsson" },
                    { "b6c6c801-2576-4d85-9fea-3028c55b1f01", 0, "a6d4a99e-ef3a-4542-a313-b0c477ba46ad", "ApplicationUser", "User@gmail.com", false, false, null, null, null, "Abc123+", null, false, "ff448562-e0d7-4166-91aa-e2748b3c5f16", false, null, "User", "Userson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a",
                column: "ConcurrencyStamp",
                value: "efaa47c3-5a45-4f75-98d0-fdb5d4f6e17b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4334345c8-1311-32a0-aa4c-cd334c4e5a52",
                column: "ConcurrencyStamp",
                value: "09e7134d-9740-4b3b-8c50-f6923bdac293");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "538dd5c8-1563-43b0-8a4c-cd496c4b3a52",
                column: "ConcurrencyStamp",
                value: "52d992c9-498f-46dc-9f96-ec38b2fe87e3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20a4e501-ac20-4e2b-9fc2-ae8da57b57e0", 0, "ecf0e609-824a-4566-9b55-87d4294657cb", "ApplicationUser", "Super@gmail.com", false, false, null, null, null, "Abc123+", null, false, "724e6f1b-2115-499b-b3c4-94d986414678", false, "Jonan" },
                    { "a464b29e-7ad5-4de0-bdf5-4773c25a5939", 0, "9dc378aa-1535-4b14-b75f-b03592df5eed", "ApplicationUser", "Admin1@gmail.com", false, false, null, null, null, "Abc123+", null, false, "47936114-a462-401c-8551-1cee15bdf553", false, "Admin1" },
                    { "1f873b4e-9e0a-4457-81fd-3a1201908d5d", 0, "6f79f2c2-a2cd-4ce8-bd73-38c28dfecf80", "ApplicationUser", "Admin2@gmail.com", false, false, null, null, null, "Abc123+", null, false, "f23b2826-10be-44be-8211-052b6b041cb7", false, "Admin2" },
                    { "0fc4ad81-7585-4e8a-b782-d1fa339cbd94", 0, "62157d15-25a2-463c-9595-7770391c9846", "ApplicationUser", "User@gmail.com", false, false, null, null, null, "Abc123+", null, false, "da959221-aa04-4c99-8237-4ed604bbe961", false, "User" }
                });
        }
    }
}
