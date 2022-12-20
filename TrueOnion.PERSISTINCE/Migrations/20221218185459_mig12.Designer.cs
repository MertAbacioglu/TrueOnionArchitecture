﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrueOnion.PERSISTINCE.Context;

#nullable disable

namespace TrueOnion.PERSISTINCE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221218185459_mig12")]
    partial class mig12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrueOnion.DOMAIN.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Clothing",
                            InsertedDate = new DateTime(2022, 6, 22, 10, 44, 40, 324, DateTimeKind.Unspecified).AddTicks(1890),
                            Status = 1
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Industrial",
                            InsertedDate = new DateTime(2021, 12, 22, 4, 0, 15, 97, DateTimeKind.Unspecified).AddTicks(41),
                            Status = 1
                        },
                        new
                        {
                            ID = 3,
                            CategoryName = "Books",
                            InsertedDate = new DateTime(2021, 10, 15, 2, 38, 53, 238, DateTimeKind.Unspecified).AddTicks(4968),
                            Status = 1
                        },
                        new
                        {
                            ID = 4,
                            CategoryName = "Computers",
                            InsertedDate = new DateTime(2021, 10, 27, 9, 40, 12, 370, DateTimeKind.Unspecified).AddTicks(5870),
                            Status = 1
                        },
                        new
                        {
                            ID = 5,
                            CategoryName = "Books",
                            InsertedDate = new DateTime(2021, 6, 9, 8, 57, 35, 104, DateTimeKind.Unspecified).AddTicks(2055),
                            Status = 1
                        },
                        new
                        {
                            ID = 6,
                            CategoryName = "Music",
                            InsertedDate = new DateTime(2022, 2, 4, 7, 14, 16, 201, DateTimeKind.Unspecified).AddTicks(3340),
                            Status = 1
                        },
                        new
                        {
                            ID = 7,
                            CategoryName = "Music",
                            InsertedDate = new DateTime(2022, 2, 4, 4, 12, 25, 922, DateTimeKind.Unspecified).AddTicks(4200),
                            Status = 1
                        },
                        new
                        {
                            ID = 8,
                            CategoryName = "Jewelery",
                            InsertedDate = new DateTime(2021, 6, 23, 15, 24, 54, 277, DateTimeKind.Unspecified).AddTicks(9960),
                            Status = 1
                        },
                        new
                        {
                            ID = 9,
                            CategoryName = "Books",
                            InsertedDate = new DateTime(2021, 8, 26, 17, 47, 6, 576, DateTimeKind.Unspecified).AddTicks(4646),
                            Status = 1
                        },
                        new
                        {
                            ID = 10,
                            CategoryName = "Baby",
                            InsertedDate = new DateTime(2021, 5, 2, 2, 40, 29, 170, DateTimeKind.Unspecified).AddTicks(9173),
                            Status = 1
                        });
                });

            modelBuilder.Entity("TrueOnion.DOMAIN.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            InsertedDate = new DateTime(2021, 10, 13, 8, 30, 12, 615, DateTimeKind.Unspecified).AddTicks(8122),
                            Name = "Incredible Plastic Keyboard",
                            Price = 50m,
                            Status = 1,
                            Stock = 91
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 7,
                            InsertedDate = new DateTime(2022, 10, 7, 12, 31, 54, 439, DateTimeKind.Unspecified).AddTicks(6041),
                            Name = "Tasty Metal Computer",
                            Price = 55m,
                            Status = 1,
                            Stock = 117
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 10,
                            InsertedDate = new DateTime(2021, 5, 25, 16, 22, 44, 234, DateTimeKind.Unspecified).AddTicks(5054),
                            Name = "Fantastic Steel Bike",
                            Price = 57m,
                            Status = 1,
                            Stock = 24
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            InsertedDate = new DateTime(2022, 2, 11, 21, 34, 31, 367, DateTimeKind.Unspecified).AddTicks(2197),
                            Name = "Intelligent Frozen Shoes",
                            Price = 55m,
                            Status = 1,
                            Stock = 148
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 6,
                            InsertedDate = new DateTime(2021, 10, 29, 19, 22, 3, 623, DateTimeKind.Unspecified).AddTicks(6474),
                            Name = "Generic Granite Fish",
                            Price = 55m,
                            Status = 1,
                            Stock = 161
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 10,
                            InsertedDate = new DateTime(2022, 6, 7, 13, 59, 29, 886, DateTimeKind.Unspecified).AddTicks(3904),
                            Name = "Fantastic Frozen Tuna",
                            Price = 52m,
                            Status = 1,
                            Stock = 124
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 5,
                            InsertedDate = new DateTime(2022, 5, 8, 9, 14, 41, 157, DateTimeKind.Unspecified).AddTicks(286),
                            Name = "Small Fresh Car",
                            Price = 54m,
                            Status = 1,
                            Stock = 75
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 9,
                            InsertedDate = new DateTime(2021, 9, 16, 10, 38, 29, 508, DateTimeKind.Unspecified).AddTicks(3778),
                            Name = "Licensed Rubber Computer",
                            Price = 57m,
                            Status = 1,
                            Stock = 81
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 7,
                            InsertedDate = new DateTime(2022, 9, 28, 7, 2, 52, 332, DateTimeKind.Unspecified).AddTicks(2699),
                            Name = "Handcrafted Concrete Chips",
                            Price = 54m,
                            Status = 1,
                            Stock = 53
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 6,
                            InsertedDate = new DateTime(2021, 5, 3, 22, 7, 18, 310, DateTimeKind.Unspecified).AddTicks(6851),
                            Name = "Small Wooden Shirt",
                            Price = 57m,
                            Status = 1,
                            Stock = 72
                        },
                        new
                        {
                            ID = 11,
                            CategoryID = 2,
                            InsertedDate = new DateTime(2021, 7, 8, 13, 11, 41, 991, DateTimeKind.Unspecified).AddTicks(3640),
                            Name = "Handcrafted Cotton Sausages",
                            Price = 50m,
                            Status = 1,
                            Stock = 156
                        },
                        new
                        {
                            ID = 12,
                            CategoryID = 4,
                            InsertedDate = new DateTime(2022, 4, 13, 9, 46, 3, 120, DateTimeKind.Unspecified).AddTicks(5099),
                            Name = "Incredible Soft Chair",
                            Price = 51m,
                            Status = 1,
                            Stock = 123
                        },
                        new
                        {
                            ID = 13,
                            CategoryID = 4,
                            InsertedDate = new DateTime(2022, 6, 28, 18, 40, 34, 368, DateTimeKind.Unspecified).AddTicks(8756),
                            Name = "Intelligent Concrete Fish",
                            Price = 56m,
                            Status = 1,
                            Stock = 142
                        },
                        new
                        {
                            ID = 14,
                            CategoryID = 7,
                            InsertedDate = new DateTime(2022, 1, 1, 23, 48, 38, 530, DateTimeKind.Unspecified).AddTicks(215),
                            Name = "Generic Concrete Fish",
                            Price = 52m,
                            Status = 1,
                            Stock = 44
                        },
                        new
                        {
                            ID = 15,
                            CategoryID = 3,
                            InsertedDate = new DateTime(2021, 11, 9, 4, 52, 44, 220, DateTimeKind.Unspecified).AddTicks(7778),
                            Name = "Small Fresh Mouse",
                            Price = 56m,
                            Status = 1,
                            Stock = 74
                        },
                        new
                        {
                            ID = 16,
                            CategoryID = 4,
                            InsertedDate = new DateTime(2022, 6, 15, 11, 14, 59, 378, DateTimeKind.Unspecified).AddTicks(6079),
                            Name = "Tasty Rubber Computer",
                            Price = 49m,
                            Status = 1,
                            Stock = 50
                        },
                        new
                        {
                            ID = 17,
                            CategoryID = 3,
                            InsertedDate = new DateTime(2021, 12, 26, 16, 40, 36, 975, DateTimeKind.Unspecified).AddTicks(6266),
                            Name = "Gorgeous Frozen Car",
                            Price = 50m,
                            Status = 1,
                            Stock = 69
                        },
                        new
                        {
                            ID = 18,
                            CategoryID = 3,
                            InsertedDate = new DateTime(2022, 11, 16, 12, 13, 19, 368, DateTimeKind.Unspecified).AddTicks(7003),
                            Name = "Ergonomic Granite Car",
                            Price = 51m,
                            Status = 1,
                            Stock = 83
                        },
                        new
                        {
                            ID = 19,
                            CategoryID = 10,
                            InsertedDate = new DateTime(2022, 3, 22, 11, 38, 31, 263, DateTimeKind.Unspecified).AddTicks(1076),
                            Name = "Tasty Soft Chicken",
                            Price = 55m,
                            Status = 1,
                            Stock = 36
                        },
                        new
                        {
                            ID = 20,
                            CategoryID = 3,
                            InsertedDate = new DateTime(2022, 6, 4, 10, 35, 36, 138, DateTimeKind.Unspecified).AddTicks(4478),
                            Name = "Licensed Fresh Chips",
                            Price = 51m,
                            Status = 1,
                            Stock = 166
                        },
                        new
                        {
                            ID = 21,
                            CategoryID = 8,
                            InsertedDate = new DateTime(2021, 10, 10, 17, 2, 7, 536, DateTimeKind.Unspecified).AddTicks(8075),
                            Name = "Handcrafted Wooden Cheese",
                            Price = 52m,
                            Status = 1,
                            Stock = 126
                        },
                        new
                        {
                            ID = 22,
                            CategoryID = 2,
                            InsertedDate = new DateTime(2022, 2, 20, 21, 42, 17, 98, DateTimeKind.Unspecified).AddTicks(305),
                            Name = "Incredible Granite Gloves",
                            Price = 50m,
                            Status = 1,
                            Stock = 160
                        },
                        new
                        {
                            ID = 23,
                            CategoryID = 8,
                            InsertedDate = new DateTime(2022, 12, 1, 8, 6, 51, 614, DateTimeKind.Unspecified).AddTicks(2390),
                            Name = "Practical Steel Gloves",
                            Price = 57m,
                            Status = 1,
                            Stock = 119
                        },
                        new
                        {
                            ID = 24,
                            CategoryID = 4,
                            InsertedDate = new DateTime(2022, 3, 3, 9, 48, 13, 417, DateTimeKind.Unspecified).AddTicks(8468),
                            Name = "Gorgeous Fresh Pants",
                            Price = 51m,
                            Status = 1,
                            Stock = 40
                        },
                        new
                        {
                            ID = 25,
                            CategoryID = 3,
                            InsertedDate = new DateTime(2022, 2, 28, 21, 14, 19, 712, DateTimeKind.Unspecified).AddTicks(6622),
                            Name = "Intelligent Fresh Towels",
                            Price = 50m,
                            Status = 1,
                            Stock = 170
                        },
                        new
                        {
                            ID = 26,
                            CategoryID = 8,
                            InsertedDate = new DateTime(2022, 10, 6, 9, 22, 32, 736, DateTimeKind.Unspecified).AddTicks(3814),
                            Name = "Sleek Fresh Bacon",
                            Price = 54m,
                            Status = 1,
                            Stock = 135
                        },
                        new
                        {
                            ID = 27,
                            CategoryID = 4,
                            InsertedDate = new DateTime(2022, 10, 2, 11, 59, 31, 690, DateTimeKind.Unspecified).AddTicks(7650),
                            Name = "Incredible Wooden Towels",
                            Price = 49m,
                            Status = 1,
                            Stock = 92
                        },
                        new
                        {
                            ID = 28,
                            CategoryID = 1,
                            InsertedDate = new DateTime(2022, 4, 30, 8, 57, 49, 986, DateTimeKind.Unspecified).AddTicks(2251),
                            Name = "Handmade Soft Shirt",
                            Price = 56m,
                            Status = 1,
                            Stock = 145
                        },
                        new
                        {
                            ID = 29,
                            CategoryID = 9,
                            InsertedDate = new DateTime(2022, 9, 14, 16, 33, 22, 217, DateTimeKind.Unspecified).AddTicks(9374),
                            Name = "Intelligent Fresh Salad",
                            Price = 54m,
                            Status = 1,
                            Stock = 151
                        },
                        new
                        {
                            ID = 30,
                            CategoryID = 10,
                            InsertedDate = new DateTime(2021, 8, 31, 19, 56, 8, 597, DateTimeKind.Unspecified).AddTicks(5740),
                            Name = "Practical Soft Chair",
                            Price = 56m,
                            Status = 1,
                            Stock = 107
                        });
                });

            modelBuilder.Entity("TrueOnion.DOMAIN.Entities.Product", b =>
                {
                    b.HasOne("TrueOnion.DOMAIN.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TrueOnion.DOMAIN.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
