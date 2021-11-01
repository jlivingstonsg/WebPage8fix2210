using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPage8.Data.Migrations
{
    public partial class _1101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerOrders_Orders_OrderId",
                table: "ComputerOrders");

            migrationBuilder.DropIndex(
                name: "IX_ComputerOrders_OrderId",
                table: "ComputerOrders");

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

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ComputerOrders");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ScreenSize",
                table: "Computers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "ComputerOrders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", "391d102f-3b5c-4499-b780-46ed99acf96c", "Admin", "ADMIN" },
                    { "1", "19ce61cc-2a81-4472-85ac-170309652c77", "User", "USER" },
                    { "3", "feef1a91-6b75-4ea1-bdbb-e8468f93992b", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d40bc84-d035-4584-8de5-0a2eecdf49d1", "25d291c6-69ba-43a8-be5b-c4ca89a2e999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "49de736e-27eb-4bb8-a402-b7e520d675ff", "Admin1@gmail.com", "f74d5cd0-c164-4933-af9f-07fb863cbca0", "Admin1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "8d62ba1f-d79f-4bda-a0c1-635854a454ee", "SuperAdmin@gmail.com", "41d2eae7-477e-4554-8f6c-060e2c391f0b", "SuperAdmin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2c46733-ec7c-4cc6-a4c7-9defb593f89a", "94f3cb6f-3cb9-45bd-a583-1d8a2fb3b770" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "091cbac9-33b3-4949-ab61-a781e0d3ab10", "Admin2@gmail.com", "f8f0bea3-5804-4bd2-bfa9-a141edede6e6", "Admin2" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "BrandUrl", "Description", "Name" },
                values: new object[] { 5, "images/Brand/Hp.png", "ASUS is a good and reputable brand, the brand is well-known for its optimized performance with the lowest computer specifications. In the fiercely competitive market for computing and hand-held devices, it is becoming extremely difficult for device and gadget manufacturers to break the clutter and stand out from the competition.", "Asus" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1,
                columns: new[] { "HardDisk", "ImageUrl", "PenAndTouch", "ScreenSize" },
                values: new object[] { "128GB", "../images/Brand/Acer6.jpg", null, "4'" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2,
                columns: new[] { "HardDisk", "ImageUrl", "PenAndTouch", "Price", "Processor", "RAM", "ScreenSize" },
                values: new object[] { "512 GB SSD", "../images/Brand/Acer1.jpg", null, 5990m, "Intel Pentium Silver N6000-processor", "8GB", "No pen and touch input is available for this display" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3,
                columns: new[] { "CategoryId", "HardDisk", "ImageUrl", "PenAndTouch", "Price", "Processor", "RAM", "ScreenSize" },
                values: new object[] { 1, "64GB", "../images/Brand/Acer2.jpg", null, 2990m, "Intel® Celeron® N4020 processor", "4GB", "14' Full HD - skärm(1920 x 1080)" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4,
                columns: new[] { "CategoryId", "HardDisk", "ImageUrl", "Name", "PenAndTouch", "Price", "Processor", "RAM", "ScreenSize" },
                values: new object[] { 1, "64GB", "../images/Brand/Acer3.jpg", "C", null, 4490m, "AMD Athlon Silver 3050C processor", "4GB", "14' Full HD - pekskärm" });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "ComputerId", "CategoryId", "HardDisk", "ImageUrl", "Name", "PenAndTouch", "Price", "Processor", "RAM", "ScreenSize", "SystemType" },
                values: new object[,]
                {
                    { 8, 3, "", "../images/Brand/Lenovo1.jpg", "E", null, 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system, x64-based processor" },
                    { 5, 1, "512 GB SSD", "../images/Brand/Acer4.jpg", "C", null, 11990m, "Intel® Core™ i5-10300H processor", "16 GB", "120 Hz 17,3' Full HD - skärm", "64-bit operating system, x64-based processor" },
                    { 6, 1, "512 GB", "../images/Brand/Acer5.jpg", "C", null, 6990m, "AMD Ryzen 5 4500U processor", "16 GB", "14' Full HD - skärm(IPS - panel)", "64-bit operating system, x64-based processor" },
                    { 7, 2, "", "../images/Brand/samsung6.jpg", "D", null, 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system, x64-based processor" },
                    { 23, 4, "256 GB SSD", "~/images/Brand/HP5.jpg", "HP ENVY x360 13-ay1335no ", null, 9990m, "AMD Ryzen™ 5 5600U processor ", "8 GB DDR4 RAM ", "13 ", "Windows 11 Home  " },
                    { 22, 4, " 512 GB SSD", "~/images/Brand/HP4.jpg", "HP Laptop 17-cn0815no ", null, 8490m, "Intel® Core™ i5-1135G7 processor ", "8 GB DDR4 RAM ", "17.3 ", "Windows 10 Home" },
                    { 24, 4, "1TB SSD", "~/images/Brand/HP6jpg", " HP OMEN 16c0800no ", null, 21990m, "AMD Ryzen 9 5900H-processor ", "16 GB DDR4 ", "16.1 ", "Windows 10 Home " },
                    { 19, 3, " 512 GB SSD-lagring", "~/images/Brand/Lenovo5.jpg", "Lenovo IdeaPad Gaming 3  ", null, 9490m, "AMD Ryzen™ 5 4600H-processor ", "8 GB DDR4 RAM ", " 15.6", "Windows 10 Home " },
                    { 9, 3, "", "../images/Brand/Lenovo2.jpg", "F", null, 7000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system, x64-based processor" },
                    { 10, 4, "", "../images/Brand/HP1.jpg", "G", null, 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system, x64-based processor" },
                    { 11, 4, "", "../images/Brand/HP2.jpg", "H", null, 20000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB", "No pen and touch input is available for this display", "64-bit operating system, x64-based processor" },
                    { 12, 2, "256GB", "~/images/Brand/samsung1.jpg", "Galaxy Book Pro 360 ", null, 11490m, "Intel® Core™ i5-1135G7 ", "8GB ", "15.6 ", "Windows 11 Home " },
                    { 13, 2, "256GB", "~/images/Brand/samsung2.jpg", "Samsung Galaxy Book Flex2 ", null, 8490m, "Intel Core i5 ", "8GB", "15.60 ", "Windows 10 Home " },
                    { 14, 2, "512GB", "~/images/Brand/samsung3.jpg ", "Galaxy Book ION Core i7", null, 11799m, "Intel Core i7", "16GB ", "13.3", "Windows 10 Home " },
                    { 15, 2, "256GB", "~/images/Brand/samsung4.jpg", "Samsung Galaxy Book Flex NP930QCG-K01DE ", null, 16729m, "Intel® Core i5 ", "8GB", "13.3 ", "Windows 10 Home " },
                    { 20, 3, "512 GB", "~/images/Brand/Lenovo6.jpg", "Lenovo IdeaPad 3 14ITL6 ", null, 7990m, "Intel Core i5 ", "8 GB", "14, ", "Windows 10 Home" },
                    { 21, 4, "512 GB SSD", "~/images/Brand/HP3.jpg", "HP Pavilion Gaming 15-ec2823no", null, 11490m, "AMD Ryzen™ 5600H-mobilprocessor ", "16 GB DDR4 RAM ", "15.6 ", "Windows 10 Home" },
                    { 16, 2, "512GB", "~/images/Brand/samsung5.jpg ", "Galaxy Book Pro 360 NP950QDB-KC2DE Notebook ", null, 26558m, " Intel Core processor i7", "16GB ", "15.6", "Windows 10 Home " },
                    { 17, 3, "512GB", "~/images/Brand/Lenovo3.jpg ", "Lenovo NOTEBOOK IP 3 17ALC6 ", null, 7638m, "Intel Core processor i7", "‎8 GB ", "‎17.3 ", "Windows 10 Home " },
                    { 18, 3, " 1000GB", "~/images/Brand/Lenovo4.jpg ", "Lenovo Legion 5", null, 12990m, "AMD Ryzen 7 ", " 16GB ", "15.6 ", "Windows 10 Home" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "ComputerId", "CustomerId", "Rating", "Text" },
                values: new object[,]
                {
                    { 5, 1, 1, 1, "I am very pleased with my purchase, I have not set it up fully yet as I need some help but it all seems to be working lovely" },
                    { 8, 4, 4, 2, "Excellent service quick to get my order to me, Excellent affordable solutions for everyone." },
                    { 4, 4, 4, 3, "I was pleasantly surprised by the quality of the product. It arrived well packaged and undamaged and was soon up and running. I had one small enquiry re WiFi connectivity and this was answered by a helpful and courteous call handler - impressed!" },
                    { 3, 3, 3, 5, "I have bought this PC for my office since 2020. There was no big issues so far and the computer worked fairly well. However, there was a small issues on the back of screen monitor which connect to unit and the wire did not connect well and not tight enough, so I have used adhesive tapes to control it to avoid pull it apart. Overall happy with their services. Keep up with your good work." },
                    { 2, 2, 2, 3, "I was reallly pleased with the quality and it was not damaged when received. It was delivered on time although when set up the keyboard was quite sticky while typing. I had to press really hard on the keys for my work. Apart from that, everything was perfect. I was really impressed. Thank you." },
                    { 1, 1, 1, 5, "Very happy with this system in good condition and working fine will buy from again and will tell friends and family" },
                    { 6, 2, 2, 1, "I love this computer. It is perfect for me to advance my I.T. knowledge and skills. I am totally satisfied and very Happy. Thank you. C. Taylor." },
                    { 7, 3, 3, 4, "2nd computer from you well packed and delivered on time very pleased with the computer works like new thankyou." }
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "ComputerId", "CategoryId", "HardDisk", "ImageUrl", "Name", "PenAndTouch", "Price", "Processor", "RAM", "ScreenSize", "SystemType" },
                values: new object[,]
                {
                    { 25, 5, "1TB NVMe-lagring", "~/images/Brand/Asus1.jpg", "Asus ProArt StudioBook Pro X  ", null, 61551m, "Intel® Xeon® E-2276M processor ", "64GB DDR4 RAM ", "17 ", "Windows 10 Home " },
                    { 26, 5, "1024 GB SSD", "~/images/Brand/Asus2.jpg", "ASUS ROG Flow X13 GV301 ", null, 37990m, "AMD Ryzen™ 9 5980HS-processor ", "32 GB LPDDR4X RAM ", "13 ", "Windows 10 Home" },
                    { 27, 5, "1 TB SSD", "~/images/Brand/Asus3.jpg", "Asus ZenBook Pro Duo 15 OLED UX582 ", null, 33990m, "Intel® Core™ i7-10870H-processor ", "32 GB DDR4 RAM ", "15,6", "Windows 10 Home" },
                    { 28, 5, "1 TB SSD", "~/images/Brand/Asus4.jpg", "Asus ZenBook Pro 15 OLED UX535 ", null, 23990m, "Intel® Core™ i7-10870H processor ", "16 GB DDR4 RAM ", "15.6 ", "Windows 10 Home" },
                    { 29, 5, "512 GB NVMe-lagring", "~/images/Brand/Asus5.jpg", "Asus ExpertBook B9 ", null, 19299m, "Intel® Core™ i7-1165G7 processor ", "16 GB DDR4 RAM ", "14 ", "Windows 10 Home" },
                    { 30, 5, "1 TB SSD", "~/images/Brand/Asus6.jpg", "Asus TUF Gaming A17 FA706QM", null, 16396m, "AMD Ryzen™ 7 5800H processor ", "16 GB RAM ", "17.3 ", "Windows 10 Home" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 30);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ScreenSize",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "ComputerOrders");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ComputerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "538dd5c8-1563-43b0-8a4c-cd496c4b3a52", "4eb383dc-3ee8-4384-af8c-dc31aab7c988", "Admin", "ADMIN" },
                    { "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a", "2858b08a-f39d-4e09-a2a8-89ef0e78c31e", "User", "USER" },
                    { "4334345c8-1311-32a0-aa4c-cd334c4e5a52", "06a56ba2-806f-4315-a45e-80560d19fbed", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05bff8a9-6631-47f9-b943-365dc71ea489",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b9fb3f6-bfdc-4430-b017-92fdc621c448", "73e29040-c9e3-4937-a9b1-f2c874e94caf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "5b5486bd-7438-4276-a4c4-de0d068fb235", "Admin2@gmail.com", "233cadf5-958f-4b70-80bb-ba2f82e73f02", "Admin2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a79321df-cdae-40b9-bece-d2286b5f6381",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "bbe7b047-328a-40e4-a6ca-9bd7f5068557", "Admin1@gmail.com", "cbdbf6dd-0faa-4642-ad52-e6e902d78d42", "Admin1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6c6c801-2576-4d85-9fea-3028c55b1f01",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6d4a99e-ef3a-4542-a313-b0c477ba46ad", "ff448562-e0d7-4166-91aa-e2748b3c5f16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp", "FirstName" },
                values: new object[] { "47fe63fd-7618-456f-ba90-1138a4d6db9c", "SuperAdmin@gmail.com", "4f36aea9-0579-43ee-bf9a-b48e54017f2b", "SuperAdmin" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 1,
                columns: new[] { "HardDisk", "ImageUrl", "PenAndTouch" },
                values: new object[] { "", "", "No pen and touch input is available for this display" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 2,
                columns: new[] { "HardDisk", "ImageUrl", "PenAndTouch", "Price", "Processor", "RAM" },
                values: new object[] { "", "", "No pen and touch input is available for this display", 7000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 3,
                columns: new[] { "CategoryId", "HardDisk", "ImageUrl", "PenAndTouch", "Price", "Processor", "RAM" },
                values: new object[] { 2, "", "", "No pen and touch input is available for this display", 2450m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB" });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "ComputerId",
                keyValue: 4,
                columns: new[] { "CategoryId", "HardDisk", "ImageUrl", "Name", "PenAndTouch", "Price", "Processor", "RAM" },
                values: new object[] { 4, "", "", "D", "No pen and touch input is available for this display", 2000m, "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70", "32GB" });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerOrders_OrderId",
                table: "ComputerOrders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerOrders_Orders_OrderId",
                table: "ComputerOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
