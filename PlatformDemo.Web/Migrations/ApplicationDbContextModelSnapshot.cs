﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformDemo.Data;

#nullable disable

namespace PlatformDemo.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlatformDemo.Data.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalOrderAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Name = "Customer 1",
                            PhoneNumber = "555-123-01",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 2,
                            Name = "Customer 2",
                            PhoneNumber = "555-123-02",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 3,
                            Name = "Customer 3",
                            PhoneNumber = "555-123-03",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 4,
                            Name = "Customer 4",
                            PhoneNumber = "555-123-04",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 5,
                            Name = "Customer 5",
                            PhoneNumber = "555-123-05",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 6,
                            Name = "Customer 6",
                            PhoneNumber = "555-123-06",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 7,
                            Name = "Customer 7",
                            PhoneNumber = "555-123-07",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 8,
                            Name = "Customer 8",
                            PhoneNumber = "555-123-08",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 9,
                            Name = "Customer 9",
                            PhoneNumber = "555-123-09",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 10,
                            Name = "Customer 10",
                            PhoneNumber = "555-123-10",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 11,
                            Name = "Customer 11",
                            PhoneNumber = "555-123-11",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 12,
                            Name = "Customer 12",
                            PhoneNumber = "555-123-12",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 13,
                            Name = "Customer 13",
                            PhoneNumber = "555-123-13",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 14,
                            Name = "Customer 14",
                            PhoneNumber = "555-123-14",
                            TotalOrderAmount = 0m
                        },
                        new
                        {
                            CustomerId = 15,
                            Name = "Customer 15",
                            PhoneNumber = "555-123-15",
                            TotalOrderAmount = 0m
                        });
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Amount = 107m,
                            CustomerId = 1,
                            OrderNumber = "Order-1-1"
                        },
                        new
                        {
                            OrderId = 2,
                            Amount = 27m,
                            CustomerId = 1,
                            OrderNumber = "Order-1-2"
                        },
                        new
                        {
                            OrderId = 3,
                            Amount = 348m,
                            CustomerId = 4,
                            OrderNumber = "Order-4-1"
                        },
                        new
                        {
                            OrderId = 4,
                            Amount = 184m,
                            CustomerId = 4,
                            OrderNumber = "Order-4-2"
                        },
                        new
                        {
                            OrderId = 5,
                            Amount = 472m,
                            CustomerId = 6,
                            OrderNumber = "Order-6-1"
                        },
                        new
                        {
                            OrderId = 6,
                            Amount = 330m,
                            CustomerId = 6,
                            OrderNumber = "Order-6-2"
                        },
                        new
                        {
                            OrderId = 7,
                            Amount = 255m,
                            CustomerId = 7,
                            OrderNumber = "Order-7-1"
                        },
                        new
                        {
                            OrderId = 8,
                            Amount = 199m,
                            CustomerId = 7,
                            OrderNumber = "Order-7-2"
                        },
                        new
                        {
                            OrderId = 9,
                            Amount = 276m,
                            CustomerId = 7,
                            OrderNumber = "Order-7-3"
                        },
                        new
                        {
                            OrderId = 10,
                            Amount = 431m,
                            CustomerId = 8,
                            OrderNumber = "Order-8-1"
                        },
                        new
                        {
                            OrderId = 11,
                            Amount = 411m,
                            CustomerId = 8,
                            OrderNumber = "Order-8-2"
                        },
                        new
                        {
                            OrderId = 12,
                            Amount = 164m,
                            CustomerId = 8,
                            OrderNumber = "Order-8-3"
                        },
                        new
                        {
                            OrderId = 13,
                            Amount = 229m,
                            CustomerId = 8,
                            OrderNumber = "Order-8-4"
                        },
                        new
                        {
                            OrderId = 14,
                            Amount = 26m,
                            CustomerId = 9,
                            OrderNumber = "Order-9-1"
                        },
                        new
                        {
                            OrderId = 15,
                            Amount = 288m,
                            CustomerId = 11,
                            OrderNumber = "Order-11-1"
                        },
                        new
                        {
                            OrderId = 16,
                            Amount = 401m,
                            CustomerId = 12,
                            OrderNumber = "Order-12-1"
                        },
                        new
                        {
                            OrderId = 17,
                            Amount = 469m,
                            CustomerId = 12,
                            OrderNumber = "Order-12-2"
                        },
                        new
                        {
                            OrderId = 18,
                            Amount = 429m,
                            CustomerId = 12,
                            OrderNumber = "Order-12-3"
                        },
                        new
                        {
                            OrderId = 19,
                            Amount = 267m,
                            CustomerId = 13,
                            OrderNumber = "Order-13-1"
                        },
                        new
                        {
                            OrderId = 20,
                            Amount = 293m,
                            CustomerId = 14,
                            OrderNumber = "Order-14-1"
                        },
                        new
                        {
                            OrderId = 21,
                            Amount = 491m,
                            CustomerId = 14,
                            OrderNumber = "Order-14-2"
                        },
                        new
                        {
                            OrderId = 22,
                            Amount = 36m,
                            CustomerId = 14,
                            OrderNumber = "Order-14-3"
                        },
                        new
                        {
                            OrderId = 23,
                            Amount = 93m,
                            CustomerId = 15,
                            OrderNumber = "Order-15-1"
                        },
                        new
                        {
                            OrderId = 24,
                            Amount = 355m,
                            CustomerId = 15,
                            OrderNumber = "Order-15-2"
                        });
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Order", b =>
                {
                    b.HasOne("PlatformDemo.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PlatformDemo.Data.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}