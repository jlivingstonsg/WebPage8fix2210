﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    ComputerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Processor = table.Column<string>(nullable: true),
                    RAM = table.Column<string>(nullable: true),
                    HardDisk = table.Column<string>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.ComputerId);
                    table.ForeignKey(
                        name: "FK_Computers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    OrderFullfilled = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerOrders",
                columns: table => new
                {
                    ComputerOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    Paid = table.Column<bool>(nullable: false),
                    ComputerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerOrders", x => x.ComputerOrderId);
                    table.ForeignKey(
                        name: "FK_ComputerOrders_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    ComputerId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Computers_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computers",
                        principalColumn: "ComputerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "438db5c8-0513-43a0-a84c-cd416c4e3a54", "6bc2aa57-6acc-4fa8-b79c-fa2fe7a44107", "Admin", "ADMIN" },
                    { "0948bea6-fb82-49c9-8cd8-fec213fe8e8a", "f4516149-a068-44f8-8cd9-b47a3ae7cbfd", "User", "USER" },
                    { "731d7700-3ae8-11ec-8d3d-0242ac130003", "da1bad01-e0a7-4f65-b91a-6d0fe4273c58", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "2ca248b4-6be8-4eca-88c8-ae952f3be531", 0, "3ff8d651-6d9a-4e92-99a3-36338c5f23ae", "ApplicationUser", "admin@admin.com", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBjLAFaF3byTK1LPRuq1Vm2Pe7i7ebHRr3miXVk+3w2nPgovZNFlEMbJ+A32OdwrWw==", null, false, "a987c1f0-c55b-4fa1-afde-75a1d95d0b89", false, "admin@gmail.com", "Joe", "Jonasson" },
                    { "05bff8a9-6631-47f9-b943-365dc71ea489", 0, "aa5ef009-86e8-434c-a326-954f85f3044e", "ApplicationUser", "superAdmin@gmail.com", false, false, null, null, "SUPERADMIN", "AQAAAAEAACcQAAAAEANC8tsgvflfbRQLgMj8dyrUQA5GPPZhXaO2CEFHFP/ofTGd43dfiKSvmbXMM/Rw3A==", null, false, "7cd1d395-b755-47a0-86f1-d8ddd5367be5", false, "superAdmin@gmail.com", "Jonan", "Eriksson" },
                    { "b6c6c801-2576-4d85-9fea-3028c55b1f01", 0, "fe92eb73-5c4e-40f1-a056-cfd8fe05d92c", "ApplicationUser", "user@gmail.com", false, false, null, null, "USER", "AQAAAAEAACcQAAAAEI/0liF4BFeraeF32Q90XgkSEHzfWE15Ft5igJS9VbVQMsJsjQj3zGs9yOdaASiCyQ==", null, false, "faef3438-b988-40ae-aea0-027dc9b185a6", false, "user@gmail.com", "user", "Userson" },
                    { "118ac7d8-c872-48ef-8729-d70ca7b9ae66", 0, "03e16f9f-fad7-402c-964a-a0b9a018cca1", "ApplicationUser", "Admin1@gmail.com", false, false, null, null, null, "Abc123+", null, false, "c8ed34dc-d391-4202-b6b3-82a54ad78e45", false, null, "Admin1", "Adminsson" },
                    { "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba", 0, "2229f4a1-b244-4f81-8064-af33d7614b4c", "ApplicationUser", "Admin2@gmail.com", false, false, null, null, null, "Abc123+", null, false, "758e993d-64dd-47f5-93b2-55879baf5092", false, null, "Admin2", "Adminsson" },
                    { "a79321df-cdae-40b9-bece-d2286b5f6381", 0, "079719a2-ffd2-4110-b894-ee751d8c5c36", "ApplicationUser", "SuperAdmin@gmail.com", false, false, null, null, null, "Abc123+", null, false, "ec6ca709-de93-45dc-9ecf-7b40c2cc943f", false, null, "SuperAdmin", "Adminsson" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "BrandUrl", "Description", "Name" },
                values: new object[,]
                {
                    { 6, "images/Brand/asus.png", "ASUS is a good and reputable brand, the brand is well-known for its optimized performance with the lowest computer specifications. In the fiercely competitive market for computing and hand-held devices", "Asus" },
                    { 5, "images/Brand/dell.png", "ASUS is a good and reputable brand, the brand is well-known for its optimized performance with the lowest computer specifications. In the fiercely competitive market for computing and hand-held devices", "DELL" },
                    { 4, "images/Brand/Hp.png", "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world", "Hp" },
                    { 1, "images/Brand/acer.jpg", "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable computers.", "Acer" },
                    { 2, "images/Brand/samsung.jpg", "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available.", "Samsung" },
                    { 3, "images/Brand/Lenovo.jfif", "Lenovo is truly an excellent brand to get for your laptop needs! They offer proven and tested reliability for their laptops, and also an amazing value at every price for every user.", "Lenovo" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "Country", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 4, "Uppsala", "Sweden", "aa@a.gmail.com", "Seong", "Gi-hun", "+33345678919", "123", "bbb" },
                    { 1, "Goteborg", "Sweden", "za@a.gmail.com", "Wei", "C", "+12345678919", "888", "Möland" },
                    { 2, "Skåne", "Sweden", "ya@a.gmail.com", "Magnus", "I", "+12345678919", "", "aaa" },
                    { 3, "Skövde", "Sweden", "xa@a.gmail.com", "Muzdalifa", "I", "+99345678919", "123", "Frostaliden" },
                    { 5, "Skövde", "Sweden", "ba@a.gmail.com", "Kang ", "Sae-Byeok", "+12345678919", "345", "Hjo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "2ca248b4-6be8-4eca-88c8-ae952f3be531", "438db5c8-0513-43a0-a84c-cd416c4e3a54" },
                    { "05bff8a9-6631-47f9-b943-365dc71ea489", "731d7700-3ae8-11ec-8d3d-0242ac130003" },
                    { "b6c6c801-2576-4d85-9fea-3028c55b1f01", "0948bea6-fb82-49c9-8cd8-fec213fe8e8a" }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "ComputerId", "CategoryId", "HardDisk", "ImageUrl", "Name", "Price", "Processor", "RAM", "ScreenSize", "SystemType" },
                values: new object[,]
                {
                    { 19, 3, " 512 GB SSD-lagring", "../images/Brand/Lenovo5.jpg", "Lenovo IdeaPad Gaming 3  ", 9490m, "AMD Ryzen™ 5 4600H-processor ", "8 GB DDR4 RAM ", " 15.6", "Windows 10 Home " },
                    { 20, 3, "512 GB", "../images/Brand/Lenovo6.jpg", "Lenovo IdeaPad 3 14ITL6 ", 7990m, "Intel Core i5 ", "8 GB", "14, ", "Windows 10 Home" },
                    { 10, 4, "", "../images/pro2.png", "G", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 11, 4, "", "../images/pro2.png", "H", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 21, 4, "512 GB SSD", "../images/Brand/HP3.jpg", "HP Pavilion Gaming 15-ec2823no", 11490m, "AMD Ryzen™ 5600H-mobilprocessor ", "16 GB DDR4 RAM ", "15.6 ", "Windows 10 Home" },
                    { 22, 4, " 512 GB SSD", "../images/Brand/HP4.jpg", "HP Laptop 17-cn0815no ", 8490m, "Intel® Core™ i5-1135G7 processor ", "8 GB DDR4 RAM ", "17.3 ", "Windows 10 Home" },
                    { 23, 4, "256 GB SSD", "../images/Brand/HP5.jpg", "HP ENVY x360 13-ay1335no ", 9990m, "AMD Ryzen™ 5 5600U processor ", "8 GB DDR4 RAM ", "13 ", "Windows 11 Home  " },
                    { 24, 4, "1TB SSD", "../images/Brand/HP6jpg", " HP OMEN 16c0800no ", 21990m, "AMD Ryzen 9 5900H-processor ", "16 GB DDR4 ", "16.1 ", "Windows 10 Home " },
                    { 25, 5, "1TB NVMe-lagring", "../images/Brand/Asus1.jpg", "Asus ProArt StudioBook Pro X  ", 61551m, "Intel® Xeon® E-2276M processor ", "64GB DDR4 RAM ", "17 ", "Windows 10 Home " },
                    { 26, 5, "1024 GB SSD", "../images/Brand/Asus2.jpg", "ASUS ROG Flow X13 GV301 ", 37990m, "AMD Ryzen™ 9 5980HS-processor ", "32 GB LPDDR4X RAM ", "13 ", "Windows 10 Home" },
                    { 27, 5, "1 TB SSD", "../images/Brand/Asus3.jpg", "Asus ZenBook Pro Duo 15 OLED UX582 ", 33990m, "Intel® Core™ i7-10870H-processor ", "32 GB DDR4 RAM ", "15,6", "Windows 10 Home" },
                    { 28, 5, "1 TB SSD", "../images/Brand/Asus4.jpg", "Asus ZenBook Pro 15 OLED UX535 ", 23990m, "Intel® Core™ i7-10870H processor ", "16 GB DDR4 RAM ", "15.6 ", "Windows 10 Home" },
                    { 18, 3, " 1000GB", "../images/Brand/Lenovo4.jpg ", "Lenovo Legion 5", 12990m, "AMD Ryzen 7 ", " 16GB ", "15.6 ", "Windows 10 Home" },
                    { 17, 3, "512GB", "../images/Brand/Lenovo3.jpg ", "Lenovo NOTEBOOK IP 3 17ALC6 ", 7638m, "Intel Core processor i7", "‎8 GB ", "‎17.3 ", "Windows 10 Home " },
                    { 9, 3, "", "../images/pro2.png", "F", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 8, 3, "", "../images/pro2.png", "E", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 16, 2, "512GB", "../images/Brand/samsung5.jpg ", "Galaxy Book Pro 360 NP950QDB-KC2DE Notebook ", 26558m, " Intel Core processor i7", "16GB ", "15.6", "Windows 10 Home " },
                    { 15, 2, "256GB", "../images/Brand/samsung4.jpg", "Samsung Galaxy Book Flex NP930QCG-K01DE ", 16729m, "Intel® Core i5 ", "8GB", "13.3 ", "Windows 10 Home " },
                    { 14, 2, "512GB", "../images/Brand/samsung3.jpg ", "Galaxy Book ION Core i7", 11799m, "Intel Core i7", "16GB ", "13.3", "Windows 10 Home " },
                    { 13, 2, "256GB", "../images/Brand/samsung2.jpg", "Samsung Galaxy Book Flex2 ", 8490m, "Intel Core i5 ", "8GB", "15.60 ", "Windows 10 Home " },
                    { 12, 2, "256GB", "../images/Brand/samsung1.jpg", "Galaxy Book Pro 360 ", 11490m, "Intel® Core™ i5-1135G7 ", "8GB ", "15.6 ", "Windows 11 Home " },
                    { 7, 2, "", "../images/pro2.png", "D", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 6, 1, "1TB SSD", "../images/4.png", "C", 29990m, "Intel® Core™ i7-10875H processor", "32 GB", "15,6' Ultra HD 4K - pekskärm(IPS - panel)", "64-bit operating system" },
                    { 5, 1, "64 GB", "../images/3.png", "C", 2990m, "Intel® Celeron® N4020 processor", "4 GB", "14' Full HD - skärm(1920 x 1080)", "64-bit operating system" },
                    { 4, 1, "1000 GB SSD", "../images/1.png", "A", 9490m, "Intel® Core™ i7-1065G7 processor", "16 GB", "14' Full HD - skärm", "64-bit operating system" },
                    { 3, 1, "512 GB SSD", "../images/2.png", "B", 5990m, "Intel Pentium Silver N6000-processor", "8GB", "No pen and touch input is available for this display", "64-bit operating system" },
                    { 2, 1, "512 GB", "../images/6.png", "C", 9490m, "Intel® Core™ i5-10300H processor", "16 GB", "120 Hz 15,6' Full HD - skärm(IPS - panel)", "64-bit operating system" },
                    { 1, 1, "512 GB SSD", "../images/5.png", "C", 11990m, "Intel® Core™ i5-10300H processor", "16 GB", "120 Hz 17,3' Full HD - skärm", "64-bit operating system" },
                    { 29, 5, "512 GB NVMe-lagring", "../images/Brand/Asus5.jpg", "Asus ExpertBook B9 ", 19299m, "Intel® Core™ i7-1165G7 processor ", "16 GB DDR4 RAM ", "14 ", "Windows 10 Home" },
                    { 30, 5, "1 TB SSD", "../images/Brand/Asus6.jpg", "Asus TUF Gaming A17 FA706QM", 16396m, "AMD Ryzen™ 7 5800H processor ", "16 GB RAM ", "17.3 ", "Windows 10 Home" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ComputerId", "CustomerId", "Rating", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, 5, "Very happy with this system in good condition and working fine will buy from again and will tell friends and family" },
                    { 5, 1, 1, 1, "I am very pleased with my purchase, I have not set it up fully yet as I need some help but it all seems to be working lovely" },
                    { 2, 2, 2, 3, "I was reallly pleased with the quality and it was not damaged when received. It was delivered on time although when set up the keyboard was quite sticky while typing. I had to press really hard on the keys for my work. Apart from that, everything was perfect. I was really impressed. Thank you." },
                    { 6, 2, 2, 1, "I love this computer. It is perfect for me to advance my I.T. knowledge and skills. I am totally satisfied and very Happy. Thank you. C. Taylor." },
                    { 3, 3, 3, 5, "I have bought this PC for my office since 2020. There was no big issues so far and the computer worked fairly well. However, there was a small issues on the back of screen monitor which connect to unit and the wire did not connect well and not tight enough, so I have used adhesive tapes to control it to avoid pull it apart. Overall happy with their services. Keep up with your good work." },
                    { 7, 3, 3, 4, "2nd computer from you well packed and delivered on time very pleased with the computer works like new thankyou." },
                    { 4, 4, 4, 3, "I was pleasantly surprised by the quality of the product. It arrived well packaged and undamaged and was soon up and running. I had one small enquiry re WiFi connectivity and this was answered by a helpful and courteous call handler - impressed!" },
                    { 8, 4, 4, 2, "Excellent service quick to get my order to me, Excellent affordable solutions for everyone." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOrders_ComputerId",
                table: "ComputerOrders",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_CategoryId",
                table: "Computers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ComputerId",
                table: "Reviews",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ComputerOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}