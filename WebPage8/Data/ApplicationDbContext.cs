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
                    ImageUrl = "../images/pro2.png",
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
                    ImageUrl = "../images/pro2.png",
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
                    ImageUrl = "../images/pro2.png",
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
                    ImageUrl = "../images/pro2.png",
                    CategoryId = 2
                },
                 new Computer
                 {
                     ComputerId = 5,
                     Name = "E",
                     Price = 2000,
                     Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                     RAM = "32GB",
                     HardDisk = "",
                     SystemType = "64-bit operating system, x64-based processor",
                     PenAndTouch = "No pen and touch input is available for this display",
                     ImageUrl = "../images/pro2.png",
                     CategoryId = 3
                 },
                  new Computer
                  {
                      ComputerId = 6,
                      Name = "F",
                      Price = 2000,
                      Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                      RAM = "32GB",
                      HardDisk = "",
                      SystemType = "64-bit operating system, x64-based processor",
                      PenAndTouch = "No pen and touch input is available for this display",
                      ImageUrl = "../images/pro2.png",
                      CategoryId = 3
                  },
                   new Computer
                   {
                       ComputerId = 7,
                       Name = "G",
                       Price = 2000,
                       Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                       RAM = "32GB",
                       HardDisk = "",
                       SystemType = "64-bit operating system, x64-based processor",
                       PenAndTouch = "No pen and touch input is available for this display",
                       ImageUrl = "../images/pro2.png",
                       CategoryId = 4
                   },
                    new Computer
                    {
                        ComputerId = 8,
                        Name = "H",
                        Price = 2000,
                        Processor = "Intel(R) Core(TM) i7-8700K CPU @ 3.7GHz3.70",
                        RAM = "32GB",
                        HardDisk = "",
                        SystemType = "64-bit operating system, x64-based processor",
                        PenAndTouch = "No pen and touch input is available for this display",
                        ImageUrl = "../images/pro2.png",
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

            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, Text = "Bla bla bla", ComputerId = 1, CustomerId = 1, Rating = 5 },
                new Review { ReviewId = 2, Text = "Bla bla bla", ComputerId = 2, CustomerId = 2, Rating = 3 },
                new Review { ReviewId = 3, Text = "Bla bla bla", ComputerId = 3, CustomerId = 3, Rating = 5 },
                new Review { ReviewId = 4, Text = "Bla bla bla", ComputerId = 4, CustomerId = 4, Rating = 3 },
                new Review { ReviewId = 5, Text = "Bla bla bla", ComputerId = 1, CustomerId = 1, Rating = 1 },
                new Review { ReviewId = 6, Text = "Bla bla bla", ComputerId = 2, CustomerId = 2, Rating = 1 },
                new Review { ReviewId = 7, Text = "Bla bla bla", ComputerId = 3, CustomerId = 3, Rating = 4 },
                new Review { ReviewId = 8, Text = "Bla bla bla", ComputerId = 4, CustomerId = 4, Rating = 2 }
                );
        }
    }
}
