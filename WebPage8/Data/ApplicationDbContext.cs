using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebPage8.Models;

namespace WebPage8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ComputerOrder> ComputerOrders { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<ApplicationUser> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Computer>(ky => ky.Computer)
                .WithMany(k => k.ComputerOrders)
                .HasForeignKey(ky => ky.ComputerId);

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasOne(c => c.UserRoles)
            //    .WithMany(y => y.ApplicationUsers);

            //modelBuilder.Entity<UserRole>()
            //              .HasOne(c => c.Roles);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Computer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Customer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Computer>()
                .HasOne(c => c.Category)
                .WithMany(r => r.Computers);

            modelBuilder.Entity<Computer>()
                .HasMany(r => r.Reviews);

            modelBuilder.Entity<Customer>()
                .HasMany(r => r.Reviews);

            modelBuilder.Entity<Computer>().HasData(
                new Computer
                {
                    ComputerId = 1,
                    Name = "A",
                    Price = 4500,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "128GB",
                    SystemType = "64-bit operating system, x64-based processor",
                    ScreenSize = "4'",
                    ImageUrl = "../images/Brand/Acer6.jpg",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 2,
                    Name = "B",
                    Price = 5990,
                    Processor = "Intel Pentium Silver N6000-processor",
                    RAM = "8GB",
                    HardDisk = "512 GB SSD",
                    SystemType = "64-bit operating system, x64-based processor",
                    ScreenSize = "No pen and touch input is available for this display",
                    ImageUrl = "../images/Brand/Acer1.jpg",
                    CategoryId = 1
                },
                 new Computer
                 {
                     ComputerId = 3,
                     Name = "C",
                     Price = 2990,
                     Processor = "Intel® Celeron® N4020 processor",
                     RAM = "4GB",
                     HardDisk = "64GB",
                     SystemType = "64-bit operating system, x64-based processor",
                     ScreenSize = "14' Full HD - skärm(1920 x 1080)",
                     ImageUrl = "../images/Brand/Acer2.jpg",
                     CategoryId = 1
                 },
                  new Computer
                  {
                      ComputerId = 4,
                      Name = "C",
                      Price = 4490,
                      Processor = "AMD Athlon Silver 3050C processor",
                      RAM = "4GB",
                      HardDisk = "64GB",
                      SystemType = "64-bit operating system, x64-based processor",
                      ScreenSize = "14' Full HD - pekskärm",
                      ImageUrl = "../images/Brand/Acer3.jpg",
                      CategoryId = 1
                  },
                   new Computer
                   {
                       ComputerId = 5,
                       Name = "C",
                       Price = 11990,
                       Processor = "Intel® Core™ i5-10300H processor",
                       RAM = "16 GB",
                       HardDisk = "512 GB SSD",
                       SystemType = "64-bit operating system, x64-based processor",
                       ScreenSize = "120 Hz 17,3' Full HD - skärm",
                       ImageUrl = "../images/Brand/Acer4.jpg",
                       CategoryId = 1
                   },
                new Computer
                {
                    ComputerId = 6,
                    Name = "C",
                    Price = 6990,
                    Processor = "AMD Ryzen 5 4500U processor",
                    RAM = "16 GB",
                    HardDisk = "512 GB",
                    SystemType = "64-bit operating system, x64-based processor",
                    ScreenSize = "14' Full HD - skärm(IPS - panel)",
                    ImageUrl = "../images/Brand/Acer5.jpg",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 7,
                    Name = "D",
                    Price = 2000,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    ScreenSize = "No pen and touch input is available for this display",
                    ImageUrl = "../images/Brand/samsung6.jpg",
                    CategoryId = 2
                },
                 new Computer
                 {
                     ComputerId = 8,
                     Name = "E",
                     Price = 2000,
                     Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                     RAM = "32GB",
                     HardDisk = "",
                     SystemType = "64-bit operating system, x64-based processor",
                     ScreenSize = "No pen and touch input is available for this display",
                     ImageUrl = "../images/Brand/Lenovo1.jpg",
                     CategoryId = 3
                 },
                  new Computer
                  {
                      ComputerId = 9,
                      Name = "F",
                      Price = 7000,
                      Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                      RAM = "32GB",
                      HardDisk = "",
                      SystemType = "64-bit operating system, x64-based processor",
                      ScreenSize = "No pen and touch input is available for this display",
                      ImageUrl = "../images/Brand/Lenovo2.jpg",
                      CategoryId = 3
                  },
                   new Computer
                   {
                       ComputerId = 10,
                       Name = "G",
                       Price = 2000,
                       Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                       RAM = "32GB",
                       HardDisk = "",
                       SystemType = "64-bit operating system, x64-based processor",
                       ScreenSize = "No pen and touch input is available for this display",
                       ImageUrl = "../images/Brand/HP1.jpg",
                       CategoryId = 4
                   },
                    new Computer
                    {
                        ComputerId = 11,
                        Name = "H",
                        Price = 20000,
                        Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                        RAM = "32GB",
                        HardDisk = "",
                        SystemType = "64-bit operating system, x64-based processor",
                        ScreenSize = "No pen and touch input is available for this display",
                        ImageUrl = "../images/Brand/HP2.jpg",
                        CategoryId = 4
                    },
                    new Computer
                    {
                        ComputerId =  12,
                        Name = "Galaxy Book Pro 360 ",
                        Price = 11490,
                        Processor = "Intel® Core™ i5-1135G7 ",
                        RAM = "8GB ",
                        HardDisk = "256GB",
                        SystemType = "Windows 11 Home ",
                        ScreenSize = "15.6 ",
                        ImageUrl = "../images/Brand/samsung1.jpg",
                        CategoryId =2  
                    },
                    new Computer
                    {
                        ComputerId =13  ,
                        Name = "Samsung Galaxy Book Flex2 ",
                        Price = 8490,
                        Processor = "Intel Core i5 ",
                        RAM = "8GB",
                        HardDisk = "256GB",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "15.60 ",
                        ImageUrl = "../images/Brand/samsung2.jpg",
                        CategoryId =2
                    },
                    new Computer
                    {
                        ComputerId =14,
                        Name = "Galaxy Book ION Core i7",
                        Price = 11799,
                        Processor = "Intel Core i7",
                        RAM = "16GB ",
                        HardDisk = "512GB",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "13.3",
                        ImageUrl = "../images/Brand/samsung3.jpg ",
                        CategoryId =2
                    },
                    new Computer
                    {
                        ComputerId =15  ,
                        Name = "Samsung Galaxy Book Flex NP930QCG-K01DE ",
                        Price = 16729,
                        Processor = "Intel® Core i5 ",
                        RAM = "8GB",
                        HardDisk = "256GB",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "13.3 ",
                        ImageUrl = "../images/Brand/samsung4.jpg",
                        CategoryId =2
                    },
                    new Computer
                    {
                        ComputerId =16  ,
                        Name = "Galaxy Book Pro 360 NP950QDB-KC2DE Notebook ",
                        Price =26558 ,
                        Processor = " Intel Core processor i7",
                        RAM = "16GB ",
                        HardDisk = "512GB",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "15.6",
                        ImageUrl = "../images/Brand/samsung5.jpg ",
                        CategoryId =2
                    },
                    new Computer
                    {
                        ComputerId =17  ,
                        Name = "Lenovo NOTEBOOK IP 3 17ALC6 ",
                        Price =7638 ,
                        Processor = "Intel Core processor i7",
                        RAM = "‎8 GB ",
                        HardDisk = "512GB",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "‎17.3 ",
                        ImageUrl = "../images/Brand/Lenovo3.jpg ",
                        CategoryId =3
                    },
                    new Computer
                    {
                        ComputerId =18,
                        Name = "Lenovo Legion 5",
                        Price = 12990,
                        Processor = "AMD Ryzen 7 ",
                        RAM = " 16GB ",
                        HardDisk = " 1000GB",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "15.6 ",
                        ImageUrl = "../images/Brand/Lenovo4.jpg ",
                        CategoryId =3
                    },
                    new Computer
                    {
                        ComputerId = 19 ,
                        Name = "Lenovo IdeaPad Gaming 3  ",
                        Price =9490 ,
                        Processor = "AMD Ryzen™ 5 4600H-processor ",
                        RAM = "8 GB DDR4 RAM ",
                        HardDisk = " 512 GB SSD-lagring",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = " 15.6",
                        ImageUrl = "../images/Brand/Lenovo5.jpg",
                        CategoryId =3
                    },
                    new Computer
                    {
                        ComputerId = 20,
                        Name = "Lenovo IdeaPad 3 14ITL6 ",
                        Price = 7990,
                        Processor = "Intel Core i5 ",
                        RAM = "8 GB",
                        HardDisk = "512 GB",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "14, ",
                        ImageUrl = "../images/Brand/Lenovo6.jpg",
                        CategoryId =3
                    },
                    new Computer
                    {
                        ComputerId =21 ,
                        Name = "HP Pavilion Gaming 15-ec2823no",
                        Price = 11490,
                        Processor = "AMD Ryzen™ 5600H-mobilprocessor ",
                        RAM = "16 GB DDR4 RAM ",
                        HardDisk = "512 GB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "15.6 ",
                        ImageUrl = "../images/Brand/HP3.jpg",
                        CategoryId =4
                    },
                    new Computer
                    {
                        ComputerId = 22,
                        Name = "HP Laptop 17-cn0815no ",
                        Price =8490 ,
                        Processor = "Intel® Core™ i5-1135G7 processor ",
                        RAM = "8 GB DDR4 RAM ",
                        HardDisk = " 512 GB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "17.3 ",
                        ImageUrl = "../images/Brand/HP4.jpg",
                        CategoryId =4
                    },
                    new Computer
                    {
                        ComputerId =23,
                        Name = "HP ENVY x360 13-ay1335no ",
                        Price = 9990,
                        Processor = "AMD Ryzen™ 5 5600U processor ",
                        RAM = "8 GB DDR4 RAM ",
                        HardDisk = "256 GB SSD",
                        SystemType = "Windows 11 Home  ",
                        ScreenSize = "13 ",
                        ImageUrl = "../images/Brand/HP5.jpg",
                        CategoryId =4
                    },
                    new Computer
                    {
                        ComputerId =24,
                        Name = " HP OMEN 16c0800no ",
                        Price =21990 ,
                        Processor = "AMD Ryzen 9 5900H-processor ",
                        RAM = "16 GB DDR4 ",
                        HardDisk = "1TB SSD",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "16.1 ",
                        ImageUrl = "../images/Brand/HP6jpg",
                        CategoryId =4
                    },
                    new Computer
                    {
                        ComputerId =25,
                        Name = "Asus ProArt StudioBook Pro X  ",
                        Price = 61551,
                        Processor = "Intel® Xeon® E-2276M processor ",
                        RAM = "64GB DDR4 RAM ",
                        HardDisk = "1TB NVMe-lagring",
                        SystemType = "Windows 10 Home ",
                        ScreenSize = "17 ",
                        ImageUrl = "../images/Brand/Asus1.jpg",
                        CategoryId =5
                    },
                    new Computer
                    {
                        ComputerId =26,
                        Name = "ASUS ROG Flow X13 GV301 ",
                        Price = 37990,
                        Processor = "AMD Ryzen™ 9 5980HS-processor ",
                        RAM = "32 GB LPDDR4X RAM ",
                        HardDisk = "1024 GB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "13 ",
                        ImageUrl = "../images/Brand/Asus2.jpg",
                        CategoryId =5
                    },
                    new Computer
                    {
                        ComputerId =27,
                        Name = "Asus ZenBook Pro Duo 15 OLED UX582 ",
                        Price = 33990,
                        Processor = "Intel® Core™ i7-10870H-processor ",
                        RAM = "32 GB DDR4 RAM ",
                        HardDisk = "1 TB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "15,6",
                        ImageUrl = "../images/Brand/Asus3.jpg",
                        CategoryId =5
                    },
                    new Computer
                    {
                        ComputerId =28,
                        Name = "Asus ZenBook Pro 15 OLED UX535 ",
                        Price =23990 ,
                        Processor = "Intel® Core™ i7-10870H processor ",
                        RAM = "16 GB DDR4 RAM ",
                        HardDisk = "1 TB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "15.6 ",
                        ImageUrl = "../images/Brand/Asus4.jpg",
                        CategoryId =5
                    },
                    new Computer
                    {
                        ComputerId =29,
                        Name = "Asus ExpertBook B9 ",
                        Price = 19299,
                        Processor = "Intel® Core™ i7-1165G7 processor ",
                        RAM = "16 GB DDR4 RAM ",
                        HardDisk = "512 GB NVMe-lagring",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "14 ",
                        ImageUrl = "../images/Brand/Asus5.jpg",
                        CategoryId =5
                    },
                    new Computer
                    {
                        ComputerId =30,
                        Name = "Asus TUF Gaming A17 FA706QM",
                        Price = 16396,
                        Processor = "AMD Ryzen™ 7 5800H processor ",
                        RAM = "16 GB RAM ",
                        HardDisk = "1 TB SSD",
                        SystemType = "Windows 10 Home",
                        ScreenSize = "17.3 ",
                        ImageUrl = "../images/Brand/Asus6.jpg",
                        CategoryId =5
                    }


            );

