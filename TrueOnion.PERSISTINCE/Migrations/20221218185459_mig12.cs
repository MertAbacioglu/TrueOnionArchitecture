using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Clothing", new DateTime(2022, 6, 22, 10, 44, 40, 324, DateTimeKind.Unspecified).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Industrial", new DateTime(2021, 12, 22, 4, 0, 15, 97, DateTimeKind.Unspecified).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Books", new DateTime(2021, 10, 15, 2, 38, 53, 238, DateTimeKind.Unspecified).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Computers", new DateTime(2021, 10, 27, 9, 40, 12, 370, DateTimeKind.Unspecified).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Books", new DateTime(2021, 6, 9, 8, 57, 35, 104, DateTimeKind.Unspecified).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Music", new DateTime(2022, 2, 4, 7, 14, 16, 201, DateTimeKind.Unspecified).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Music", new DateTime(2022, 2, 4, 4, 12, 25, 922, DateTimeKind.Unspecified).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Jewelery", new DateTime(2021, 6, 23, 15, 24, 54, 277, DateTimeKind.Unspecified).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Books", new DateTime(2021, 8, 26, 17, 47, 6, 576, DateTimeKind.Unspecified).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Baby", new DateTime(2021, 5, 2, 2, 40, 29, 170, DateTimeKind.Unspecified).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 10, 13, 8, 30, 12, 615, DateTimeKind.Unspecified).AddTicks(8122), "Incredible Plastic Keyboard", 50m, 91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 10, 7, 12, 31, 54, 439, DateTimeKind.Unspecified).AddTicks(6041), "Tasty Metal Computer", 55m, 117 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 5, 25, 16, 22, 44, 234, DateTimeKind.Unspecified).AddTicks(5054), "Fantastic Steel Bike", 57m, 24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 2, 11, 21, 34, 31, 367, DateTimeKind.Unspecified).AddTicks(2197), "Intelligent Frozen Shoes", 148 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 10, 29, 19, 22, 3, 623, DateTimeKind.Unspecified).AddTicks(6474), "Generic Granite Fish", 55m, 161 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 6, 7, 13, 59, 29, 886, DateTimeKind.Unspecified).AddTicks(3904), "Fantastic Frozen Tuna", 52m, 124 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2022, 5, 8, 9, 14, 41, 157, DateTimeKind.Unspecified).AddTicks(286), "Small Fresh Car", 54m, 75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 9, 16, 10, 38, 29, 508, DateTimeKind.Unspecified).AddTicks(3778), "Licensed Rubber Computer", 57m, 81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 28, 7, 2, 52, 332, DateTimeKind.Unspecified).AddTicks(2699), "Handcrafted Concrete Chips", 54m, 53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 5, 3, 22, 7, 18, 310, DateTimeKind.Unspecified).AddTicks(6851), "Small Wooden Shirt", 57m, 72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 7, 8, 13, 11, 41, 991, DateTimeKind.Unspecified).AddTicks(3640), "Handcrafted Cotton Sausages", 50m, 156 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 4, 13, 9, 46, 3, 120, DateTimeKind.Unspecified).AddTicks(5099), "Incredible Soft Chair", 51m, 123 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 6, 28, 18, 40, 34, 368, DateTimeKind.Unspecified).AddTicks(8756), "Intelligent Concrete Fish", 56m, 142 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 1, 1, 23, 48, 38, 530, DateTimeKind.Unspecified).AddTicks(215), "Generic Concrete Fish", 52m, 44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 11, 9, 4, 52, 44, 220, DateTimeKind.Unspecified).AddTicks(7778), "Small Fresh Mouse", 56m, 74 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 6, 15, 11, 14, 59, 378, DateTimeKind.Unspecified).AddTicks(6079), "Tasty Rubber Computer", 49m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 3, new DateTime(2021, 12, 26, 16, 40, 36, 975, DateTimeKind.Unspecified).AddTicks(6266), "Gorgeous Frozen Car", 69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 3, new DateTime(2022, 11, 16, 12, 13, 19, 368, DateTimeKind.Unspecified).AddTicks(7003), "Ergonomic Granite Car", 83 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2022, 3, 22, 11, 38, 31, 263, DateTimeKind.Unspecified).AddTicks(1076), "Tasty Soft Chicken", 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 6, 4, 10, 35, 36, 138, DateTimeKind.Unspecified).AddTicks(4478), "Licensed Fresh Chips", 51m, 166 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 10, 10, 17, 2, 7, 536, DateTimeKind.Unspecified).AddTicks(8075), "Handcrafted Wooden Cheese", 126 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 2, 20, 21, 42, 17, 98, DateTimeKind.Unspecified).AddTicks(305), "Incredible Granite Gloves", 50m, 160 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 12, 1, 8, 6, 51, 614, DateTimeKind.Unspecified).AddTicks(2390), "Practical Steel Gloves", 57m, 119 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 3, 3, 9, 48, 13, 417, DateTimeKind.Unspecified).AddTicks(8468), "Gorgeous Fresh Pants", 51m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 2, 28, 21, 14, 19, 712, DateTimeKind.Unspecified).AddTicks(6622), "Intelligent Fresh Towels", 50m, 170 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 10, 6, 9, 22, 32, 736, DateTimeKind.Unspecified).AddTicks(3814), "Sleek Fresh Bacon", 54m, 135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 10, 2, 11, 59, 31, 690, DateTimeKind.Unspecified).AddTicks(7650), "Incredible Wooden Towels", 49m, 92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 4, 30, 8, 57, 49, 986, DateTimeKind.Unspecified).AddTicks(2251), "Handmade Soft Shirt", 56m, 145 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 9, 14, 16, 33, 22, 217, DateTimeKind.Unspecified).AddTicks(9374), "Intelligent Fresh Salad", 54m, 151 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 8, 31, 19, 56, 8, 597, DateTimeKind.Unspecified).AddTicks(5740), "Practical Soft Chair", 107 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Kids", new DateTime(2022, 10, 21, 19, 13, 55, 250, DateTimeKind.Unspecified).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Computers", new DateTime(2022, 11, 11, 11, 10, 4, 650, DateTimeKind.Unspecified).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Clothing", new DateTime(2021, 3, 23, 2, 29, 7, 589, DateTimeKind.Unspecified).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Clothing", new DateTime(2022, 9, 21, 5, 1, 59, 541, DateTimeKind.Unspecified).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Baby", new DateTime(2021, 10, 6, 18, 1, 12, 719, DateTimeKind.Unspecified).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Shoes", new DateTime(2022, 12, 17, 11, 7, 6, 818, DateTimeKind.Unspecified).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Games", new DateTime(2021, 11, 19, 4, 16, 39, 71, DateTimeKind.Unspecified).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Sports", new DateTime(2021, 11, 8, 2, 22, 23, 358, DateTimeKind.Unspecified).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Movies", new DateTime(2022, 6, 1, 17, 47, 58, 412, DateTimeKind.Unspecified).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Games", new DateTime(2022, 12, 4, 5, 35, 42, 540, DateTimeKind.Unspecified).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 9, 7, 15, 53, 6, 59, DateTimeKind.Unspecified).AddTicks(9884), "Generic Rubber Chicken", 51m, 128 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 9, 25, 11, 33, 37, 631, DateTimeKind.Unspecified).AddTicks(9006), "Intelligent Cotton Mouse", 54m, 156 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 3, 10, 14, 54, 27, 175, DateTimeKind.Unspecified).AddTicks(5036), "Handcrafted Fresh Ball", 53m, 164 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 9, 2, 16, 10, 0, 798, DateTimeKind.Unspecified).AddTicks(6128), "Intelligent Wooden Keyboard", 39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 5, 10, 12, 20, 27, 929, DateTimeKind.Unspecified).AddTicks(9350), "Tasty Wooden Mouse", 56m, 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 9, 2, 0, 1, 45, 239, DateTimeKind.Unspecified).AddTicks(9617), "Awesome Steel Shoes", 53m, 154 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 6, 11, 11, 54, 29, 744, DateTimeKind.Unspecified).AddTicks(5829), "Handmade Wooden Soap", 49m, 84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 1, 31, 15, 52, 26, 709, DateTimeKind.Unspecified).AddTicks(2429), "Intelligent Soft Fish", 55m, 172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 0, 26, 534, DateTimeKind.Unspecified).AddTicks(8), "Practical Cotton Chips", 50m, 143 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 3, 28, 21, 9, 48, 298, DateTimeKind.Unspecified).AddTicks(1137), "Handmade Frozen Chicken", 54m, 199 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 1, 29, 10, 20, 29, 714, DateTimeKind.Unspecified).AddTicks(8169), "Intelligent Concrete Pizza", 54m, 116 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 6, 12, 9, 49, 26, 916, DateTimeKind.Unspecified).AddTicks(9834), "Handmade Fresh Table", 56m, 53 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 2, 19, 20, 38, 29, 702, DateTimeKind.Unspecified).AddTicks(4919), "Small Granite Shoes", 55m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 7, 24, 4, 30, 18, 691, DateTimeKind.Unspecified).AddTicks(7854), "Practical Rubber Shirt", 49m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 4, 5, 9, 21, 43, 465, DateTimeKind.Unspecified).AddTicks(322), "Sleek Cotton Salad", 54m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 6, 9, 1, 1, 14, 295, DateTimeKind.Unspecified).AddTicks(3582), "Intelligent Fresh Soap", 56m, 114 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 2, new DateTime(2022, 7, 3, 4, 31, 11, 100, DateTimeKind.Unspecified).AddTicks(4444), "Licensed Concrete Towels", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 4, new DateTime(2021, 12, 15, 8, 20, 50, 234, DateTimeKind.Unspecified).AddTicks(7913), "Practical Frozen Mouse", 184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 9, new DateTime(2022, 8, 26, 22, 15, 20, 423, DateTimeKind.Unspecified).AddTicks(1103), "Generic Plastic Chair", 94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 3, 31, 5, 42, 33, 16, DateTimeKind.Unspecified).AddTicks(8671), "Rustic Fresh Bike", 49m, 171 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 15, 58, 859, DateTimeKind.Unspecified).AddTicks(8234), "Generic Rubber Computer", 157 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 10, 9, 8, 46, 13, 725, DateTimeKind.Unspecified).AddTicks(8432), "Gorgeous Frozen Chips", 53m, 27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 4, 3, 14, 45, 43, 414, DateTimeKind.Unspecified).AddTicks(1177), "Unbranded Concrete Ball", 51m, 176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 9, 4, 20, 43, 3, 725, DateTimeKind.Unspecified).AddTicks(6557), "Gorgeous Concrete Tuna", 49m, 71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 6, 22, 10, 26, 56, 866, DateTimeKind.Unspecified).AddTicks(4263), "Refined Metal Hat", 57m, 59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 5, 29, 5, 38, 45, 413, DateTimeKind.Unspecified).AddTicks(1285), "Generic Metal Sausages", 52m, 82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 10, 6, 3, 8, 10, 768, DateTimeKind.Unspecified).AddTicks(8861), "Fantastic Steel Cheese", 56m, 143 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 5, 4, 12, 10, 12, 118, DateTimeKind.Unspecified).AddTicks(404), "Handmade Frozen Sausages", 57m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 11, 25, 10, 24, 57, 646, DateTimeKind.Unspecified).AddTicks(3605), "Small Cotton Soap", 56m, 160 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 50, 48, 931, DateTimeKind.Unspecified).AddTicks(707), "Practical Fresh Keyboard", 175 });
        }
    }
}
