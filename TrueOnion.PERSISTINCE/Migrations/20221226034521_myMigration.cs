using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myMigration : Migration
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
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Categories",
                        principalColumn: "ID");
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
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "ParentID", "Status" },
                values: new object[] { 1, "All", null, new DateTime(2021, 4, 1, 10, 9, 58, 908, DateTimeKind.Unspecified).AddTicks(124), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "CompanyName", "DeletedDate", "InsertedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Kub Inc", null, new DateTime(2022, 3, 22, 19, 14, 25, 618, DateTimeKind.Unspecified).AddTicks(5595), null, 1 },
                    { 2, "Weissnat and Sons", null, new DateTime(2022, 9, 8, 9, 43, 30, 331, DateTimeKind.Unspecified).AddTicks(7513), null, 1 },
                    { 3, "Predovic, Hintz and Borer", null, new DateTime(2021, 7, 21, 17, 59, 43, 99, DateTimeKind.Unspecified).AddTicks(7884), null, 1 },
                    { 4, "Keeling, Smitham and Raynor", null, new DateTime(2021, 5, 1, 23, 32, 15, 287, DateTimeKind.Unspecified).AddTicks(6255), null, 1 },
                    { 5, "Klein - Shields", null, new DateTime(2021, 9, 13, 8, 28, 17, 897, DateTimeKind.Unspecified).AddTicks(2501), null, 1 },
                    { 6, "Becker - Doyle", null, new DateTime(2021, 6, 19, 0, 31, 3, 62, DateTimeKind.Unspecified).AddTicks(9908), null, 1 },
                    { 7, "Jenkins and Sons", null, new DateTime(2022, 5, 31, 15, 15, 49, 716, DateTimeKind.Unspecified).AddTicks(1775), null, 1 },
                    { 8, "Stoltenberg, Tillman and Barrows", null, new DateTime(2022, 7, 3, 23, 28, 35, 478, DateTimeKind.Unspecified).AddTicks(8817), null, 1 },
                    { 9, "Lockman - Boehm", null, new DateTime(2022, 1, 20, 16, 22, 28, 441, DateTimeKind.Unspecified).AddTicks(5232), null, 1 },
                    { 10, "Huels LLC", null, new DateTime(2022, 3, 14, 1, 33, 5, 98, DateTimeKind.Unspecified).AddTicks(7502), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 2, "Computers", null, new DateTime(2021, 7, 1, 10, 58, 32, 671, DateTimeKind.Unspecified).AddTicks(9537), null, 1, 1 },
                    { 4, "Outdoors", null, new DateTime(2022, 4, 9, 14, 54, 55, 599, DateTimeKind.Unspecified).AddTicks(2540), null, 1, 1 },
                    { 5, "Outdoors", null, new DateTime(2022, 3, 20, 8, 20, 15, 206, DateTimeKind.Unspecified).AddTicks(2809), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 16, 1, null, new DateTime(2022, 2, 21, 22, 57, 52, 907, DateTimeKind.Unspecified).AddTicks(2516), null, "Small Rubber Shirt", 49m, 1, 76 },
                    { 27, 1, null, new DateTime(2022, 3, 12, 11, 54, 18, 580, DateTimeKind.Unspecified).AddTicks(9543), null, "Gorgeous Cotton Pants", 53m, 1, 169 },
                    { 29, 1, null, new DateTime(2021, 8, 30, 2, 53, 25, 927, DateTimeKind.Unspecified).AddTicks(9711), null, "Fantastic Soft Pants", 50m, 1, 153 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 3, "Books", null, new DateTime(2022, 7, 17, 3, 17, 29, 143, DateTimeKind.Unspecified).AddTicks(8039), null, 2, 1 },
                    { 8, "Music", null, new DateTime(2021, 7, 24, 18, 41, 4, 593, DateTimeKind.Unspecified).AddTicks(9238), null, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 16, null, new DateTime(2021, 4, 16, 18, 44, 4, 806, DateTimeKind.Unspecified).AddTicks(3589), "Senegal", null, new DateTime(2022, 11, 18, 23, 37, 6, 389, DateTimeKind.Unspecified).AddTicks(6328), 1 },
                    { 27, null, new DateTime(2022, 11, 16, 9, 46, 36, 882, DateTimeKind.Unspecified).AddTicks(671), "Suriname", null, new DateTime(2021, 7, 8, 10, 56, 50, 366, DateTimeKind.Unspecified).AddTicks(2752), 1 },
                    { 29, null, new DateTime(2022, 6, 17, 21, 33, 51, 785, DateTimeKind.Unspecified).AddTicks(4178), "Canada", null, new DateTime(2021, 11, 27, 21, 0, 19, 199, DateTimeKind.Unspecified).AddTicks(4973), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 4, 4, null, new DateTime(2021, 11, 3, 17, 5, 4, 170, DateTimeKind.Unspecified).AddTicks(2362), null, "Small Fresh Car", 50m, 1, 131 },
                    { 5, 4, null, new DateTime(2022, 1, 10, 22, 33, 0, 0, DateTimeKind.Unspecified).AddTicks(1951), null, "Licensed Wooden Pants", 57m, 1, 185 },
                    { 6, 2, null, new DateTime(2022, 6, 25, 0, 1, 48, 42, DateTimeKind.Unspecified).AddTicks(3269), null, "Licensed Metal Cheese", 51m, 1, 189 },
                    { 7, 5, null, new DateTime(2022, 9, 19, 10, 3, 14, 746, DateTimeKind.Unspecified).AddTicks(5805), null, "Gorgeous Plastic Mouse", 56m, 1, 147 },
                    { 8, 4, null, new DateTime(2021, 4, 6, 23, 11, 46, 877, DateTimeKind.Unspecified).AddTicks(4760), null, "Intelligent Granite Cheese", 54m, 1, 90 },
                    { 9, 4, null, new DateTime(2021, 4, 3, 21, 20, 24, 782, DateTimeKind.Unspecified).AddTicks(5444), null, "Licensed Concrete Sausages", 57m, 1, 59 },
                    { 10, 5, null, new DateTime(2021, 11, 16, 14, 18, 29, 816, DateTimeKind.Unspecified).AddTicks(8036), null, "Practical Concrete Bacon", 54m, 1, 118 },
                    { 13, 4, null, new DateTime(2022, 3, 25, 18, 35, 38, 982, DateTimeKind.Unspecified).AddTicks(9699), null, "Incredible Rubber Towels", 57m, 1, 168 },
                    { 17, 4, null, new DateTime(2022, 4, 3, 4, 35, 43, 481, DateTimeKind.Unspecified).AddTicks(639), null, "Tasty Fresh Towels", 52m, 1, 168 },
                    { 21, 4, null, new DateTime(2021, 4, 29, 20, 7, 10, 963, DateTimeKind.Unspecified).AddTicks(853), null, "Handmade Plastic Salad", 53m, 1, 150 },
                    { 23, 5, null, new DateTime(2022, 10, 22, 4, 33, 30, 159, DateTimeKind.Unspecified).AddTicks(2818), null, "Refined Wooden Car", 55m, 1, 159 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 16, 2, null, new DateTime(2021, 5, 5, 23, 18, 35, 449, DateTimeKind.Unspecified).AddTicks(4019), 113, null, 1 },
                    { 16, 3, null, new DateTime(2022, 12, 8, 10, 45, 31, 41, DateTimeKind.Unspecified).AddTicks(3677), 7, null, 1 },
                    { 16, 6, null, new DateTime(2022, 3, 14, 21, 12, 21, 728, DateTimeKind.Unspecified).AddTicks(8740), 120, null, 1 },
                    { 16, 8, null, new DateTime(2021, 9, 23, 3, 28, 33, 106, DateTimeKind.Unspecified).AddTicks(7597), 110, null, 1 },
                    { 16, 9, null, new DateTime(2021, 4, 5, 1, 29, 49, 500, DateTimeKind.Unspecified).AddTicks(1409), 156, null, 1 },
                    { 27, 9, null, new DateTime(2021, 12, 6, 16, 16, 57, 969, DateTimeKind.Unspecified).AddTicks(6501), 71, null, 1 },
                    { 27, 10, null, new DateTime(2022, 1, 11, 14, 31, 2, 942, DateTimeKind.Unspecified).AddTicks(5708), 8, null, 1 },
                    { 29, 2, null, new DateTime(2022, 1, 13, 8, 7, 1, 121, DateTimeKind.Unspecified).AddTicks(7472), 14, null, 1 },
                    { 29, 3, null, new DateTime(2022, 8, 8, 15, 50, 42, 400, DateTimeKind.Unspecified).AddTicks(1463), 197, null, 1 },
                    { 29, 7, null, new DateTime(2021, 7, 18, 2, 43, 43, 394, DateTimeKind.Unspecified).AddTicks(9303), 200, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 6, "Tools", null, new DateTime(2021, 10, 22, 3, 29, 8, 80, DateTimeKind.Unspecified).AddTicks(7743), null, 3, 1 },
                    { 7, "Grocery", null, new DateTime(2021, 10, 3, 5, 14, 20, 793, DateTimeKind.Unspecified).AddTicks(3498), null, 3, 1 },
                    { 9, "Industrial", null, new DateTime(2022, 9, 1, 17, 43, 45, 277, DateTimeKind.Unspecified).AddTicks(1989), null, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2021, 9, 19, 21, 27, 33, 630, DateTimeKind.Unspecified).AddTicks(7832), "Heard Island and McDonald Islands", null, new DateTime(2022, 11, 14, 19, 50, 18, 296, DateTimeKind.Unspecified).AddTicks(8549), 1 },
                    { 5, null, new DateTime(2022, 9, 27, 5, 52, 51, 812, DateTimeKind.Unspecified).AddTicks(3305), "Fiji", null, new DateTime(2022, 2, 12, 4, 19, 40, 693, DateTimeKind.Unspecified).AddTicks(6130), 1 },
                    { 6, null, new DateTime(2022, 8, 30, 21, 21, 4, 514, DateTimeKind.Unspecified).AddTicks(9837), "Kyrgyz Republic", null, new DateTime(2022, 1, 3, 19, 20, 30, 80, DateTimeKind.Unspecified).AddTicks(7380), 1 },
                    { 7, null, new DateTime(2022, 3, 4, 1, 20, 21, 834, DateTimeKind.Unspecified).AddTicks(7059), "Sri Lanka", null, new DateTime(2022, 11, 5, 5, 45, 26, 405, DateTimeKind.Unspecified).AddTicks(8886), 1 },
                    { 8, null, new DateTime(2022, 8, 22, 15, 33, 17, 80, DateTimeKind.Unspecified).AddTicks(3529), "Zimbabwe", null, new DateTime(2021, 7, 8, 14, 21, 17, 722, DateTimeKind.Unspecified).AddTicks(5454), 1 },
                    { 9, null, new DateTime(2021, 9, 10, 17, 28, 14, 399, DateTimeKind.Unspecified).AddTicks(7620), "Kyrgyz Republic", null, new DateTime(2022, 3, 24, 10, 28, 11, 198, DateTimeKind.Unspecified).AddTicks(422), 1 },
                    { 10, null, new DateTime(2021, 6, 12, 6, 57, 43, 415, DateTimeKind.Unspecified).AddTicks(8114), "Moldova", null, new DateTime(2022, 8, 21, 14, 26, 18, 792, DateTimeKind.Unspecified).AddTicks(5944), 1 },
                    { 13, null, new DateTime(2022, 11, 5, 21, 10, 18, 287, DateTimeKind.Unspecified).AddTicks(2584), "Canada", null, new DateTime(2021, 11, 30, 0, 38, 27, 40, DateTimeKind.Unspecified).AddTicks(4777), 1 },
                    { 17, null, new DateTime(2022, 3, 20, 4, 7, 41, 965, DateTimeKind.Unspecified).AddTicks(3757), "Japan", null, new DateTime(2022, 1, 29, 6, 30, 3, 76, DateTimeKind.Unspecified).AddTicks(6911), 1 },
                    { 21, null, new DateTime(2022, 2, 12, 14, 36, 51, 124, DateTimeKind.Unspecified).AddTicks(1134), "Algeria", null, new DateTime(2021, 9, 28, 9, 29, 14, 814, DateTimeKind.Unspecified).AddTicks(304), 1 },
                    { 23, null, new DateTime(2022, 7, 21, 2, 8, 29, 51, DateTimeKind.Unspecified).AddTicks(211), "Vanuatu", null, new DateTime(2022, 2, 14, 10, 56, 59, 925, DateTimeKind.Unspecified).AddTicks(9108), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 8, null, new DateTime(2022, 6, 9, 6, 57, 21, 661, DateTimeKind.Unspecified).AddTicks(6058), null, "Awesome Granite Pants", 52m, 1, 95 },
                    { 12, 3, null, new DateTime(2022, 6, 7, 20, 28, 18, 176, DateTimeKind.Unspecified).AddTicks(4143), null, "Awesome Frozen Shoes", 53m, 1, 46 },
                    { 14, 8, null, new DateTime(2021, 7, 16, 5, 59, 20, 722, DateTimeKind.Unspecified).AddTicks(9853), null, "Fantastic Fresh Fish", 54m, 1, 161 },
                    { 20, 3, null, new DateTime(2021, 10, 27, 20, 55, 12, 750, DateTimeKind.Unspecified).AddTicks(8387), null, "Licensed Wooden Table", 53m, 1, 126 },
                    { 26, 8, null, new DateTime(2021, 11, 26, 12, 19, 0, 299, DateTimeKind.Unspecified).AddTicks(3424), null, "Generic Cotton Table", 56m, 1, 144 },
                    { 28, 8, null, new DateTime(2021, 8, 7, 9, 8, 12, 945, DateTimeKind.Unspecified).AddTicks(7973), null, "Refined Soft Mouse", 51m, 1, 141 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 4, 1, null, new DateTime(2021, 6, 5, 17, 16, 24, 365, DateTimeKind.Unspecified).AddTicks(3370), 134, null, 1 },
                    { 5, 4, null, new DateTime(2022, 5, 17, 9, 17, 44, 576, DateTimeKind.Unspecified).AddTicks(5505), 111, null, 1 },
                    { 5, 7, null, new DateTime(2022, 1, 15, 10, 27, 41, 330, DateTimeKind.Unspecified).AddTicks(1094), 113, null, 1 },
                    { 5, 8, null, new DateTime(2021, 12, 5, 4, 16, 51, 290, DateTimeKind.Unspecified).AddTicks(631), 172, null, 1 },
                    { 6, 2, null, new DateTime(2021, 6, 18, 22, 29, 49, 787, DateTimeKind.Unspecified).AddTicks(4524), 1, null, 1 },
                    { 6, 9, null, new DateTime(2022, 11, 2, 7, 31, 47, 613, DateTimeKind.Unspecified).AddTicks(1734), 62, null, 1 },
                    { 7, 1, null, new DateTime(2021, 10, 14, 3, 4, 42, 621, DateTimeKind.Unspecified).AddTicks(4585), 127, null, 1 },
                    { 7, 7, null, new DateTime(2021, 6, 27, 0, 3, 41, 406, DateTimeKind.Unspecified).AddTicks(6156), 25, null, 1 },
                    { 8, 2, null, new DateTime(2021, 8, 8, 21, 22, 50, 837, DateTimeKind.Unspecified).AddTicks(8269), 195, null, 1 },
                    { 8, 8, null, new DateTime(2021, 12, 1, 19, 47, 48, 278, DateTimeKind.Unspecified).AddTicks(8415), 131, null, 1 },
                    { 9, 2, null, new DateTime(2021, 4, 8, 16, 2, 7, 558, DateTimeKind.Unspecified).AddTicks(2738), 58, null, 1 },
                    { 9, 3, null, new DateTime(2022, 2, 5, 9, 59, 42, 573, DateTimeKind.Unspecified).AddTicks(7872), 199, null, 1 },
                    { 9, 8, null, new DateTime(2021, 4, 26, 13, 59, 8, 159, DateTimeKind.Unspecified).AddTicks(185), 98, null, 1 },
                    { 10, 8, null, new DateTime(2021, 5, 3, 10, 59, 55, 741, DateTimeKind.Unspecified).AddTicks(1366), 72, null, 1 },
                    { 13, 7, null, new DateTime(2022, 2, 22, 1, 13, 2, 437, DateTimeKind.Unspecified).AddTicks(9137), 134, null, 1 },
                    { 17, 3, null, new DateTime(2022, 11, 14, 20, 39, 12, 611, DateTimeKind.Unspecified).AddTicks(1320), 3, null, 1 },
                    { 17, 5, null, new DateTime(2022, 2, 21, 3, 32, 1, 928, DateTimeKind.Unspecified).AddTicks(5202), 78, null, 1 },
                    { 17, 7, null, new DateTime(2022, 5, 2, 4, 6, 1, 45, DateTimeKind.Unspecified).AddTicks(9640), 84, null, 1 },
                    { 17, 9, null, new DateTime(2022, 1, 26, 17, 40, 27, 927, DateTimeKind.Unspecified).AddTicks(6055), 115, null, 1 },
                    { 21, 3, null, new DateTime(2021, 7, 28, 23, 3, 48, 822, DateTimeKind.Unspecified).AddTicks(4799), 95, null, 1 },
                    { 21, 9, null, new DateTime(2021, 10, 10, 6, 29, 39, 106, DateTimeKind.Unspecified).AddTicks(5574), 21, null, 1 },
                    { 23, 1, null, new DateTime(2022, 6, 27, 18, 34, 52, 441, DateTimeKind.Unspecified).AddTicks(9952), 187, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "ParentID", "Status" },
                values: new object[] { 10, "Baby", null, new DateTime(2021, 12, 13, 15, 5, 42, 985, DateTimeKind.Unspecified).AddTicks(5492), null, 9, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 8, 31, 21, 23, 52, 100, DateTimeKind.Unspecified).AddTicks(5817), "Niger", null, new DateTime(2021, 4, 4, 4, 17, 2, 289, DateTimeKind.Unspecified).AddTicks(6553), 1 },
                    { 12, null, new DateTime(2021, 11, 29, 3, 2, 10, 955, DateTimeKind.Unspecified).AddTicks(881), "Wallis and Futuna", null, new DateTime(2022, 12, 24, 5, 46, 9, 912, DateTimeKind.Unspecified).AddTicks(3630), 1 },
                    { 14, null, new DateTime(2022, 2, 28, 0, 16, 14, 889, DateTimeKind.Unspecified).AddTicks(6210), "Cayman Islands", null, new DateTime(2021, 6, 29, 8, 18, 53, 582, DateTimeKind.Unspecified).AddTicks(3074), 1 },
                    { 20, null, new DateTime(2021, 10, 16, 4, 7, 48, 453, DateTimeKind.Unspecified).AddTicks(123), "Guadeloupe", null, new DateTime(2022, 5, 29, 2, 6, 58, 367, DateTimeKind.Unspecified).AddTicks(429), 1 },
                    { 26, null, new DateTime(2022, 3, 19, 20, 10, 31, 486, DateTimeKind.Unspecified).AddTicks(821), "Poland", null, new DateTime(2021, 6, 1, 7, 18, 1, 343, DateTimeKind.Unspecified).AddTicks(2178), 1 },
                    { 28, null, new DateTime(2022, 7, 18, 10, 37, 18, 445, DateTimeKind.Unspecified).AddTicks(7806), "Sierra Leone", null, new DateTime(2022, 7, 8, 7, 59, 9, 461, DateTimeKind.Unspecified).AddTicks(9934), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 2, 7, null, new DateTime(2022, 1, 8, 23, 27, 42, 412, DateTimeKind.Unspecified).AddTicks(7792), null, "Awesome Frozen Pizza", 56m, 1, 127 },
                    { 3, 7, null, new DateTime(2021, 11, 10, 21, 36, 8, 380, DateTimeKind.Unspecified).AddTicks(737), null, "Rustic Fresh Towels", 54m, 1, 55 },
                    { 15, 9, null, new DateTime(2022, 9, 15, 8, 49, 41, 905, DateTimeKind.Unspecified).AddTicks(5938), null, "Ergonomic Cotton Towels", 50m, 1, 15 },
                    { 18, 6, null, new DateTime(2021, 10, 15, 4, 49, 55, 694, DateTimeKind.Unspecified).AddTicks(430), null, "Gorgeous Granite Bike", 54m, 1, 144 },
                    { 22, 6, null, new DateTime(2021, 9, 1, 13, 38, 17, 722, DateTimeKind.Unspecified).AddTicks(3375), null, "Tasty Wooden Hat", 56m, 1, 38 },
                    { 24, 6, null, new DateTime(2022, 8, 20, 11, 30, 34, 519, DateTimeKind.Unspecified).AddTicks(790), null, "Tasty Rubber Cheese", 51m, 1, 131 },
                    { 25, 6, null, new DateTime(2022, 6, 24, 4, 56, 52, 918, DateTimeKind.Unspecified).AddTicks(5810), null, "Awesome Steel Ball", 56m, 1, 164 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 6, null, new DateTime(2022, 1, 19, 1, 35, 33, 954, DateTimeKind.Unspecified).AddTicks(8798), 142, null, 1 },
                    { 1, 7, null, new DateTime(2022, 1, 20, 14, 51, 12, 843, DateTimeKind.Unspecified).AddTicks(5543), 40, null, 1 },
                    { 1, 8, null, new DateTime(2021, 4, 6, 0, 23, 14, 485, DateTimeKind.Unspecified).AddTicks(6605), 33, null, 1 },
                    { 1, 9, null, new DateTime(2022, 10, 15, 9, 23, 58, 709, DateTimeKind.Unspecified).AddTicks(2654), 80, null, 1 },
                    { 12, 6, null, new DateTime(2022, 5, 31, 5, 11, 5, 980, DateTimeKind.Unspecified).AddTicks(8451), 142, null, 1 },
                    { 12, 7, null, new DateTime(2022, 7, 22, 2, 42, 29, 315, DateTimeKind.Unspecified).AddTicks(6986), 136, null, 1 },
                    { 12, 8, null, new DateTime(2021, 12, 22, 9, 11, 51, 526, DateTimeKind.Unspecified).AddTicks(7558), 156, null, 1 },
                    { 14, 1, null, new DateTime(2022, 2, 12, 2, 52, 45, 870, DateTimeKind.Unspecified).AddTicks(5653), 56, null, 1 },
                    { 14, 6, null, new DateTime(2022, 5, 7, 20, 57, 36, 262, DateTimeKind.Unspecified).AddTicks(560), 42, null, 1 },
                    { 14, 7, null, new DateTime(2022, 6, 11, 2, 26, 50, 721, DateTimeKind.Unspecified).AddTicks(7788), 109, null, 1 },
                    { 14, 8, null, new DateTime(2022, 8, 28, 17, 2, 9, 267, DateTimeKind.Unspecified).AddTicks(1825), 127, null, 1 },
                    { 14, 9, null, new DateTime(2022, 5, 29, 23, 21, 55, 632, DateTimeKind.Unspecified).AddTicks(545), 25, null, 1 },
                    { 14, 10, null, new DateTime(2022, 9, 23, 22, 5, 21, 455, DateTimeKind.Unspecified).AddTicks(9676), 19, null, 1 },
                    { 20, 1, null, new DateTime(2021, 10, 27, 18, 44, 50, 684, DateTimeKind.Unspecified).AddTicks(7292), 138, null, 1 },
                    { 20, 2, null, new DateTime(2021, 7, 29, 0, 59, 46, 762, DateTimeKind.Unspecified).AddTicks(3602), 92, null, 1 },
                    { 20, 9, null, new DateTime(2021, 9, 7, 14, 21, 1, 402, DateTimeKind.Unspecified).AddTicks(8879), 42, null, 1 },
                    { 20, 10, null, new DateTime(2021, 12, 24, 21, 59, 47, 534, DateTimeKind.Unspecified).AddTicks(4915), 63, null, 1 },
                    { 26, 3, null, new DateTime(2022, 11, 3, 3, 21, 25, 842, DateTimeKind.Unspecified).AddTicks(5793), 46, null, 1 },
                    { 26, 8, null, new DateTime(2021, 10, 29, 12, 21, 21, 260, DateTimeKind.Unspecified).AddTicks(9248), 89, null, 1 },
                    { 28, 2, null, new DateTime(2021, 6, 20, 3, 49, 22, 744, DateTimeKind.Unspecified).AddTicks(2144), 163, null, 1 },
                    { 28, 3, null, new DateTime(2022, 6, 13, 21, 8, 50, 754, DateTimeKind.Unspecified).AddTicks(6811), 65, null, 1 },
                    { 28, 4, null, new DateTime(2022, 7, 11, 14, 55, 35, 171, DateTimeKind.Unspecified).AddTicks(5089), 27, null, 1 },
                    { 28, 6, null, new DateTime(2022, 6, 26, 21, 37, 59, 761, DateTimeKind.Unspecified).AddTicks(9231), 26, null, 1 },
                    { 28, 7, null, new DateTime(2022, 1, 25, 14, 21, 43, 200, DateTimeKind.Unspecified).AddTicks(877), 197, null, 1 },
                    { 28, 9, null, new DateTime(2022, 8, 3, 20, 26, 45, 339, DateTimeKind.Unspecified).AddTicks(5882), 23, null, 1 },
                    { 28, 10, null, new DateTime(2022, 7, 17, 8, 41, 30, 149, DateTimeKind.Unspecified).AddTicks(9083), 148, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 8, 22, 11, 48, 28, 682, DateTimeKind.Unspecified).AddTicks(5708), "Netherlands Antilles", null, new DateTime(2021, 9, 16, 8, 13, 41, 619, DateTimeKind.Unspecified).AddTicks(5420), 1 },
                    { 3, null, new DateTime(2022, 6, 7, 11, 36, 28, 913, DateTimeKind.Unspecified).AddTicks(284), "Oman", null, new DateTime(2022, 10, 26, 19, 25, 12, 387, DateTimeKind.Unspecified).AddTicks(3461), 1 },
                    { 15, null, new DateTime(2022, 8, 1, 21, 4, 57, 871, DateTimeKind.Unspecified).AddTicks(9898), "Turkmenistan", null, new DateTime(2022, 2, 22, 22, 20, 2, 630, DateTimeKind.Unspecified).AddTicks(4753), 1 },
                    { 18, null, new DateTime(2021, 4, 21, 11, 18, 46, 762, DateTimeKind.Unspecified).AddTicks(9889), "Hong Kong", null, new DateTime(2022, 1, 19, 12, 33, 6, 769, DateTimeKind.Unspecified).AddTicks(4724), 1 },
                    { 22, null, new DateTime(2022, 11, 10, 15, 48, 35, 286, DateTimeKind.Unspecified).AddTicks(6057), "Oman", null, new DateTime(2022, 7, 28, 16, 52, 8, 742, DateTimeKind.Unspecified).AddTicks(949), 1 },
                    { 24, null, new DateTime(2022, 8, 15, 17, 16, 53, 368, DateTimeKind.Unspecified).AddTicks(2585), "Comoros", null, new DateTime(2021, 5, 14, 15, 6, 49, 640, DateTimeKind.Unspecified).AddTicks(3858), 1 },
                    { 25, null, new DateTime(2021, 12, 25, 4, 38, 23, 623, DateTimeKind.Unspecified).AddTicks(5665), "Albania", null, new DateTime(2022, 3, 19, 13, 50, 51, 151, DateTimeKind.Unspecified).AddTicks(8729), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 11, 10, null, new DateTime(2021, 10, 3, 1, 30, 41, 271, DateTimeKind.Unspecified).AddTicks(6241), null, "Fantastic Frozen Gloves", 55m, 1, 125 },
                    { 19, 10, null, new DateTime(2021, 6, 20, 15, 21, 16, 287, DateTimeKind.Unspecified).AddTicks(657), null, "Ergonomic Steel Shoes", 57m, 1, 46 },
                    { 30, 10, null, new DateTime(2021, 4, 25, 9, 54, 18, 683, DateTimeKind.Unspecified).AddTicks(4832), null, "Fantastic Fresh Keyboard", 52m, 1, 117 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 2, 10, null, new DateTime(2022, 9, 29, 3, 17, 0, 768, DateTimeKind.Unspecified).AddTicks(3213), 163, null, 1 },
                    { 3, 4, null, new DateTime(2021, 8, 22, 2, 24, 38, 315, DateTimeKind.Unspecified).AddTicks(3868), 70, null, 1 },
                    { 3, 7, null, new DateTime(2021, 12, 17, 1, 35, 34, 816, DateTimeKind.Unspecified).AddTicks(3401), 45, null, 1 },
                    { 3, 10, null, new DateTime(2022, 10, 22, 7, 20, 44, 465, DateTimeKind.Unspecified).AddTicks(8366), 193, null, 1 },
                    { 15, 1, null, new DateTime(2021, 7, 13, 14, 11, 29, 306, DateTimeKind.Unspecified).AddTicks(3458), 166, null, 1 },
                    { 15, 7, null, new DateTime(2022, 4, 4, 23, 36, 33, 401, DateTimeKind.Unspecified).AddTicks(9515), 78, null, 1 },
                    { 15, 8, null, new DateTime(2022, 4, 22, 8, 11, 41, 315, DateTimeKind.Unspecified).AddTicks(933), 9, null, 1 },
                    { 18, 3, null, new DateTime(2021, 8, 20, 17, 40, 40, 795, DateTimeKind.Unspecified).AddTicks(949), 71, null, 1 },
                    { 18, 7, null, new DateTime(2021, 12, 28, 12, 46, 22, 91, DateTimeKind.Unspecified).AddTicks(3681), 35, null, 1 },
                    { 18, 9, null, new DateTime(2021, 11, 3, 7, 18, 42, 221, DateTimeKind.Unspecified).AddTicks(6107), 40, null, 1 },
                    { 22, 6, null, new DateTime(2021, 3, 30, 6, 24, 30, 488, DateTimeKind.Unspecified).AddTicks(6075), 157, null, 1 },
                    { 22, 7, null, new DateTime(2021, 12, 31, 18, 27, 9, 48, DateTimeKind.Unspecified).AddTicks(8028), 183, null, 1 },
                    { 24, 3, null, new DateTime(2021, 5, 5, 1, 13, 48, 403, DateTimeKind.Unspecified).AddTicks(8626), 164, null, 1 },
                    { 24, 4, null, new DateTime(2021, 12, 30, 18, 40, 50, 606, DateTimeKind.Unspecified).AddTicks(8576), 69, null, 1 },
                    { 24, 8, null, new DateTime(2021, 10, 18, 6, 6, 46, 65, DateTimeKind.Unspecified).AddTicks(9190), 97, null, 1 },
                    { 25, 3, null, new DateTime(2022, 7, 20, 13, 42, 41, 631, DateTimeKind.Unspecified).AddTicks(609), 75, null, 1 },
                    { 25, 5, null, new DateTime(2021, 8, 9, 11, 0, 14, 951, DateTimeKind.Unspecified).AddTicks(415), 56, null, 1 },
                    { 25, 9, null, new DateTime(2021, 11, 17, 4, 29, 34, 323, DateTimeKind.Unspecified).AddTicks(4137), 162, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "DeletedDate", "InsertedDate", "MadeIn", "ModifiedDate", "RealeseDate", "Status" },
                values: new object[,]
                {
                    { 11, null, new DateTime(2021, 7, 12, 14, 40, 40, 416, DateTimeKind.Unspecified).AddTicks(871), "Nauru", null, new DateTime(2022, 6, 2, 9, 41, 34, 956, DateTimeKind.Unspecified).AddTicks(5132), 1 },
                    { 19, null, new DateTime(2022, 10, 20, 5, 48, 34, 355, DateTimeKind.Unspecified).AddTicks(3834), "San Marino", null, new DateTime(2022, 6, 29, 15, 10, 17, 537, DateTimeKind.Unspecified).AddTicks(5009), 1 },
                    { 30, null, new DateTime(2022, 9, 2, 8, 2, 50, 379, DateTimeKind.Unspecified).AddTicks(3427), "Western Sahara", null, new DateTime(2022, 10, 3, 19, 16, 24, 845, DateTimeKind.Unspecified).AddTicks(9995), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "DeletedDate", "InsertedDate", "MaxCountPerShipping", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 11, 1, null, new DateTime(2021, 11, 30, 8, 14, 29, 902, DateTimeKind.Unspecified).AddTicks(2981), 161, null, 1 },
                    { 11, 2, null, new DateTime(2022, 10, 1, 23, 46, 25, 553, DateTimeKind.Unspecified).AddTicks(3485), 45, null, 1 },
                    { 11, 5, null, new DateTime(2021, 7, 26, 1, 11, 51, 407, DateTimeKind.Unspecified).AddTicks(329), 167, null, 1 },
                    { 11, 6, null, new DateTime(2022, 11, 6, 1, 56, 6, 495, DateTimeKind.Unspecified).AddTicks(2632), 135, null, 1 },
                    { 11, 8, null, new DateTime(2022, 8, 23, 17, 38, 33, 629, DateTimeKind.Unspecified).AddTicks(3578), 44, null, 1 },
                    { 11, 9, null, new DateTime(2022, 10, 12, 21, 56, 51, 271, DateTimeKind.Unspecified).AddTicks(9418), 13, null, 1 },
                    { 19, 1, null, new DateTime(2022, 9, 15, 16, 23, 43, 378, DateTimeKind.Unspecified).AddTicks(1032), 52, null, 1 },
                    { 30, 1, null, new DateTime(2022, 3, 21, 6, 1, 10, 386, DateTimeKind.Unspecified).AddTicks(6926), 132, null, 1 },
                    { 30, 5, null, new DateTime(2021, 4, 5, 12, 44, 54, 573, DateTimeKind.Unspecified).AddTicks(7015), 117, null, 1 },
                    { 30, 6, null, new DateTime(2021, 9, 8, 15, 46, 5, 66, DateTimeKind.Unspecified).AddTicks(2213), 131, null, 1 },
                    { 30, 9, null, new DateTime(2022, 3, 24, 13, 53, 30, 552, DateTimeKind.Unspecified).AddTicks(2460), 57, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentID",
                table: "Categories",
                column: "ParentID");

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
