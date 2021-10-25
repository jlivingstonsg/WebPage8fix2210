﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPage8.Data;

namespace WebPage8.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "538dd5c8-1563-43b0-8a4c-cd496c4b3a52",
                            ConcurrencyStamp = "52d992c9-498f-46dc-9f96-ec38b2fe87e3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "09b8dca6-fb22-4cc9-82d8-fe52137e8e8a",
                            ConcurrencyStamp = "efaa47c3-5a45-4f75-98d0-fdb5d4f6e17b",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "4334345c8-1311-32a0-aa4c-cd334c4e5a52",
                            ConcurrencyStamp = "09e7134d-9740-4b3b-8c50-f6923bdac293",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.HasData(
                        new
                        {
                            Id = "20a4e501-ac20-4e2b-9fc2-ae8da57b57e0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ecf0e609-824a-4566-9b55-87d4294657cb",
                            Email = "Super@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc123+",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "724e6f1b-2115-499b-b3c4-94d986414678",
                            TwoFactorEnabled = false,
                            UserName = "Jonan"
                        },
                        new
                        {
                            Id = "a464b29e-7ad5-4de0-bdf5-4773c25a5939",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9dc378aa-1535-4b14-b75f-b03592df5eed",
                            Email = "Admin1@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc123+",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "47936114-a462-401c-8551-1cee15bdf553",
                            TwoFactorEnabled = false,
                            UserName = "Admin1"
                        },
                        new
                        {
                            Id = "1f873b4e-9e0a-4457-81fd-3a1201908d5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f79f2c2-a2cd-4ce8-bd73-38c28dfecf80",
                            Email = "Admin2@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc123+",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f23b2826-10be-44be-8211-052b6b041cb7",
                            TwoFactorEnabled = false,
                            UserName = "Admin2"
                        },
                        new
                        {
                            Id = "0fc4ad81-7585-4e8a-b782-d1fa339cbd94",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "62157d15-25a2-463c-9595-7770391c9846",
                            Email = "User@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc123+",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da959221-aa04-4c99-8237-4ed604bbe961",
                            TwoFactorEnabled = false,
                            UserName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebPage8.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            BrandUrl = "images/Brand/acer.jpg",
                            Description = "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable laptop computers.",
                            Name = "Acer"
                        },
                        new
                        {
                            CategoryId = 2,
                            BrandUrl = "images/Brand/samsung.jpg",
                            Description = "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available. Featuring powerful specs, great battery life, and premium designs, Samsung devices are consistently cutting edge and high quality",
                            Name = "Samsung"
                        },
                        new
                        {
                            CategoryId = 3,
                            BrandUrl = "images/Brand/Lenovo.jfif",
                            Description = "Lenovo is truly an excellent brand to get for your laptop needs! They offer proven and tested reliability for their laptops, and also an amazing value at every price for every user.",
                            Name = "Lenovo"
                        },
                        new
                        {
                            CategoryId = 4,
                            BrandUrl = "images/Brand/Hp.png",
                            Description = "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world. Customer support options place HP in the top five of all manufacturers.",
                            Name = "Hp"
                        });
                });

            modelBuilder.Entity("WebPage8.Models.Computer", b =>
                {
                    b.Property<int>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("HardDisk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PenAndTouch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComputerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Computers");

                    b.HasData(
                        new
                        {
                            ComputerId = 1,
                            CategoryId = 1,
                            HardDisk = "",
                            ImageUrl = "",
                            Name = "A",
                            PenAndTouch = "No pen and touch input is available for this display",
                            Price = 4500m,
                            Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                            RAM = "32GB",
                            SystemType = "64-bit operating system, x64-based processor"
                        },
                        new
                        {
                            ComputerId = 2,
                            CategoryId = 1,
                            HardDisk = "",
                            ImageUrl = "",
                            Name = "B",
                            PenAndTouch = "No pen and touch input is available for this display",
                            Price = 7000m,
                            Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                            RAM = "32GB",
                            SystemType = "64-bit operating system, x64-based processor"
                        },
                        new
                        {
                            ComputerId = 3,
                            CategoryId = 2,
                            HardDisk = "",
                            ImageUrl = "",
                            Name = "C",
                            PenAndTouch = "No pen and touch input is available for this display",
                            Price = 2450m,
                            Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                            RAM = "32GB",
                            SystemType = "64-bit operating system, x64-based processor"
                        },
                        new
                        {
                            ComputerId = 4,
                            CategoryId = 4,
                            HardDisk = "",
                            ImageUrl = "",
                            Name = "D",
                            PenAndTouch = "No pen and touch input is available for this display",
                            Price = 2000m,
                            Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                            RAM = "32GB",
                            SystemType = "64-bit operating system, x64-based processor"
                        });
                });

            modelBuilder.Entity("WebPage8.Models.ComputerOrder", b =>
                {
                    b.Property<int>("ComputerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ComputerOrderId");

                    b.HasIndex("ComputerId");

                    b.HasIndex("OrderId");

                    b.ToTable("ComputerOrders");
                });

            modelBuilder.Entity("WebPage8.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            City = "Goteborg",
                            Country = "Sweden",
                            Email = "za@a.gmail.com",
                            FirstName = "Wei",
                            LastName = "C",
                            PhoneNumber = "+12345678919",
                            PostalCode = "888",
                            Street = "Möland"
                        },
                        new
                        {
                            CustomerId = 2,
                            City = "Skåne",
                            Country = "Sweden",
                            Email = "ya@a.gmail.com",
                            FirstName = "Magnus",
                            LastName = "I",
                            PhoneNumber = "+12345678919",
                            PostalCode = "",
                            Street = "aaa"
                        },
                        new
                        {
                            CustomerId = 3,
                            City = "Skövde",
                            Country = "Sweden",
                            Email = "xa@a.gmail.com",
                            FirstName = "Muzdalifa",
                            LastName = "I",
                            PhoneNumber = "+99345678919",
                            PostalCode = "123",
                            Street = "Frostaliden"
                        },
                        new
                        {
                            CustomerId = 4,
                            City = "Uppsala",
                            Country = "Sweden",
                            Email = "aa@a.gmail.com",
                            FirstName = "Seong",
                            LastName = "Gi-hun",
                            PhoneNumber = "+33345678919",
                            PostalCode = "123",
                            Street = "bbb"
                        },
                        new
                        {
                            CustomerId = 5,
                            City = "Skövde",
                            Country = "Sweden",
                            Email = "ba@a.gmail.com",
                            FirstName = "Kang ",
                            LastName = "Sae-Byeok",
                            PhoneNumber = "+12345678919",
                            PostalCode = "345",
                            Street = "Hjo"
                        });
                });

            modelBuilder.Entity("WebPage8.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderFullfilled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebPage8.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComputerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("ComputerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WebPage8.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebPage8.Models.Computer", b =>
                {
                    b.HasOne("WebPage8.Models.Category", "Category")
                        .WithMany("Computers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebPage8.Models.ComputerOrder", b =>
                {
                    b.HasOne("WebPage8.Models.Computer", "Computer")
                        .WithMany("ComputerOrders")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPage8.Models.Order", "Order")
                        .WithMany("ComputerOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebPage8.Models.Order", b =>
                {
                    b.HasOne("WebPage8.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebPage8.Models.Review", b =>
                {
                    b.HasOne("WebPage8.Models.Computer", "Computer")
                        .WithMany("Reviews")
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebPage8.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
