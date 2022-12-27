using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myMig : Migration
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
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    RelaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                columns: new[] { "ID", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[] { 1, "All", new DateTime(2021, 12, 15, 10, 39, 27, 595, DateTimeKind.Unspecified).AddTicks(3566), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "CompanyName", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Spinka LLC", new DateTime(2020, 7, 14, 20, 40, 34, 554, DateTimeKind.Unspecified).AddTicks(2891), null, 1 },
                    { 2, "Doyle Inc", new DateTime(2021, 9, 10, 21, 36, 2, 141, DateTimeKind.Unspecified).AddTicks(3060), null, 1 },
                    { 3, "Morissette Group", new DateTime(2020, 7, 11, 23, 9, 20, 295, DateTimeKind.Unspecified).AddTicks(7210), null, 1 },
                    { 4, "Rutherford - Hintz", new DateTime(2020, 12, 20, 11, 48, 16, 7, DateTimeKind.Unspecified).AddTicks(6612), null, 1 },
                    { 5, "Hagenes, Hodkiewicz and Gislason", new DateTime(2022, 11, 14, 16, 25, 31, 617, DateTimeKind.Unspecified).AddTicks(3253), null, 1 },
                    { 6, "Schmeler - Rice", new DateTime(2020, 12, 21, 12, 59, 46, 734, DateTimeKind.Unspecified).AddTicks(7482), null, 1 },
                    { 7, "Mante, Leannon and Hilll", new DateTime(2021, 8, 9, 16, 56, 1, 986, DateTimeKind.Unspecified).AddTicks(9081), null, 1 },
                    { 8, "Balistreri, Collier and Grant", new DateTime(2022, 11, 10, 15, 32, 31, 595, DateTimeKind.Unspecified).AddTicks(241), null, 1 },
                    { 9, "Batz and Sons", new DateTime(2020, 8, 30, 11, 12, 56, 18, DateTimeKind.Unspecified).AddTicks(9736), null, 1 },
                    { 10, "Jacobson - Parisian", new DateTime(2020, 5, 6, 0, 21, 40, 405, DateTimeKind.Unspecified).AddTicks(7667), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 2, "Jewelery", new DateTime(2021, 5, 16, 9, 57, 16, 522, DateTimeKind.Unspecified).AddTicks(3575), null, 1, 1 },
                    { 3, "Music", new DateTime(2020, 10, 14, 7, 22, 38, 334, DateTimeKind.Unspecified).AddTicks(1724), null, 1, 1 },
                    { 5, "Jewelery", new DateTime(2022, 10, 21, 9, 0, 20, 237, DateTimeKind.Unspecified).AddTicks(7910), null, 1, 1 },
                    { 7, "Kids", new DateTime(2021, 1, 3, 12, 57, 18, 637, DateTimeKind.Unspecified).AddTicks(4534), null, 1, 1 },
                    { 9, "Beauty", new DateTime(2020, 7, 15, 11, 42, 38, 736, DateTimeKind.Unspecified).AddTicks(6861), null, 1, 1 },
                    { 4, "Health", new DateTime(2021, 11, 16, 8, 17, 23, 26, DateTimeKind.Unspecified).AddTicks(1312), null, 2, 1 },
                    { 8, "Automotive", new DateTime(2020, 6, 21, 17, 49, 56, 278, DateTimeKind.Unspecified).AddTicks(2337), null, 7, 1 },
                    { 10, "Books", new DateTime(2022, 12, 6, 5, 8, 15, 119, DateTimeKind.Unspecified).AddTicks(1152), null, 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2022, 3, 21, 23, 38, 58, 265, DateTimeKind.Unspecified).AddTicks(2181), null, "Incredible Metal Bike", 55m, 1, 172 },
                    { 3, 3, new DateTime(2022, 5, 15, 14, 3, 32, 259, DateTimeKind.Unspecified).AddTicks(4080), null, "Handcrafted Frozen Ball", 52m, 1, 149 },
                    { 4, 7, new DateTime(2020, 5, 28, 18, 2, 35, 115, DateTimeKind.Unspecified).AddTicks(5804), null, "Handcrafted Plastic Mouse", 56m, 1, 195 },
                    { 5, 5, new DateTime(2020, 10, 22, 14, 34, 23, 86, DateTimeKind.Unspecified).AddTicks(1126), null, "Practical Granite Chips", 57m, 1, 181 },
                    { 7, 9, new DateTime(2022, 12, 20, 23, 32, 42, 513, DateTimeKind.Unspecified).AddTicks(3060), null, "Refined Soft Keyboard", 50m, 1, 137 },
                    { 8, 2, new DateTime(2020, 3, 28, 14, 40, 11, 871, DateTimeKind.Unspecified).AddTicks(5669), null, "Handcrafted Cotton Towels", 49m, 1, 52 },
                    { 11, 9, new DateTime(2022, 2, 20, 14, 52, 52, 207, DateTimeKind.Unspecified).AddTicks(3955), null, "Practical Steel Chair", 54m, 1, 34 },
                    { 12, 3, new DateTime(2020, 10, 5, 13, 35, 5, 32, DateTimeKind.Unspecified).AddTicks(823), null, "Ergonomic Cotton Pants", 52m, 1, 110 },
                    { 13, 2, new DateTime(2021, 9, 29, 18, 54, 49, 307, DateTimeKind.Unspecified).AddTicks(4449), null, "Sleek Granite Computer", 54m, 1, 37 },
                    { 17, 7, new DateTime(2022, 12, 26, 21, 36, 54, 610, DateTimeKind.Unspecified).AddTicks(8655), null, "Refined Fresh Bacon", 57m, 1, 15 },
                    { 18, 3, new DateTime(2021, 5, 8, 17, 51, 47, 630, DateTimeKind.Unspecified).AddTicks(1711), null, "Unbranded Soft Sausages", 52m, 1, 16 },
                    { 19, 9, new DateTime(2022, 12, 6, 20, 56, 19, 26, DateTimeKind.Unspecified).AddTicks(8456), null, "Gorgeous Cotton Mouse", 49m, 1, 115 },
                    { 20, 9, new DateTime(2022, 11, 4, 14, 11, 11, 662, DateTimeKind.Unspecified).AddTicks(5713), null, "Awesome Frozen Gloves", 50m, 1, 154 },
                    { 22, 3, new DateTime(2022, 3, 12, 9, 34, 11, 386, DateTimeKind.Unspecified).AddTicks(7246), null, "Ergonomic Rubber Computer", 57m, 1, 22 },
                    { 23, 3, new DateTime(2020, 6, 3, 5, 49, 51, 456, DateTimeKind.Unspecified).AddTicks(8126), null, "Intelligent Soft Table", 53m, 1, 175 },
                    { 24, 2, new DateTime(2020, 6, 23, 8, 22, 48, 135, DateTimeKind.Unspecified).AddTicks(5762), null, "Incredible Frozen Table", 53m, 1, 195 },
                    { 26, 5, new DateTime(2022, 9, 21, 1, 19, 30, 50, DateTimeKind.Unspecified).AddTicks(8704), null, "Generic Metal Bacon", 54m, 1, 191 },
                    { 28, 5, new DateTime(2022, 8, 28, 11, 15, 49, 262, DateTimeKind.Unspecified).AddTicks(9488), null, "Awesome Concrete Computer", 56m, 1, 36 },
                    { 29, 9, new DateTime(2020, 7, 18, 16, 18, 55, 945, DateTimeKind.Unspecified).AddTicks(7642), null, "Licensed Rubber Pizza", 56m, 1, 106 },
                    { 30, 7, new DateTime(2021, 6, 3, 0, 59, 18, 85, DateTimeKind.Unspecified).AddTicks(652), null, "Generic Plastic Mouse", 53m, 1, 105 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[] { 6, "Home", new DateTime(2020, 10, 17, 2, 7, 29, 599, DateTimeKind.Unspecified).AddTicks(113), null, 4, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 9, 12, 6, 42, 36, 945, DateTimeKind.Unspecified).AddTicks(6885), null, "Solomon Islands", new DateTime(2020, 10, 29, 0, 42, 3, 980, DateTimeKind.Unspecified).AddTicks(6948), 1 },
                    { 3, new DateTime(2020, 12, 14, 7, 2, 1, 597, DateTimeKind.Unspecified).AddTicks(4534), null, "Mauritania", new DateTime(2022, 9, 7, 0, 26, 12, 543, DateTimeKind.Unspecified).AddTicks(7959), 1 },
                    { 4, new DateTime(2020, 7, 11, 16, 40, 45, 423, DateTimeKind.Unspecified).AddTicks(5384), null, "Holy See (Vatican City State)", new DateTime(2021, 4, 6, 14, 27, 36, 508, DateTimeKind.Unspecified).AddTicks(7076), 1 },
                    { 5, new DateTime(2021, 1, 9, 23, 46, 0, 166, DateTimeKind.Unspecified).AddTicks(3874), null, "Macedonia", new DateTime(2020, 3, 24, 9, 11, 38, 588, DateTimeKind.Unspecified).AddTicks(2776), 1 },
                    { 7, new DateTime(2021, 5, 11, 10, 46, 39, 130, DateTimeKind.Unspecified).AddTicks(5410), null, "British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2022, 12, 16, 15, 48, 0, 316, DateTimeKind.Unspecified).AddTicks(4771), 1 },
                    { 8, new DateTime(2021, 3, 11, 16, 17, 32, 884, DateTimeKind.Unspecified).AddTicks(9378), null, "Guam", new DateTime(2021, 3, 27, 19, 26, 52, 16, DateTimeKind.Unspecified).AddTicks(4845), 1 },
                    { 11, new DateTime(2022, 8, 1, 23, 50, 54, 413, DateTimeKind.Unspecified).AddTicks(7051), null, "Solomon Islands", new DateTime(2021, 1, 12, 6, 37, 50, 101, DateTimeKind.Unspecified).AddTicks(8146), 1 },
                    { 12, new DateTime(2021, 8, 4, 8, 55, 19, 862, DateTimeKind.Unspecified).AddTicks(4538), null, "Montserrat", new DateTime(2022, 8, 20, 0, 3, 13, 269, DateTimeKind.Unspecified).AddTicks(1434), 1 },
                    { 13, new DateTime(2022, 8, 15, 9, 47, 53, 245, DateTimeKind.Unspecified).AddTicks(3263), null, "Hungary", new DateTime(2021, 1, 8, 20, 4, 59, 734, DateTimeKind.Unspecified).AddTicks(5440), 1 },
                    { 17, new DateTime(2022, 1, 14, 6, 2, 52, 620, DateTimeKind.Unspecified).AddTicks(7072), null, "Holy See (Vatican City State)", new DateTime(2022, 1, 22, 17, 44, 44, 527, DateTimeKind.Unspecified).AddTicks(9616), 1 },
                    { 18, new DateTime(2020, 3, 19, 22, 0, 0, 906, DateTimeKind.Unspecified).AddTicks(2309), null, "Bangladesh", new DateTime(2022, 5, 27, 19, 16, 30, 652, DateTimeKind.Unspecified).AddTicks(2579), 1 },
                    { 19, new DateTime(2022, 5, 2, 11, 28, 27, 752, DateTimeKind.Unspecified).AddTicks(6427), null, "Svalbard & Jan Mayen Islands", new DateTime(2022, 10, 29, 5, 25, 28, 928, DateTimeKind.Unspecified).AddTicks(6092), 1 },
                    { 20, new DateTime(2021, 9, 28, 0, 1, 14, 651, DateTimeKind.Unspecified).AddTicks(73), null, "Belgium", new DateTime(2020, 3, 24, 16, 46, 19, 821, DateTimeKind.Unspecified).AddTicks(8504), 1 },
                    { 22, new DateTime(2022, 9, 27, 7, 33, 45, 622, DateTimeKind.Unspecified).AddTicks(9857), null, "Guam", new DateTime(2021, 5, 7, 2, 35, 42, 515, DateTimeKind.Unspecified).AddTicks(1869), 1 },
                    { 23, new DateTime(2021, 1, 1, 22, 9, 42, 28, DateTimeKind.Unspecified).AddTicks(3879), null, "Solomon Islands", new DateTime(2021, 5, 9, 10, 41, 38, 216, DateTimeKind.Unspecified).AddTicks(6471), 1 },
                    { 24, new DateTime(2020, 12, 17, 17, 56, 14, 120, DateTimeKind.Unspecified).AddTicks(2080), null, "Aruba", new DateTime(2022, 10, 23, 11, 10, 25, 867, DateTimeKind.Unspecified).AddTicks(1286), 1 },
                    { 26, new DateTime(2021, 11, 24, 0, 45, 39, 85, DateTimeKind.Unspecified).AddTicks(2340), null, "Malawi", new DateTime(2021, 7, 25, 3, 45, 9, 993, DateTimeKind.Unspecified).AddTicks(4288), 1 },
                    { 28, new DateTime(2022, 10, 27, 3, 55, 4, 511, DateTimeKind.Unspecified).AddTicks(4009), null, "Indonesia", new DateTime(2020, 12, 26, 9, 2, 37, 849, DateTimeKind.Unspecified).AddTicks(3485), 1 },
                    { 29, new DateTime(2021, 4, 15, 16, 35, 54, 688, DateTimeKind.Unspecified).AddTicks(9342), null, "Spain", new DateTime(2021, 4, 6, 19, 59, 25, 964, DateTimeKind.Unspecified).AddTicks(983), 1 },
                    { 30, new DateTime(2021, 2, 9, 15, 41, 23, 9, DateTimeKind.Unspecified).AddTicks(3667), null, "Western Sahara", new DateTime(2022, 9, 17, 19, 5, 36, 803, DateTimeKind.Unspecified).AddTicks(2682), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2020, 3, 23, 6, 8, 48, 876, DateTimeKind.Unspecified).AddTicks(6389), null, "Generic Rubber Fish", 56m, 1, 101 },
                    { 6, 10, new DateTime(2021, 1, 27, 8, 37, 2, 839, DateTimeKind.Unspecified).AddTicks(7135), null, "Small Wooden Tuna", 52m, 1, 110 },
                    { 9, 10, new DateTime(2020, 9, 7, 15, 51, 0, 943, DateTimeKind.Unspecified).AddTicks(2031), null, "Refined Rubber Soap", 54m, 1, 35 },
                    { 10, 4, new DateTime(2022, 12, 1, 20, 20, 2, 171, DateTimeKind.Unspecified).AddTicks(549), null, "Practical Frozen Chicken", 57m, 1, 36 },
                    { 15, 10, new DateTime(2020, 9, 4, 23, 29, 42, 28, DateTimeKind.Unspecified).AddTicks(330), null, "Sleek Metal Gloves", 53m, 1, 110 },
                    { 25, 10, new DateTime(2020, 9, 4, 7, 31, 20, 210, DateTimeKind.Unspecified).AddTicks(3674), null, "Tasty Wooden Keyboard", 55m, 1, 6 },
                    { 27, 8, new DateTime(2022, 3, 24, 21, 53, 23, 696, DateTimeKind.Unspecified).AddTicks(5676), null, "Sleek Frozen Tuna", 52m, 1, 26 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2021, 6, 9, 13, 30, 7, 727, DateTimeKind.Unspecified).AddTicks(7186), null, 170, 1 },
                    { 2, 4, new DateTime(2022, 1, 13, 11, 47, 46, 529, DateTimeKind.Unspecified).AddTicks(370), null, 75, 1 },
                    { 2, 5, new DateTime(2021, 7, 27, 14, 14, 55, 86, DateTimeKind.Unspecified).AddTicks(8356), null, 120, 1 },
                    { 2, 6, new DateTime(2022, 11, 19, 10, 21, 42, 684, DateTimeKind.Unspecified).AddTicks(7822), null, 30, 1 },
                    { 2, 9, new DateTime(2022, 4, 7, 6, 36, 5, 83, DateTimeKind.Unspecified).AddTicks(4983), null, 194, 1 },
                    { 3, 1, new DateTime(2022, 2, 15, 18, 56, 48, 598, DateTimeKind.Unspecified).AddTicks(4994), null, 3, 1 },
                    { 3, 8, new DateTime(2021, 11, 28, 10, 27, 24, 65, DateTimeKind.Unspecified).AddTicks(1541), null, 11, 1 },
                    { 4, 2, new DateTime(2022, 6, 17, 11, 59, 40, 630, DateTimeKind.Unspecified).AddTicks(3978), null, 85, 1 },
                    { 4, 5, new DateTime(2022, 2, 4, 10, 55, 17, 792, DateTimeKind.Unspecified).AddTicks(1178), null, 84, 1 },
                    { 5, 1, new DateTime(2020, 7, 25, 0, 22, 33, 841, DateTimeKind.Unspecified).AddTicks(9960), null, 116, 1 },
                    { 5, 3, new DateTime(2022, 9, 7, 16, 22, 25, 487, DateTimeKind.Unspecified).AddTicks(7456), null, 135, 1 },
                    { 5, 6, new DateTime(2020, 11, 13, 12, 44, 33, 293, DateTimeKind.Unspecified).AddTicks(1012), null, 103, 1 },
                    { 5, 7, new DateTime(2022, 1, 8, 23, 23, 46, 710, DateTimeKind.Unspecified).AddTicks(7561), null, 166, 1 },
                    { 5, 10, new DateTime(2022, 5, 15, 18, 44, 57, 481, DateTimeKind.Unspecified).AddTicks(1384), null, 148, 1 },
                    { 7, 1, new DateTime(2020, 9, 29, 9, 31, 17, 265, DateTimeKind.Unspecified).AddTicks(2114), null, 103, 1 },
                    { 7, 2, new DateTime(2021, 2, 9, 5, 41, 5, 692, DateTimeKind.Unspecified).AddTicks(7682), null, 12, 1 },
                    { 7, 6, new DateTime(2021, 6, 2, 8, 59, 53, 586, DateTimeKind.Unspecified).AddTicks(8745), null, 50, 1 },
                    { 8, 1, new DateTime(2020, 9, 2, 20, 17, 48, 305, DateTimeKind.Unspecified).AddTicks(6824), null, 54, 1 },
                    { 8, 2, new DateTime(2021, 3, 16, 3, 54, 41, 490, DateTimeKind.Unspecified).AddTicks(8270), null, 63, 1 },
                    { 8, 3, new DateTime(2022, 3, 9, 12, 16, 17, 164, DateTimeKind.Unspecified).AddTicks(6172), null, 140, 1 },
                    { 8, 8, new DateTime(2022, 3, 17, 23, 51, 36, 370, DateTimeKind.Unspecified).AddTicks(7972), null, 26, 1 },
                    { 11, 1, new DateTime(2021, 9, 1, 15, 58, 1, 67, DateTimeKind.Unspecified).AddTicks(1731), null, 176, 1 },
                    { 11, 5, new DateTime(2022, 8, 13, 13, 43, 39, 482, DateTimeKind.Unspecified).AddTicks(7184), null, 181, 1 },
                    { 11, 7, new DateTime(2020, 12, 9, 16, 40, 14, 714, DateTimeKind.Unspecified).AddTicks(7716), null, 17, 1 },
                    { 11, 9, new DateTime(2021, 6, 8, 0, 57, 48, 49, DateTimeKind.Unspecified).AddTicks(1863), null, 122, 1 },
                    { 12, 2, new DateTime(2021, 11, 24, 5, 54, 53, 769, DateTimeKind.Unspecified).AddTicks(3231), null, 151, 1 },
                    { 12, 6, new DateTime(2022, 4, 21, 23, 24, 41, 430, DateTimeKind.Unspecified).AddTicks(5161), null, 157, 1 },
                    { 12, 10, new DateTime(2020, 5, 29, 19, 15, 8, 453, DateTimeKind.Unspecified).AddTicks(2862), null, 37, 1 },
                    { 13, 3, new DateTime(2021, 1, 1, 15, 29, 49, 62, DateTimeKind.Unspecified).AddTicks(5260), null, 114, 1 },
                    { 13, 6, new DateTime(2021, 9, 18, 14, 15, 45, 775, DateTimeKind.Unspecified).AddTicks(3993), null, 12, 1 },
                    { 13, 10, new DateTime(2020, 10, 10, 19, 26, 26, 341, DateTimeKind.Unspecified).AddTicks(9761), null, 84, 1 },
                    { 17, 1, new DateTime(2020, 4, 16, 14, 59, 46, 822, DateTimeKind.Unspecified).AddTicks(5392), null, 31, 1 },
                    { 17, 2, new DateTime(2021, 3, 14, 0, 44, 46, 652, DateTimeKind.Unspecified).AddTicks(5919), null, 196, 1 },
                    { 17, 3, new DateTime(2022, 5, 31, 16, 51, 36, 101, DateTimeKind.Unspecified).AddTicks(8809), null, 105, 1 },
                    { 17, 4, new DateTime(2021, 12, 30, 16, 33, 50, 359, DateTimeKind.Unspecified).AddTicks(469), null, 71, 1 },
                    { 17, 9, new DateTime(2022, 3, 8, 19, 28, 7, 707, DateTimeKind.Unspecified).AddTicks(622), null, 46, 1 },
                    { 17, 10, new DateTime(2022, 7, 23, 2, 27, 8, 440, DateTimeKind.Unspecified).AddTicks(823), null, 152, 1 },
                    { 18, 6, new DateTime(2022, 4, 21, 1, 27, 8, 769, DateTimeKind.Unspecified).AddTicks(5777), null, 33, 1 },
                    { 18, 8, new DateTime(2020, 4, 11, 19, 43, 15, 336, DateTimeKind.Unspecified).AddTicks(5378), null, 103, 1 },
                    { 19, 6, new DateTime(2022, 8, 19, 13, 56, 35, 875, DateTimeKind.Unspecified).AddTicks(113), null, 181, 1 },
                    { 19, 7, new DateTime(2021, 1, 16, 0, 31, 16, 226, DateTimeKind.Unspecified).AddTicks(6020), null, 192, 1 },
                    { 19, 9, new DateTime(2022, 5, 16, 0, 56, 33, 764, DateTimeKind.Unspecified).AddTicks(6586), null, 64, 1 },
                    { 20, 3, new DateTime(2022, 9, 13, 14, 47, 56, 570, DateTimeKind.Unspecified).AddTicks(7510), null, 21, 1 },
                    { 20, 6, new DateTime(2021, 7, 16, 15, 52, 0, 50, DateTimeKind.Unspecified).AddTicks(9952), null, 149, 1 },
                    { 20, 8, new DateTime(2020, 3, 31, 15, 13, 20, 916, DateTimeKind.Unspecified).AddTicks(9672), null, 51, 1 },
                    { 22, 9, new DateTime(2021, 11, 19, 20, 21, 2, 803, DateTimeKind.Unspecified).AddTicks(488), null, 116, 1 },
                    { 23, 3, new DateTime(2022, 8, 13, 21, 48, 27, 789, DateTimeKind.Unspecified).AddTicks(8679), null, 39, 1 },
                    { 24, 1, new DateTime(2021, 11, 28, 14, 7, 27, 655, DateTimeKind.Unspecified).AddTicks(4386), null, 159, 1 },
                    { 24, 7, new DateTime(2020, 3, 21, 2, 55, 49, 653, DateTimeKind.Unspecified).AddTicks(1565), null, 195, 1 },
                    { 24, 10, new DateTime(2021, 1, 29, 14, 41, 0, 452, DateTimeKind.Unspecified).AddTicks(4099), null, 69, 1 },
                    { 26, 4, new DateTime(2020, 3, 24, 17, 52, 27, 64, DateTimeKind.Unspecified).AddTicks(1908), null, 178, 1 },
                    { 26, 6, new DateTime(2022, 1, 17, 2, 48, 31, 437, DateTimeKind.Unspecified).AddTicks(3347), null, 198, 1 },
                    { 26, 7, new DateTime(2021, 8, 21, 14, 4, 29, 905, DateTimeKind.Unspecified).AddTicks(4544), null, 96, 1 },
                    { 26, 8, new DateTime(2021, 5, 6, 10, 35, 57, 888, DateTimeKind.Unspecified).AddTicks(7544), null, 30, 1 },
                    { 26, 10, new DateTime(2020, 11, 26, 23, 44, 42, 79, DateTimeKind.Unspecified).AddTicks(1691), null, 104, 1 },
                    { 28, 5, new DateTime(2020, 8, 22, 2, 49, 36, 211, DateTimeKind.Unspecified).AddTicks(7624), null, 62, 1 },
                    { 28, 8, new DateTime(2022, 8, 16, 2, 40, 23, 446, DateTimeKind.Unspecified).AddTicks(4482), null, 167, 1 },
                    { 29, 2, new DateTime(2020, 7, 19, 4, 49, 26, 159, DateTimeKind.Unspecified).AddTicks(4789), null, 118, 1 },
                    { 29, 4, new DateTime(2021, 5, 31, 8, 17, 54, 546, DateTimeKind.Unspecified).AddTicks(6459), null, 70, 1 },
                    { 29, 8, new DateTime(2020, 7, 18, 3, 40, 23, 285, DateTimeKind.Unspecified).AddTicks(2808), null, 159, 1 },
                    { 30, 5, new DateTime(2021, 3, 14, 1, 46, 59, 662, DateTimeKind.Unspecified).AddTicks(6179), null, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 20, 10, 12, 50, 373, DateTimeKind.Unspecified).AddTicks(93), null, "Burkina Faso", new DateTime(2022, 11, 10, 3, 54, 36, 724, DateTimeKind.Unspecified).AddTicks(65), 1 },
                    { 6, new DateTime(2021, 10, 2, 6, 21, 40, 277, DateTimeKind.Unspecified).AddTicks(454), null, "Australia", new DateTime(2022, 11, 22, 18, 52, 42, 357, DateTimeKind.Unspecified).AddTicks(2041), 1 },
                    { 9, new DateTime(2020, 7, 20, 10, 8, 1, 330, DateTimeKind.Unspecified).AddTicks(8179), null, "Cameroon", new DateTime(2020, 11, 14, 9, 43, 58, 9, DateTimeKind.Unspecified).AddTicks(1569), 1 },
                    { 10, new DateTime(2020, 9, 30, 13, 38, 45, 961, DateTimeKind.Unspecified).AddTicks(8165), null, "Cyprus", new DateTime(2021, 12, 14, 18, 55, 44, 690, DateTimeKind.Unspecified).AddTicks(9374), 1 },
                    { 15, new DateTime(2021, 10, 18, 22, 37, 13, 494, DateTimeKind.Unspecified).AddTicks(1024), null, "Norway", new DateTime(2020, 8, 24, 2, 57, 4, 784, DateTimeKind.Unspecified).AddTicks(152), 1 },
                    { 25, new DateTime(2022, 1, 17, 22, 6, 4, 199, DateTimeKind.Unspecified).AddTicks(8755), null, "Jamaica", new DateTime(2021, 10, 1, 16, 45, 32, 455, DateTimeKind.Unspecified).AddTicks(253), 1 },
                    { 27, new DateTime(2020, 11, 24, 13, 57, 24, 137, DateTimeKind.Unspecified).AddTicks(8993), null, "Burundi", new DateTime(2020, 7, 15, 15, 24, 49, 984, DateTimeKind.Unspecified).AddTicks(9804), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 14, 6, new DateTime(2021, 10, 19, 7, 40, 19, 69, DateTimeKind.Unspecified).AddTicks(1744), null, "Unbranded Granite Shirt", 55m, 1, 78 },
                    { 16, 6, new DateTime(2022, 3, 8, 12, 15, 56, 600, DateTimeKind.Unspecified).AddTicks(1643), null, "Small Plastic Cheese", 52m, 1, 170 },
                    { 21, 6, new DateTime(2021, 6, 18, 20, 56, 11, 925, DateTimeKind.Unspecified).AddTicks(2705), null, "Sleek Concrete Cheese", 50m, 1, 96 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2021, 6, 27, 5, 38, 56, 321, DateTimeKind.Unspecified).AddTicks(5170), null, 145, 1 },
                    { 6, 1, new DateTime(2020, 5, 26, 16, 49, 21, 728, DateTimeKind.Unspecified).AddTicks(8818), null, 18, 1 },
                    { 6, 2, new DateTime(2020, 9, 26, 3, 4, 22, 520, DateTimeKind.Unspecified).AddTicks(2758), null, 30, 1 },
                    { 6, 3, new DateTime(2022, 9, 29, 21, 41, 1, 611, DateTimeKind.Unspecified).AddTicks(696), null, 184, 1 },
                    { 10, 4, new DateTime(2020, 10, 22, 21, 12, 49, 376, DateTimeKind.Unspecified).AddTicks(2148), null, 47, 1 },
                    { 15, 3, new DateTime(2020, 10, 7, 18, 58, 15, 25, DateTimeKind.Unspecified).AddTicks(2619), null, 73, 1 },
                    { 15, 6, new DateTime(2021, 12, 20, 20, 23, 41, 597, DateTimeKind.Unspecified).AddTicks(678), null, 33, 1 },
                    { 15, 8, new DateTime(2022, 10, 7, 1, 45, 16, 268, DateTimeKind.Unspecified).AddTicks(5210), null, 148, 1 },
                    { 15, 10, new DateTime(2020, 9, 16, 15, 1, 58, 231, DateTimeKind.Unspecified).AddTicks(8845), null, 157, 1 },
                    { 25, 3, new DateTime(2021, 10, 24, 13, 42, 6, 188, DateTimeKind.Unspecified).AddTicks(888), null, 1, 1 },
                    { 25, 7, new DateTime(2020, 5, 15, 12, 55, 18, 811, DateTimeKind.Unspecified).AddTicks(5531), null, 25, 1 },
                    { 25, 10, new DateTime(2021, 7, 16, 9, 19, 35, 667, DateTimeKind.Unspecified).AddTicks(7619), null, 67, 1 },
                    { 27, 3, new DateTime(2020, 9, 9, 0, 23, 56, 356, DateTimeKind.Unspecified).AddTicks(3105), null, 168, 1 },
                    { 27, 5, new DateTime(2022, 11, 15, 19, 52, 27, 701, DateTimeKind.Unspecified).AddTicks(1653), null, 94, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "ID", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 14, new DateTime(2022, 12, 16, 20, 16, 26, 646, DateTimeKind.Unspecified).AddTicks(5763), null, "French Polynesia", new DateTime(2020, 3, 30, 9, 28, 4, 686, DateTimeKind.Unspecified).AddTicks(6589), 1 },
                    { 16, new DateTime(2021, 8, 4, 19, 16, 47, 864, DateTimeKind.Unspecified).AddTicks(7786), null, "Haiti", new DateTime(2022, 3, 12, 14, 18, 2, 147, DateTimeKind.Unspecified).AddTicks(4255), 1 },
                    { 21, new DateTime(2021, 7, 4, 17, 27, 16, 34, DateTimeKind.Unspecified).AddTicks(6707), null, "Malawi", new DateTime(2021, 3, 6, 17, 59, 55, 582, DateTimeKind.Unspecified).AddTicks(6675), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 14, 2, new DateTime(2022, 10, 1, 23, 37, 18, 733, DateTimeKind.Unspecified).AddTicks(1532), null, 109, 1 },
                    { 14, 4, new DateTime(2020, 5, 19, 17, 22, 36, 867, DateTimeKind.Unspecified).AddTicks(7388), null, 172, 1 },
                    { 14, 6, new DateTime(2020, 10, 24, 21, 10, 52, 873, DateTimeKind.Unspecified).AddTicks(3196), null, 34, 1 },
                    { 16, 2, new DateTime(2020, 12, 25, 14, 20, 12, 909, DateTimeKind.Unspecified).AddTicks(38), null, 105, 1 },
                    { 16, 6, new DateTime(2021, 6, 2, 12, 3, 33, 18, DateTimeKind.Unspecified).AddTicks(3546), null, 64, 1 },
                    { 16, 7, new DateTime(2020, 6, 20, 3, 57, 56, 400, DateTimeKind.Unspecified).AddTicks(6988), null, 180, 1 },
                    { 16, 8, new DateTime(2020, 10, 25, 9, 31, 36, 820, DateTimeKind.Unspecified).AddTicks(2902), null, 43, 1 },
                    { 21, 4, new DateTime(2022, 11, 27, 3, 11, 47, 525, DateTimeKind.Unspecified).AddTicks(2768), null, 161, 1 },
                    { 21, 7, new DateTime(2020, 8, 20, 3, 20, 15, 730, DateTimeKind.Unspecified).AddTicks(4605), null, 173, 1 },
                    { 21, 9, new DateTime(2020, 10, 26, 1, 51, 45, 297, DateTimeKind.Unspecified).AddTicks(209), null, 166, 1 }
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
