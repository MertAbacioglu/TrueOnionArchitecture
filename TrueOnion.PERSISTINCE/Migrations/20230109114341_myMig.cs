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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsSuppliers",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSuppliers", x => new { x.ProductId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "InsertedDate", "LastModifiedDate", "Name", "NormalizedName", "DataStatus" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 9, 14, 43, 40, 778, DateTimeKind.Local).AddTicks(2341), null, "Admin", "ADMIN", 1 },
                    { 2, null, new DateTime(2023, 1, 9, 14, 43, 40, 778, DateTimeKind.Local).AddTicks(2543), null, "Member", "MEMBER", 1 },
                    { 3, null, new DateTime(2023, 1, 9, 14, 43, 40, 778, DateTimeKind.Local).AddTicks(2547), null, "Supplier", "SUPPLIER", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "DataStatus", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "daa40086-6fc6-4e1b-b3e4-2f07b0d86cf7", "Domingo.Champlin@gmail.com", true, new DateTime(2020, 10, 21, 4, 21, 59, 208, DateTimeKind.Unspecified).AddTicks(3894), null, false, null, "DOMINGO.CHAMPLIN@GMAIL.COM", "JEWEL14", "aezlsYAQFY", "845-234-7341 x328", false, "wveaZknLmV", 1, false, "Jewel14" },
                    { 2, 0, "22b47f47-d035-4db4-af8e-1830a4cd3cfd", "America_Hayes2@gmail.com", true, new DateTime(2022, 2, 15, 6, 10, 20, 256, DateTimeKind.Unspecified).AddTicks(2381), null, false, null, "AMERICA_HAYES2@GMAIL.COM", "FLORENCIO.LITTLE", "J02BvyYdXz", "588.243.4217 x12375", false, "wLI2xHmKpP", 1, false, "Florencio.Little" },
                    { 3, 0, "5ee89776-2bd0-4452-9b7f-e39e636086f7", "Yesenia16@yahoo.com", true, new DateTime(2022, 9, 21, 6, 26, 38, 457, DateTimeKind.Unspecified).AddTicks(1246), null, false, null, "YESENIA16@YAHOO.COM", "GENESIS57", "xMt4shTSAY", "1-600-827-4635", false, "2Eum4g0RdD", 1, false, "Genesis57" },
                    { 4, 0, "0b308e6f-8ae0-4603-9401-4a246fe3fdcb", "Rodrigo15@hotmail.com", true, new DateTime(2020, 10, 24, 17, 2, 0, 562, DateTimeKind.Unspecified).AddTicks(2714), null, false, null, "RODRIGO15@HOTMAIL.COM", "MYAH_OLSON95", "u9SKAt8Z79", "1-526-357-0767", false, "bvhqCYrv0k", 1, false, "Myah_Olson95" },
                    { 5, 0, "62864d7f-c686-4cf0-b1d4-a494d91a3882", "Garth_Padberg@yahoo.com", true, new DateTime(2020, 9, 18, 9, 37, 51, 82, DateTimeKind.Unspecified).AddTicks(1704), null, false, null, "GARTH_PADBERG@YAHOO.COM", "CARLETON.WHITE74", "lcMeXWzjo9", "(423) 720-0049 x90848", false, "Ye9_J3U1Nt", 1, false, "Carleton.White74" },
                    { 6, 0, "3da33864-202c-4f3e-9622-389934c5589b", "Theodore90@yahoo.com", true, new DateTime(2022, 6, 7, 19, 33, 32, 384, DateTimeKind.Unspecified).AddTicks(110), null, false, null, "THEODORE90@YAHOO.COM", "TERRANCE.LYNCH", "pxS0d7o7Zm", "(518) 733-2592 x8106", false, "ydic7B4DFs", 1, false, "Terrance.Lynch" },
                    { 7, 0, "4b6fb2dc-4158-4118-bad5-5a0a71531a8d", "Stewart_Macejkovic@hotmail.com", true, new DateTime(2020, 7, 27, 22, 43, 18, 452, DateTimeKind.Unspecified).AddTicks(8027), null, false, null, "STEWART_MACEJKOVIC@HOTMAIL.COM", "ESTELLA69", "I5UGlcT_VN", "(531) 369-3815 x94544", false, "KkZzImrfSh", 1, false, "Estella69" },
                    { 8, 0, "8eda4529-7313-463f-8c78-64118b51e879", "Jaiden_Prosacco@hotmail.com", true, new DateTime(2021, 5, 1, 7, 42, 50, 837, DateTimeKind.Unspecified).AddTicks(6858), null, false, null, "JAIDEN_PROSACCO@HOTMAIL.COM", "PERCY49", "sNVvsijKdQ", "1-667-639-1891 x7596", false, "XqbV66Hogs", 1, false, "Percy49" },
                    { 9, 0, "40898040-1cff-4b99-aee7-c790c9010fe3", "Velma.Tromp@hotmail.com", true, new DateTime(2021, 5, 16, 23, 17, 37, 857, DateTimeKind.Unspecified).AddTicks(1350), null, false, null, "VELMA.TROMP@HOTMAIL.COM", "HORACIO96", "hWjTEqg7X4", "1-237-716-5108 x462", false, "bft4eIHfhQ", 1, false, "Horacio96" },
                    { 10, 0, "2e2fa176-9587-4546-b820-ee4a5e8d28a5", "Emory_Heidenreich64@yahoo.com", true, new DateTime(2022, 8, 26, 9, 38, 21, 635, DateTimeKind.Unspecified).AddTicks(313), null, false, null, "EMORY_HEIDENREICH64@YAHOO.COM", "KENYATTA.FLATLEY56", "lzNs1HKIRx", "1-585-475-6923 x0366", false, "B5va77BAEz", 1, false, "Kenyatta.Flatley56" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 1, "All", new DateTime(2020, 8, 4, 10, 54, 9, 311, DateTimeKind.Unspecified).AddTicks(3275), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "14779 Retta Roads, New Hollis, Cyprus", "Bradtke Group", new DateTime(2020, 11, 21, 23, 43, 57, 792, DateTimeKind.Unspecified).AddTicks(4999), null, 1 },
                    { 2, "4419 Herzog Crossing, Coleview, Finland", "Jacobi - Ledner", new DateTime(2021, 3, 7, 22, 55, 47, 282, DateTimeKind.Unspecified).AddTicks(5464), null, 1 },
                    { 3, "47164 Block Fall, South Cliftonport, Peru", "Kris, Bosco and Bogan", new DateTime(2021, 11, 1, 20, 10, 47, 63, DateTimeKind.Unspecified).AddTicks(7324), null, 1 },
                    { 4, "803 Magnus Overpass, East Zena, American Samoa", "Walsh Inc", new DateTime(2021, 8, 7, 16, 48, 56, 364, DateTimeKind.Unspecified).AddTicks(559), null, 1 },
                    { 5, "68397 Rodriguez Crest, Lake Mia, Bermuda", "O'Connell LLC", new DateTime(2022, 3, 14, 16, 22, 33, 858, DateTimeKind.Unspecified).AddTicks(9058), null, 1 },
                    { 6, "579 Rau Manors, Schummshire, Saint Kitts and Nevis", "Lind LLC", new DateTime(2022, 1, 18, 4, 50, 22, 329, DateTimeKind.Unspecified).AddTicks(8280), null, 1 },
                    { 7, "2621 Fleta Bypass, Duaneville, Northern Mariana Islands", "Adams, Willms and Fay", new DateTime(2021, 12, 10, 18, 3, 4, 922, DateTimeKind.Unspecified).AddTicks(9991), null, 1 },
                    { 8, "53195 Klocko Terrace, Robinport, Dominican Republic", "Cartwright Group", new DateTime(2021, 3, 24, 7, 37, 1, 770, DateTimeKind.Unspecified).AddTicks(7236), null, 1 },
                    { 9, "85293 Alene Court, East Ellsworth, Swaziland", "Stamm - Kunde", new DateTime(2021, 9, 14, 11, 22, 3, 506, DateTimeKind.Unspecified).AddTicks(5033), null, 1 },
                    { 10, "844 Sporer Mountain, East Osvaldoville, San Marino", "Dicki - Keeling", new DateTime(2023, 1, 2, 11, 26, 50, 734, DateTimeKind.Unspecified).AddTicks(4932), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "InsertedDate", "LastModifiedDate", "DataStatus" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 22, 16, 50, 52, 360, DateTimeKind.Unspecified).AddTicks(2993), null, 1 },
                    { 1, 2, new DateTime(2020, 11, 24, 15, 3, 58, 105, DateTimeKind.Unspecified).AddTicks(8488), null, 1 },
                    { 1, 3, new DateTime(2020, 6, 5, 15, 47, 50, 488, DateTimeKind.Unspecified).AddTicks(5546), null, 1 },
                    { 1, 4, new DateTime(2022, 9, 12, 12, 28, 0, 981, DateTimeKind.Unspecified).AddTicks(135), null, 1 },
                    { 2, 5, new DateTime(2021, 1, 13, 0, 58, 48, 697, DateTimeKind.Unspecified).AddTicks(6143), null, 1 },
                    { 2, 6, new DateTime(2020, 11, 30, 20, 7, 25, 700, DateTimeKind.Unspecified).AddTicks(6637), null, 1 },
                    { 1, 7, new DateTime(2022, 1, 23, 14, 38, 3, 136, DateTimeKind.Unspecified).AddTicks(8596), null, 1 },
                    { 2, 8, new DateTime(2022, 6, 21, 7, 1, 59, 906, DateTimeKind.Unspecified).AddTicks(3502), null, 1 },
                    { 2, 9, new DateTime(2020, 6, 9, 21, 26, 8, 835, DateTimeKind.Unspecified).AddTicks(8997), null, 1 },
                    { 3, 10, new DateTime(2022, 3, 30, 1, 12, 10, 347, DateTimeKind.Unspecified).AddTicks(384), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 2, "Baby", new DateTime(2022, 12, 21, 5, 33, 19, 984, DateTimeKind.Unspecified).AddTicks(6193), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 8, 1, new DateTime(2020, 5, 1, 7, 0, 44, 975, DateTimeKind.Unspecified).AddTicks(6204), null, "Licensed Cotton Tuna", 1 },
                    { 9, 1, new DateTime(2022, 4, 20, 17, 9, 16, 318, DateTimeKind.Unspecified).AddTicks(4566), null, "Awesome Granite Mouse", 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 3, "Books", new DateTime(2020, 10, 22, 20, 37, 34, 817, DateTimeKind.Unspecified).AddTicks(8199), null, 2, 1 },
                    { 6, "Garden", new DateTime(2021, 5, 23, 3, 20, 41, 137, DateTimeKind.Unspecified).AddTicks(6120), null, 2, 1 },
                    { 7, "Movies", new DateTime(2022, 1, 22, 8, 48, 32, 492, DateTimeKind.Unspecified).AddTicks(6997), null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 12, 20, 8, 54, 27, 43, DateTimeKind.Unspecified).AddTicks(5503), null, "Malta", new DateTime(2022, 10, 13, 11, 51, 55, 199, DateTimeKind.Unspecified).AddTicks(1892), 1 },
                    { 9, new DateTime(2021, 4, 22, 12, 43, 38, 653, DateTimeKind.Unspecified).AddTicks(7002), null, "Iraq", new DateTime(2020, 4, 7, 8, 4, 10, 375, DateTimeKind.Unspecified).AddTicks(1011), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2020, 3, 19, 4, 34, 50, 494, DateTimeKind.Unspecified).AddTicks(6441), null, "Gorgeous Metal Pizza", 1 },
                    { 6, 2, new DateTime(2022, 9, 10, 4, 19, 42, 189, DateTimeKind.Unspecified).AddTicks(1121), null, "Unbranded Rubber Shirt", 1 },
                    { 17, 2, new DateTime(2022, 8, 29, 4, 55, 7, 451, DateTimeKind.Unspecified).AddTicks(8330), null, "Incredible Wooden Soap", 1 },
                    { 22, 2, new DateTime(2020, 10, 27, 14, 36, 22, 692, DateTimeKind.Unspecified).AddTicks(8162), null, "Small Soft Chicken", 1 },
                    { 25, 2, new DateTime(2022, 6, 12, 21, 56, 33, 465, DateTimeKind.Unspecified).AddTicks(5973), null, "Ergonomic Plastic Mouse", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 9, 4, new DateTime(2021, 10, 24, 17, 54, 54, 549, DateTimeKind.Unspecified).AddTicks(1915), null, 57m, 1, 19 },
                    { 9, 5, new DateTime(2022, 4, 26, 1, 50, 42, 25, DateTimeKind.Unspecified).AddTicks(6453), null, 52m, 1, 22 },
                    { 9, 8, new DateTime(2021, 6, 5, 19, 2, 30, 334, DateTimeKind.Unspecified).AddTicks(7822), null, 52m, 1, 89 },
                    { 9, 10, new DateTime(2022, 9, 30, 10, 39, 28, 449, DateTimeKind.Unspecified).AddTicks(3830), null, 49m, 1, 19 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 4, "Automotive", new DateTime(2020, 8, 14, 15, 44, 50, 804, DateTimeKind.Unspecified).AddTicks(8054), null, 3, 1 },
                    { 8, "Garden", new DateTime(2020, 3, 15, 10, 27, 58, 949, DateTimeKind.Unspecified).AddTicks(7026), null, 3, 1 },
                    { 10, "Outdoors", new DateTime(2021, 4, 29, 6, 19, 37, 736, DateTimeKind.Unspecified).AddTicks(6454), null, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 12, 29, 3, 22, 47, 723, DateTimeKind.Unspecified).AddTicks(6016), null, "Vanuatu", new DateTime(2020, 10, 28, 4, 40, 11, 810, DateTimeKind.Unspecified).AddTicks(3863), 1 },
                    { 6, new DateTime(2021, 6, 29, 16, 13, 34, 665, DateTimeKind.Unspecified).AddTicks(226), null, "Aruba", new DateTime(2020, 5, 30, 5, 16, 33, 818, DateTimeKind.Unspecified).AddTicks(5110), 1 },
                    { 17, new DateTime(2021, 5, 11, 0, 1, 27, 986, DateTimeKind.Unspecified).AddTicks(5565), null, "Solomon Islands", new DateTime(2020, 5, 1, 15, 53, 9, 453, DateTimeKind.Unspecified).AddTicks(6330), 1 },
                    { 22, new DateTime(2021, 4, 17, 6, 30, 52, 681, DateTimeKind.Unspecified).AddTicks(239), null, "Aruba", new DateTime(2020, 11, 14, 11, 54, 46, 234, DateTimeKind.Unspecified).AddTicks(8988), 1 },
                    { 25, new DateTime(2020, 12, 18, 20, 5, 10, 876, DateTimeKind.Unspecified).AddTicks(7830), null, "Grenada", new DateTime(2021, 11, 5, 18, 55, 50, 466, DateTimeKind.Unspecified).AddTicks(570), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 3, 7, new DateTime(2022, 12, 7, 22, 0, 44, 557, DateTimeKind.Unspecified).AddTicks(6102), null, "Licensed Plastic Computer", 1 },
                    { 12, 6, new DateTime(2020, 8, 25, 5, 29, 13, 145, DateTimeKind.Unspecified).AddTicks(6888), null, "Handcrafted Concrete Computer", 1 },
                    { 15, 6, new DateTime(2021, 6, 29, 4, 5, 27, 406, DateTimeKind.Unspecified).AddTicks(2330), null, "Incredible Cotton Computer", 1 },
                    { 23, 7, new DateTime(2022, 10, 26, 19, 18, 54, 927, DateTimeKind.Unspecified).AddTicks(2962), null, "Handmade Metal Pizza", 1 },
                    { 24, 6, new DateTime(2022, 4, 24, 10, 32, 13, 366, DateTimeKind.Unspecified).AddTicks(155), null, "Rustic Granite Cheese", 1 },
                    { 27, 7, new DateTime(2022, 5, 9, 13, 3, 48, 357, DateTimeKind.Unspecified).AddTicks(2536), null, "Practical Fresh Shoes", 1 },
                    { 28, 7, new DateTime(2020, 7, 4, 15, 56, 33, 601, DateTimeKind.Unspecified).AddTicks(8849), null, "Awesome Granite Sausages", 1 },
                    { 30, 6, new DateTime(2020, 6, 23, 8, 58, 40, 175, DateTimeKind.Unspecified).AddTicks(5528), null, "Ergonomic Rubber Fish", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2022, 1, 24, 20, 8, 58, 714, DateTimeKind.Unspecified).AddTicks(2208), null, 52m, 1, 130 },
                    { 4, 3, new DateTime(2022, 10, 8, 21, 23, 16, 693, DateTimeKind.Unspecified).AddTicks(9988), null, 53m, 1, 16 },
                    { 4, 4, new DateTime(2020, 5, 16, 2, 1, 44, 267, DateTimeKind.Unspecified).AddTicks(5388), null, 51m, 1, 65 },
                    { 6, 4, new DateTime(2020, 9, 5, 2, 48, 20, 725, DateTimeKind.Unspecified).AddTicks(8666), null, 55m, 1, 34 },
                    { 6, 9, new DateTime(2021, 5, 13, 2, 4, 49, 601, DateTimeKind.Unspecified).AddTicks(2250), null, 54m, 1, 171 },
                    { 6, 10, new DateTime(2021, 1, 26, 23, 38, 53, 123, DateTimeKind.Unspecified).AddTicks(352), null, 55m, 1, 28 },
                    { 17, 3, new DateTime(2022, 8, 22, 1, 25, 47, 685, DateTimeKind.Unspecified).AddTicks(8259), null, 51m, 1, 27 },
                    { 17, 4, new DateTime(2022, 11, 14, 9, 6, 27, 793, DateTimeKind.Unspecified).AddTicks(4585), null, 51m, 1, 34 },
                    { 17, 5, new DateTime(2020, 5, 18, 23, 3, 50, 177, DateTimeKind.Unspecified).AddTicks(7574), null, 56m, 1, 107 },
                    { 22, 2, new DateTime(2021, 8, 19, 20, 36, 54, 129, DateTimeKind.Unspecified).AddTicks(4668), null, 55m, 1, 151 },
                    { 22, 6, new DateTime(2022, 8, 6, 11, 38, 34, 90, DateTimeKind.Unspecified).AddTicks(274), null, 53m, 1, 61 },
                    { 25, 4, new DateTime(2021, 11, 23, 10, 14, 14, 790, DateTimeKind.Unspecified).AddTicks(5362), null, 49m, 1, 97 },
                    { 25, 5, new DateTime(2022, 12, 3, 3, 56, 41, 797, DateTimeKind.Unspecified).AddTicks(811), null, 55m, 1, 89 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 5, "Automotive", new DateTime(2022, 4, 22, 11, 48, 39, 121, DateTimeKind.Unspecified).AddTicks(8262), null, 4, 1 },
                    { 9, "Automotive", new DateTime(2022, 12, 29, 10, 23, 42, 621, DateTimeKind.Unspecified).AddTicks(106), null, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 8, 13, 7, 34, 11, 668, DateTimeKind.Unspecified).AddTicks(687), null, "Moldova", new DateTime(2021, 3, 21, 22, 16, 56, 942, DateTimeKind.Unspecified).AddTicks(5257), 1 },
                    { 12, new DateTime(2022, 2, 21, 18, 52, 54, 165, DateTimeKind.Unspecified).AddTicks(3391), null, "Northern Mariana Islands", new DateTime(2022, 8, 16, 17, 38, 51, 662, DateTimeKind.Unspecified).AddTicks(2545), 1 },
                    { 15, new DateTime(2020, 7, 19, 8, 8, 50, 671, DateTimeKind.Unspecified).AddTicks(3158), null, "South Africa", new DateTime(2022, 11, 3, 12, 57, 54, 523, DateTimeKind.Unspecified).AddTicks(7400), 1 },
                    { 23, new DateTime(2021, 11, 12, 14, 27, 4, 258, DateTimeKind.Unspecified).AddTicks(1357), null, "Timor-Leste", new DateTime(2022, 6, 17, 2, 13, 26, 310, DateTimeKind.Unspecified).AddTicks(6088), 1 },
                    { 24, new DateTime(2022, 7, 3, 10, 6, 48, 171, DateTimeKind.Unspecified).AddTicks(1100), null, "Thailand", new DateTime(2020, 10, 21, 17, 30, 19, 749, DateTimeKind.Unspecified).AddTicks(3001), 1 },
                    { 27, new DateTime(2022, 5, 26, 0, 32, 26, 328, DateTimeKind.Unspecified).AddTicks(8508), null, "Sweden", new DateTime(2022, 1, 14, 19, 51, 59, 485, DateTimeKind.Unspecified).AddTicks(238), 1 },
                    { 28, new DateTime(2021, 3, 22, 13, 10, 57, 676, DateTimeKind.Unspecified).AddTicks(6234), null, "Thailand", new DateTime(2020, 10, 28, 20, 4, 26, 244, DateTimeKind.Unspecified).AddTicks(3166), 1 },
                    { 30, new DateTime(2022, 4, 9, 14, 6, 48, 684, DateTimeKind.Unspecified).AddTicks(5243), null, "Iraq", new DateTime(2021, 10, 8, 19, 57, 1, 887, DateTimeKind.Unspecified).AddTicks(5946), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2022, 7, 15, 18, 28, 10, 310, DateTimeKind.Unspecified).AddTicks(4742), null, "Fantastic Metal Shoes", 1 },
                    { 2, 8, new DateTime(2021, 11, 27, 2, 56, 30, 335, DateTimeKind.Unspecified).AddTicks(4385), null, "Gorgeous Wooden Gloves", 1 },
                    { 5, 10, new DateTime(2022, 10, 13, 2, 18, 21, 558, DateTimeKind.Unspecified).AddTicks(9952), null, "Awesome Wooden Tuna", 1 },
                    { 7, 8, new DateTime(2022, 10, 22, 13, 38, 56, 268, DateTimeKind.Unspecified).AddTicks(4872), null, "Tasty Wooden Chips", 1 },
                    { 10, 10, new DateTime(2021, 6, 26, 14, 35, 40, 428, DateTimeKind.Unspecified).AddTicks(1450), null, "Tasty Plastic Fish", 1 },
                    { 13, 10, new DateTime(2022, 11, 12, 12, 25, 50, 899, DateTimeKind.Unspecified).AddTicks(3390), null, "Generic Soft Salad", 1 },
                    { 16, 8, new DateTime(2022, 9, 16, 20, 22, 2, 507, DateTimeKind.Unspecified).AddTicks(3106), null, "Tasty Soft Ball", 1 },
                    { 19, 10, new DateTime(2022, 11, 26, 4, 1, 8, 689, DateTimeKind.Unspecified).AddTicks(3254), null, "Ergonomic Granite Shoes", 1 },
                    { 21, 8, new DateTime(2020, 9, 28, 6, 54, 19, 220, DateTimeKind.Unspecified).AddTicks(2750), null, "Incredible Wooden Pants", 1 },
                    { 26, 8, new DateTime(2022, 11, 4, 13, 4, 50, 60, DateTimeKind.Unspecified).AddTicks(1010), null, "Practical Frozen Chair", 1 },
                    { 29, 4, new DateTime(2022, 8, 5, 17, 7, 49, 105, DateTimeKind.Unspecified).AddTicks(6567), null, "Tasty Plastic Shirt", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2021, 7, 3, 19, 17, 18, 270, DateTimeKind.Unspecified).AddTicks(5863), null, 50m, 1, 175 },
                    { 3, 2, new DateTime(2021, 2, 19, 15, 20, 10, 254, DateTimeKind.Unspecified).AddTicks(7965), null, 52m, 1, 91 },
                    { 3, 3, new DateTime(2020, 12, 19, 18, 1, 19, 890, DateTimeKind.Unspecified).AddTicks(8057), null, 53m, 1, 74 },
                    { 3, 5, new DateTime(2020, 10, 10, 14, 45, 23, 172, DateTimeKind.Unspecified).AddTicks(3294), null, 54m, 1, 135 },
                    { 3, 6, new DateTime(2021, 3, 27, 15, 37, 33, 166, DateTimeKind.Unspecified).AddTicks(4180), null, 53m, 1, 46 },
                    { 3, 8, new DateTime(2020, 12, 20, 13, 31, 54, 844, DateTimeKind.Unspecified).AddTicks(6391), null, 57m, 1, 157 },
                    { 3, 10, new DateTime(2020, 11, 26, 10, 29, 49, 448, DateTimeKind.Unspecified).AddTicks(2189), null, 50m, 1, 147 },
                    { 12, 3, new DateTime(2022, 8, 1, 4, 31, 39, 769, DateTimeKind.Unspecified).AddTicks(4166), null, 54m, 1, 32 },
                    { 12, 5, new DateTime(2022, 11, 2, 7, 11, 32, 724, DateTimeKind.Unspecified).AddTicks(3282), null, 54m, 1, 92 },
                    { 12, 10, new DateTime(2020, 7, 30, 0, 5, 58, 47, DateTimeKind.Unspecified).AddTicks(1816), null, 51m, 1, 178 },
                    { 15, 8, new DateTime(2022, 9, 30, 7, 10, 18, 676, DateTimeKind.Unspecified).AddTicks(9146), null, 51m, 1, 9 },
                    { 15, 9, new DateTime(2021, 12, 1, 10, 45, 3, 72, DateTimeKind.Unspecified).AddTicks(459), null, 57m, 1, 25 },
                    { 23, 4, new DateTime(2020, 5, 27, 16, 35, 20, 451, DateTimeKind.Unspecified).AddTicks(3284), null, 53m, 1, 97 },
                    { 23, 5, new DateTime(2020, 8, 26, 0, 6, 3, 946, DateTimeKind.Unspecified).AddTicks(1341), null, 52m, 1, 176 },
                    { 23, 10, new DateTime(2022, 9, 15, 11, 52, 55, 497, DateTimeKind.Unspecified).AddTicks(8670), null, 50m, 1, 197 },
                    { 24, 4, new DateTime(2022, 11, 19, 22, 26, 11, 653, DateTimeKind.Unspecified).AddTicks(1702), null, 56m, 1, 128 },
                    { 24, 9, new DateTime(2021, 4, 15, 0, 29, 20, 36, DateTimeKind.Unspecified).AddTicks(6837), null, 55m, 1, 104 },
                    { 27, 6, new DateTime(2022, 11, 26, 13, 13, 6, 614, DateTimeKind.Unspecified).AddTicks(3015), null, 49m, 1, 13 },
                    { 27, 8, new DateTime(2022, 8, 25, 18, 50, 53, 151, DateTimeKind.Unspecified).AddTicks(9631), null, 52m, 1, 123 },
                    { 28, 2, new DateTime(2020, 8, 29, 5, 59, 44, 241, DateTimeKind.Unspecified).AddTicks(1055), null, 56m, 1, 95 },
                    { 28, 3, new DateTime(2021, 6, 7, 7, 18, 10, 669, DateTimeKind.Unspecified).AddTicks(1964), null, 56m, 1, 111 },
                    { 28, 4, new DateTime(2021, 4, 17, 5, 54, 41, 152, DateTimeKind.Unspecified).AddTicks(7328), null, 53m, 1, 179 },
                    { 28, 6, new DateTime(2020, 5, 31, 21, 19, 50, 144, DateTimeKind.Unspecified).AddTicks(4284), null, 54m, 1, 34 },
                    { 28, 9, new DateTime(2021, 4, 4, 19, 51, 34, 76, DateTimeKind.Unspecified).AddTicks(2190), null, 53m, 1, 12 },
                    { 28, 10, new DateTime(2022, 9, 19, 4, 12, 4, 564, DateTimeKind.Unspecified).AddTicks(4829), null, 55m, 1, 84 },
                    { 30, 5, new DateTime(2022, 11, 27, 3, 59, 16, 291, DateTimeKind.Unspecified).AddTicks(7377), null, 49m, 1, 174 },
                    { 30, 6, new DateTime(2021, 10, 21, 0, 30, 2, 155, DateTimeKind.Unspecified).AddTicks(6415), null, 51m, 1, 180 },
                    { 30, 8, new DateTime(2021, 6, 1, 20, 45, 37, 89, DateTimeKind.Unspecified).AddTicks(1744), null, 51m, 1, 148 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 1, 14, 21, 2, 397, DateTimeKind.Unspecified).AddTicks(9395), null, "Swaziland", new DateTime(2022, 7, 21, 11, 20, 4, 131, DateTimeKind.Unspecified).AddTicks(2110), 1 },
                    { 2, new DateTime(2022, 6, 25, 22, 47, 33, 170, DateTimeKind.Unspecified).AddTicks(4473), null, "Libyan Arab Jamahiriya", new DateTime(2021, 9, 29, 3, 33, 39, 449, DateTimeKind.Unspecified).AddTicks(1869), 1 },
                    { 5, new DateTime(2021, 3, 20, 20, 46, 56, 530, DateTimeKind.Unspecified).AddTicks(151), null, "Western Sahara", new DateTime(2021, 7, 24, 11, 53, 42, 31, DateTimeKind.Unspecified).AddTicks(7802), 1 },
                    { 7, new DateTime(2021, 2, 6, 0, 50, 50, 819, DateTimeKind.Unspecified).AddTicks(506), null, "Vanuatu", new DateTime(2022, 11, 14, 23, 46, 36, 508, DateTimeKind.Unspecified).AddTicks(5171), 1 },
                    { 10, new DateTime(2020, 6, 19, 23, 53, 55, 500, DateTimeKind.Unspecified).AddTicks(7460), null, "Taiwan", new DateTime(2020, 11, 2, 23, 29, 18, 947, DateTimeKind.Unspecified).AddTicks(3410), 1 },
                    { 13, new DateTime(2021, 8, 14, 14, 4, 51, 789, DateTimeKind.Unspecified).AddTicks(4277), null, "Cameroon", new DateTime(2021, 12, 3, 10, 5, 30, 686, DateTimeKind.Unspecified).AddTicks(4880), 1 },
                    { 16, new DateTime(2020, 9, 11, 11, 29, 53, 533, DateTimeKind.Unspecified).AddTicks(2451), null, "Israel", new DateTime(2022, 4, 22, 17, 29, 36, 218, DateTimeKind.Unspecified).AddTicks(3031), 1 },
                    { 19, new DateTime(2022, 10, 23, 20, 11, 42, 307, DateTimeKind.Unspecified).AddTicks(1638), null, "Western Sahara", new DateTime(2021, 11, 12, 1, 10, 39, 383, DateTimeKind.Unspecified).AddTicks(4206), 1 },
                    { 21, new DateTime(2022, 11, 8, 9, 23, 9, 12, DateTimeKind.Unspecified).AddTicks(3030), null, "Haiti", new DateTime(2022, 5, 20, 12, 25, 44, 311, DateTimeKind.Unspecified).AddTicks(5787), 1 },
                    { 26, new DateTime(2020, 4, 26, 4, 27, 11, 184, DateTimeKind.Unspecified).AddTicks(4767), null, "Mauritania", new DateTime(2020, 9, 2, 23, 54, 54, 306, DateTimeKind.Unspecified).AddTicks(3771), 1 },
                    { 29, new DateTime(2021, 2, 8, 7, 37, 42, 698, DateTimeKind.Unspecified).AddTicks(525), null, "Gambia", new DateTime(2020, 8, 19, 12, 17, 26, 253, DateTimeKind.Unspecified).AddTicks(3198), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 11, 5, new DateTime(2020, 9, 25, 10, 43, 43, 643, DateTimeKind.Unspecified).AddTicks(1561), null, "Handcrafted Frozen Shirt", 1 },
                    { 14, 5, new DateTime(2021, 8, 3, 22, 33, 56, 68, DateTimeKind.Unspecified).AddTicks(4610), null, "Licensed Fresh Chair", 1 },
                    { 18, 9, new DateTime(2020, 5, 30, 22, 39, 25, 769, DateTimeKind.Unspecified).AddTicks(9525), null, "Intelligent Wooden Table", 1 },
                    { 20, 5, new DateTime(2021, 2, 6, 16, 19, 4, 775, DateTimeKind.Unspecified).AddTicks(3018), null, "Practical Fresh Shirt", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2022, 5, 26, 16, 7, 6, 675, DateTimeKind.Unspecified).AddTicks(620), null, 55m, 1, 94 },
                    { 1, 4, new DateTime(2022, 3, 6, 18, 31, 6, 379, DateTimeKind.Unspecified).AddTicks(7323), null, 52m, 1, 46 },
                    { 1, 7, new DateTime(2021, 2, 17, 14, 0, 53, 687, DateTimeKind.Unspecified).AddTicks(7356), null, 54m, 1, 15 },
                    { 1, 8, new DateTime(2021, 3, 9, 19, 34, 28, 670, DateTimeKind.Unspecified).AddTicks(9990), null, 54m, 1, 142 },
                    { 2, 7, new DateTime(2021, 3, 23, 18, 46, 3, 132, DateTimeKind.Unspecified).AddTicks(6952), null, 51m, 1, 147 },
                    { 5, 8, new DateTime(2021, 10, 13, 2, 27, 47, 892, DateTimeKind.Unspecified).AddTicks(4235), null, 54m, 1, 95 },
                    { 7, 1, new DateTime(2020, 7, 11, 9, 54, 9, 354, DateTimeKind.Unspecified).AddTicks(1592), null, 54m, 1, 184 },
                    { 7, 3, new DateTime(2020, 6, 7, 15, 12, 34, 481, DateTimeKind.Unspecified).AddTicks(2257), null, 53m, 1, 128 },
                    { 7, 7, new DateTime(2020, 5, 19, 2, 3, 59, 477, DateTimeKind.Unspecified).AddTicks(9374), null, 51m, 1, 76 },
                    { 7, 8, new DateTime(2021, 8, 20, 10, 16, 53, 445, DateTimeKind.Unspecified).AddTicks(1140), null, 54m, 1, 158 },
                    { 7, 9, new DateTime(2022, 8, 5, 5, 49, 44, 135, DateTimeKind.Unspecified).AddTicks(8140), null, 56m, 1, 154 },
                    { 10, 3, new DateTime(2022, 10, 5, 19, 48, 52, 844, DateTimeKind.Unspecified).AddTicks(5535), null, 56m, 1, 178 },
                    { 10, 7, new DateTime(2021, 9, 14, 11, 41, 20, 417, DateTimeKind.Unspecified).AddTicks(8607), null, 56m, 1, 58 },
                    { 10, 9, new DateTime(2021, 2, 9, 21, 43, 0, 170, DateTimeKind.Unspecified).AddTicks(6966), null, 51m, 1, 108 },
                    { 10, 10, new DateTime(2021, 7, 18, 1, 15, 3, 291, DateTimeKind.Unspecified).AddTicks(3129), null, 50m, 1, 133 },
                    { 13, 6, new DateTime(2020, 5, 26, 7, 41, 9, 275, DateTimeKind.Unspecified).AddTicks(8784), null, 50m, 1, 139 },
                    { 13, 10, new DateTime(2020, 3, 14, 10, 12, 38, 375, DateTimeKind.Unspecified).AddTicks(4387), null, 51m, 1, 102 },
                    { 16, 2, new DateTime(2022, 9, 30, 20, 42, 58, 583, DateTimeKind.Unspecified).AddTicks(8354), null, 49m, 1, 97 },
                    { 16, 3, new DateTime(2020, 9, 6, 4, 13, 7, 529, DateTimeKind.Unspecified).AddTicks(5769), null, 56m, 1, 125 },
                    { 16, 7, new DateTime(2021, 4, 11, 23, 54, 14, 570, DateTimeKind.Unspecified).AddTicks(1150), null, 50m, 1, 39 },
                    { 16, 9, new DateTime(2022, 1, 24, 18, 50, 56, 888, DateTimeKind.Unspecified).AddTicks(457), null, 55m, 1, 23 },
                    { 16, 10, new DateTime(2021, 7, 25, 14, 22, 13, 861, DateTimeKind.Unspecified).AddTicks(2981), null, 55m, 1, 103 },
                    { 19, 2, new DateTime(2022, 1, 2, 8, 50, 15, 204, DateTimeKind.Unspecified).AddTicks(9935), null, 56m, 1, 125 },
                    { 19, 5, new DateTime(2022, 12, 23, 18, 13, 51, 24, DateTimeKind.Unspecified).AddTicks(1327), null, 54m, 1, 172 },
                    { 19, 6, new DateTime(2021, 2, 28, 10, 10, 21, 15, DateTimeKind.Unspecified).AddTicks(2807), null, 57m, 1, 178 },
                    { 19, 10, new DateTime(2020, 12, 14, 3, 50, 16, 637, DateTimeKind.Unspecified).AddTicks(139), null, 53m, 1, 165 },
                    { 21, 1, new DateTime(2021, 9, 4, 15, 38, 19, 688, DateTimeKind.Unspecified).AddTicks(1885), null, 55m, 1, 11 },
                    { 21, 4, new DateTime(2020, 7, 10, 22, 1, 20, 290, DateTimeKind.Unspecified).AddTicks(5144), null, 51m, 1, 18 },
                    { 21, 6, new DateTime(2020, 10, 6, 10, 17, 2, 504, DateTimeKind.Unspecified).AddTicks(8527), null, 52m, 1, 191 },
                    { 21, 7, new DateTime(2020, 9, 16, 11, 28, 45, 236, DateTimeKind.Unspecified).AddTicks(7442), null, 54m, 1, 160 },
                    { 21, 9, new DateTime(2020, 11, 3, 3, 8, 46, 932, DateTimeKind.Unspecified).AddTicks(7343), null, 57m, 1, 194 },
                    { 26, 4, new DateTime(2020, 6, 22, 19, 37, 4, 967, DateTimeKind.Unspecified).AddTicks(1640), null, 55m, 1, 45 },
                    { 26, 8, new DateTime(2020, 4, 10, 4, 19, 42, 938, DateTimeKind.Unspecified).AddTicks(3726), null, 51m, 1, 128 },
                    { 29, 4, new DateTime(2020, 9, 3, 19, 47, 58, 481, DateTimeKind.Unspecified).AddTicks(8421), null, 56m, 1, 38 },
                    { 29, 6, new DateTime(2022, 12, 30, 23, 59, 12, 13, DateTimeKind.Unspecified).AddTicks(1158), null, 54m, 1, 144 },
                    { 29, 8, new DateTime(2020, 9, 16, 16, 34, 22, 226, DateTimeKind.Unspecified).AddTicks(1222), null, 53m, 1, 109 },
                    { 29, 9, new DateTime(2021, 9, 17, 8, 30, 37, 407, DateTimeKind.Unspecified).AddTicks(8423), null, 53m, 1, 151 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 5, 30, 18, 13, 53, 971, DateTimeKind.Unspecified).AddTicks(4804), null, "Guadeloupe", new DateTime(2020, 7, 1, 18, 43, 56, 68, DateTimeKind.Unspecified).AddTicks(1998), 1 },
                    { 14, new DateTime(2020, 5, 4, 12, 25, 12, 175, DateTimeKind.Unspecified).AddTicks(1665), null, "Micronesia", new DateTime(2022, 5, 8, 17, 21, 42, 492, DateTimeKind.Unspecified).AddTicks(1473), 1 },
                    { 18, new DateTime(2020, 4, 24, 7, 51, 57, 744, DateTimeKind.Unspecified).AddTicks(1379), null, "Indonesia", new DateTime(2020, 6, 27, 18, 24, 58, 380, DateTimeKind.Unspecified).AddTicks(4051), 1 },
                    { 20, new DateTime(2020, 5, 13, 17, 56, 1, 384, DateTimeKind.Unspecified).AddTicks(2444), null, "Moldova", new DateTime(2020, 5, 8, 7, 23, 59, 979, DateTimeKind.Unspecified).AddTicks(331), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 11, 7, new DateTime(2022, 1, 16, 17, 22, 9, 955, DateTimeKind.Unspecified).AddTicks(2444), null, 56m, 1, 185 },
                    { 14, 1, new DateTime(2020, 11, 8, 20, 3, 28, 333, DateTimeKind.Unspecified).AddTicks(8414), null, 51m, 1, 64 },
                    { 14, 5, new DateTime(2021, 7, 23, 17, 5, 9, 559, DateTimeKind.Unspecified).AddTicks(8501), null, 55m, 1, 194 },
                    { 14, 7, new DateTime(2022, 5, 16, 11, 20, 45, 976, DateTimeKind.Unspecified).AddTicks(2432), null, 49m, 1, 94 },
                    { 14, 8, new DateTime(2022, 2, 19, 1, 14, 24, 108, DateTimeKind.Unspecified).AddTicks(842), null, 51m, 1, 63 },
                    { 14, 10, new DateTime(2021, 5, 23, 3, 1, 32, 870, DateTimeKind.Unspecified).AddTicks(8369), null, 49m, 1, 64 },
                    { 18, 4, new DateTime(2020, 8, 20, 22, 33, 2, 101, DateTimeKind.Unspecified).AddTicks(9416), null, 49m, 1, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentID",
                table: "Categories",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsSuppliers_SupplierId",
                table: "ProductsSuppliers",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductsSuppliers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
