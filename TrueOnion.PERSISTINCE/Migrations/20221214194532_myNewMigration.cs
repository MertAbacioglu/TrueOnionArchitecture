using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myNewMigration : Migration
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "DeletedDate", "InsertedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Jewelery", null, new DateTime(2022, 6, 29, 18, 31, 56, 414, DateTimeKind.Unspecified).AddTicks(3050), null, 1 },
                    { 2, "Baby", null, new DateTime(2021, 9, 5, 9, 9, 39, 73, DateTimeKind.Unspecified).AddTicks(2435), null, 1 },
                    { 3, "Tools", null, new DateTime(2022, 8, 1, 12, 23, 24, 557, DateTimeKind.Unspecified).AddTicks(7576), null, 1 },
                    { 4, "Clothing", null, new DateTime(2022, 9, 26, 7, 27, 20, 84, DateTimeKind.Unspecified).AddTicks(6179), null, 1 },
                    { 5, "Games", null, new DateTime(2022, 1, 1, 23, 53, 25, 656, DateTimeKind.Unspecified).AddTicks(1339), null, 1 },
                    { 6, "Garden", null, new DateTime(2021, 9, 16, 1, 49, 35, 657, DateTimeKind.Unspecified).AddTicks(8899), null, 1 },
                    { 7, "Home", null, new DateTime(2021, 5, 17, 16, 10, 21, 512, DateTimeKind.Unspecified).AddTicks(5845), null, 1 },
                    { 8, "Games", null, new DateTime(2022, 2, 17, 8, 46, 12, 35, DateTimeKind.Unspecified).AddTicks(5396), null, 1 },
                    { 9, "Toys", null, new DateTime(2022, 12, 10, 12, 3, 9, 52, DateTimeKind.Unspecified).AddTicks(5460), null, 1 },
                    { 10, "Toys", null, new DateTime(2021, 7, 27, 12, 30, 26, 687, DateTimeKind.Unspecified).AddTicks(3658), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "DeletedDate", "InsertedDate", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 7, null, new DateTime(2022, 7, 15, 9, 43, 47, 525, DateTimeKind.Unspecified).AddTicks(1015), null, "Handmade Fresh Bike", 51m, 1, 3 },
                    { 2, 6, null, new DateTime(2022, 6, 16, 3, 42, 25, 958, DateTimeKind.Unspecified).AddTicks(2942), null, "Ergonomic Granite Fish", 49m, 1, 168 },
                    { 3, 8, null, new DateTime(2022, 4, 5, 21, 8, 16, 456, DateTimeKind.Unspecified).AddTicks(6070), null, "Sleek Metal Chair", 53m, 1, 132 },
                    { 4, 2, null, new DateTime(2022, 3, 28, 1, 38, 6, 122, DateTimeKind.Unspecified).AddTicks(5678), null, "Ergonomic Concrete Soap", 49m, 1, 141 },
                    { 5, 7, null, new DateTime(2021, 4, 25, 11, 5, 31, 845, DateTimeKind.Unspecified).AddTicks(7404), null, "Incredible Cotton Pizza", 52m, 1, 197 },
                    { 6, 4, null, new DateTime(2021, 12, 1, 0, 13, 12, 335, DateTimeKind.Unspecified).AddTicks(3963), null, "Incredible Concrete Towels", 50m, 1, 14 },
                    { 7, 9, null, new DateTime(2022, 1, 24, 14, 57, 26, 846, DateTimeKind.Unspecified).AddTicks(8444), null, "Sleek Cotton Sausages", 52m, 1, 134 },
                    { 8, 7, null, new DateTime(2022, 11, 13, 22, 10, 28, 59, DateTimeKind.Unspecified).AddTicks(2891), null, "Incredible Concrete Shoes", 55m, 1, 122 },
                    { 9, 6, null, new DateTime(2021, 10, 18, 19, 15, 13, 602, DateTimeKind.Unspecified).AddTicks(8848), null, "Practical Cotton Table", 51m, 1, 174 },
                    { 10, 2, null, new DateTime(2021, 7, 18, 6, 21, 52, 235, DateTimeKind.Unspecified).AddTicks(3351), null, "Small Cotton Pizza", 50m, 1, 180 },
                    { 11, 7, null, new DateTime(2022, 3, 4, 12, 52, 59, 975, DateTimeKind.Unspecified).AddTicks(3700), null, "Fantastic Rubber Pants", 52m, 1, 109 },
                    { 12, 8, null, new DateTime(2021, 7, 18, 1, 33, 22, 275, DateTimeKind.Unspecified).AddTicks(3783), null, "Gorgeous Fresh Towels", 53m, 1, 12 },
                    { 13, 7, null, new DateTime(2022, 3, 20, 15, 30, 2, 222, DateTimeKind.Unspecified).AddTicks(7791), null, "Tasty Granite Car", 51m, 1, 47 },
                    { 14, 3, null, new DateTime(2021, 9, 11, 8, 42, 38, 384, DateTimeKind.Unspecified).AddTicks(9622), null, "Gorgeous Metal Ball", 53m, 1, 154 },
                    { 15, 7, null, new DateTime(2022, 7, 7, 12, 47, 44, 532, DateTimeKind.Unspecified).AddTicks(5900), null, "Sleek Concrete Car", 49m, 1, 8 },
                    { 16, 6, null, new DateTime(2022, 5, 29, 4, 40, 8, 144, DateTimeKind.Unspecified).AddTicks(3812), null, "Intelligent Frozen Sausages", 54m, 1, 106 },
                    { 17, 6, null, new DateTime(2022, 10, 6, 18, 1, 58, 961, DateTimeKind.Unspecified).AddTicks(6905), null, "Handcrafted Wooden Fish", 51m, 1, 40 },
                    { 18, 8, null, new DateTime(2022, 12, 6, 13, 28, 50, 503, DateTimeKind.Unspecified).AddTicks(9611), null, "Awesome Plastic Hat", 56m, 1, 138 },
                    { 19, 4, null, new DateTime(2021, 10, 20, 13, 12, 4, 345, DateTimeKind.Unspecified).AddTicks(8560), null, "Handcrafted Rubber Mouse", 49m, 1, 18 },
                    { 20, 1, null, new DateTime(2021, 3, 28, 20, 47, 10, 726, DateTimeKind.Unspecified).AddTicks(1690), null, "Handmade Granite Mouse", 50m, 1, 50 },
                    { 21, 4, null, new DateTime(2021, 9, 27, 6, 41, 15, 528, DateTimeKind.Unspecified).AddTicks(8364), null, "Rustic Metal Mouse", 49m, 1, 133 },
                    { 22, 4, null, new DateTime(2021, 3, 27, 19, 13, 52, 469, DateTimeKind.Unspecified).AddTicks(6310), null, "Sleek Metal Ball", 54m, 1, 132 },
                    { 23, 9, null, new DateTime(2022, 9, 19, 3, 57, 4, 642, DateTimeKind.Unspecified).AddTicks(2694), null, "Fantastic Cotton Fish", 49m, 1, 59 },
                    { 24, 10, null, new DateTime(2022, 5, 1, 12, 44, 40, 828, DateTimeKind.Unspecified).AddTicks(2822), null, "Small Metal Bike", 57m, 1, 10 },
                    { 25, 9, null, new DateTime(2022, 10, 20, 23, 21, 39, 556, DateTimeKind.Unspecified).AddTicks(7050), null, "Handmade Soft Soap", 56m, 1, 87 },
                    { 26, 6, null, new DateTime(2021, 9, 22, 10, 5, 17, 766, DateTimeKind.Unspecified).AddTicks(9440), null, "Licensed Rubber Salad", 49m, 1, 73 },
                    { 27, 9, null, new DateTime(2022, 3, 15, 21, 13, 52, 906, DateTimeKind.Unspecified).AddTicks(3359), null, "Rustic Steel Gloves", 52m, 1, 146 },
                    { 28, 6, null, new DateTime(2022, 9, 13, 7, 43, 51, 49, DateTimeKind.Unspecified).AddTicks(9431), null, "Licensed Plastic Pants", 55m, 1, 139 },
                    { 29, 9, null, new DateTime(2021, 3, 30, 18, 13, 15, 537, DateTimeKind.Unspecified).AddTicks(4146), null, "Awesome Rubber Shoes", 52m, 1, 197 },
                    { 30, 3, null, new DateTime(2021, 8, 9, 8, 50, 31, 424, DateTimeKind.Unspecified).AddTicks(707), null, "Incredible Metal Soap", 55m, 1, 163 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
