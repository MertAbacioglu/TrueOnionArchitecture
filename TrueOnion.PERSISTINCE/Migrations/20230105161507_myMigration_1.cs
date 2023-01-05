using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myMigration1 : Migration
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
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    MaxCountPerShipping = table.Column<int>(type: "int", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsSuppliers", x => new { x.ProductID, x.SupplierID });
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsSuppliers_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "InsertedDate", "LastModifiedDate", "Name", "NormalizedName", "DataStatus" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 5, 19, 15, 7, 375, DateTimeKind.Local).AddTicks(2758), null, "Admin", "ADMIN", 1 },
                    { 2, null, new DateTime(2023, 1, 5, 19, 15, 7, 375, DateTimeKind.Local).AddTicks(2956), null, "Member", "MEMBER", 1 },
                    { 3, null, new DateTime(2023, 1, 5, 19, 15, 7, 375, DateTimeKind.Local).AddTicks(2960), null, "Supplier", "SUPPLIER", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "DataStatus", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "7ca3903f-ad04-43ef-8a91-1f01ad545321", "Kamryn87@hotmail.com", true, new DateTime(2021, 9, 5, 1, 11, 38, 219, DateTimeKind.Unspecified).AddTicks(3409), null, false, null, "KAMRYN87@HOTMAIL.COM", "TYREEK.NIKOLAUS", "fKz5tVHheS", "818-940-8966", false, "JEKZ0wcUMq", 1, false, "Tyreek.Nikolaus" },
                    { 2, 0, "73df970a-09e4-4fbf-8463-85c5b26944c6", "Erika.Corwin@hotmail.com", true, new DateTime(2021, 4, 2, 18, 30, 10, 973, DateTimeKind.Unspecified).AddTicks(1255), null, false, null, "ERIKA.CORWIN@HOTMAIL.COM", "AMPARO_BOGAN", "bsc2_cCCHC", "1-333-248-2524", false, "yKH7Cm2EDJ", 1, false, "Amparo_Bogan" },
                    { 3, 0, "75689ae1-c57e-4f83-9262-cc78dcda5910", "Percy_Daugherty@gmail.com", true, new DateTime(2021, 3, 11, 0, 11, 48, 589, DateTimeKind.Unspecified).AddTicks(5760), null, false, null, "PERCY_DAUGHERTY@GMAIL.COM", "BERNARD55", "r7f_fhCqJj", "446.228.6999", false, "rrOAJ6Dkha", 1, false, "Bernard55" },
                    { 4, 0, "334af678-7b5f-44f3-9fc4-c84a272d5b3d", "Sarah_Predovic@gmail.com", true, new DateTime(2020, 10, 17, 20, 40, 21, 482, DateTimeKind.Unspecified).AddTicks(432), null, false, null, "SARAH_PREDOVIC@GMAIL.COM", "RYLEY_MOSCISKI", "dDU7jMCjzb", "1-336-588-0418", false, "dA0Dqd1aSz", 1, false, "Ryley_Mosciski" },
                    { 5, 0, "47725fc9-d5af-4e65-bd61-9ace27f6dcf9", "Annabell.Block@yahoo.com", true, new DateTime(2021, 9, 28, 10, 6, 40, 861, DateTimeKind.Unspecified).AddTicks(906), null, false, null, "ANNABELL.BLOCK@YAHOO.COM", "ALEXANNE_LEHNER", "vibp8kuxyn", "494.917.2830 x380", false, "yItlF2tESf", 1, false, "Alexanne_Lehner" },
                    { 6, 0, "a81d0249-ea0f-4101-bcf3-d06bedd41251", "Ida.Davis@hotmail.com", true, new DateTime(2022, 9, 16, 4, 36, 59, 549, DateTimeKind.Unspecified).AddTicks(290), null, false, null, "IDA.DAVIS@HOTMAIL.COM", "RYLAN.ZULAUF14", "zYnmp24GQH", "326-502-9030 x82889", false, "HPClFYCAQG", 1, false, "Rylan.Zulauf14" },
                    { 7, 0, "c1925167-6c3c-4964-90b1-09597697dfc6", "Fredrick79@yahoo.com", true, new DateTime(2022, 7, 10, 7, 37, 7, 279, DateTimeKind.Unspecified).AddTicks(1846), null, false, null, "FREDRICK79@YAHOO.COM", "PINK25", "VRFCdPUjbN", "262.799.2627", false, "avbNj49njJ", 1, false, "Pink25" },
                    { 8, 0, "fdf201aa-440c-4756-860b-d36490f0db71", "Karson_Schimmel63@yahoo.com", true, new DateTime(2022, 10, 28, 16, 26, 54, 701, DateTimeKind.Unspecified).AddTicks(112), null, false, null, "KARSON_SCHIMMEL63@YAHOO.COM", "ELISA.SCHNEIDER", "Ou5mZCIEf2", "402.331.3531", false, "Ylqivs3U5E", 1, false, "Elisa.Schneider" },
                    { 9, 0, "e075c096-b0de-4d81-ad00-64d126f14570", "Emie.Gutkowski@hotmail.com", true, new DateTime(2022, 6, 3, 13, 0, 52, 757, DateTimeKind.Unspecified).AddTicks(2141), null, false, null, "EMIE.GUTKOWSKI@HOTMAIL.COM", "DON.ZBONCAK", "dYjHbVit_m", "426-863-0157", false, "wyeAv8VDI0", 1, false, "Don.Zboncak" },
                    { 10, 0, "ad129402-f409-401c-bf29-0b3457bf6a10", "Chet13@gmail.com", true, new DateTime(2022, 3, 4, 4, 49, 10, 572, DateTimeKind.Unspecified).AddTicks(2396), null, false, null, "CHET13@GMAIL.COM", "KELSI.MEDHURST12", "XRwgtjvwDt", "901.819.8610 x90274", false, "xNJ13iWV2K", 1, false, "Kelsi.Medhurst12" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 1, "All", new DateTime(2021, 9, 23, 5, 3, 5, 491, DateTimeKind.Unspecified).AddTicks(666), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "3102 Lowe Route, East Dedricburgh, Qatar", "Jaskolski Group", new DateTime(2022, 7, 7, 0, 47, 54, 709, DateTimeKind.Unspecified).AddTicks(7960), null, 1 },
                    { 2, "20397 Watsica Shoal, Schmidtton, United Kingdom", "Ward - Gorczany", new DateTime(2021, 9, 23, 7, 23, 46, 368, DateTimeKind.Unspecified).AddTicks(7362), null, 1 },
                    { 3, "08738 Ziemann Island, Haskellside, Cameroon", "Zieme, Yundt and Kuvalis", new DateTime(2022, 3, 20, 14, 22, 49, 974, DateTimeKind.Unspecified).AddTicks(3348), null, 1 },
                    { 4, "03781 Krajcik Meadows, Port Kay, Latvia", "D'Amore, Schmeler and Spinka", new DateTime(2021, 10, 14, 12, 11, 47, 916, DateTimeKind.Unspecified).AddTicks(5643), null, 1 },
                    { 5, "413 Stamm Forks, East Thomas, Iran", "Ritchie - Graham", new DateTime(2020, 3, 30, 20, 58, 35, 0, DateTimeKind.Unspecified).AddTicks(2325), null, 1 },
                    { 6, "685 Terry Bridge, New Arjunfort, Bangladesh", "Bruen LLC", new DateTime(2023, 1, 5, 5, 41, 24, 363, DateTimeKind.Unspecified).AddTicks(4062), null, 1 },
                    { 7, "096 McGlynn Oval, Brandimouth, Latvia", "Nienow and Sons", new DateTime(2021, 6, 14, 6, 28, 2, 464, DateTimeKind.Unspecified).AddTicks(2135), null, 1 },
                    { 8, "58744 Maurine Square, West Declanmouth, Colombia", "Hamill and Sons", new DateTime(2021, 9, 17, 19, 58, 40, 723, DateTimeKind.Unspecified).AddTicks(5848), null, 1 },
                    { 9, "21032 Senger Run, Lake Matilde, Slovenia", "Kassulke - Okuneva", new DateTime(2022, 6, 30, 4, 56, 32, 438, DateTimeKind.Unspecified).AddTicks(5698), null, 1 },
                    { 10, "25904 Krajcik Light, North Rafaelfort, Northern Mariana Islands", "Hyatt LLC", new DateTime(2021, 8, 2, 19, 27, 45, 53, DateTimeKind.Unspecified).AddTicks(6355), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "InsertedDate", "LastModifiedDate", "DataStatus" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2022, 9, 25, 15, 29, 30, 910, DateTimeKind.Unspecified).AddTicks(3246), null, 1 },
                    { 3, 3, new DateTime(2021, 6, 12, 3, 46, 33, 495, DateTimeKind.Unspecified).AddTicks(5225), null, 1 },
                    { 1, 7, new DateTime(2021, 1, 18, 0, 29, 53, 740, DateTimeKind.Unspecified).AddTicks(9792), null, 1 },
                    { 3, 7, new DateTime(2020, 9, 19, 12, 54, 5, 638, DateTimeKind.Unspecified).AddTicks(1524), null, 1 },
                    { 2, 8, new DateTime(2022, 5, 4, 12, 48, 33, 164, DateTimeKind.Unspecified).AddTicks(900), null, 1 },
                    { 1, 9, new DateTime(2021, 8, 19, 5, 53, 52, 743, DateTimeKind.Unspecified).AddTicks(1990), null, 1 },
                    { 2, 9, new DateTime(2022, 2, 12, 15, 49, 29, 663, DateTimeKind.Unspecified).AddTicks(8906), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 2, "Games", new DateTime(2021, 8, 4, 10, 37, 30, 424, DateTimeKind.Unspecified).AddTicks(9610), null, 1, 1 },
                    { 3, "Outdoors", new DateTime(2021, 5, 30, 15, 43, 27, 467, DateTimeKind.Unspecified).AddTicks(2445), null, 1, 1 },
                    { 7, "Industrial", new DateTime(2020, 4, 3, 17, 42, 52, 436, DateTimeKind.Unspecified).AddTicks(4698), null, 1, 1 },
                    { 9, "Computers", new DateTime(2021, 10, 11, 5, 5, 42, 500, DateTimeKind.Unspecified).AddTicks(4882), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 12, 1, new DateTime(2020, 7, 17, 5, 21, 26, 257, DateTimeKind.Unspecified).AddTicks(5144), null, "Handmade Steel Towels", 56m, 1, 23 },
                    { 19, 1, new DateTime(2021, 1, 22, 13, 47, 32, 784, DateTimeKind.Unspecified).AddTicks(4537), null, "Small Concrete Pants", 52m, 1, 20 },
                    { 20, 1, new DateTime(2021, 8, 6, 22, 6, 13, 547, DateTimeKind.Unspecified).AddTicks(5592), null, "Licensed Soft Pizza", 51m, 1, 86 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 4, "Industrial", new DateTime(2021, 4, 10, 8, 10, 20, 309, DateTimeKind.Unspecified).AddTicks(7800), null, 3, 1 },
                    { 6, "Jewelery", new DateTime(2022, 4, 21, 8, 23, 32, 617, DateTimeKind.Unspecified).AddTicks(7810), null, 2, 1 },
                    { 10, "Automotive", new DateTime(2021, 1, 25, 8, 3, 10, 945, DateTimeKind.Unspecified).AddTicks(5811), null, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 12, new DateTime(2022, 7, 9, 10, 51, 5, 943, DateTimeKind.Unspecified).AddTicks(9118), null, "Bouvet Island (Bouvetoya)", new DateTime(2022, 10, 20, 4, 42, 18, 46, DateTimeKind.Unspecified).AddTicks(1686), 1 },
                    { 19, new DateTime(2022, 9, 3, 3, 16, 52, 871, DateTimeKind.Unspecified).AddTicks(1236), null, "Rwanda", new DateTime(2022, 12, 23, 17, 31, 24, 127, DateTimeKind.Unspecified).AddTicks(3181), 1 },
                    { 20, new DateTime(2021, 2, 22, 4, 52, 39, 83, DateTimeKind.Unspecified).AddTicks(6136), null, "Trinidad and Tobago", new DateTime(2021, 2, 2, 19, 19, 48, 170, DateTimeKind.Unspecified).AddTicks(7450), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2020, 9, 7, 0, 38, 30, 460, DateTimeKind.Unspecified).AddTicks(2536), null, "Intelligent Cotton Pizza", 51m, 1, 131 },
                    { 2, 2, new DateTime(2020, 10, 24, 1, 31, 8, 991, DateTimeKind.Unspecified).AddTicks(1161), null, "Small Cotton Towels", 52m, 1, 39 },
                    { 3, 2, new DateTime(2022, 3, 5, 3, 54, 57, 394, DateTimeKind.Unspecified).AddTicks(9329), null, "Rustic Metal Car", 50m, 1, 113 },
                    { 5, 2, new DateTime(2021, 9, 5, 7, 14, 50, 636, DateTimeKind.Unspecified).AddTicks(289), null, "Generic Frozen Chair", 52m, 1, 185 },
                    { 7, 3, new DateTime(2022, 10, 30, 0, 2, 54, 702, DateTimeKind.Unspecified).AddTicks(6756), null, "Gorgeous Fresh Sausages", 54m, 1, 123 },
                    { 8, 7, new DateTime(2020, 11, 17, 19, 53, 55, 382, DateTimeKind.Unspecified).AddTicks(8700), null, "Generic Frozen Chair", 55m, 1, 58 },
                    { 9, 2, new DateTime(2020, 10, 9, 19, 15, 32, 143, DateTimeKind.Unspecified).AddTicks(5691), null, "Rustic Granite Cheese", 49m, 1, 154 },
                    { 15, 3, new DateTime(2021, 12, 7, 1, 17, 22, 221, DateTimeKind.Unspecified).AddTicks(7107), null, "Ergonomic Cotton Tuna", 54m, 1, 70 },
                    { 21, 9, new DateTime(2021, 8, 2, 2, 41, 17, 223, DateTimeKind.Unspecified).AddTicks(2970), null, "Handmade Rubber Chicken", 51m, 1, 177 },
                    { 23, 3, new DateTime(2022, 8, 23, 19, 44, 37, 664, DateTimeKind.Unspecified).AddTicks(9329), null, "Handcrafted Fresh Computer", 52m, 1, 161 },
                    { 25, 7, new DateTime(2021, 6, 18, 8, 39, 51, 142, DateTimeKind.Unspecified).AddTicks(5081), null, "Rustic Cotton Mouse", 51m, 1, 16 },
                    { 27, 3, new DateTime(2020, 12, 8, 5, 30, 56, 922, DateTimeKind.Unspecified).AddTicks(6270), null, "Tasty Wooden Car", 56m, 1, 173 },
                    { 28, 2, new DateTime(2020, 8, 17, 6, 13, 47, 476, DateTimeKind.Unspecified).AddTicks(280), null, "Practical Wooden Mouse", 49m, 1, 152 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "DataStatus" },
                values: new object[,]
                {
                    { 12, 8, new DateTime(2021, 2, 23, 7, 31, 43, 283, DateTimeKind.Unspecified).AddTicks(5031), null, 129, 1 },
                    { 19, 2, new DateTime(2022, 11, 30, 2, 54, 2, 211, DateTimeKind.Unspecified).AddTicks(7867), null, 90, 1 },
                    { 19, 3, new DateTime(2022, 1, 21, 1, 34, 36, 583, DateTimeKind.Unspecified).AddTicks(1119), null, 55, 1 },
                    { 19, 6, new DateTime(2022, 1, 20, 1, 54, 54, 537, DateTimeKind.Unspecified).AddTicks(386), null, 131, 1 },
                    { 19, 9, new DateTime(2022, 5, 19, 6, 18, 40, 2, DateTimeKind.Unspecified).AddTicks(6980), null, 85, 1 },
                    { 20, 3, new DateTime(2020, 8, 5, 20, 23, 56, 980, DateTimeKind.Unspecified).AddTicks(3039), null, 21, 1 },
                    { 20, 4, new DateTime(2021, 5, 17, 18, 24, 49, 501, DateTimeKind.Unspecified).AddTicks(6383), null, 169, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 5, "Health", new DateTime(2022, 8, 17, 8, 25, 24, 386, DateTimeKind.Unspecified).AddTicks(6343), null, 4, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 3, 10, 22, 51, 442, DateTimeKind.Unspecified).AddTicks(1535), null, "Canada", new DateTime(2021, 9, 22, 11, 19, 37, 939, DateTimeKind.Unspecified).AddTicks(7258), 1 },
                    { 2, new DateTime(2022, 12, 19, 12, 17, 36, 866, DateTimeKind.Unspecified).AddTicks(2926), null, "El Salvador", new DateTime(2022, 6, 4, 23, 21, 20, 83, DateTimeKind.Unspecified).AddTicks(8880), 1 },
                    { 3, new DateTime(2020, 5, 26, 21, 29, 4, 980, DateTimeKind.Unspecified).AddTicks(2572), null, "Rwanda", new DateTime(2021, 7, 22, 10, 36, 37, 485, DateTimeKind.Unspecified).AddTicks(1681), 1 },
                    { 5, new DateTime(2022, 6, 20, 15, 53, 58, 348, DateTimeKind.Unspecified).AddTicks(1480), null, "Luxembourg", new DateTime(2020, 9, 10, 11, 9, 3, 838, DateTimeKind.Unspecified).AddTicks(9810), 1 },
                    { 7, new DateTime(2021, 12, 27, 1, 40, 25, 800, DateTimeKind.Unspecified).AddTicks(6817), null, "Czech Republic", new DateTime(2020, 9, 30, 23, 47, 30, 34, DateTimeKind.Unspecified).AddTicks(30), 1 },
                    { 8, new DateTime(2020, 11, 26, 2, 20, 27, 279, DateTimeKind.Unspecified).AddTicks(864), null, "Niue", new DateTime(2020, 9, 26, 2, 54, 39, 704, DateTimeKind.Unspecified).AddTicks(1427), 1 },
                    { 9, new DateTime(2020, 6, 23, 2, 9, 43, 262, DateTimeKind.Unspecified).AddTicks(7373), null, "Barbados", new DateTime(2021, 12, 30, 22, 20, 53, 173, DateTimeKind.Unspecified).AddTicks(1424), 1 },
                    { 15, new DateTime(2020, 11, 25, 20, 6, 27, 738, DateTimeKind.Unspecified).AddTicks(8771), null, "Uzbekistan", new DateTime(2022, 2, 21, 22, 43, 42, 346, DateTimeKind.Unspecified).AddTicks(9991), 1 },
                    { 21, new DateTime(2022, 4, 28, 0, 8, 45, 620, DateTimeKind.Unspecified).AddTicks(8302), null, "Antigua and Barbuda", new DateTime(2022, 12, 4, 16, 23, 1, 33, DateTimeKind.Unspecified).AddTicks(8528), 1 },
                    { 23, new DateTime(2021, 10, 16, 5, 46, 55, 331, DateTimeKind.Unspecified).AddTicks(5008), null, "Niger", new DateTime(2022, 12, 17, 22, 22, 45, 920, DateTimeKind.Unspecified).AddTicks(6051), 1 },
                    { 25, new DateTime(2021, 1, 15, 8, 24, 32, 598, DateTimeKind.Unspecified).AddTicks(7708), null, "Anguilla", new DateTime(2020, 12, 3, 1, 36, 22, 520, DateTimeKind.Unspecified).AddTicks(9155), 1 },
                    { 27, new DateTime(2022, 10, 25, 1, 20, 23, 578, DateTimeKind.Unspecified).AddTicks(9734), null, "South Georgia and the South Sandwich Islands", new DateTime(2022, 3, 6, 19, 0, 56, 65, DateTimeKind.Unspecified).AddTicks(8864), 1 },
                    { 28, new DateTime(2021, 4, 21, 2, 19, 36, 127, DateTimeKind.Unspecified).AddTicks(1087), null, "Ethiopia", new DateTime(2020, 5, 29, 15, 18, 40, 520, DateTimeKind.Unspecified).AddTicks(241), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 6, 10, new DateTime(2022, 6, 8, 3, 6, 2, 504, DateTimeKind.Unspecified).AddTicks(4275), null, "Practical Plastic Hat", 55m, 1, 61 },
                    { 10, 6, new DateTime(2022, 2, 28, 21, 25, 23, 267, DateTimeKind.Unspecified).AddTicks(2417), null, "Sleek Wooden Fish", 50m, 1, 159 },
                    { 11, 4, new DateTime(2022, 5, 17, 6, 48, 30, 91, DateTimeKind.Unspecified).AddTicks(3159), null, "Intelligent Steel Salad", 57m, 1, 1 },
                    { 13, 6, new DateTime(2020, 12, 2, 0, 36, 41, 504, DateTimeKind.Unspecified).AddTicks(6255), null, "Ergonomic Frozen Towels", 53m, 1, 181 },
                    { 14, 10, new DateTime(2022, 12, 27, 1, 42, 14, 377, DateTimeKind.Unspecified).AddTicks(7199), null, "Practical Metal Bike", 57m, 1, 18 },
                    { 16, 10, new DateTime(2022, 5, 7, 1, 28, 25, 961, DateTimeKind.Unspecified).AddTicks(4145), null, "Intelligent Fresh Table", 56m, 1, 198 },
                    { 22, 10, new DateTime(2020, 6, 19, 6, 22, 4, 281, DateTimeKind.Unspecified).AddTicks(4670), null, "Incredible Soft Pants", 52m, 1, 182 },
                    { 24, 4, new DateTime(2023, 1, 1, 16, 56, 10, 600, DateTimeKind.Unspecified).AddTicks(3725), null, "Intelligent Concrete Pants", 50m, 1, 71 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "DataStatus" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 2, 25, 8, 52, 7, 118, DateTimeKind.Unspecified).AddTicks(5033), null, 51, 1 },
                    { 2, 1, new DateTime(2022, 7, 21, 13, 27, 50, 708, DateTimeKind.Unspecified).AddTicks(1245), null, 57, 1 },
                    { 2, 2, new DateTime(2020, 6, 23, 12, 51, 40, 939, DateTimeKind.Unspecified).AddTicks(6742), null, 136, 1 },
                    { 2, 5, new DateTime(2022, 11, 2, 19, 15, 56, 989, DateTimeKind.Unspecified).AddTicks(3330), null, 14, 1 },
                    { 3, 5, new DateTime(2021, 5, 23, 19, 28, 30, 741, DateTimeKind.Unspecified).AddTicks(420), null, 158, 1 },
                    { 3, 8, new DateTime(2021, 6, 12, 13, 31, 51, 818, DateTimeKind.Unspecified).AddTicks(8900), null, 31, 1 },
                    { 5, 1, new DateTime(2022, 1, 28, 21, 56, 46, 293, DateTimeKind.Unspecified).AddTicks(9297), null, 150, 1 },
                    { 5, 4, new DateTime(2021, 10, 19, 0, 11, 10, 410, DateTimeKind.Unspecified).AddTicks(92), null, 161, 1 },
                    { 5, 5, new DateTime(2021, 10, 28, 11, 45, 19, 428, DateTimeKind.Unspecified).AddTicks(6045), null, 123, 1 },
                    { 5, 8, new DateTime(2020, 6, 20, 18, 44, 7, 126, DateTimeKind.Unspecified).AddTicks(2943), null, 189, 1 },
                    { 5, 10, new DateTime(2022, 9, 20, 14, 7, 54, 625, DateTimeKind.Unspecified).AddTicks(1562), null, 123, 1 },
                    { 7, 3, new DateTime(2022, 12, 10, 4, 38, 50, 269, DateTimeKind.Unspecified).AddTicks(6205), null, 172, 1 },
                    { 7, 4, new DateTime(2022, 12, 4, 23, 58, 58, 703, DateTimeKind.Unspecified).AddTicks(9462), null, 91, 1 },
                    { 7, 5, new DateTime(2022, 7, 6, 2, 31, 57, 984, DateTimeKind.Unspecified).AddTicks(1342), null, 5, 1 },
                    { 7, 8, new DateTime(2022, 10, 11, 11, 29, 48, 685, DateTimeKind.Unspecified).AddTicks(6129), null, 128, 1 },
                    { 7, 9, new DateTime(2020, 6, 20, 14, 35, 14, 419, DateTimeKind.Unspecified).AddTicks(9767), null, 96, 1 },
                    { 7, 10, new DateTime(2022, 11, 19, 4, 12, 5, 57, DateTimeKind.Unspecified).AddTicks(9762), null, 75, 1 },
                    { 8, 2, new DateTime(2020, 11, 15, 12, 43, 31, 445, DateTimeKind.Unspecified).AddTicks(5668), null, 175, 1 },
                    { 8, 4, new DateTime(2021, 7, 9, 6, 5, 26, 305, DateTimeKind.Unspecified).AddTicks(5424), null, 30, 1 },
                    { 8, 5, new DateTime(2021, 7, 13, 3, 57, 33, 303, DateTimeKind.Unspecified).AddTicks(5823), null, 68, 1 },
                    { 8, 6, new DateTime(2022, 4, 30, 18, 49, 1, 421, DateTimeKind.Unspecified).AddTicks(2028), null, 151, 1 },
                    { 9, 2, new DateTime(2021, 1, 22, 8, 14, 10, 109, DateTimeKind.Unspecified).AddTicks(1391), null, 103, 1 },
                    { 9, 5, new DateTime(2020, 12, 24, 16, 18, 22, 334, DateTimeKind.Unspecified).AddTicks(8500), null, 168, 1 },
                    { 9, 6, new DateTime(2020, 8, 27, 15, 57, 34, 333, DateTimeKind.Unspecified).AddTicks(4153), null, 79, 1 },
                    { 9, 7, new DateTime(2022, 2, 18, 22, 32, 31, 213, DateTimeKind.Unspecified).AddTicks(9464), null, 126, 1 },
                    { 15, 2, new DateTime(2021, 11, 10, 12, 40, 42, 242, DateTimeKind.Unspecified).AddTicks(8494), null, 135, 1 },
                    { 15, 4, new DateTime(2020, 8, 10, 2, 34, 56, 486, DateTimeKind.Unspecified).AddTicks(74), null, 60, 1 },
                    { 21, 2, new DateTime(2022, 1, 27, 5, 48, 47, 211, DateTimeKind.Unspecified).AddTicks(7691), null, 199, 1 },
                    { 21, 5, new DateTime(2020, 11, 24, 4, 41, 20, 547, DateTimeKind.Unspecified).AddTicks(2835), null, 110, 1 },
                    { 23, 1, new DateTime(2021, 8, 18, 11, 1, 36, 215, DateTimeKind.Unspecified).AddTicks(3274), null, 36, 1 },
                    { 23, 8, new DateTime(2021, 11, 6, 5, 30, 26, 44, DateTimeKind.Unspecified).AddTicks(3177), null, 55, 1 },
                    { 23, 9, new DateTime(2021, 8, 28, 15, 47, 44, 843, DateTimeKind.Unspecified).AddTicks(6422), null, 86, 1 },
                    { 25, 3, new DateTime(2022, 5, 14, 3, 45, 14, 270, DateTimeKind.Unspecified).AddTicks(6016), null, 125, 1 },
                    { 25, 5, new DateTime(2022, 5, 26, 1, 18, 40, 476, DateTimeKind.Unspecified).AddTicks(6910), null, 96, 1 },
                    { 25, 7, new DateTime(2021, 3, 12, 1, 10, 44, 303, DateTimeKind.Unspecified).AddTicks(6508), null, 143, 1 },
                    { 27, 2, new DateTime(2022, 11, 26, 2, 56, 7, 889, DateTimeKind.Unspecified).AddTicks(1315), null, 92, 1 },
                    { 27, 3, new DateTime(2020, 3, 25, 12, 57, 35, 156, DateTimeKind.Unspecified).AddTicks(5515), null, 86, 1 },
                    { 28, 4, new DateTime(2020, 8, 3, 9, 43, 2, 140, DateTimeKind.Unspecified).AddTicks(5667), null, 152, 1 },
                    { 28, 10, new DateTime(2022, 3, 22, 9, 59, 48, 638, DateTimeKind.Unspecified).AddTicks(2630), null, 188, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 8, "Music", new DateTime(2020, 7, 6, 0, 31, 56, 556, DateTimeKind.Unspecified).AddTicks(883), null, 5, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 9, 1, 6, 39, 26, 171, DateTimeKind.Unspecified).AddTicks(833), null, "Guinea-Bissau", new DateTime(2020, 8, 12, 6, 55, 47, 907, DateTimeKind.Unspecified).AddTicks(2272), 1 },
                    { 10, new DateTime(2022, 1, 2, 17, 36, 12, 890, DateTimeKind.Unspecified).AddTicks(8425), null, "Australia", new DateTime(2020, 10, 25, 8, 10, 0, 464, DateTimeKind.Unspecified).AddTicks(6366), 1 },
                    { 11, new DateTime(2021, 7, 30, 14, 42, 40, 313, DateTimeKind.Unspecified).AddTicks(6034), null, "Chad", new DateTime(2022, 8, 24, 6, 30, 24, 410, DateTimeKind.Unspecified).AddTicks(3239), 1 },
                    { 13, new DateTime(2022, 5, 25, 0, 2, 31, 425, DateTimeKind.Unspecified).AddTicks(8770), null, "Lebanon", new DateTime(2021, 8, 23, 7, 44, 12, 388, DateTimeKind.Unspecified).AddTicks(2883), 1 },
                    { 14, new DateTime(2021, 12, 6, 21, 13, 22, 528, DateTimeKind.Unspecified).AddTicks(6889), null, "Kiribati", new DateTime(2021, 7, 31, 18, 31, 34, 33, DateTimeKind.Unspecified).AddTicks(14), 1 },
                    { 16, new DateTime(2021, 1, 14, 12, 52, 3, 430, DateTimeKind.Unspecified).AddTicks(6408), null, "Tunisia", new DateTime(2022, 8, 19, 4, 32, 41, 228, DateTimeKind.Unspecified).AddTicks(5346), 1 },
                    { 22, new DateTime(2021, 1, 9, 8, 12, 34, 405, DateTimeKind.Unspecified).AddTicks(4967), null, "Dominican Republic", new DateTime(2021, 12, 16, 9, 49, 0, 657, DateTimeKind.Unspecified).AddTicks(8319), 1 },
                    { 24, new DateTime(2021, 10, 31, 23, 34, 3, 451, DateTimeKind.Unspecified).AddTicks(8921), null, "French Southern Territories", new DateTime(2020, 11, 29, 11, 3, 29, 3, DateTimeKind.Unspecified).AddTicks(5020), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 4, 5, new DateTime(2020, 5, 11, 20, 22, 24, 657, DateTimeKind.Unspecified).AddTicks(883), null, "Awesome Rubber Chips", 53m, 1, 1 },
                    { 17, 5, new DateTime(2022, 2, 3, 6, 48, 12, 530, DateTimeKind.Unspecified).AddTicks(7399), null, "Fantastic Cotton Fish", 55m, 1, 23 },
                    { 18, 5, new DateTime(2022, 6, 6, 19, 52, 45, 685, DateTimeKind.Unspecified).AddTicks(1076), null, "Small Frozen Salad", 53m, 1, 143 },
                    { 26, 5, new DateTime(2021, 6, 14, 21, 0, 5, 390, DateTimeKind.Unspecified).AddTicks(3651), null, "Sleek Plastic Soap", 49m, 1, 49 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "DataStatus" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2021, 9, 5, 21, 31, 4, 282, DateTimeKind.Unspecified).AddTicks(1973), null, 182, 1 },
                    { 6, 2, new DateTime(2020, 8, 18, 9, 1, 15, 739, DateTimeKind.Unspecified).AddTicks(3439), null, 200, 1 },
                    { 6, 4, new DateTime(2022, 6, 11, 14, 8, 3, 621, DateTimeKind.Unspecified).AddTicks(9619), null, 54, 1 },
                    { 6, 5, new DateTime(2022, 2, 22, 6, 1, 35, 371, DateTimeKind.Unspecified).AddTicks(5101), null, 174, 1 },
                    { 6, 6, new DateTime(2021, 1, 23, 13, 36, 5, 643, DateTimeKind.Unspecified).AddTicks(472), null, 192, 1 },
                    { 10, 1, new DateTime(2022, 8, 15, 4, 38, 8, 14, DateTimeKind.Unspecified).AddTicks(2154), null, 123, 1 },
                    { 10, 5, new DateTime(2020, 4, 15, 13, 49, 9, 156, DateTimeKind.Unspecified).AddTicks(9733), null, 185, 1 },
                    { 10, 6, new DateTime(2021, 2, 26, 18, 18, 17, 504, DateTimeKind.Unspecified).AddTicks(797), null, 75, 1 },
                    { 10, 9, new DateTime(2021, 2, 1, 10, 47, 40, 582, DateTimeKind.Unspecified).AddTicks(1342), null, 103, 1 },
                    { 11, 4, new DateTime(2022, 6, 14, 1, 11, 54, 937, DateTimeKind.Unspecified).AddTicks(2582), null, 85, 1 },
                    { 11, 7, new DateTime(2022, 10, 23, 7, 10, 37, 452, DateTimeKind.Unspecified).AddTicks(246), null, 150, 1 },
                    { 13, 2, new DateTime(2022, 3, 23, 17, 52, 19, 552, DateTimeKind.Unspecified).AddTicks(7869), null, 39, 1 },
                    { 13, 6, new DateTime(2022, 1, 25, 15, 30, 4, 303, DateTimeKind.Unspecified).AddTicks(3971), null, 171, 1 },
                    { 13, 9, new DateTime(2021, 9, 15, 21, 33, 20, 259, DateTimeKind.Unspecified).AddTicks(8834), null, 195, 1 },
                    { 14, 3, new DateTime(2020, 9, 22, 16, 21, 9, 876, DateTimeKind.Unspecified).AddTicks(1652), null, 163, 1 },
                    { 16, 3, new DateTime(2021, 5, 28, 22, 54, 8, 317, DateTimeKind.Unspecified).AddTicks(7057), null, 9, 1 },
                    { 16, 10, new DateTime(2022, 8, 12, 6, 58, 28, 872, DateTimeKind.Unspecified).AddTicks(5605), null, 122, 1 },
                    { 22, 2, new DateTime(2020, 8, 8, 22, 40, 58, 752, DateTimeKind.Unspecified).AddTicks(4455), null, 115, 1 },
                    { 22, 3, new DateTime(2021, 12, 24, 2, 31, 15, 654, DateTimeKind.Unspecified).AddTicks(513), null, 117, 1 },
                    { 22, 9, new DateTime(2020, 11, 26, 21, 57, 7, 88, DateTimeKind.Unspecified).AddTicks(3858), null, 52, 1 },
                    { 24, 5, new DateTime(2020, 4, 10, 6, 57, 41, 916, DateTimeKind.Unspecified).AddTicks(334), null, 166, 1 },
                    { 24, 7, new DateTime(2021, 10, 12, 9, 8, 46, 629, DateTimeKind.Unspecified).AddTicks(1259), null, 194, 1 },
                    { 24, 9, new DateTime(2022, 6, 28, 20, 20, 49, 128, DateTimeKind.Unspecified).AddTicks(1158), null, 34, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 6, 24, 17, 55, 16, 560, DateTimeKind.Unspecified).AddTicks(6109), null, "Liechtenstein", new DateTime(2021, 1, 12, 22, 48, 52, 900, DateTimeKind.Unspecified).AddTicks(9269), 1 },
                    { 17, new DateTime(2020, 4, 18, 18, 2, 16, 587, DateTimeKind.Unspecified).AddTicks(5207), null, "Colombia", new DateTime(2023, 1, 4, 19, 25, 54, 161, DateTimeKind.Unspecified).AddTicks(6546), 1 },
                    { 18, new DateTime(2022, 8, 2, 15, 7, 32, 709, DateTimeKind.Unspecified).AddTicks(7131), null, "Comoros", new DateTime(2021, 4, 21, 20, 38, 50, 187, DateTimeKind.Unspecified).AddTicks(1653), 1 },
                    { 26, new DateTime(2021, 7, 21, 11, 15, 31, 818, DateTimeKind.Unspecified).AddTicks(6893), null, "Reunion", new DateTime(2021, 9, 8, 4, 47, 43, 729, DateTimeKind.Unspecified).AddTicks(4062), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 29, 8, new DateTime(2020, 10, 20, 6, 22, 47, 708, DateTimeKind.Unspecified).AddTicks(1714), null, "Awesome Concrete Tuna", 51m, 1, 47 },
                    { 30, 8, new DateTime(2020, 11, 27, 3, 42, 37, 757, DateTimeKind.Unspecified).AddTicks(8076), null, "Tasty Soft Hat", 49m, 1, 146 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "DataStatus" },
                values: new object[,]
                {
                    { 4, 6, new DateTime(2020, 5, 27, 9, 47, 3, 59, DateTimeKind.Unspecified).AddTicks(7681), null, 161, 1 },
                    { 4, 10, new DateTime(2021, 12, 3, 16, 42, 18, 407, DateTimeKind.Unspecified).AddTicks(2024), null, 191, 1 },
                    { 17, 5, new DateTime(2022, 3, 12, 7, 41, 53, 981, DateTimeKind.Unspecified).AddTicks(883), null, 88, 1 },
                    { 17, 7, new DateTime(2020, 4, 22, 12, 48, 12, 434, DateTimeKind.Unspecified).AddTicks(5090), null, 14, 1 },
                    { 18, 4, new DateTime(2022, 7, 15, 0, 57, 51, 618, DateTimeKind.Unspecified).AddTicks(9196), null, 70, 1 },
                    { 18, 6, new DateTime(2021, 6, 9, 23, 57, 50, 674, DateTimeKind.Unspecified).AddTicks(3113), null, 31, 1 },
                    { 18, 7, new DateTime(2022, 10, 25, 19, 47, 0, 618, DateTimeKind.Unspecified).AddTicks(1226), null, 72, 1 },
                    { 18, 8, new DateTime(2020, 5, 18, 23, 35, 9, 989, DateTimeKind.Unspecified).AddTicks(8214), null, 38, 1 },
                    { 26, 4, new DateTime(2022, 10, 17, 23, 33, 34, 794, DateTimeKind.Unspecified).AddTicks(9340), null, 184, 1 },
                    { 26, 8, new DateTime(2020, 12, 19, 2, 58, 55, 175, DateTimeKind.Unspecified).AddTicks(6825), null, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 29, new DateTime(2020, 8, 2, 0, 29, 22, 277, DateTimeKind.Unspecified).AddTicks(934), null, "Philippines", new DateTime(2022, 5, 15, 22, 34, 41, 598, DateTimeKind.Unspecified).AddTicks(9556), 1 },
                    { 30, new DateTime(2022, 12, 26, 18, 2, 7, 158, DateTimeKind.Unspecified).AddTicks(1348), null, "Namibia", new DateTime(2020, 9, 20, 5, 23, 32, 16, DateTimeKind.Unspecified).AddTicks(5840), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "DataStatus" },
                values: new object[,]
                {
                    { 29, 2, new DateTime(2020, 3, 15, 15, 52, 51, 614, DateTimeKind.Unspecified).AddTicks(6486), null, 125, 1 },
                    { 29, 5, new DateTime(2020, 9, 18, 12, 34, 41, 342, DateTimeKind.Unspecified).AddTicks(6112), null, 154, 1 },
                    { 29, 6, new DateTime(2021, 12, 21, 22, 28, 32, 831, DateTimeKind.Unspecified).AddTicks(7844), null, 200, 1 },
                    { 29, 7, new DateTime(2020, 12, 19, 13, 37, 29, 938, DateTimeKind.Unspecified).AddTicks(3140), null, 124, 1 },
                    { 29, 10, new DateTime(2021, 7, 31, 9, 43, 34, 74, DateTimeKind.Unspecified).AddTicks(992), null, 118, 1 },
                    { 30, 6, new DateTime(2021, 3, 6, 5, 1, 37, 661, DateTimeKind.Unspecified).AddTicks(2620), null, 120, 1 }
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
                name: "IX_ProductsSuppliers_SupplierID",
                table: "ProductsSuppliers",
                column: "SupplierID");
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
