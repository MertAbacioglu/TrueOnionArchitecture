using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class WhiskeyCola : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealeseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ID",
                        column: x => x.ID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSuppliers",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    MaxCountPerShipping = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSuppliers", x => new { x.ProductID, x.SupplierID });
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Baby", null, new DateTime(2022, 10, 6, 12, 56, 36, 554, DateTimeKind.Unspecified).AddTicks(3677), null, 1 },
                    { 2, "Industrial", null, new DateTime(2021, 7, 2, 9, 1, 13, 575, DateTimeKind.Unspecified).AddTicks(7335), null, 1 },
                    { 3, "Jewelery", null, new DateTime(2022, 3, 22, 2, 14, 12, 799, DateTimeKind.Unspecified).AddTicks(5865), null, 1 },
                    { 4, "Computers", null, new DateTime(2021, 12, 8, 9, 14, 22, 231, DateTimeKind.Unspecified).AddTicks(1906), null, 1 },
                    { 5, "Baby", null, new DateTime(2022, 5, 12, 1, 58, 7, 705, DateTimeKind.Unspecified).AddTicks(3222), null, 1 },
                    { 6, "Beauty", null, new DateTime(2022, 9, 9, 20, 19, 29, 17, DateTimeKind.Unspecified).AddTicks(346), null, 1 },
                    { 7, "Toys", null, new DateTime(2021, 4, 25, 12, 30, 45, 43, DateTimeKind.Unspecified).AddTicks(6052), null, 1 },
                    { 8, "Sports", null, new DateTime(2022, 1, 23, 15, 49, 45, 233, DateTimeKind.Unspecified).AddTicks(6476), null, 1 },
                    { 9, "Garden", null, new DateTime(2022, 12, 5, 13, 37, 59, 919, DateTimeKind.Unspecified).AddTicks(9155), null, 1 },
                    { 10, "Health", null, new DateTime(2021, 4, 28, 15, 43, 22, 867, DateTimeKind.Unspecified).AddTicks(2276), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "CompanyName", "DeletedDate", "InsertedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Ferry - Kertzmann", null, new DateTime(2022, 10, 20, 23, 39, 17, 271, DateTimeKind.Unspecified).AddTicks(6520), null, 1 },
                    { 2, "Witting - Beahan", null, new DateTime(2021, 4, 11, 8, 18, 47, 136, DateTimeKind.Unspecified).AddTicks(8962), null, 1 },
                    { 3, "Armstrong and Sons", null, new DateTime(2021, 7, 1, 23, 29, 54, 175, DateTimeKind.Unspecified).AddTicks(2455), null, 1 },
                    { 4, "Connelly LLC", null, new DateTime(2022, 2, 28, 1, 13, 59, 806, DateTimeKind.Unspecified).AddTicks(4620), null, 1 },
                    { 5, "Reilly - Hettinger", null, new DateTime(2022, 3, 17, 1, 15, 50, 991, DateTimeKind.Unspecified).AddTicks(846), null, 1 },
                    { 6, "Wuckert, Friesen and Pfannerstill", null, new DateTime(2022, 4, 15, 19, 28, 21, 137, DateTimeKind.Unspecified).AddTicks(6551), null, 1 },
                    { 7, "VonRueden, Simonis and Torphy", null, new DateTime(2022, 3, 15, 18, 41, 2, 296, DateTimeKind.Unspecified).AddTicks(3913), null, 1 },
                    { 8, "Blanda - Nader", null, new DateTime(2021, 9, 28, 11, 11, 40, 56, DateTimeKind.Unspecified).AddTicks(3310), null, 1 },
                    { 9, "Kihn LLC", null, new DateTime(2021, 6, 20, 12, 22, 32, 780, DateTimeKind.Unspecified).AddTicks(9273), null, 1 },
                    { 10, "Stiedemann - Watsica", null, new DateTime(2021, 4, 3, 19, 34, 55, 828, DateTimeKind.Unspecified).AddTicks(3469), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 10, null, new DateTime(2022, 12, 6, 5, 28, 5, 584, DateTimeKind.Unspecified).AddTicks(1891), null, "Incredible Granite Bike", 51m, 1, 72 },
                    { 2, 2, null, new DateTime(2022, 8, 26, 12, 15, 2, 787, DateTimeKind.Unspecified).AddTicks(9449), null, "Generic Cotton Towels", 55m, 1, 81 },
                    { 3, 10, null, new DateTime(2021, 8, 11, 15, 32, 48, 314, DateTimeKind.Unspecified).AddTicks(6010), null, "Rustic Rubber Hat", 50m, 1, 93 },
                    { 4, 9, null, new DateTime(2022, 1, 31, 1, 29, 11, 537, DateTimeKind.Unspecified).AddTicks(5064), null, "Incredible Plastic Shoes", 51m, 1, 40 },
                    { 5, 7, null, new DateTime(2021, 10, 9, 9, 0, 9, 360, DateTimeKind.Unspecified).AddTicks(9898), null, "Handmade Soft Pizza", 52m, 1, 76 },
                    { 6, 2, null, new DateTime(2022, 1, 25, 5, 57, 24, 182, DateTimeKind.Unspecified).AddTicks(9808), null, "Handmade Concrete Soap", 56m, 1, 33 },
                    { 7, 2, null, new DateTime(2021, 8, 14, 15, 48, 29, 224, DateTimeKind.Unspecified).AddTicks(1110), null, "Licensed Rubber Tuna", 57m, 1, 7 },
                    { 8, 8, null, new DateTime(2022, 11, 6, 17, 48, 31, 194, DateTimeKind.Unspecified).AddTicks(9570), null, "Handmade Wooden Chicken", 52m, 1, 189 },
                    { 9, 7, null, new DateTime(2022, 11, 29, 4, 50, 12, 195, DateTimeKind.Unspecified).AddTicks(4794), null, "Gorgeous Concrete Bike", 53m, 1, 41 },
                    { 10, 5, null, new DateTime(2022, 2, 6, 7, 27, 30, 712, DateTimeKind.Unspecified).AddTicks(3823), null, "Practical Steel Sausages", 56m, 1, 65 },
                    { 11, 3, null, new DateTime(2021, 8, 17, 17, 17, 29, 465, DateTimeKind.Unspecified).AddTicks(9865), null, "Incredible Granite Chips", 53m, 1, 83 },
                    { 12, 5, null, new DateTime(2021, 8, 29, 22, 47, 23, 593, DateTimeKind.Unspecified).AddTicks(1429), null, "Licensed Steel Table", 55m, 1, 86 },
                    { 13, 5, null, new DateTime(2022, 4, 9, 12, 43, 7, 332, DateTimeKind.Unspecified).AddTicks(9622), null, "Unbranded Steel Soap", 54m, 1, 161 },
                    { 14, 4, null, new DateTime(2022, 3, 11, 7, 24, 55, 362, DateTimeKind.Unspecified).AddTicks(4808), null, "Tasty Granite Table", 53m, 1, 97 },
                    { 15, 10, null, new DateTime(2021, 5, 4, 7, 51, 11, 554, DateTimeKind.Unspecified).AddTicks(2779), null, "Ergonomic Wooden Keyboard", 51m, 1, 82 },
                    { 16, 10, null, new DateTime(2021, 7, 29, 9, 32, 8, 668, DateTimeKind.Unspecified).AddTicks(7518), null, "Sleek Frozen Keyboard", 55m, 1, 87 },
                    { 17, 3, null, new DateTime(2021, 4, 14, 11, 41, 25, 553, DateTimeKind.Unspecified).AddTicks(7746), null, "Unbranded Metal Pizza", 51m, 1, 160 },
                    { 18, 1, null, new DateTime(2021, 4, 3, 10, 13, 55, 915, DateTimeKind.Unspecified).AddTicks(3022), null, "Generic Fresh Hat", 53m, 1, 153 },
                    { 19, 7, null, new DateTime(2022, 9, 6, 15, 1, 36, 530, DateTimeKind.Unspecified).AddTicks(9011), null, "Practical Plastic Keyboard", 50m, 1, 88 },
                    { 20, 3, null, new DateTime(2022, 7, 15, 14, 31, 49, 831, DateTimeKind.Unspecified).AddTicks(3668), null, "Licensed Concrete Car", 52m, 1, 35 },
                    { 21, 6, null, new DateTime(2022, 10, 18, 15, 27, 34, 753, DateTimeKind.Unspecified).AddTicks(2881), null, "Practical Fresh Cheese", 56m, 1, 80 },
                    { 22, 1, null, new DateTime(2021, 5, 25, 5, 17, 36, 325, DateTimeKind.Unspecified).AddTicks(5961), null, "Tasty Concrete Ball", 57m, 1, 189 },
                    { 23, 3, null, new DateTime(2021, 3, 18, 2, 38, 30, 204, DateTimeKind.Unspecified).AddTicks(8874), null, "Sleek Rubber Keyboard", 50m, 1, 140 },
                    { 24, 6, null, new DateTime(2022, 3, 19, 3, 27, 35, 271, DateTimeKind.Unspecified).AddTicks(253), null, "Handmade Concrete Tuna", 56m, 1, 102 },
                    { 25, 8, null, new DateTime(2022, 3, 9, 23, 43, 40, 904, DateTimeKind.Unspecified).AddTicks(5731), null, "Unbranded Plastic Shirt", 54m, 1, 193 },
                    { 26, 2, null, new DateTime(2021, 10, 13, 21, 58, 7, 873, DateTimeKind.Unspecified).AddTicks(6372), null, "Incredible Steel Computer", 55m, 1, 117 },
                    { 27, 7, null, new DateTime(2021, 8, 31, 8, 3, 44, 90, DateTimeKind.Unspecified).AddTicks(8603), null, "Sleek Metal Hat", 54m, 1, 121 },
                    { 28, 7, null, new DateTime(2021, 3, 21, 8, 10, 35, 645, DateTimeKind.Unspecified).AddTicks(6909), null, "Licensed Soft Fish", 51m, 1, 125 },
                    { 29, 5, null, new DateTime(2022, 7, 14, 14, 20, 49, 20, DateTimeKind.Unspecified).AddTicks(5789), null, "Practical Soft Pants", 50m, 1, 171 },
                    { 30, 6, null, new DateTime(2021, 8, 27, 15, 10, 23, 298, DateTimeKind.Unspecified).AddTicks(4049), null, "Awesome Steel Gloves", 52m, 1, 147 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 10, 10, 14, 45, 51, 642, DateTimeKind.Unspecified).AddTicks(3667), "Northern Mariana Islands", null, new DateTime(2021, 7, 22, 0, 58, 19, 446, DateTimeKind.Unspecified).AddTicks(8586), 1 },
                    { 2, null, new DateTime(2021, 6, 3, 17, 49, 5, 535, DateTimeKind.Unspecified).AddTicks(9622), "Gabon", null, new DateTime(2022, 7, 27, 4, 21, 53, 940, DateTimeKind.Unspecified).AddTicks(6746), 1 },
                    { 3, null, new DateTime(2022, 11, 15, 6, 32, 50, 5, DateTimeKind.Unspecified).AddTicks(9724), "Cyprus", null, new DateTime(2022, 9, 28, 0, 13, 44, 703, DateTimeKind.Unspecified).AddTicks(577), 1 },
                    { 4, null, new DateTime(2021, 11, 1, 15, 40, 55, 970, DateTimeKind.Unspecified).AddTicks(8038), "Germany", null, new DateTime(2022, 12, 20, 10, 6, 18, 112, DateTimeKind.Unspecified).AddTicks(2126), 1 },
                    { 5, null, new DateTime(2021, 4, 3, 20, 20, 16, 753, DateTimeKind.Unspecified).AddTicks(2821), "Palau", null, new DateTime(2021, 4, 10, 6, 53, 48, 411, DateTimeKind.Unspecified).AddTicks(5736), 1 },
                    { 6, null, new DateTime(2022, 10, 7, 2, 29, 32, 509, DateTimeKind.Unspecified).AddTicks(8255), "Azerbaijan", null, new DateTime(2021, 8, 10, 11, 45, 48, 495, DateTimeKind.Unspecified).AddTicks(9899), 1 },
                    { 7, null, new DateTime(2021, 4, 25, 13, 15, 10, 123, DateTimeKind.Unspecified).AddTicks(7794), "Albania", null, new DateTime(2021, 8, 12, 18, 29, 14, 884, DateTimeKind.Unspecified).AddTicks(6486), 1 },
                    { 8, null, new DateTime(2021, 4, 24, 2, 0, 40, 348, DateTimeKind.Unspecified).AddTicks(9028), "Bosnia and Herzegovina", null, new DateTime(2022, 6, 20, 5, 9, 50, 325, DateTimeKind.Unspecified).AddTicks(6688), 1 },
                    { 9, null, new DateTime(2021, 11, 6, 0, 5, 25, 599, DateTimeKind.Unspecified).AddTicks(6783), "Malaysia", null, new DateTime(2021, 7, 20, 22, 43, 12, 567, DateTimeKind.Unspecified).AddTicks(4244), 1 },
                    { 10, null, new DateTime(2022, 4, 30, 4, 47, 50, 973, DateTimeKind.Unspecified).AddTicks(491), "Republic of Korea", null, new DateTime(2021, 10, 31, 13, 31, 17, 72, DateTimeKind.Unspecified).AddTicks(3741), 1 },
                    { 11, null, new DateTime(2022, 2, 20, 1, 14, 42, 781, DateTimeKind.Unspecified).AddTicks(8911), "Palestinian Territory", null, new DateTime(2022, 7, 29, 14, 46, 20, 34, DateTimeKind.Unspecified).AddTicks(1654), 1 },
                    { 12, null, new DateTime(2022, 5, 15, 23, 6, 40, 378, DateTimeKind.Unspecified).AddTicks(5846), "Morocco", null, new DateTime(2022, 4, 29, 15, 16, 19, 648, DateTimeKind.Unspecified).AddTicks(8036), 1 },
                    { 13, null, new DateTime(2022, 10, 31, 4, 5, 51, 531, DateTimeKind.Unspecified).AddTicks(8531), "Hungary", null, new DateTime(2021, 5, 10, 15, 56, 27, 172, DateTimeKind.Unspecified).AddTicks(9521), 1 },
                    { 14, null, new DateTime(2021, 5, 31, 9, 3, 35, 642, DateTimeKind.Unspecified).AddTicks(5229), "Iran", null, new DateTime(2022, 7, 12, 0, 54, 10, 61, DateTimeKind.Unspecified).AddTicks(6862), 1 },
                    { 15, null, new DateTime(2022, 12, 10, 3, 0, 0, 865, DateTimeKind.Unspecified).AddTicks(9011), "Singapore", null, new DateTime(2021, 7, 27, 18, 10, 37, 718, DateTimeKind.Unspecified).AddTicks(8561), 1 },
                    { 16, null, new DateTime(2022, 2, 7, 13, 31, 1, 92, DateTimeKind.Unspecified).AddTicks(6049), "Sudan", null, new DateTime(2022, 1, 31, 3, 21, 0, 968, DateTimeKind.Unspecified).AddTicks(1962), 1 },
                    { 17, null, new DateTime(2022, 2, 15, 16, 33, 27, 447, DateTimeKind.Unspecified).AddTicks(9618), "Germany", null, new DateTime(2022, 10, 27, 19, 12, 7, 151, DateTimeKind.Unspecified).AddTicks(6028), 1 },
                    { 18, null, new DateTime(2022, 5, 3, 17, 29, 10, 281, DateTimeKind.Unspecified).AddTicks(939), "Falkland Islands (Malvinas)", null, new DateTime(2022, 7, 6, 2, 23, 53, 10, DateTimeKind.Unspecified).AddTicks(5606), 1 },
                    { 19, null, new DateTime(2022, 3, 14, 13, 4, 51, 173, DateTimeKind.Unspecified).AddTicks(995), "Vietnam", null, new DateTime(2022, 5, 6, 15, 29, 19, 400, DateTimeKind.Unspecified).AddTicks(3240), 1 },
                    { 20, null, new DateTime(2021, 10, 27, 9, 57, 0, 12, DateTimeKind.Unspecified).AddTicks(1363), "Saint Barthelemy", null, new DateTime(2022, 7, 4, 21, 10, 17, 679, DateTimeKind.Unspecified).AddTicks(9501), 1 },
                    { 21, null, new DateTime(2022, 1, 29, 0, 27, 8, 525, DateTimeKind.Unspecified).AddTicks(6712), "Ghana", null, new DateTime(2021, 9, 9, 9, 18, 46, 848, DateTimeKind.Unspecified).AddTicks(5028), 1 },
                    { 22, null, new DateTime(2021, 4, 5, 21, 18, 14, 550, DateTimeKind.Unspecified).AddTicks(9723), "Lesotho", null, new DateTime(2021, 10, 16, 16, 8, 20, 918, DateTimeKind.Unspecified).AddTicks(129), 1 },
                    { 23, null, new DateTime(2022, 5, 19, 17, 46, 52, 316, DateTimeKind.Unspecified).AddTicks(3065), "Benin", null, new DateTime(2022, 3, 10, 10, 3, 13, 653, DateTimeKind.Unspecified).AddTicks(3564), 1 },
                    { 24, null, new DateTime(2022, 2, 26, 10, 29, 0, 699, DateTimeKind.Unspecified).AddTicks(5236), "Saint Pierre and Miquelon", null, new DateTime(2021, 7, 1, 1, 15, 48, 296, DateTimeKind.Unspecified).AddTicks(9957), 1 },
                    { 25, null, new DateTime(2022, 9, 17, 2, 34, 41, 444, DateTimeKind.Unspecified).AddTicks(5687), "United States of America", null, new DateTime(2021, 11, 8, 22, 12, 54, 373, DateTimeKind.Unspecified).AddTicks(2103), 1 },
                    { 26, null, new DateTime(2021, 11, 10, 17, 39, 40, 656, DateTimeKind.Unspecified).AddTicks(2828), "Cayman Islands", null, new DateTime(2022, 8, 3, 16, 48, 47, 216, DateTimeKind.Unspecified).AddTicks(3903), 1 },
                    { 27, null, new DateTime(2021, 4, 5, 6, 34, 9, 754, DateTimeKind.Unspecified).AddTicks(716), "Australia", null, new DateTime(2021, 10, 13, 6, 12, 17, 741, DateTimeKind.Unspecified).AddTicks(6018), 1 },
                    { 28, null, new DateTime(2022, 4, 28, 12, 44, 26, 807, DateTimeKind.Unspecified).AddTicks(6891), "Peru", null, new DateTime(2022, 10, 8, 3, 18, 23, 750, DateTimeKind.Unspecified).AddTicks(1840), 1 },
                    { 29, null, new DateTime(2022, 9, 26, 3, 42, 35, 884, DateTimeKind.Unspecified).AddTicks(2766), "Belgium", null, new DateTime(2022, 2, 9, 2, 46, 57, 549, DateTimeKind.Unspecified).AddTicks(3909), 1 },
                    { 30, null, new DateTime(2022, 3, 11, 23, 57, 50, 114, DateTimeKind.Unspecified).AddTicks(4171), "Peru", null, new DateTime(2021, 6, 23, 2, 15, 52, 57, DateTimeKind.Unspecified).AddTicks(5191), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 2, null, new DateTime(2022, 9, 15, 2, 21, 22, 882, DateTimeKind.Unspecified).AddTicks(7317), 2, null, 1 },
                    { 1, 4, null, new DateTime(2021, 8, 1, 9, 59, 22, 753, DateTimeKind.Unspecified).AddTicks(2275), 132, null, 1 },
                    { 1, 6, null, new DateTime(2021, 8, 15, 12, 45, 4, 10, DateTimeKind.Unspecified).AddTicks(5632), 65, null, 1 },
                    { 1, 7, null, new DateTime(2022, 8, 10, 14, 40, 4, 683, DateTimeKind.Unspecified).AddTicks(3765), 79, null, 1 },
                    { 2, 2, null, new DateTime(2021, 7, 10, 12, 17, 54, 967, DateTimeKind.Unspecified).AddTicks(7096), 83, null, 1 },
                    { 2, 3, null, new DateTime(2022, 9, 8, 15, 28, 12, 993, DateTimeKind.Unspecified).AddTicks(7776), 7, null, 1 },
                    { 2, 5, null, new DateTime(2022, 4, 15, 9, 24, 31, 265, DateTimeKind.Unspecified).AddTicks(3107), 167, null, 1 },
                    { 2, 6, null, new DateTime(2021, 7, 17, 23, 43, 31, 688, DateTimeKind.Unspecified).AddTicks(4991), 112, null, 1 },
                    { 2, 7, null, new DateTime(2022, 6, 26, 5, 43, 3, 476, DateTimeKind.Unspecified).AddTicks(6978), 142, null, 1 },
                    { 2, 8, null, new DateTime(2022, 3, 18, 1, 17, 45, 951, DateTimeKind.Unspecified).AddTicks(779), 85, null, 1 },
                    { 2, 10, null, new DateTime(2022, 12, 18, 7, 44, 13, 249, DateTimeKind.Unspecified).AddTicks(7352), 144, null, 1 },
                    { 3, 5, null, new DateTime(2021, 4, 1, 4, 15, 15, 937, DateTimeKind.Unspecified).AddTicks(1989), 76, null, 1 },
                    { 3, 8, null, new DateTime(2021, 7, 22, 2, 16, 31, 246, DateTimeKind.Unspecified).AddTicks(7310), 34, null, 1 },
                    { 4, 2, null, new DateTime(2021, 9, 10, 17, 16, 40, 139, DateTimeKind.Unspecified).AddTicks(6243), 172, null, 1 },
                    { 4, 3, null, new DateTime(2022, 4, 13, 13, 18, 43, 7, DateTimeKind.Unspecified).AddTicks(4807), 181, null, 1 },
                    { 4, 9, null, new DateTime(2022, 1, 24, 2, 27, 48, 240, DateTimeKind.Unspecified).AddTicks(2056), 81, null, 1 },
                    { 5, 3, null, new DateTime(2021, 4, 11, 16, 39, 36, 581, DateTimeKind.Unspecified).AddTicks(7803), 113, null, 1 },
                    { 5, 7, null, new DateTime(2021, 8, 29, 13, 37, 18, 304, DateTimeKind.Unspecified).AddTicks(76), 75, null, 1 },
                    { 5, 9, null, new DateTime(2021, 12, 26, 13, 12, 8, 113, DateTimeKind.Unspecified).AddTicks(9693), 38, null, 1 },
                    { 5, 10, null, new DateTime(2022, 10, 21, 10, 17, 38, 108, DateTimeKind.Unspecified).AddTicks(7475), 153, null, 1 },
                    { 6, 2, null, new DateTime(2022, 10, 31, 15, 46, 19, 490, DateTimeKind.Unspecified).AddTicks(4739), 70, null, 1 },
                    { 7, 2, null, new DateTime(2022, 6, 8, 3, 6, 11, 280, DateTimeKind.Unspecified).AddTicks(4027), 147, null, 1 },
                    { 7, 8, null, new DateTime(2022, 10, 18, 5, 29, 29, 363, DateTimeKind.Unspecified).AddTicks(9832), 167, null, 1 },
                    { 8, 1, null, new DateTime(2022, 6, 30, 12, 10, 0, 505, DateTimeKind.Unspecified).AddTicks(8126), 149, null, 1 },
                    { 9, 3, null, new DateTime(2021, 10, 14, 2, 53, 43, 793, DateTimeKind.Unspecified).AddTicks(2866), 141, null, 1 },
                    { 9, 6, null, new DateTime(2022, 6, 9, 13, 41, 25, 722, DateTimeKind.Unspecified).AddTicks(9184), 188, null, 1 },
                    { 9, 7, null, new DateTime(2021, 4, 4, 16, 50, 52, 161, DateTimeKind.Unspecified).AddTicks(838), 76, null, 1 },
                    { 9, 9, null, new DateTime(2022, 6, 2, 4, 7, 8, 886, DateTimeKind.Unspecified).AddTicks(8996), 42, null, 1 },
                    { 10, 6, null, new DateTime(2022, 11, 16, 8, 46, 41, 371, DateTimeKind.Unspecified).AddTicks(5234), 73, null, 1 },
                    { 11, 1, null, new DateTime(2022, 12, 16, 17, 31, 19, 117, DateTimeKind.Unspecified).AddTicks(337), 143, null, 1 },
                    { 11, 3, null, new DateTime(2022, 1, 23, 1, 36, 41, 545, DateTimeKind.Unspecified).AddTicks(3783), 134, null, 1 },
                    { 11, 8, null, new DateTime(2022, 3, 26, 12, 29, 32, 586, DateTimeKind.Unspecified).AddTicks(1174), 21, null, 1 },
                    { 12, 2, null, new DateTime(2022, 5, 2, 5, 58, 12, 306, DateTimeKind.Unspecified).AddTicks(8177), 158, null, 1 },
                    { 12, 4, null, new DateTime(2021, 5, 27, 21, 26, 10, 76, DateTimeKind.Unspecified).AddTicks(4869), 100, null, 1 },
                    { 13, 2, null, new DateTime(2021, 3, 23, 3, 24, 14, 821, DateTimeKind.Unspecified).AddTicks(7646), 191, null, 1 },
                    { 13, 3, null, new DateTime(2021, 4, 1, 7, 0, 45, 740, DateTimeKind.Unspecified).AddTicks(686), 91, null, 1 },
                    { 13, 10, null, new DateTime(2022, 3, 6, 14, 17, 17, 747, DateTimeKind.Unspecified).AddTicks(1249), 135, null, 1 },
                    { 14, 4, null, new DateTime(2021, 5, 19, 9, 35, 45, 676, DateTimeKind.Unspecified).AddTicks(3515), 15, null, 1 },
                    { 14, 6, null, new DateTime(2022, 10, 31, 12, 12, 26, 127, DateTimeKind.Unspecified).AddTicks(9642), 32, null, 1 },
                    { 14, 9, null, new DateTime(2021, 9, 30, 19, 44, 38, 208, DateTimeKind.Unspecified).AddTicks(5874), 97, null, 1 },
                    { 15, 9, null, new DateTime(2022, 6, 21, 21, 45, 54, 894, DateTimeKind.Unspecified).AddTicks(1152), 155, null, 1 },
                    { 16, 1, null, new DateTime(2022, 6, 15, 6, 17, 24, 999, DateTimeKind.Unspecified).AddTicks(3974), 33, null, 1 },
                    { 16, 2, null, new DateTime(2022, 12, 1, 10, 4, 22, 662, DateTimeKind.Unspecified).AddTicks(2291), 65, null, 1 },
                    { 16, 8, null, new DateTime(2021, 6, 13, 15, 15, 5, 814, DateTimeKind.Unspecified).AddTicks(9093), 187, null, 1 },
                    { 16, 9, null, new DateTime(2022, 7, 8, 12, 38, 24, 75, DateTimeKind.Unspecified).AddTicks(4994), 26, null, 1 },
                    { 17, 2, null, new DateTime(2022, 12, 6, 7, 35, 33, 75, DateTimeKind.Unspecified).AddTicks(4080), 78, null, 1 },
                    { 17, 5, null, new DateTime(2022, 8, 17, 5, 37, 15, 102, DateTimeKind.Unspecified).AddTicks(26), 58, null, 1 },
                    { 17, 9, null, new DateTime(2022, 7, 23, 19, 31, 12, 957, DateTimeKind.Unspecified).AddTicks(9276), 119, null, 1 },
                    { 17, 10, null, new DateTime(2022, 5, 20, 21, 1, 31, 12, DateTimeKind.Unspecified).AddTicks(7843), 84, null, 1 },
                    { 18, 1, null, new DateTime(2021, 7, 6, 9, 28, 23, 263, DateTimeKind.Unspecified).AddTicks(9043), 101, null, 1 },
                    { 19, 1, null, new DateTime(2021, 11, 4, 7, 45, 34, 775, DateTimeKind.Unspecified).AddTicks(9497), 15, null, 1 },
                    { 19, 3, null, new DateTime(2022, 8, 24, 6, 57, 28, 722, DateTimeKind.Unspecified).AddTicks(6170), 116, null, 1 },
                    { 19, 5, null, new DateTime(2022, 8, 11, 20, 50, 41, 97, DateTimeKind.Unspecified).AddTicks(4446), 32, null, 1 },
                    { 19, 6, null, new DateTime(2022, 7, 5, 2, 25, 31, 172, DateTimeKind.Unspecified).AddTicks(7674), 178, null, 1 },
                    { 19, 8, null, new DateTime(2021, 5, 19, 23, 44, 6, 363, DateTimeKind.Unspecified).AddTicks(3471), 200, null, 1 },
                    { 19, 10, null, new DateTime(2022, 6, 15, 23, 36, 38, 519, DateTimeKind.Unspecified).AddTicks(9960), 121, null, 1 },
                    { 20, 1, null, new DateTime(2022, 7, 25, 13, 56, 52, 6, DateTimeKind.Unspecified).AddTicks(1194), 199, null, 1 },
                    { 20, 2, null, new DateTime(2021, 10, 16, 9, 59, 9, 429, DateTimeKind.Unspecified).AddTicks(6443), 93, null, 1 },
                    { 20, 8, null, new DateTime(2022, 4, 8, 2, 12, 54, 855, DateTimeKind.Unspecified).AddTicks(9769), 61, null, 1 },
                    { 21, 1, null, new DateTime(2021, 9, 16, 10, 1, 14, 601, DateTimeKind.Unspecified).AddTicks(7925), 105, null, 1 },
                    { 21, 3, null, new DateTime(2022, 6, 19, 10, 38, 23, 435, DateTimeKind.Unspecified).AddTicks(9654), 38, null, 1 },
                    { 21, 5, null, new DateTime(2022, 10, 18, 21, 29, 41, 186, DateTimeKind.Unspecified).AddTicks(5874), 167, null, 1 },
                    { 21, 6, null, new DateTime(2022, 4, 12, 6, 28, 37, 720, DateTimeKind.Unspecified).AddTicks(695), 144, null, 1 },
                    { 22, 6, null, new DateTime(2021, 8, 10, 2, 56, 45, 99, DateTimeKind.Unspecified).AddTicks(8435), 24, null, 1 },
                    { 23, 3, null, new DateTime(2021, 12, 30, 15, 4, 39, 288, DateTimeKind.Unspecified).AddTicks(2985), 154, null, 1 },
                    { 23, 8, null, new DateTime(2021, 10, 11, 23, 4, 51, 738, DateTimeKind.Unspecified).AddTicks(814), 132, null, 1 },
                    { 23, 9, null, new DateTime(2021, 9, 25, 6, 31, 52, 556, DateTimeKind.Unspecified).AddTicks(6683), 42, null, 1 },
                    { 23, 10, null, new DateTime(2022, 4, 23, 19, 35, 13, 911, DateTimeKind.Unspecified).AddTicks(7479), 24, null, 1 },
                    { 24, 8, null, new DateTime(2022, 4, 26, 20, 53, 48, 424, DateTimeKind.Unspecified).AddTicks(402), 122, null, 1 },
                    { 24, 9, null, new DateTime(2021, 7, 8, 0, 20, 0, 866, DateTimeKind.Unspecified).AddTicks(7921), 2, null, 1 },
                    { 25, 5, null, new DateTime(2021, 8, 22, 2, 18, 58, 931, DateTimeKind.Unspecified).AddTicks(2617), 1, null, 1 },
                    { 25, 6, null, new DateTime(2021, 10, 3, 2, 26, 24, 524, DateTimeKind.Unspecified).AddTicks(6300), 113, null, 1 },
                    { 25, 8, null, new DateTime(2022, 6, 23, 6, 32, 37, 782, DateTimeKind.Unspecified).AddTicks(7779), 93, null, 1 },
                    { 25, 9, null, new DateTime(2021, 10, 7, 13, 14, 14, 686, DateTimeKind.Unspecified).AddTicks(5810), 145, null, 1 },
                    { 25, 10, null, new DateTime(2021, 9, 10, 7, 42, 41, 486, DateTimeKind.Unspecified).AddTicks(5962), 41, null, 1 },
                    { 26, 1, null, new DateTime(2021, 5, 4, 3, 13, 32, 280, DateTimeKind.Unspecified).AddTicks(8241), 98, null, 1 },
                    { 26, 5, null, new DateTime(2021, 4, 23, 0, 0, 22, 210, DateTimeKind.Unspecified).AddTicks(3837), 99, null, 1 },
                    { 26, 10, null, new DateTime(2021, 11, 5, 22, 24, 40, 583, DateTimeKind.Unspecified).AddTicks(7217), 14, null, 1 },
                    { 27, 4, null, new DateTime(2021, 7, 20, 18, 24, 38, 494, DateTimeKind.Unspecified).AddTicks(73), 7, null, 1 },
                    { 28, 5, null, new DateTime(2021, 5, 2, 14, 0, 32, 46, DateTimeKind.Unspecified).AddTicks(8668), 105, null, 1 },
                    { 28, 6, null, new DateTime(2021, 8, 3, 18, 8, 4, 512, DateTimeKind.Unspecified).AddTicks(9250), 133, null, 1 },
                    { 29, 5, null, new DateTime(2021, 4, 7, 15, 28, 53, 776, DateTimeKind.Unspecified).AddTicks(2160), 126, null, 1 },
                    { 29, 7, null, new DateTime(2022, 11, 28, 4, 58, 33, 166, DateTimeKind.Unspecified).AddTicks(77), 132, null, 1 },
                    { 30, 1, null, new DateTime(2021, 8, 12, 18, 42, 48, 836, DateTimeKind.Unspecified).AddTicks(3808), 10, null, 1 },
                    { 30, 8, null, new DateTime(2022, 11, 16, 1, 57, 2, 426, DateTimeKind.Unspecified).AddTicks(2893), 193, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSuppliers_SupplierID",
                table: "ProductsSuppliers",
                column: "SupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductsSuppliers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
