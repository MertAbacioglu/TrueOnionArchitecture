using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class migMonster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "InsertedDate",
                value: new DateTime(2022, 9, 21, 5, 1, 59, 541, DateTimeKind.Unspecified).AddTicks(279));

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
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 9, 7, 15, 53, 6, 59, DateTimeKind.Unspecified).AddTicks(9884), "Generic Rubber Chicken", 128 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 9, new DateTime(2022, 3, 10, 14, 54, 27, 175, DateTimeKind.Unspecified).AddTicks(5036), "Handcrafted Fresh Ball", 164 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 2, 16, 10, 0, 798, DateTimeKind.Unspecified).AddTicks(6128), "Intelligent Wooden Keyboard", 55m, 39 });

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
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 9, 2, 0, 1, 45, 239, DateTimeKind.Unspecified).AddTicks(9617), "Awesome Steel Shoes", 53m, 154 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 6, 11, 11, 54, 29, 744, DateTimeKind.Unspecified).AddTicks(5829), "Handmade Wooden Soap", 49m, 84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 1, 31, 15, 52, 26, 709, DateTimeKind.Unspecified).AddTicks(2429), "Intelligent Soft Fish", 172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 9, 10, 5, 0, 26, 534, DateTimeKind.Unspecified).AddTicks(8), "Practical Cotton Chips", 50m, 143 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 7, 24, 4, 30, 18, 691, DateTimeKind.Unspecified).AddTicks(7854), "Practical Rubber Shirt", 49m, 31 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 7, 3, 4, 31, 11, 100, DateTimeKind.Unspecified).AddTicks(4444), "Licensed Concrete Towels", 50m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 12, 15, 8, 20, 50, 234, DateTimeKind.Unspecified).AddTicks(7913), "Practical Frozen Mouse", 51m, 184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 8, 26, 22, 15, 20, 423, DateTimeKind.Unspecified).AddTicks(1103), "Generic Plastic Chair", 55m, 94 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 1, 4, 6, 15, 58, 859, DateTimeKind.Unspecified).AddTicks(8234), "Generic Rubber Computer", 52m, 157 });

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
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 43, 3, 725, DateTimeKind.Unspecified).AddTicks(6557), "Gorgeous Concrete Tuna", 49m, 71 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 11, 11, 22, 50, 48, 931, DateTimeKind.Unspecified).AddTicks(707), "Practical Fresh Keyboard", 56m, 175 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Jewelery", new DateTime(2022, 6, 29, 18, 31, 56, 414, DateTimeKind.Unspecified).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Baby", new DateTime(2021, 9, 5, 9, 9, 39, 73, DateTimeKind.Unspecified).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Tools", new DateTime(2022, 8, 1, 12, 23, 24, 557, DateTimeKind.Unspecified).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "InsertedDate",
                value: new DateTime(2022, 9, 26, 7, 27, 20, 84, DateTimeKind.Unspecified).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Games", new DateTime(2022, 1, 1, 23, 53, 25, 656, DateTimeKind.Unspecified).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Garden", new DateTime(2021, 9, 16, 1, 49, 35, 657, DateTimeKind.Unspecified).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Home", new DateTime(2021, 5, 17, 16, 10, 21, 512, DateTimeKind.Unspecified).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Games", new DateTime(2022, 2, 17, 8, 46, 12, 35, DateTimeKind.Unspecified).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Toys", new DateTime(2022, 12, 10, 12, 3, 9, 52, DateTimeKind.Unspecified).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Toys", new DateTime(2021, 7, 27, 12, 30, 26, 687, DateTimeKind.Unspecified).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 7, 15, 9, 43, 47, 525, DateTimeKind.Unspecified).AddTicks(1015), "Handmade Fresh Bike", 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 6, 16, 3, 42, 25, 958, DateTimeKind.Unspecified).AddTicks(2942), "Ergonomic Granite Fish", 49m, 168 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 8, new DateTime(2022, 4, 5, 21, 8, 16, 456, DateTimeKind.Unspecified).AddTicks(6070), "Sleek Metal Chair", 132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 3, 28, 1, 38, 6, 122, DateTimeKind.Unspecified).AddTicks(5678), "Ergonomic Concrete Soap", 49m, 141 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2021, 4, 25, 11, 5, 31, 845, DateTimeKind.Unspecified).AddTicks(7404), "Incredible Cotton Pizza", 52m, 197 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 12, 1, 0, 13, 12, 335, DateTimeKind.Unspecified).AddTicks(3963), "Incredible Concrete Towels", 50m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 57, 26, 846, DateTimeKind.Unspecified).AddTicks(8444), "Sleek Cotton Sausages", 52m, 134 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 11, 13, 22, 10, 28, 59, DateTimeKind.Unspecified).AddTicks(2891), "Incredible Concrete Shoes", 122 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 10, 18, 19, 15, 13, 602, DateTimeKind.Unspecified).AddTicks(8848), "Practical Cotton Table", 51m, 174 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 7, 18, 6, 21, 52, 235, DateTimeKind.Unspecified).AddTicks(3351), "Small Cotton Pizza", 50m, 180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 3, 4, 12, 52, 59, 975, DateTimeKind.Unspecified).AddTicks(3700), "Fantastic Rubber Pants", 52m, 109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 7, 18, 1, 33, 22, 275, DateTimeKind.Unspecified).AddTicks(3783), "Gorgeous Fresh Towels", 53m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 3, 20, 15, 30, 2, 222, DateTimeKind.Unspecified).AddTicks(7791), "Tasty Granite Car", 51m, 47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 9, 11, 8, 42, 38, 384, DateTimeKind.Unspecified).AddTicks(9622), "Gorgeous Metal Ball", 53m, 154 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 7, 7, 12, 47, 44, 532, DateTimeKind.Unspecified).AddTicks(5900), "Sleek Concrete Car", 49m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 5, 29, 4, 40, 8, 144, DateTimeKind.Unspecified).AddTicks(3812), "Intelligent Frozen Sausages", 54m, 106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 10, 6, 18, 1, 58, 961, DateTimeKind.Unspecified).AddTicks(6905), "Handcrafted Wooden Fish", 51m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 12, 6, 13, 28, 50, 503, DateTimeKind.Unspecified).AddTicks(9611), "Awesome Plastic Hat", 56m, 138 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 10, 20, 13, 12, 4, 345, DateTimeKind.Unspecified).AddTicks(8560), "Handcrafted Rubber Mouse", 49m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 3, 28, 20, 47, 10, 726, DateTimeKind.Unspecified).AddTicks(1690), "Handmade Granite Mouse", 50m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 9, 27, 6, 41, 15, 528, DateTimeKind.Unspecified).AddTicks(8364), "Rustic Metal Mouse", 49m, 133 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 3, 27, 19, 13, 52, 469, DateTimeKind.Unspecified).AddTicks(6310), "Sleek Metal Ball", 54m, 132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 9, 19, 3, 57, 4, 642, DateTimeKind.Unspecified).AddTicks(2694), "Fantastic Cotton Fish", 49m, 59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 5, 1, 12, 44, 40, 828, DateTimeKind.Unspecified).AddTicks(2822), "Small Metal Bike", 57m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 10, 20, 23, 21, 39, 556, DateTimeKind.Unspecified).AddTicks(7050), "Handmade Soft Soap", 56m, 87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 9, 22, 10, 5, 17, 766, DateTimeKind.Unspecified).AddTicks(9440), "Licensed Rubber Salad", 49m, 73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 3, 15, 21, 13, 52, 906, DateTimeKind.Unspecified).AddTicks(3359), "Rustic Steel Gloves", 52m, 146 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 9, 13, 7, 43, 51, 49, DateTimeKind.Unspecified).AddTicks(9431), "Licensed Plastic Pants", 55m, 139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 3, 30, 18, 13, 15, 537, DateTimeKind.Unspecified).AddTicks(4146), "Awesome Rubber Shoes", 52m, 197 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 8, 9, 8, 50, 31, 424, DateTimeKind.Unspecified).AddTicks(707), "Incredible Metal Soap", 55m, 163 });
        }
    }
}
