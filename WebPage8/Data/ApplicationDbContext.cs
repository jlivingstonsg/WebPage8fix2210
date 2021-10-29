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

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Order>(ky => ky.Order)
                .WithMany(y => y.ComputerOrders)
                .HasForeignKey(ky => ky.OrderId);

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
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 2,
                    Name = "B",
                    Price = 7000,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Computer
                {
                    ComputerId = 3,
                    Name = "C",
                    Price = 2450,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 2
                },
                new Computer
                {
                    ComputerId = 4,
                    Name = "D",
                    Price = 2000,
                    Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                    RAM = "32GB",
                    HardDisk = "",
                    SystemType = "64-bit operating system, x64-based processor",
                    PenAndTouch = "No pen and touch input is available for this display",
                    ImageUrl = "",
                    CategoryId = 4
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Acer", BrandUrl = "images/Brand/acer.jpg", Description = "Acer incorporated is now one of the biggest brands in computer hardware and electronics. They're also one of the biggest laptop brands known for their cheap and affordable laptop computers." },
                new Category { CategoryId = 2, Name = "Samsung", BrandUrl = "images/Brand/samsung.jpg", Description = "Samsung is one of the best laptop manufacturers right now, and over the last few years, it has released some of the best Windows laptops available. Featuring powerful specs, great battery life, and premium designs, Samsung devices are consistently cutting edge and high quality" },
                new Category { CategoryId = 3, Name = "Lenovo", BrandUrl = "images/Brand/Lenovo.jfif", Description = "Lenovo is truly an excellent brand to get for your laptop needs! They offer proven and tested reliability for their laptops, and also an amazing value at every price for every user." },
                new Category { CategoryId = 4, Name = "Hp", BrandUrl = "images/Brand/Hp.png", Description = "Through it all, HP has earned a reputation for reliable laptops with very competent customer service. Today, HP regularly goes head-to-head with some of the best laptop manufacturers in the world. Customer support options place HP in the top five of all manufacturers." }
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
            //        RoleId = "1"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "118ac7d8-c872-48ef-8729-d70ca7b9ae66",
            //        RoleId = "2"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "de6b3424-fe25-49a9-b9d2-7b66ef2d74ba",
            //        RoleId = "3"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "a79321df-cdae-40b9-bece-d2286b5f6381",
            //        RoleId = "1"
            //    },
            //    new IdentityUserRole()
            //    {
            //        UserId = "b6c6c801-2576-4d85-9fea-3028c55b1f01",
            //        RoleId = "2"
            //    }

            //    );

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole()
            {
                Id = "2",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
              new IdentityRole()
              {
                  Id = "1",
                  Name = "User",
                  NormalizedName = "USER"
              },
               new IdentityRole()
               {
                   Id = "3",
                   Name = "SuperAdmin",
                   NormalizedName = "SUPERADMIN"
               }
             );
        }
    }
}