            modelBuilder.Entity<Category>().HasData(
           new Category { CategoryId = 1, Name = "Acer", BrandUrl = "images/Brand/acer.jpg", Description = "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable laptop computers." },
           new Category { CategoryId = 2, Name = "Samsung", BrandUrl = "images/Brand/samsung.jpg", Description = "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available. Featuring powerful specs, great battery life, and premium designs, Samsung devices are consistently cutting edge and high quality" },
           new Category { CategoryId = 3, Name = "Lenovo", BrandUrl = "images/Brand/Lenovo.jfif", Description = "Lenovo is truly an excellent brand to get for your laptop needs! They offer proven and tested reliability for their laptops, and also an amazing value at every price for every user." },
           new Category { CategoryId = 4, Name = "Hp", BrandUrl = "images/Brand/Hp.png", Description = "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world. Customer support options place HP in the top five of all manufacturers." },
           new Category { CategoryId = 5, Name = "Asus", BrandUrl = "images/Brand/Hp.png", Description = "ASUS is a good and reputable brand, the brand is well-known for its optimized performance with the lowest computer specifications. In the fiercely competitive market for computing and hand-held devices, it is becoming extremely difficult for device and gadget manufacturers to break the clutter and stand out from the competition." }
           );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "Wei",
                    LastName = "C",
                    PhoneNumber = "+12345678919",
                    Email = "za@a.gmail.com",
                    PostalCode = "888",
                    Street = "Möland",
                    City = "Goteborg",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Magnus",
                    LastName = "I",
                    PhoneNumber = "+12345678919",
                    Email = "ya@a.gmail.com",
                    PostalCode = "",
                    Street = "aaa",
                    City = "Skåne",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Muzdalifa",
                    LastName = "I",
                    PhoneNumber = "+99345678919",
                    Email = "xa@a.gmail.com",
                    PostalCode = "123",
                    Street = "Frostaliden",
                    City = "Skövde",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Seong",
                    LastName = "Gi-hun",
                    PhoneNumber = "+33345678919",
                    Email = "aa@a.gmail.com",
                    PostalCode = "123",
                    Street = "bbb",
                    City = "Uppsala",
                    Country = "Sweden"
                },
                new Customer
                {
                    CustomerId = 5,
                    FirstName = "Kang ",
                    LastName = "Sae-Byeok",
                    PhoneNumber = "+12345678919",
                    Email = "ba@a.gmail.com",
                    PostalCode = "345",
                    Street = "Hjo",
                    City = "Skövde",
                    Country = "Sweden"
                }
            );
            
            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, Text = "Very happy with this system in good condition and working fine will buy from again and will tell friends and family", ComputerId = 1, CustomerId = 1, Rating = 5 },
                new Review { ReviewId = 2, Text = "I was reallly pleased with the quality and it was not damaged when received. It was delivered on time although when set up the keyboard was quite sticky while typing. I had to press really hard on the keys for my work. Apart from that, everything was perfect. I was really impressed. Thank you.", ComputerId = 2, CustomerId = 2, Rating = 3 },
                new Review { ReviewId = 3, Text = "I have bought this PC for my office since 2020. There was no big issues so far and the computer worked fairly well. However, there was a small issues on the back of screen monitor which connect to unit and the wire did not connect well and not tight enough, so I have used adhesive tapes to control it to avoid pull it apart. Overall happy with their services. Keep up with your good work.", ComputerId = 3, CustomerId = 3, Rating = 5 },
                new Review { ReviewId = 4, Text = "I was pleasantly surprised by the quality of the product. It arrived well packaged and undamaged and was soon up and running. I had one small enquiry re WiFi connectivity and this was answered by a helpful and courteous call handler - impressed!", ComputerId = 4, CustomerId = 4, Rating = 3},
                new Review { ReviewId = 5, Text = "I am very pleased with my purchase, I have not set it up fully yet as I need some help but it all seems to be working lovely", ComputerId = 1, CustomerId = 1, Rating = 1},
                new Review { ReviewId = 6, Text = "I love this computer. It is perfect for me to advance my I.T. knowledge and skills. I am totally satisfied and very Happy. Thank you. C. Taylor.", ComputerId = 2, CustomerId = 2, Rating = 1},
                new Review { ReviewId = 7, Text = "2nd computer from you well packed and delivered on time very pleased with the computer works like new thankyou.", ComputerId = 3, CustomerId = 3, Rating = 4},
                new Review { ReviewId = 8, Text = "Excellent service quick to get my order to me, Excellent affordable solutions for everyone.", ComputerId = 4, CustomerId = 4, Rating = 2}
                );

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser() { Id = "05bff8a9-6631-47f9-b943-365dc71ea489", FirstName = "Jonan", LastName = "Eriksson",  PasswordHash = "Abc123+", Email = "Super@gmail.com" },
                 new ApplicationUser() { Id = "118ac7d8-c872-48ef-8729-d70ca7b9ae66", FirstName = "Admin1", LastName = "Adminsson", PasswordHash = "Abc123+", Email = "Admin1@gmail.com" },
                  new ApplicationUser() { Id = "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba", FirstName = "Admin2", LastName = "Adminsson",   PasswordHash = "Abc123+", Email = "Admin2@gmail.com" },
                  new ApplicationUser() { Id = "a79321df-cdae-40b9-bece-d2286b5f6381", FirstName = "SuperAdmin", LastName = "Adminsson", PasswordHash = "Abc123+", Email = "SuperAdmin@gmail.com" },
                  new ApplicationUser() { Id = "b6c6c801-2576-4d85-9fea-3028c55b1f01", FirstName = "User", LastName = "Userson",  PasswordHash = "Abc123+", Email = "User@gmail.com" }
    );

            //modelBuilder.Entity<IdentityUserRole>().HasData(
            //    new IdentityUserRole()
            //    {
            //        UserId = "05bff8a9-6631-47f9-b943-365dc71ea489",
            //        RoleId = "55635e1e-3ae8-11ec-8d3d-0242ac130003"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
            //        RoleId = "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
            //        RoleId = "731d7700-3ae8-11ec-8d3d-0242ac130003"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "a79321df-cdae-40b9-bece-d2286b5f6381",
            //        RoleId = "55635e1e-3ae8-11ec-8d3d-0242ac130003"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "b6c6c801-2576-4d85-9fea-3028c55b1f01",
            //        RoleId = "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003"
            //    }

            //    );

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "3e4ce8e4-3ae8-11ec-8d3d-0242ac130003",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
              new IdentityRole()
              {
                  Id = "55635e1e-3ae8-11ec-8d3d-0242ac130003",
                  Name = "User",
                  NormalizedName = "USER"
              },
               new IdentityRole()
               {
                   Id = "731d7700-3ae8-11ec-8d3d-0242ac130003",
                   Name = "SuperAdmin",
                   NormalizedName = "SUPERADMIN"
               }
             );
        }
    }
}
