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
                    { 1, null, new DateTime(2023, 1, 8, 17, 23, 15, 271, DateTimeKind.Local).AddTicks(3510), null, "Admin", "ADMIN", 1 },
                    { 2, null, new DateTime(2023, 1, 8, 17, 23, 15, 271, DateTimeKind.Local).AddTicks(3726), null, "Member", "MEMBER", 1 },
                    { 3, null, new DateTime(2023, 1, 8, 17, 23, 15, 271, DateTimeKind.Local).AddTicks(3731), null, "Supplier", "SUPPLIER", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "DataStatus", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "416c6321-2489-464e-9f02-255617e87bcc", "Alex38@gmail.com", true, new DateTime(2022, 1, 23, 5, 14, 7, 88, DateTimeKind.Unspecified).AddTicks(3995), null, false, null, "ALEX38@GMAIL.COM", "VANCE.SPORER", "khTjSoSIX0", "215.621.1275 x44740", false, "lVqwGnKnnB", 1, false, "Vance.Sporer" },
                    { 2, 0, "6e05afd0-e950-430d-9848-97dde79a9ede", "Emerson94@gmail.com", true, new DateTime(2021, 12, 11, 8, 36, 11, 923, DateTimeKind.Unspecified).AddTicks(6706), null, false, null, "EMERSON94@GMAIL.COM", "BRIGITTE_HAUCK84", "7cnggRIwWV", "881-718-9417", false, "pm5UJn_9nh", 1, false, "Brigitte_Hauck84" },
                    { 3, 0, "76396229-072b-47ad-8ac5-91eaf4967cf5", "Camila54@gmail.com", true, new DateTime(2022, 1, 11, 20, 1, 13, 897, DateTimeKind.Unspecified).AddTicks(3155), null, false, null, "CAMILA54@GMAIL.COM", "MICHALE_OKEEFE85", "J1coR_7L1G", "1-874-690-7533", false, "9YniW_uyOe", 1, false, "Michale_OKeefe85" },
                    { 4, 0, "9e7ac1b3-0ae2-4795-8691-b78b320b1f31", "Drew.Hane10@gmail.com", true, new DateTime(2020, 5, 26, 19, 39, 43, 164, DateTimeKind.Unspecified).AddTicks(5995), null, false, null, "DREW.HANE10@GMAIL.COM", "ODA_ABERNATHY", "DO1k6WLpMQ", "1-577-912-4565", false, "eSHns4KBL4", 1, false, "Oda_Abernathy" },
                    { 5, 0, "36d30a5b-5460-4e21-b509-5242afc00e8a", "Earlene.Sporer@gmail.com", true, new DateTime(2021, 2, 6, 3, 4, 24, 13, DateTimeKind.Unspecified).AddTicks(1277), null, false, null, "EARLENE.SPORER@GMAIL.COM", "SID.GIBSON97", "XFMTvrWG6P", "425.929.0256 x881", false, "t_3iYaVX8X", 1, false, "Sid.Gibson97" },
                    { 6, 0, "714a53c3-46e2-4df2-a136-f272ff60d1f6", "Fiona24@gmail.com", true, new DateTime(2020, 7, 3, 5, 38, 28, 203, DateTimeKind.Unspecified).AddTicks(6652), null, false, null, "FIONA24@GMAIL.COM", "HUBERT88", "PCb39fMH_w", "1-936-448-6634 x79537", false, "kC4ZciI97a", 1, false, "Hubert88" },
                    { 7, 0, "6041ff89-7a44-4883-838d-c9a767299069", "Camille5@gmail.com", true, new DateTime(2020, 5, 25, 13, 18, 53, 966, DateTimeKind.Unspecified).AddTicks(6948), null, false, null, "CAMILLE5@GMAIL.COM", "TAMARA_SHANAHAN34", "nWU0ME97Ql", "779-536-9728", false, "JahIzsUKhN", 1, false, "Tamara_Shanahan34" },
                    { 8, 0, "b0840b58-baae-413a-adb3-2828599998e2", "Tod3@hotmail.com", true, new DateTime(2021, 5, 28, 12, 5, 26, 364, DateTimeKind.Unspecified).AddTicks(4083), null, false, null, "TOD3@HOTMAIL.COM", "TAYLOR30", "cQhbukNrAK", "447-226-9228 x0433", false, "lzbTog_VmT", 1, false, "Taylor30" },
                    { 9, 0, "e65348be-2b3b-419c-8f56-27552bc2f65b", "Lacy92@yahoo.com", true, new DateTime(2020, 7, 7, 7, 0, 2, 105, DateTimeKind.Unspecified).AddTicks(2295), null, false, null, "LACY92@YAHOO.COM", "SHAYNE.LOWE", "8tVqE_BaUe", "546.480.9220 x01742", false, "5CzKI8DycN", 1, false, "Shayne.Lowe" },
                    { 10, 0, "7b454289-f389-438a-9061-2c098a87455c", "Shad_Beatty@hotmail.com", true, new DateTime(2022, 4, 26, 12, 7, 16, 440, DateTimeKind.Unspecified).AddTicks(4588), null, false, null, "SHAD_BEATTY@HOTMAIL.COM", "DAN1", "mvJpGwOpGL", "427-260-9293 x33364", false, "RwXqYzfpc7", 1, false, "Dan1" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 1, "All", new DateTime(2022, 12, 1, 0, 12, 7, 795, DateTimeKind.Unspecified).AddTicks(2788), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "32070 Magali Radial, Port Myrahaven, Vanuatu", "Collier Group", new DateTime(2021, 12, 20, 3, 32, 20, 387, DateTimeKind.Unspecified).AddTicks(9337), null, 1 },
                    { 2, "8506 McCullough Roads, Lake Lavinaland, Cocos (Keeling) Islands", "Hahn Group", new DateTime(2023, 1, 3, 16, 25, 58, 257, DateTimeKind.Unspecified).AddTicks(3772), null, 1 },
                    { 3, "61836 Corkery Walks, North Moises, Republic of Korea", "Bauch and Sons", new DateTime(2020, 6, 19, 5, 18, 38, 365, DateTimeKind.Unspecified).AddTicks(3052), null, 1 },
                    { 4, "155 Torphy Bridge, Port Jarredborough, Mauritius", "Williamson and Sons", new DateTime(2021, 4, 2, 11, 26, 20, 4, DateTimeKind.Unspecified).AddTicks(2764), null, 1 },
                    { 5, "64285 Leuschke Pine, North Luciano, Saint Pierre and Miquelon", "Rodriguez, Hirthe and Wehner", new DateTime(2022, 1, 10, 13, 11, 47, 858, DateTimeKind.Unspecified).AddTicks(8716), null, 1 },
                    { 6, "54859 Gutmann Forge, West Erich, Guadeloupe", "Hilpert, Goyette and Ritchie", new DateTime(2020, 9, 18, 3, 25, 20, 297, DateTimeKind.Unspecified).AddTicks(9173), null, 1 },
                    { 7, "60257 Dooley Pine, Lake Cathy, France", "Casper, Mitchell and McCullough", new DateTime(2021, 11, 6, 12, 28, 16, 931, DateTimeKind.Unspecified).AddTicks(8616), null, 1 },
                    { 8, "21122 Mayert Radial, South Gianniberg, Lebanon", "Herman - Hoppe", new DateTime(2021, 2, 12, 4, 46, 52, 93, DateTimeKind.Unspecified).AddTicks(544), null, 1 },
                    { 9, "136 Carroll Pine, North Otilia, Mayotte", "Pollich, Boehm and Rolfson", new DateTime(2020, 3, 23, 16, 43, 4, 988, DateTimeKind.Unspecified).AddTicks(5979), null, 1 },
                    { 10, "13631 Keyshawn Light, Swaniawskiborough, Tajikistan", "Kemmer - Kling", new DateTime(2020, 10, 31, 11, 10, 33, 908, DateTimeKind.Unspecified).AddTicks(2381), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "InsertedDate", "LastModifiedDate", "DataStatus" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 3, 24, 21, 47, 13, 784, DateTimeKind.Unspecified).AddTicks(5681), null, 1 },
                    { 1, 2, new DateTime(2021, 6, 12, 0, 36, 2, 857, DateTimeKind.Unspecified).AddTicks(302), null, 1 },
                    { 2, 3, new DateTime(2022, 3, 25, 4, 19, 48, 555, DateTimeKind.Unspecified).AddTicks(6674), null, 1 },
                    { 1, 4, new DateTime(2022, 8, 2, 12, 47, 46, 491, DateTimeKind.Unspecified).AddTicks(7934), null, 1 },
                    { 1, 5, new DateTime(2020, 5, 10, 2, 17, 11, 36, DateTimeKind.Unspecified).AddTicks(8281), null, 1 },
                    { 2, 6, new DateTime(2022, 10, 5, 0, 9, 42, 964, DateTimeKind.Unspecified).AddTicks(3725), null, 1 },
                    { 1, 7, new DateTime(2021, 8, 23, 5, 18, 57, 972, DateTimeKind.Unspecified).AddTicks(7541), null, 1 },
                    { 1, 8, new DateTime(2020, 11, 22, 0, 26, 2, 95, DateTimeKind.Unspecified).AddTicks(6103), null, 1 },
                    { 2, 9, new DateTime(2021, 3, 20, 3, 3, 17, 44, DateTimeKind.Unspecified).AddTicks(9609), null, 1 },
                    { 3, 10, new DateTime(2022, 3, 16, 5, 36, 3, 698, DateTimeKind.Unspecified).AddTicks(7580), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 2, "Electronics", new DateTime(2021, 1, 22, 14, 1, 0, 718, DateTimeKind.Unspecified).AddTicks(6690), null, 1, 1 },
                    { 3, "Automotive", new DateTime(2022, 10, 29, 13, 53, 32, 658, DateTimeKind.Unspecified).AddTicks(9144), null, 1, 1 },
                    { 6, "Home", new DateTime(2021, 2, 16, 17, 46, 21, 113, DateTimeKind.Unspecified).AddTicks(3360), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 28, 16, 26, 24, 418, DateTimeKind.Unspecified).AddTicks(447), null, "Handcrafted Rubber Bacon", 1 },
                    { 4, 1, new DateTime(2020, 4, 20, 7, 5, 44, 344, DateTimeKind.Unspecified).AddTicks(2365), null, "Practical Cotton Bike", 1 },
                    { 20, 1, new DateTime(2021, 6, 30, 14, 14, 49, 976, DateTimeKind.Unspecified).AddTicks(1451), null, "Generic Soft Pizza", 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 4, "Outdoors", new DateTime(2022, 2, 23, 4, 17, 47, 69, DateTimeKind.Unspecified).AddTicks(8169), null, 2, 1 },
                    { 5, "Clothing", new DateTime(2020, 5, 4, 22, 45, 23, 697, DateTimeKind.Unspecified).AddTicks(8383), null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 14, 12, 30, 5, 672, DateTimeKind.Unspecified).AddTicks(3576), null, "Liberia", new DateTime(2021, 3, 10, 4, 52, 25, 103, DateTimeKind.Unspecified).AddTicks(5129), 1 },
                    { 4, new DateTime(2022, 4, 7, 3, 21, 51, 242, DateTimeKind.Unspecified).AddTicks(5466), null, "Peru", new DateTime(2022, 7, 30, 22, 15, 27, 497, DateTimeKind.Unspecified).AddTicks(1888), 1 },
                    { 20, new DateTime(2021, 1, 18, 14, 43, 2, 718, DateTimeKind.Unspecified).AddTicks(5943), null, "Guinea", new DateTime(2022, 5, 10, 13, 55, 45, 528, DateTimeKind.Unspecified).AddTicks(2473), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 2, 6, new DateTime(2020, 5, 31, 17, 28, 30, 395, DateTimeKind.Unspecified).AddTicks(406), null, "Incredible Soft Bike", 1 },
                    { 6, 2, new DateTime(2021, 5, 3, 21, 40, 13, 248, DateTimeKind.Unspecified).AddTicks(6444), null, "Tasty Frozen Soap", 1 },
                    { 7, 6, new DateTime(2020, 6, 2, 9, 46, 47, 651, DateTimeKind.Unspecified).AddTicks(4889), null, "Intelligent Frozen Tuna", 1 },
                    { 12, 6, new DateTime(2021, 10, 25, 6, 17, 0, 808, DateTimeKind.Unspecified).AddTicks(6239), null, "Unbranded Fresh Pants", 1 },
                    { 13, 2, new DateTime(2021, 9, 10, 15, 35, 21, 437, DateTimeKind.Unspecified).AddTicks(7618), null, "Practical Plastic Salad", 1 },
                    { 15, 2, new DateTime(2020, 8, 18, 19, 30, 32, 498, DateTimeKind.Unspecified).AddTicks(704), null, "Fantastic Wooden Chicken", 1 },
                    { 18, 2, new DateTime(2021, 7, 17, 2, 38, 35, 702, DateTimeKind.Unspecified).AddTicks(9683), null, "Fantastic Steel Tuna", 1 },
                    { 24, 2, new DateTime(2022, 11, 25, 4, 8, 32, 737, DateTimeKind.Unspecified).AddTicks(3419), null, "Practical Fresh Chair", 1 },
                    { 27, 3, new DateTime(2021, 10, 5, 5, 0, 13, 261, DateTimeKind.Unspecified).AddTicks(6249), null, "Practical Steel Pizza", 1 },
                    { 29, 6, new DateTime(2022, 1, 4, 22, 28, 38, 135, DateTimeKind.Unspecified).AddTicks(9223), null, "Incredible Rubber Chips", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2022, 10, 7, 21, 33, 13, 600, DateTimeKind.Unspecified).AddTicks(963), null, 56m, 1, 83 },
                    { 1, 9, new DateTime(2020, 5, 28, 2, 26, 53, 73, DateTimeKind.Unspecified).AddTicks(7457), null, 55m, 1, 9 },
                    { 20, 6, new DateTime(2021, 9, 3, 6, 51, 7, 998, DateTimeKind.Unspecified).AddTicks(9361), null, 51m, 1, 103 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 7, "Computers", new DateTime(2022, 5, 12, 19, 7, 49, 302, DateTimeKind.Unspecified).AddTicks(8108), null, 5, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 8, 19, 8, 49, 49, 895, DateTimeKind.Unspecified).AddTicks(7498), null, "China", new DateTime(2022, 6, 18, 1, 22, 13, 564, DateTimeKind.Unspecified).AddTicks(8220), 1 },
                    { 6, new DateTime(2021, 10, 3, 13, 59, 19, 320, DateTimeKind.Unspecified).AddTicks(8790), null, "Greenland", new DateTime(2022, 2, 28, 14, 48, 55, 54, DateTimeKind.Unspecified).AddTicks(1510), 1 },
                    { 7, new DateTime(2020, 5, 13, 0, 30, 48, 161, DateTimeKind.Unspecified).AddTicks(6083), null, "Netherlands", new DateTime(2021, 3, 20, 5, 48, 59, 878, DateTimeKind.Unspecified).AddTicks(7139), 1 },
                    { 12, new DateTime(2020, 6, 2, 16, 35, 37, 142, DateTimeKind.Unspecified).AddTicks(2354), null, "Saint Vincent and the Grenadines", new DateTime(2020, 12, 6, 7, 29, 14, 580, DateTimeKind.Unspecified).AddTicks(5093), 1 },
                    { 13, new DateTime(2020, 9, 28, 17, 55, 43, 713, DateTimeKind.Unspecified).AddTicks(2971), null, "Indonesia", new DateTime(2021, 10, 14, 12, 33, 0, 573, DateTimeKind.Unspecified).AddTicks(5840), 1 },
                    { 15, new DateTime(2021, 10, 1, 13, 0, 5, 486, DateTimeKind.Unspecified).AddTicks(6014), null, "Tokelau", new DateTime(2022, 11, 24, 23, 31, 10, 398, DateTimeKind.Unspecified).AddTicks(8682), 1 },
                    { 18, new DateTime(2021, 1, 12, 1, 28, 37, 853, DateTimeKind.Unspecified).AddTicks(1955), null, "Mali", new DateTime(2021, 3, 22, 16, 10, 30, 334, DateTimeKind.Unspecified).AddTicks(2041), 1 },
                    { 24, new DateTime(2020, 12, 6, 23, 32, 0, 992, DateTimeKind.Unspecified).AddTicks(7637), null, "Equatorial Guinea", new DateTime(2021, 4, 2, 1, 36, 27, 763, DateTimeKind.Unspecified).AddTicks(1089), 1 },
                    { 27, new DateTime(2021, 1, 27, 4, 35, 8, 33, DateTimeKind.Unspecified).AddTicks(533), null, "Antarctica (the territory South of 60 deg S)", new DateTime(2020, 4, 1, 10, 47, 13, 20, DateTimeKind.Unspecified).AddTicks(628), 1 },
                    { 29, new DateTime(2021, 2, 12, 4, 12, 24, 516, DateTimeKind.Unspecified).AddTicks(1223), null, "Samoa", new DateTime(2022, 4, 16, 5, 15, 12, 319, DateTimeKind.Unspecified).AddTicks(7580), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2021, 4, 20, 16, 11, 58, 345, DateTimeKind.Unspecified).AddTicks(6510), null, "Refined Granite Salad", 1 },
                    { 5, 5, new DateTime(2020, 4, 30, 9, 10, 20, 906, DateTimeKind.Unspecified).AddTicks(1246), null, "Rustic Fresh Bacon", 1 },
                    { 8, 5, new DateTime(2022, 6, 23, 10, 26, 47, 177, DateTimeKind.Unspecified).AddTicks(7650), null, "Tasty Concrete Salad", 1 },
                    { 9, 5, new DateTime(2022, 6, 12, 5, 9, 23, 353, DateTimeKind.Unspecified).AddTicks(206), null, "Generic Soft Mouse", 1 },
                    { 17, 4, new DateTime(2021, 2, 25, 14, 26, 52, 825, DateTimeKind.Unspecified).AddTicks(569), null, "Fantastic Cotton Keyboard", 1 },
                    { 19, 4, new DateTime(2022, 2, 28, 3, 37, 10, 35, DateTimeKind.Unspecified).AddTicks(8171), null, "Fantastic Steel Soap", 1 },
                    { 23, 4, new DateTime(2021, 1, 8, 23, 21, 19, 764, DateTimeKind.Unspecified).AddTicks(9463), null, "Practical Concrete Soap", 1 },
                    { 25, 5, new DateTime(2022, 3, 26, 9, 48, 34, 779, DateTimeKind.Unspecified).AddTicks(3892), null, "Licensed Concrete Tuna", 1 },
                    { 26, 4, new DateTime(2021, 4, 6, 23, 54, 21, 213, DateTimeKind.Unspecified).AddTicks(7788), null, "Ergonomic Metal Bacon", 1 },
                    { 28, 4, new DateTime(2022, 11, 30, 11, 47, 33, 183, DateTimeKind.Unspecified).AddTicks(2964), null, "Incredible Plastic Ball", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2022, 5, 1, 20, 40, 39, 749, DateTimeKind.Unspecified).AddTicks(3480), null, 55m, 1, 147 },
                    { 2, 4, new DateTime(2020, 9, 26, 12, 52, 37, 746, DateTimeKind.Unspecified).AddTicks(4319), null, 54m, 1, 6 },
                    { 2, 5, new DateTime(2022, 3, 19, 8, 50, 3, 873, DateTimeKind.Unspecified).AddTicks(1931), null, 55m, 1, 109 },
                    { 2, 8, new DateTime(2022, 12, 6, 12, 44, 37, 103, DateTimeKind.Unspecified).AddTicks(4848), null, 57m, 1, 69 },
                    { 2, 9, new DateTime(2022, 6, 16, 6, 49, 34, 898, DateTimeKind.Unspecified).AddTicks(2270), null, 50m, 1, 129 },
                    { 6, 1, new DateTime(2021, 7, 13, 10, 51, 14, 42, DateTimeKind.Unspecified).AddTicks(73), null, 49m, 1, 127 },
                    { 6, 4, new DateTime(2020, 9, 21, 8, 24, 2, 335, DateTimeKind.Unspecified).AddTicks(1114), null, 56m, 1, 154 },
                    { 6, 5, new DateTime(2021, 7, 2, 0, 57, 55, 822, DateTimeKind.Unspecified).AddTicks(8368), null, 52m, 1, 19 },
                    { 6, 7, new DateTime(2021, 8, 13, 18, 51, 4, 121, DateTimeKind.Unspecified).AddTicks(1386), null, 49m, 1, 156 },
                    { 12, 5, new DateTime(2022, 4, 26, 15, 15, 29, 506, DateTimeKind.Unspecified).AddTicks(9217), null, 53m, 1, 156 },
                    { 12, 8, new DateTime(2022, 1, 29, 23, 47, 23, 676, DateTimeKind.Unspecified).AddTicks(692), null, 54m, 1, 124 },
                    { 15, 1, new DateTime(2021, 5, 6, 5, 11, 12, 869, DateTimeKind.Unspecified).AddTicks(6860), null, 49m, 1, 40 },
                    { 15, 3, new DateTime(2022, 12, 15, 14, 37, 55, 595, DateTimeKind.Unspecified).AddTicks(9851), null, 55m, 1, 177 },
                    { 15, 5, new DateTime(2020, 10, 4, 23, 39, 53, 972, DateTimeKind.Unspecified).AddTicks(4792), null, 51m, 1, 150 },
                    { 15, 6, new DateTime(2020, 9, 27, 18, 45, 19, 77, DateTimeKind.Unspecified).AddTicks(4948), null, 56m, 1, 182 },
                    { 15, 7, new DateTime(2020, 3, 20, 1, 48, 44, 167, DateTimeKind.Unspecified).AddTicks(3061), null, 49m, 1, 59 },
                    { 18, 5, new DateTime(2022, 5, 1, 7, 10, 31, 701, DateTimeKind.Unspecified).AddTicks(2820), null, 49m, 1, 1 },
                    { 24, 4, new DateTime(2021, 8, 13, 8, 33, 25, 50, DateTimeKind.Unspecified).AddTicks(6880), null, 49m, 1, 68 },
                    { 24, 8, new DateTime(2020, 5, 24, 15, 51, 3, 399, DateTimeKind.Unspecified).AddTicks(2703), null, 57m, 1, 114 },
                    { 27, 2, new DateTime(2021, 2, 26, 13, 24, 4, 683, DateTimeKind.Unspecified).AddTicks(4142), null, 53m, 1, 62 },
                    { 27, 6, new DateTime(2020, 11, 23, 5, 14, 25, 712, DateTimeKind.Unspecified).AddTicks(2721), null, 51m, 1, 8 },
                    { 29, 1, new DateTime(2021, 3, 24, 18, 40, 40, 50, DateTimeKind.Unspecified).AddTicks(6947), null, 57m, 1, 180 },
                    { 29, 3, new DateTime(2021, 9, 20, 22, 7, 39, 813, DateTimeKind.Unspecified).AddTicks(7663), null, 52m, 1, 15 },
                    { 29, 6, new DateTime(2020, 11, 3, 13, 38, 26, 228, DateTimeKind.Unspecified).AddTicks(7128), null, 49m, 1, 193 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[,]
                {
                    { 8, "Sports", new DateTime(2022, 12, 6, 4, 50, 41, 105, DateTimeKind.Unspecified).AddTicks(296), null, 7, 1 },
                    { 10, "Tools", new DateTime(2021, 2, 16, 2, 22, 16, 175, DateTimeKind.Unspecified).AddTicks(2427), null, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 11, 6, 2, 8, 9, 226, DateTimeKind.Unspecified).AddTicks(8211), null, "Azerbaijan", new DateTime(2021, 4, 11, 17, 28, 39, 90, DateTimeKind.Unspecified).AddTicks(4030), 1 },
                    { 5, new DateTime(2022, 11, 20, 15, 41, 12, 488, DateTimeKind.Unspecified).AddTicks(2137), null, "Puerto Rico", new DateTime(2020, 9, 5, 4, 43, 7, 293, DateTimeKind.Unspecified).AddTicks(7394), 1 },
                    { 8, new DateTime(2021, 12, 29, 0, 45, 37, 183, DateTimeKind.Unspecified).AddTicks(1774), null, "Portugal", new DateTime(2022, 11, 25, 1, 13, 54, 591, DateTimeKind.Unspecified).AddTicks(3697), 1 },
                    { 9, new DateTime(2020, 8, 15, 1, 4, 21, 669, DateTimeKind.Unspecified).AddTicks(566), null, "Suriname", new DateTime(2021, 5, 9, 9, 8, 12, 968, DateTimeKind.Unspecified).AddTicks(634), 1 },
                    { 17, new DateTime(2022, 1, 27, 7, 39, 3, 871, DateTimeKind.Unspecified).AddTicks(7106), null, "Central African Republic", new DateTime(2021, 1, 31, 7, 41, 0, 447, DateTimeKind.Unspecified).AddTicks(3294), 1 },
                    { 19, new DateTime(2021, 11, 17, 0, 49, 45, 218, DateTimeKind.Unspecified).AddTicks(498), null, "Saint Helena", new DateTime(2021, 8, 4, 19, 13, 35, 24, DateTimeKind.Unspecified).AddTicks(7131), 1 },
                    { 23, new DateTime(2020, 9, 14, 18, 46, 36, 817, DateTimeKind.Unspecified).AddTicks(4809), null, "Mauritania", new DateTime(2022, 4, 8, 14, 10, 39, 327, DateTimeKind.Unspecified).AddTicks(4934), 1 },
                    { 25, new DateTime(2023, 1, 6, 0, 21, 49, 902, DateTimeKind.Unspecified).AddTicks(2592), null, "Tuvalu", new DateTime(2021, 1, 17, 18, 59, 29, 169, DateTimeKind.Unspecified).AddTicks(4787), 1 },
                    { 26, new DateTime(2022, 6, 4, 7, 12, 13, 477, DateTimeKind.Unspecified).AddTicks(264), null, "Malaysia", new DateTime(2022, 3, 16, 19, 35, 43, 500, DateTimeKind.Unspecified).AddTicks(8262), 1 },
                    { 28, new DateTime(2022, 9, 20, 11, 45, 55, 993, DateTimeKind.Unspecified).AddTicks(7008), null, "Western Sahara", new DateTime(2021, 4, 16, 4, 12, 26, 519, DateTimeKind.Unspecified).AddTicks(9150), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[] { 16, 7, new DateTime(2021, 1, 22, 9, 11, 49, 511, DateTimeKind.Unspecified).AddTicks(5206), null, "Unbranded Rubber Cheese", 1 });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2021, 7, 29, 15, 39, 2, 921, DateTimeKind.Unspecified).AddTicks(9620), null, 52m, 1, 3 },
                    { 5, 2, new DateTime(2022, 8, 29, 22, 13, 44, 700, DateTimeKind.Unspecified).AddTicks(3599), null, 57m, 1, 159 },
                    { 5, 3, new DateTime(2022, 6, 11, 9, 22, 33, 491, DateTimeKind.Unspecified).AddTicks(8968), null, 53m, 1, 172 },
                    { 5, 4, new DateTime(2021, 5, 7, 0, 38, 59, 183, DateTimeKind.Unspecified).AddTicks(4945), null, 52m, 1, 125 },
                    { 5, 9, new DateTime(2022, 1, 29, 16, 16, 2, 64, DateTimeKind.Unspecified).AddTicks(6828), null, 50m, 1, 69 },
                    { 8, 2, new DateTime(2021, 11, 19, 3, 35, 18, 933, DateTimeKind.Unspecified).AddTicks(7458), null, 56m, 1, 179 },
                    { 8, 4, new DateTime(2021, 10, 27, 7, 12, 56, 14, DateTimeKind.Unspecified).AddTicks(7615), null, 54m, 1, 76 },
                    { 9, 2, new DateTime(2021, 2, 7, 21, 3, 22, 870, DateTimeKind.Unspecified).AddTicks(7277), null, 57m, 1, 166 },
                    { 9, 3, new DateTime(2020, 8, 26, 3, 23, 58, 173, DateTimeKind.Unspecified).AddTicks(3856), null, 54m, 1, 198 },
                    { 9, 5, new DateTime(2020, 9, 15, 20, 26, 52, 139, DateTimeKind.Unspecified).AddTicks(8732), null, 54m, 1, 154 },
                    { 9, 7, new DateTime(2020, 7, 26, 6, 49, 23, 854, DateTimeKind.Unspecified).AddTicks(5678), null, 55m, 1, 160 },
                    { 17, 2, new DateTime(2022, 4, 19, 12, 51, 37, 662, DateTimeKind.Unspecified).AddTicks(521), null, 49m, 1, 175 },
                    { 17, 4, new DateTime(2021, 1, 29, 20, 10, 19, 288, DateTimeKind.Unspecified).AddTicks(666), null, 52m, 1, 75 },
                    { 17, 6, new DateTime(2022, 3, 3, 22, 42, 29, 762, DateTimeKind.Unspecified).AddTicks(1), null, 51m, 1, 70 },
                    { 19, 4, new DateTime(2022, 1, 24, 15, 9, 47, 563, DateTimeKind.Unspecified).AddTicks(8114), null, 51m, 1, 55 },
                    { 19, 5, new DateTime(2021, 3, 8, 20, 58, 54, 480, DateTimeKind.Unspecified).AddTicks(4750), null, 49m, 1, 145 },
                    { 19, 7, new DateTime(2022, 4, 10, 11, 22, 58, 725, DateTimeKind.Unspecified).AddTicks(6501), null, 50m, 1, 25 },
                    { 19, 8, new DateTime(2022, 5, 14, 0, 24, 14, 246, DateTimeKind.Unspecified).AddTicks(2895), null, 50m, 1, 172 },
                    { 19, 9, new DateTime(2022, 2, 5, 19, 34, 57, 15, DateTimeKind.Unspecified).AddTicks(1015), null, 50m, 1, 141 },
                    { 23, 3, new DateTime(2022, 7, 26, 11, 40, 6, 775, DateTimeKind.Unspecified).AddTicks(2972), null, 52m, 1, 193 },
                    { 23, 4, new DateTime(2020, 10, 12, 20, 38, 21, 537, DateTimeKind.Unspecified).AddTicks(8654), null, 55m, 1, 13 },
                    { 23, 5, new DateTime(2020, 7, 28, 10, 44, 17, 327, DateTimeKind.Unspecified).AddTicks(2641), null, 50m, 1, 163 },
                    { 25, 2, new DateTime(2022, 10, 22, 5, 0, 35, 662, DateTimeKind.Unspecified).AddTicks(4927), null, 53m, 1, 41 },
                    { 25, 3, new DateTime(2021, 1, 31, 21, 21, 45, 484, DateTimeKind.Unspecified).AddTicks(9289), null, 50m, 1, 96 },
                    { 25, 7, new DateTime(2022, 11, 16, 14, 49, 1, 927, DateTimeKind.Unspecified).AddTicks(5524), null, 56m, 1, 69 },
                    { 25, 8, new DateTime(2021, 8, 24, 16, 29, 5, 429, DateTimeKind.Unspecified).AddTicks(8744), null, 57m, 1, 128 },
                    { 25, 9, new DateTime(2022, 2, 7, 16, 39, 46, 584, DateTimeKind.Unspecified).AddTicks(4962), null, 53m, 1, 62 },
                    { 26, 8, new DateTime(2022, 9, 4, 11, 51, 44, 63, DateTimeKind.Unspecified).AddTicks(6993), null, 50m, 1, 95 },
                    { 26, 9, new DateTime(2022, 4, 23, 4, 30, 59, 411, DateTimeKind.Unspecified).AddTicks(3037), null, 52m, 1, 58 },
                    { 28, 3, new DateTime(2021, 5, 24, 14, 35, 8, 615, DateTimeKind.Unspecified).AddTicks(8882), null, 50m, 1, 26 },
                    { 28, 4, new DateTime(2022, 8, 3, 12, 51, 24, 622, DateTimeKind.Unspecified).AddTicks(3660), null, 51m, 1, 38 },
                    { 28, 6, new DateTime(2021, 10, 12, 7, 7, 27, 772, DateTimeKind.Unspecified).AddTicks(8850), null, 57m, 1, 70 },
                    { 28, 10, new DateTime(2022, 8, 11, 12, 53, 53, 267, DateTimeKind.Unspecified).AddTicks(2846), null, 57m, 1, 187 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "DataStatus" },
                values: new object[] { 9, "Outdoors", new DateTime(2020, 3, 25, 23, 38, 53, 806, DateTimeKind.Unspecified).AddTicks(9234), null, 8, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[] { 16, new DateTime(2022, 3, 12, 12, 36, 0, 619, DateTimeKind.Unspecified).AddTicks(3806), null, "Micronesia", new DateTime(2020, 8, 20, 2, 51, 21, 911, DateTimeKind.Unspecified).AddTicks(7891), 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 10, 8, new DateTime(2022, 8, 1, 10, 12, 49, 628, DateTimeKind.Unspecified).AddTicks(962), null, "Refined Frozen Gloves", 1 },
                    { 11, 8, new DateTime(2022, 7, 21, 12, 2, 50, 179, DateTimeKind.Unspecified).AddTicks(5726), null, "Handcrafted Granite Bike", 1 },
                    { 22, 8, new DateTime(2022, 7, 7, 20, 9, 47, 484, DateTimeKind.Unspecified).AddTicks(1092), null, "Handcrafted Concrete Chicken", 1 },
                    { 30, 8, new DateTime(2021, 1, 23, 3, 28, 2, 50, DateTimeKind.Unspecified).AddTicks(7575), null, "Handmade Soft Pizza", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 16, 1, new DateTime(2021, 2, 22, 21, 28, 6, 56, DateTimeKind.Unspecified).AddTicks(6088), null, 57m, 1, 60 },
                    { 16, 5, new DateTime(2021, 1, 5, 10, 1, 19, 691, DateTimeKind.Unspecified).AddTicks(8083), null, 53m, 1, 99 },
                    { 16, 8, new DateTime(2020, 10, 6, 18, 10, 47, 101, DateTimeKind.Unspecified).AddTicks(5119), null, 56m, 1, 161 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 10, new DateTime(2022, 5, 28, 21, 8, 22, 21, DateTimeKind.Unspecified).AddTicks(6715), null, "Colombia", new DateTime(2022, 9, 29, 19, 39, 56, 614, DateTimeKind.Unspecified).AddTicks(5555), 1 },
                    { 11, new DateTime(2020, 9, 7, 15, 39, 47, 829, DateTimeKind.Unspecified).AddTicks(3480), null, "Sao Tome and Principe", new DateTime(2022, 6, 6, 15, 37, 2, 318, DateTimeKind.Unspecified).AddTicks(6273), 1 },
                    { 22, new DateTime(2022, 7, 4, 9, 44, 41, 172, DateTimeKind.Unspecified).AddTicks(8278), null, "Swaziland", new DateTime(2021, 7, 4, 18, 31, 33, 617, DateTimeKind.Unspecified).AddTicks(2011), 1 },
                    { 30, new DateTime(2022, 2, 17, 18, 30, 49, 808, DateTimeKind.Unspecified).AddTicks(4400), null, "Saint Vincent and the Grenadines", new DateTime(2022, 9, 13, 21, 31, 32, 252, DateTimeKind.Unspecified).AddTicks(5834), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "DataStatus" },
                values: new object[,]
                {
                    { 14, 9, new DateTime(2021, 7, 25, 11, 41, 31, 33, DateTimeKind.Unspecified).AddTicks(8112), null, "Practical Plastic Gloves", 1 },
                    { 21, 9, new DateTime(2022, 5, 9, 21, 53, 14, 630, DateTimeKind.Unspecified).AddTicks(3167), null, "Unbranded Soft Gloves", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 10, 5, new DateTime(2022, 2, 17, 8, 54, 13, 404, DateTimeKind.Unspecified).AddTicks(1807), null, 49m, 1, 166 },
                    { 11, 4, new DateTime(2020, 6, 13, 9, 47, 52, 672, DateTimeKind.Unspecified).AddTicks(1754), null, 50m, 1, 65 },
                    { 11, 6, new DateTime(2021, 11, 11, 13, 19, 32, 672, DateTimeKind.Unspecified).AddTicks(7828), null, 49m, 1, 13 },
                    { 11, 10, new DateTime(2021, 11, 2, 15, 30, 40, 604, DateTimeKind.Unspecified).AddTicks(1450), null, 54m, 1, 173 },
                    { 22, 5, new DateTime(2022, 1, 26, 11, 28, 22, 128, DateTimeKind.Unspecified).AddTicks(2774), null, 54m, 1, 186 },
                    { 22, 7, new DateTime(2021, 1, 23, 10, 15, 15, 724, DateTimeKind.Unspecified).AddTicks(3554), null, 49m, 1, 103 },
                    { 22, 8, new DateTime(2020, 7, 18, 4, 46, 23, 778, DateTimeKind.Unspecified).AddTicks(1527), null, 56m, 1, 98 },
                    { 22, 9, new DateTime(2020, 8, 30, 14, 10, 52, 83, DateTimeKind.Unspecified).AddTicks(4635), null, 56m, 1, 3 },
                    { 30, 1, new DateTime(2021, 12, 16, 21, 1, 32, 344, DateTimeKind.Unspecified).AddTicks(1053), null, 55m, 1, 14 },
                    { 30, 2, new DateTime(2022, 4, 26, 0, 16, 42, 615, DateTimeKind.Unspecified).AddTicks(1363), null, 52m, 1, 161 },
                    { 30, 3, new DateTime(2022, 1, 26, 20, 3, 32, 677, DateTimeKind.Unspecified).AddTicks(8305), null, 49m, 1, 130 },
                    { 30, 8, new DateTime(2022, 3, 15, 20, 18, 23, 596, DateTimeKind.Unspecified).AddTicks(8316), null, 53m, 1, 144 },
                    { 30, 9, new DateTime(2021, 1, 26, 4, 19, 2, 45, DateTimeKind.Unspecified).AddTicks(3427), null, 57m, 1, 190 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "DataStatus" },
                values: new object[,]
                {
                    { 14, new DateTime(2022, 4, 26, 9, 29, 2, 510, DateTimeKind.Unspecified).AddTicks(2412), null, "Guinea", new DateTime(2022, 3, 5, 11, 20, 35, 938, DateTimeKind.Unspecified).AddTicks(3230), 1 },
                    { 21, new DateTime(2020, 10, 23, 20, 27, 48, 620, DateTimeKind.Unspecified).AddTicks(9760), null, "Saint Lucia", new DateTime(2021, 3, 18, 8, 5, 46, 113, DateTimeKind.Unspecified).AddTicks(4961), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductId", "SupplierId", "InsertedDate", "LastModifiedDate", "Price", "DataStatus", "Stock" },
                values: new object[,]
                {
                    { 14, 3, new DateTime(2022, 2, 8, 2, 59, 29, 545, DateTimeKind.Unspecified).AddTicks(8037), null, 54m, 1, 18 },
                    { 14, 5, new DateTime(2021, 3, 3, 21, 6, 59, 379, DateTimeKind.Unspecified).AddTicks(9286), null, 52m, 1, 172 },
                    { 21, 3, new DateTime(2020, 4, 18, 14, 49, 2, 972, DateTimeKind.Unspecified).AddTicks(4300), null, 51m, 1, 178 },
                    { 21, 4, new DateTime(2020, 5, 17, 4, 53, 43, 315, DateTimeKind.Unspecified).AddTicks(8198), null, 56m, 1, 121 },
                    { 21, 9, new DateTime(2021, 1, 28, 8, 22, 30, 862, DateTimeKind.Unspecified).AddTicks(2778), null, 57m, 1, 126 }
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
