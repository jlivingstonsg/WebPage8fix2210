using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class AddApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "538dd5c8-1563-43b0-8a4c-cd496c4b3a52", "52d992c9-498f-46dc-9f96-ec38b2fe87e3", "Admin", "ADMIN" },
                    { "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a", "efaa47c3-5a45-4f75-98d0-fdb5d4f6e17b", "User", "USER" },
                    { "4334345c8-1311-32a0-aa4c-cd334c4e5a52", "09e7134d-9740-4b3b-8c50-f6923bdac293", "SuperAdmin", "SUPERADMIN" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4334345c8-1311-32a0-aa4c-cd334c4e5a52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "538dd5c8-1563-43b0-8a4c-cd496c4b3a52");

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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
