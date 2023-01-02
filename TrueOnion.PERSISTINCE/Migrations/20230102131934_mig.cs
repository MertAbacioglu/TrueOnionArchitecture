using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
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
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "ConcurrencyStamp", "InsertedDate", "LastModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 2, 16, 19, 33, 615, DateTimeKind.Local).AddTicks(7096), null, "Admin", "ADMIN", 1 },
                    { 2, null, new DateTime(2023, 1, 2, 16, 19, 33, 615, DateTimeKind.Local).AddTicks(7340), null, "Member", "MEMBER", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "LastModifiedDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "dd1d7b22-7c5e-446b-a976-3d12d7cacea4", "Shana.Ferry43@gmail.com", false, new DateTime(2022, 12, 22, 10, 55, 6, 950, DateTimeKind.Unspecified).AddTicks(9221), null, false, null, "SHANA.FERRY43@GMAIL.COM", "KAILEY14", "9mlbBWzLct", "335-721-8641", false, null, 1, false, "Kailey14" },
                    { 2, 0, "cf329f3e-7819-4afb-b682-c1fb928cdfff", "Dewitt_Spinka5@yahoo.com", false, new DateTime(2021, 9, 14, 20, 38, 11, 844, DateTimeKind.Unspecified).AddTicks(1733), null, false, null, "DEWITT_SPINKA5@YAHOO.COM", "THEO98", "QqZoEE1Nes", "686.976.3792", false, null, 1, false, "Theo98" },
                    { 3, 0, "372ea579-aa03-4439-932f-5ac89d135b36", "Sarah50@gmail.com", false, new DateTime(2022, 9, 8, 5, 59, 26, 29, DateTimeKind.Unspecified).AddTicks(4732), null, false, null, "SARAH50@GMAIL.COM", "STANFORD.HOWE75", "gHxx_4vOhG", "282-854-6760", false, null, 1, false, "Stanford.Howe75" },
                    { 4, 0, "76330b5c-f722-4c1b-832e-b9f7d1b45c3f", "Ottilie_Davis71@hotmail.com", false, new DateTime(2021, 2, 10, 15, 41, 42, 426, DateTimeKind.Unspecified).AddTicks(5076), null, false, null, "OTTILIE_DAVIS71@HOTMAIL.COM", "LENNA.KSHLERIN32", "tBCSOXZiIw", "(842) 212-9082 x79900", false, null, 1, false, "Lenna.Kshlerin32" },
                    { 5, 0, "a307bf15-3199-47ab-bc17-afc35b0f1464", "Clair_Nikolaus62@hotmail.com", false, new DateTime(2022, 1, 4, 23, 15, 33, 389, DateTimeKind.Unspecified).AddTicks(7015), null, false, null, "CLAIR_NIKOLAUS62@HOTMAIL.COM", "EMMITT_GERHOLD", "vJInsGMlRr", "(304) 736-5296", false, null, 1, false, "Emmitt_Gerhold" },
                    { 6, 0, "56647723-9008-452e-8b8b-6b688e2f4f60", "Sandy_Luettgen20@yahoo.com", false, new DateTime(2021, 5, 19, 2, 22, 15, 752, DateTimeKind.Unspecified).AddTicks(8830), null, false, null, "SANDY_LUETTGEN20@YAHOO.COM", "YVETTE.RODRIGUEZ", "bUDuNuWtCr", "840-799-7770", false, null, 1, false, "Yvette.Rodriguez" },
                    { 7, 0, "cab903cc-b873-47d3-b7d2-884be2d9e438", "Margarita21@gmail.com", false, new DateTime(2021, 3, 2, 10, 54, 2, 63, DateTimeKind.Unspecified).AddTicks(4479), null, false, null, "MARGARITA21@GMAIL.COM", "ASHLYNN_ROMAGUERA", "VPGmsook3D", "1-963-931-3099 x218", false, null, 1, false, "Ashlynn_Romaguera" },
                    { 8, 0, "102e31d0-bb5b-4144-b225-3a721cbd14db", "Rickey.McGlynn@gmail.com", false, new DateTime(2020, 7, 14, 6, 9, 52, 973, DateTimeKind.Unspecified).AddTicks(8298), null, false, null, "RICKEY.MCGLYNN@GMAIL.COM", "ADRIEL.LEHNER", "hydM66XiIH", "1-983-951-7654 x299", false, null, 1, false, "Adriel.Lehner" },
                    { 9, 0, "110e830e-b1dc-4672-bda6-09e65a53ca0a", "Hazle_Runolfsson41@hotmail.com", false, new DateTime(2022, 12, 24, 21, 23, 14, 698, DateTimeKind.Unspecified).AddTicks(2767), null, false, null, "HAZLE_RUNOLFSSON41@HOTMAIL.COM", "VALENTINA_LEHNER", "2qs8OIy6Qd", "1-350-732-6503 x464", false, null, 1, false, "Valentina_Lehner" },
                    { 10, 0, "ff6f22a4-6338-4481-ab97-d2620b1bc44e", "Irwin.Franecki@gmail.com", false, new DateTime(2021, 5, 13, 10, 42, 14, 91, DateTimeKind.Unspecified).AddTicks(7668), null, false, null, "IRWIN.FRANECKI@GMAIL.COM", "SERENA_STROSIN41", "M4fAGE7nPN", "772.286.7984 x83045", false, null, 1, false, "Serena_Strosin41" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[] { 1, "All", new DateTime(2021, 9, 24, 1, 15, 15, 843, DateTimeKind.Unspecified).AddTicks(2825), null, null, 1 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "CompanyName", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "58918 Micheal Junctions, Port Carloside, France", "Mayert, Volkman and Jast", new DateTime(2021, 10, 5, 21, 39, 20, 723, DateTimeKind.Unspecified).AddTicks(4561), null, 1 },
                    { 2, "05352 Huel Bridge, McKenziehaven, Tuvalu", "Lesch and Sons", new DateTime(2022, 6, 23, 13, 23, 51, 255, DateTimeKind.Unspecified).AddTicks(2440), null, 1 },
                    { 3, "3252 Sonny Grove, Sauermouth, Sierra Leone", "Ward LLC", new DateTime(2021, 4, 8, 23, 49, 14, 378, DateTimeKind.Unspecified).AddTicks(1426), null, 1 },
                    { 4, "49046 Nicholas Cape, Laneshire, Oman", "Keeling Group", new DateTime(2021, 10, 13, 8, 20, 49, 493, DateTimeKind.Unspecified).AddTicks(7565), null, 1 },
                    { 5, "07074 Keeling Rest, Gissellefort, Solomon Islands", "Wiza - Bartoletti", new DateTime(2022, 12, 17, 2, 49, 1, 47, DateTimeKind.Unspecified).AddTicks(3407), null, 1 },
                    { 6, "59662 Lorenza Orchard, Adonisside, Kazakhstan", "Dicki, Wolff and Fadel", new DateTime(2022, 5, 28, 0, 11, 30, 619, DateTimeKind.Unspecified).AddTicks(8577), null, 1 },
                    { 7, "3105 Gregoria Rapids, South Bianka, Jordan", "Mueller and Sons", new DateTime(2022, 7, 22, 17, 16, 0, 883, DateTimeKind.Unspecified).AddTicks(5654), null, 1 },
                    { 8, "39380 Hills Passage, North Elmira, Cocos (Keeling) Islands", "Marvin LLC", new DateTime(2021, 7, 23, 7, 55, 54, 16, DateTimeKind.Unspecified).AddTicks(6026), null, 1 },
                    { 9, "1698 Reagan Field, Goodwinton, Pitcairn Islands", "Weimann - Wuckert", new DateTime(2020, 5, 10, 15, 1, 8, 433, DateTimeKind.Unspecified).AddTicks(9986), null, 1 },
                    { 10, "2108 Ernser Hollow, Finnport, Albania", "Green, Pouros and Lesch", new DateTime(2020, 12, 28, 2, 25, 56, 431, DateTimeKind.Unspecified).AddTicks(9187), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 2, "Home", new DateTime(2020, 10, 14, 21, 10, 8, 486, DateTimeKind.Unspecified).AddTicks(1703), null, 1, 1 },
                    { 7, "Automotive", new DateTime(2021, 10, 10, 8, 9, 46, 98, DateTimeKind.Unspecified).AddTicks(9409), null, 1, 1 },
                    { 9, "Movies", new DateTime(2021, 11, 27, 17, 26, 28, 610, DateTimeKind.Unspecified).AddTicks(751), null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2021, 4, 21, 22, 15, 10, 79, DateTimeKind.Unspecified).AddTicks(4403), null, "Tasty Steel Mouse", 52m, 1, 4 },
                    { 15, 1, new DateTime(2022, 5, 20, 12, 38, 35, 573, DateTimeKind.Unspecified).AddTicks(5312), null, "Incredible Steel Gloves", 52m, 1, 109 },
                    { 18, 1, new DateTime(2020, 12, 3, 14, 10, 39, 713, DateTimeKind.Unspecified).AddTicks(2174), null, "Small Fresh Tuna", 50m, 1, 87 },
                    { 19, 1, new DateTime(2020, 6, 18, 16, 33, 35, 248, DateTimeKind.Unspecified).AddTicks(7372), null, "Rustic Plastic Sausages", 54m, 1, 190 },
                    { 21, 1, new DateTime(2021, 6, 27, 3, 4, 24, 374, DateTimeKind.Unspecified).AddTicks(9275), null, "Refined Metal Hat", 51m, 1, 15 },
                    { 29, 1, new DateTime(2021, 3, 22, 1, 34, 19, 541, DateTimeKind.Unspecified).AddTicks(901), null, "Licensed Soft Computer", 57m, 1, 171 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 3, "Electronics", new DateTime(2022, 3, 31, 18, 11, 41, 847, DateTimeKind.Unspecified).AddTicks(9764), null, 2, 1 },
                    { 6, "Baby", new DateTime(2021, 5, 14, 21, 12, 32, 689, DateTimeKind.Unspecified).AddTicks(3795), null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 8, 27, 23, 10, 49, 365, DateTimeKind.Unspecified).AddTicks(4647), null, "Brunei Darussalam", new DateTime(2021, 8, 20, 15, 1, 44, 49, DateTimeKind.Unspecified).AddTicks(9383), 1 },
                    { 15, new DateTime(2021, 7, 27, 1, 31, 36, 984, DateTimeKind.Unspecified).AddTicks(3177), null, "Namibia", new DateTime(2021, 2, 9, 22, 16, 55, 859, DateTimeKind.Unspecified).AddTicks(2855), 1 },
                    { 18, new DateTime(2022, 11, 11, 14, 26, 18, 203, DateTimeKind.Unspecified).AddTicks(8081), null, "United States of America", new DateTime(2022, 10, 18, 6, 58, 25, 123, DateTimeKind.Unspecified).AddTicks(1092), 1 },
                    { 19, new DateTime(2020, 6, 27, 23, 49, 11, 662, DateTimeKind.Unspecified).AddTicks(5507), null, "Indonesia", new DateTime(2021, 7, 31, 11, 54, 37, 351, DateTimeKind.Unspecified).AddTicks(2210), 1 },
                    { 21, new DateTime(2022, 8, 23, 22, 24, 12, 594, DateTimeKind.Unspecified).AddTicks(4566), null, "Lao People's Democratic Republic", new DateTime(2020, 8, 3, 20, 48, 8, 340, DateTimeKind.Unspecified).AddTicks(5126), 1 },
                    { 29, new DateTime(2022, 6, 10, 9, 16, 43, 33, DateTimeKind.Unspecified).AddTicks(9932), null, "Uruguay", new DateTime(2022, 11, 15, 0, 19, 29, 397, DateTimeKind.Unspecified).AddTicks(634), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 5, 2, new DateTime(2021, 5, 5, 18, 53, 55, 275, DateTimeKind.Unspecified).AddTicks(2004), null, "Unbranded Concrete Computer", 52m, 1, 165 },
                    { 7, 2, new DateTime(2021, 9, 8, 4, 36, 13, 638, DateTimeKind.Unspecified).AddTicks(3840), null, "Small Granite Towels", 54m, 1, 92 },
                    { 11, 2, new DateTime(2021, 7, 30, 11, 1, 46, 235, DateTimeKind.Unspecified).AddTicks(7416), null, "Small Wooden Salad", 56m, 1, 136 },
                    { 12, 2, new DateTime(2020, 10, 13, 7, 23, 2, 80, DateTimeKind.Unspecified).AddTicks(7806), null, "Tasty Wooden Sausages", 52m, 1, 63 },
                    { 13, 2, new DateTime(2022, 12, 16, 0, 6, 10, 127, DateTimeKind.Unspecified).AddTicks(7452), null, "Generic Soft Bike", 55m, 1, 63 },
                    { 22, 7, new DateTime(2020, 5, 13, 9, 39, 51, 147, DateTimeKind.Unspecified).AddTicks(4539), null, "Refined Plastic Mouse", 53m, 1, 62 },
                    { 23, 7, new DateTime(2021, 2, 25, 7, 54, 18, 162, DateTimeKind.Unspecified).AddTicks(4471), null, "Unbranded Fresh Hat", 56m, 1, 44 },
                    { 28, 7, new DateTime(2020, 7, 11, 20, 3, 43, 204, DateTimeKind.Unspecified).AddTicks(2645), null, "Practical Frozen Bike", 53m, 1, 162 },
                    { 30, 2, new DateTime(2020, 7, 20, 20, 12, 23, 439, DateTimeKind.Unspecified).AddTicks(8781), null, "Generic Frozen Tuna", 50m, 1, 47 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 2, 8, new DateTime(2021, 8, 6, 15, 48, 0, 28, DateTimeKind.Unspecified).AddTicks(692), null, 185, 1 },
                    { 2, 10, new DateTime(2022, 2, 13, 19, 16, 57, 93, DateTimeKind.Unspecified).AddTicks(7645), null, 179, 1 },
                    { 15, 2, new DateTime(2022, 8, 11, 16, 23, 1, 735, DateTimeKind.Unspecified).AddTicks(1411), null, 54, 1 },
                    { 15, 6, new DateTime(2022, 1, 13, 8, 7, 2, 22, DateTimeKind.Unspecified).AddTicks(8613), null, 18, 1 },
                    { 15, 8, new DateTime(2022, 6, 23, 23, 17, 40, 613, DateTimeKind.Unspecified).AddTicks(4930), null, 157, 1 },
                    { 15, 10, new DateTime(2020, 5, 25, 0, 38, 8, 923, DateTimeKind.Unspecified).AddTicks(2967), null, 194, 1 },
                    { 18, 1, new DateTime(2020, 10, 14, 3, 32, 54, 504, DateTimeKind.Unspecified).AddTicks(8960), null, 18, 1 },
                    { 18, 8, new DateTime(2022, 4, 21, 22, 49, 33, 48, DateTimeKind.Unspecified).AddTicks(6034), null, 63, 1 },
                    { 19, 4, new DateTime(2021, 3, 6, 17, 45, 15, 624, DateTimeKind.Unspecified).AddTicks(4233), null, 72, 1 },
                    { 19, 8, new DateTime(2022, 11, 3, 3, 25, 1, 712, DateTimeKind.Unspecified).AddTicks(5536), null, 7, 1 },
                    { 19, 10, new DateTime(2023, 1, 1, 17, 15, 31, 576, DateTimeKind.Unspecified).AddTicks(9556), null, 31, 1 },
                    { 21, 8, new DateTime(2021, 8, 29, 7, 22, 27, 325, DateTimeKind.Unspecified).AddTicks(4376), null, 181, 1 },
                    { 29, 1, new DateTime(2021, 12, 23, 21, 0, 10, 762, DateTimeKind.Unspecified).AddTicks(6555), null, 79, 1 },
                    { 29, 10, new DateTime(2022, 10, 27, 11, 39, 11, 55, DateTimeKind.Unspecified).AddTicks(8954), null, 65, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[,]
                {
                    { 4, "Clothing", new DateTime(2021, 3, 11, 8, 58, 50, 856, DateTimeKind.Unspecified).AddTicks(5120), null, 3, 1 },
                    { 8, "Clothing", new DateTime(2021, 12, 23, 23, 24, 38, 863, DateTimeKind.Unspecified).AddTicks(5719), null, 3, 1 },
                    { 10, "Jewelery", new DateTime(2021, 3, 16, 21, 6, 48, 263, DateTimeKind.Unspecified).AddTicks(4687), null, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 5, new DateTime(2022, 7, 6, 1, 43, 37, 365, DateTimeKind.Unspecified).AddTicks(6333), null, "Bermuda", new DateTime(2022, 5, 28, 18, 14, 22, 952, DateTimeKind.Unspecified).AddTicks(4725), 1 },
                    { 7, new DateTime(2020, 6, 27, 3, 24, 9, 656, DateTimeKind.Unspecified).AddTicks(4162), null, "Cote d'Ivoire", new DateTime(2021, 3, 15, 12, 49, 28, 952, DateTimeKind.Unspecified).AddTicks(1138), 1 },
                    { 11, new DateTime(2022, 1, 1, 9, 1, 41, 81, DateTimeKind.Unspecified).AddTicks(2113), null, "Comoros", new DateTime(2022, 6, 10, 2, 43, 26, 798, DateTimeKind.Unspecified).AddTicks(9967), 1 },
                    { 12, new DateTime(2022, 9, 16, 10, 21, 18, 725, DateTimeKind.Unspecified).AddTicks(8648), null, "Holy See (Vatican City State)", new DateTime(2022, 2, 3, 21, 2, 44, 763, DateTimeKind.Unspecified).AddTicks(3986), 1 },
                    { 13, new DateTime(2022, 9, 13, 22, 12, 42, 845, DateTimeKind.Unspecified).AddTicks(3643), null, "French Polynesia", new DateTime(2020, 5, 9, 10, 35, 27, 842, DateTimeKind.Unspecified).AddTicks(1919), 1 },
                    { 22, new DateTime(2022, 12, 20, 23, 23, 23, 977, DateTimeKind.Unspecified).AddTicks(5284), null, "Papua New Guinea", new DateTime(2021, 2, 7, 9, 14, 39, 115, DateTimeKind.Unspecified).AddTicks(8533), 1 },
                    { 23, new DateTime(2020, 3, 30, 23, 15, 10, 145, DateTimeKind.Unspecified).AddTicks(9696), null, "Ethiopia", new DateTime(2021, 6, 30, 1, 26, 42, 593, DateTimeKind.Unspecified).AddTicks(6045), 1 },
                    { 28, new DateTime(2022, 4, 20, 19, 4, 27, 939, DateTimeKind.Unspecified).AddTicks(3004), null, "Haiti", new DateTime(2020, 12, 11, 10, 28, 35, 407, DateTimeKind.Unspecified).AddTicks(6090), 1 },
                    { 30, new DateTime(2021, 4, 7, 15, 3, 55, 369, DateTimeKind.Unspecified).AddTicks(4180), null, "Japan", new DateTime(2023, 1, 1, 16, 16, 40, 522, DateTimeKind.Unspecified).AddTicks(5593), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 6, 6, new DateTime(2021, 4, 9, 19, 59, 50, 972, DateTimeKind.Unspecified).AddTicks(3158), null, "Licensed Granite Salad", 52m, 1, 175 },
                    { 9, 6, new DateTime(2020, 6, 29, 18, 6, 55, 345, DateTimeKind.Unspecified).AddTicks(7842), null, "Awesome Metal Table", 56m, 1, 144 },
                    { 10, 3, new DateTime(2021, 2, 23, 20, 38, 4, 46, DateTimeKind.Unspecified).AddTicks(692), null, "Awesome Plastic Salad", 50m, 1, 165 },
                    { 16, 6, new DateTime(2020, 10, 18, 16, 51, 36, 897, DateTimeKind.Unspecified).AddTicks(1466), null, "Tasty Plastic Sausages", 52m, 1, 148 },
                    { 17, 6, new DateTime(2021, 10, 26, 10, 10, 46, 441, DateTimeKind.Unspecified).AddTicks(9793), null, "Handmade Rubber Mouse", 57m, 1, 143 },
                    { 20, 3, new DateTime(2021, 7, 7, 15, 44, 38, 403, DateTimeKind.Unspecified).AddTicks(6760), null, "Generic Fresh Chair", 50m, 1, 43 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 5, 7, new DateTime(2021, 5, 13, 0, 51, 45, 167, DateTimeKind.Unspecified).AddTicks(5046), null, 111, 1 },
                    { 5, 8, new DateTime(2020, 3, 14, 6, 38, 4, 42, DateTimeKind.Unspecified).AddTicks(7739), null, 112, 1 },
                    { 5, 10, new DateTime(2022, 2, 7, 11, 48, 2, 756, DateTimeKind.Unspecified).AddTicks(1421), null, 197, 1 },
                    { 7, 5, new DateTime(2022, 5, 24, 6, 3, 17, 208, DateTimeKind.Unspecified).AddTicks(7950), null, 124, 1 },
                    { 7, 6, new DateTime(2023, 1, 1, 23, 41, 38, 70, DateTimeKind.Unspecified).AddTicks(7009), null, 24, 1 },
                    { 7, 7, new DateTime(2021, 8, 2, 21, 26, 50, 286, DateTimeKind.Unspecified).AddTicks(2178), null, 50, 1 },
                    { 7, 8, new DateTime(2021, 10, 10, 9, 18, 56, 847, DateTimeKind.Unspecified).AddTicks(738), null, 138, 1 },
                    { 11, 2, new DateTime(2022, 3, 2, 7, 45, 42, 98, DateTimeKind.Unspecified).AddTicks(132), null, 164, 1 },
                    { 11, 5, new DateTime(2021, 12, 13, 7, 24, 29, 242, DateTimeKind.Unspecified).AddTicks(3368), null, 196, 1 },
                    { 11, 6, new DateTime(2021, 11, 14, 22, 27, 40, 650, DateTimeKind.Unspecified).AddTicks(973), null, 94, 1 },
                    { 12, 5, new DateTime(2022, 10, 2, 21, 2, 1, 307, DateTimeKind.Unspecified).AddTicks(11), null, 111, 1 },
                    { 13, 5, new DateTime(2020, 4, 5, 20, 39, 17, 496, DateTimeKind.Unspecified).AddTicks(9867), null, 10, 1 },
                    { 13, 9, new DateTime(2020, 9, 7, 15, 30, 11, 208, DateTimeKind.Unspecified).AddTicks(3581), null, 171, 1 },
                    { 22, 2, new DateTime(2020, 11, 29, 8, 15, 12, 602, DateTimeKind.Unspecified).AddTicks(5696), null, 141, 1 },
                    { 22, 3, new DateTime(2020, 5, 18, 18, 42, 46, 151, DateTimeKind.Unspecified).AddTicks(4895), null, 151, 1 },
                    { 22, 8, new DateTime(2022, 10, 30, 23, 54, 16, 462, DateTimeKind.Unspecified).AddTicks(3757), null, 144, 1 },
                    { 22, 9, new DateTime(2021, 3, 21, 15, 28, 52, 892, DateTimeKind.Unspecified).AddTicks(57), null, 187, 1 },
                    { 23, 4, new DateTime(2022, 11, 12, 11, 52, 21, 892, DateTimeKind.Unspecified).AddTicks(7099), null, 24, 1 },
                    { 23, 5, new DateTime(2022, 10, 3, 10, 7, 2, 394, DateTimeKind.Unspecified).AddTicks(2712), null, 28, 1 },
                    { 23, 9, new DateTime(2022, 1, 30, 4, 24, 30, 810, DateTimeKind.Unspecified).AddTicks(8056), null, 25, 1 },
                    { 28, 2, new DateTime(2021, 3, 5, 0, 10, 28, 322, DateTimeKind.Unspecified).AddTicks(476), null, 39, 1 },
                    { 28, 3, new DateTime(2022, 2, 12, 1, 55, 10, 72, DateTimeKind.Unspecified).AddTicks(1990), null, 182, 1 },
                    { 28, 4, new DateTime(2020, 9, 11, 7, 36, 42, 129, DateTimeKind.Unspecified).AddTicks(5903), null, 170, 1 },
                    { 28, 5, new DateTime(2021, 9, 20, 20, 46, 0, 60, DateTimeKind.Unspecified).AddTicks(4099), null, 75, 1 },
                    { 28, 8, new DateTime(2020, 6, 13, 4, 35, 18, 402, DateTimeKind.Unspecified).AddTicks(1139), null, 81, 1 },
                    { 28, 9, new DateTime(2021, 6, 7, 0, 40, 37, 246, DateTimeKind.Unspecified).AddTicks(5157), null, 5, 1 },
                    { 30, 2, new DateTime(2021, 10, 13, 4, 10, 4, 973, DateTimeKind.Unspecified).AddTicks(2908), null, 91, 1 },
                    { 30, 7, new DateTime(2022, 10, 5, 13, 55, 1, 860, DateTimeKind.Unspecified).AddTicks(6505), null, 85, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "InsertedDate", "LastModifiedDate", "ParentID", "Status" },
                values: new object[] { 5, "Books", new DateTime(2020, 7, 22, 17, 30, 50, 743, DateTimeKind.Unspecified).AddTicks(1958), null, 4, 1 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 7, 20, 2, 19, 21, 927, DateTimeKind.Unspecified).AddTicks(6517), null, "Macao", new DateTime(2021, 7, 7, 13, 9, 10, 454, DateTimeKind.Unspecified).AddTicks(7673), 1 },
                    { 9, new DateTime(2020, 3, 23, 1, 6, 22, 523, DateTimeKind.Unspecified).AddTicks(1899), null, "Panama", new DateTime(2021, 7, 18, 17, 12, 36, 146, DateTimeKind.Unspecified).AddTicks(5982), 1 },
                    { 10, new DateTime(2020, 11, 30, 9, 31, 48, 503, DateTimeKind.Unspecified).AddTicks(6458), null, "South Georgia and the South Sandwich Islands", new DateTime(2022, 11, 25, 18, 3, 57, 642, DateTimeKind.Unspecified).AddTicks(9254), 1 },
                    { 16, new DateTime(2021, 6, 29, 7, 58, 15, 750, DateTimeKind.Unspecified).AddTicks(3978), null, "Albania", new DateTime(2022, 4, 1, 0, 20, 38, 682, DateTimeKind.Unspecified).AddTicks(2132), 1 },
                    { 17, new DateTime(2022, 1, 24, 16, 56, 38, 371, DateTimeKind.Unspecified).AddTicks(505), null, "Guernsey", new DateTime(2021, 1, 13, 6, 5, 49, 141, DateTimeKind.Unspecified).AddTicks(3147), 1 },
                    { 20, new DateTime(2020, 3, 30, 12, 46, 13, 341, DateTimeKind.Unspecified).AddTicks(8502), null, "Pakistan", new DateTime(2021, 11, 19, 4, 16, 25, 849, DateTimeKind.Unspecified).AddTicks(3471), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2021, 6, 1, 22, 43, 56, 674, DateTimeKind.Unspecified).AddTicks(44), null, "Handmade Soft Sausages", 54m, 1, 88 },
                    { 4, 4, new DateTime(2022, 4, 25, 3, 43, 45, 289, DateTimeKind.Unspecified).AddTicks(5709), null, "Handmade Soft Tuna", 51m, 1, 184 },
                    { 8, 4, new DateTime(2020, 12, 14, 22, 55, 36, 148, DateTimeKind.Unspecified).AddTicks(8825), null, "Intelligent Metal Table", 54m, 1, 151 },
                    { 24, 4, new DateTime(2021, 4, 21, 7, 12, 13, 76, DateTimeKind.Unspecified).AddTicks(1437), null, "Tasty Soft Gloves", 54m, 1, 48 },
                    { 25, 4, new DateTime(2020, 12, 6, 3, 39, 4, 547, DateTimeKind.Unspecified).AddTicks(8750), null, "Practical Frozen Tuna", 50m, 1, 39 },
                    { 27, 8, new DateTime(2020, 3, 19, 23, 50, 47, 881, DateTimeKind.Unspecified).AddTicks(9660), null, "Generic Soft Pants", 52m, 1, 164 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 6, 3, new DateTime(2021, 2, 9, 19, 52, 51, 560, DateTimeKind.Unspecified).AddTicks(6353), null, 6, 1 },
                    { 9, 1, new DateTime(2020, 5, 20, 21, 42, 51, 65, DateTimeKind.Unspecified).AddTicks(9412), null, 60, 1 },
                    { 9, 10, new DateTime(2021, 4, 29, 3, 27, 38, 851, DateTimeKind.Unspecified).AddTicks(7356), null, 32, 1 },
                    { 10, 2, new DateTime(2022, 8, 23, 0, 33, 57, 72, DateTimeKind.Unspecified).AddTicks(446), null, 83, 1 },
                    { 10, 6, new DateTime(2021, 11, 29, 16, 30, 16, 582, DateTimeKind.Unspecified).AddTicks(252), null, 141, 1 },
                    { 10, 9, new DateTime(2021, 9, 5, 22, 45, 51, 199, DateTimeKind.Unspecified).AddTicks(7865), null, 115, 1 },
                    { 16, 5, new DateTime(2020, 8, 19, 1, 36, 58, 278, DateTimeKind.Unspecified).AddTicks(1062), null, 148, 1 },
                    { 16, 10, new DateTime(2022, 8, 18, 9, 28, 20, 739, DateTimeKind.Unspecified).AddTicks(5848), null, 13, 1 },
                    { 17, 1, new DateTime(2022, 6, 9, 10, 6, 19, 201, DateTimeKind.Unspecified).AddTicks(1757), null, 49, 1 },
                    { 17, 9, new DateTime(2022, 6, 23, 8, 44, 32, 94, DateTimeKind.Unspecified).AddTicks(717), null, 34, 1 },
                    { 20, 2, new DateTime(2022, 10, 1, 17, 57, 31, 66, DateTimeKind.Unspecified).AddTicks(3259), null, 42, 1 },
                    { 20, 6, new DateTime(2021, 2, 24, 1, 44, 8, 54, DateTimeKind.Unspecified).AddTicks(4128), null, 172, 1 },
                    { 20, 7, new DateTime(2022, 5, 27, 15, 29, 33, 630, DateTimeKind.Unspecified).AddTicks(8934), null, 98, 1 },
                    { 20, 8, new DateTime(2022, 11, 26, 16, 13, 54, 501, DateTimeKind.Unspecified).AddTicks(3264), null, 155, 1 },
                    { 20, 10, new DateTime(2022, 3, 17, 18, 38, 40, 722, DateTimeKind.Unspecified).AddTicks(1743), null, 76, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 21, 6, 54, 7, 616, DateTimeKind.Unspecified).AddTicks(7205), null, "Bolivia", new DateTime(2022, 11, 11, 4, 55, 39, 467, DateTimeKind.Unspecified).AddTicks(3340), 1 },
                    { 4, new DateTime(2021, 2, 8, 3, 28, 57, 467, DateTimeKind.Unspecified).AddTicks(7147), null, "Palestinian Territory", new DateTime(2021, 11, 14, 2, 32, 14, 330, DateTimeKind.Unspecified).AddTicks(9351), 1 },
                    { 8, new DateTime(2022, 10, 30, 22, 11, 9, 143, DateTimeKind.Unspecified).AddTicks(1729), null, "Uganda", new DateTime(2021, 9, 24, 14, 2, 21, 35, DateTimeKind.Unspecified).AddTicks(1372), 1 },
                    { 24, new DateTime(2021, 3, 15, 10, 49, 52, 255, DateTimeKind.Unspecified).AddTicks(3151), null, "Nepal", new DateTime(2022, 5, 10, 4, 54, 57, 54, DateTimeKind.Unspecified).AddTicks(1101), 1 },
                    { 25, new DateTime(2020, 9, 18, 3, 18, 49, 492, DateTimeKind.Unspecified).AddTicks(7712), null, "Romania", new DateTime(2021, 11, 21, 11, 32, 41, 262, DateTimeKind.Unspecified).AddTicks(7394), 1 },
                    { 27, new DateTime(2021, 5, 30, 3, 29, 3, 551, DateTimeKind.Unspecified).AddTicks(4986), null, "Hungary", new DateTime(2021, 10, 18, 23, 7, 4, 741, DateTimeKind.Unspecified).AddTicks(5680), 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "InsertedDate", "LastModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 3, 5, new DateTime(2021, 3, 23, 18, 12, 56, 61, DateTimeKind.Unspecified).AddTicks(9657), null, "Tasty Concrete Chips", 52m, 1, 76 },
                    { 14, 5, new DateTime(2021, 11, 6, 12, 21, 41, 474, DateTimeKind.Unspecified).AddTicks(5943), null, "Tasty Soft Chicken", 49m, 1, 65 },
                    { 26, 5, new DateTime(2020, 8, 25, 16, 23, 42, 935, DateTimeKind.Unspecified).AddTicks(654), null, "Fantastic Rubber Car", 53m, 1, 172 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 12, 18, 15, 26, 14, 221, DateTimeKind.Unspecified).AddTicks(5135), null, 188, 1 },
                    { 1, 4, new DateTime(2020, 12, 16, 11, 11, 0, 69, DateTimeKind.Unspecified).AddTicks(9744), null, 15, 1 },
                    { 4, 5, new DateTime(2020, 11, 9, 16, 32, 40, 277, DateTimeKind.Unspecified).AddTicks(1718), null, 47, 1 },
                    { 8, 1, new DateTime(2022, 5, 27, 5, 2, 52, 155, DateTimeKind.Unspecified).AddTicks(6589), null, 103, 1 },
                    { 8, 4, new DateTime(2020, 10, 3, 14, 21, 3, 592, DateTimeKind.Unspecified).AddTicks(4255), null, 115, 1 },
                    { 8, 5, new DateTime(2021, 7, 28, 0, 15, 12, 692, DateTimeKind.Unspecified).AddTicks(5560), null, 59, 1 },
                    { 8, 10, new DateTime(2022, 9, 5, 8, 16, 23, 128, DateTimeKind.Unspecified).AddTicks(1539), null, 96, 1 },
                    { 24, 2, new DateTime(2020, 6, 26, 21, 34, 46, 932, DateTimeKind.Unspecified).AddTicks(192), null, 98, 1 },
                    { 24, 4, new DateTime(2020, 11, 19, 21, 14, 18, 520, DateTimeKind.Unspecified).AddTicks(823), null, 77, 1 },
                    { 24, 9, new DateTime(2020, 6, 18, 22, 15, 2, 953, DateTimeKind.Unspecified).AddTicks(4382), null, 75, 1 },
                    { 25, 1, new DateTime(2021, 8, 22, 7, 50, 49, 419, DateTimeKind.Unspecified).AddTicks(1894), null, 16, 1 },
                    { 25, 5, new DateTime(2021, 6, 23, 10, 22, 4, 29, DateTimeKind.Unspecified).AddTicks(7664), null, 176, 1 },
                    { 25, 6, new DateTime(2021, 8, 5, 0, 1, 49, 818, DateTimeKind.Unspecified).AddTicks(2616), null, 21, 1 },
                    { 25, 7, new DateTime(2022, 12, 10, 22, 6, 16, 361, DateTimeKind.Unspecified).AddTicks(2285), null, 139, 1 },
                    { 25, 8, new DateTime(2021, 12, 11, 4, 23, 16, 310, DateTimeKind.Unspecified).AddTicks(7576), null, 96, 1 },
                    { 25, 10, new DateTime(2021, 5, 13, 12, 12, 52, 581, DateTimeKind.Unspecified).AddTicks(6771), null, 22, 1 },
                    { 27, 3, new DateTime(2022, 4, 13, 13, 30, 41, 698, DateTimeKind.Unspecified).AddTicks(1978), null, 200, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "InsertedDate", "LastModifiedDate", "MadeIn", "RelaseDate", "Status" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 8, 15, 12, 24, 50, 938, DateTimeKind.Unspecified).AddTicks(611), null, "Burundi", new DateTime(2022, 9, 28, 14, 12, 33, 717, DateTimeKind.Unspecified).AddTicks(7002), 1 },
                    { 14, new DateTime(2021, 10, 22, 16, 29, 48, 923, DateTimeKind.Unspecified).AddTicks(2259), null, "Hong Kong", new DateTime(2022, 3, 12, 9, 13, 6, 875, DateTimeKind.Unspecified).AddTicks(7235), 1 },
                    { 26, new DateTime(2022, 2, 19, 21, 38, 19, 543, DateTimeKind.Unspecified).AddTicks(4404), null, "Namibia", new DateTime(2020, 8, 20, 11, 31, 59, 47, DateTimeKind.Unspecified).AddTicks(6438), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2021, 6, 28, 13, 43, 52, 666, DateTimeKind.Unspecified).AddTicks(7135), null, 130, 1 },
                    { 3, 5, new DateTime(2022, 12, 5, 17, 38, 2, 503, DateTimeKind.Unspecified).AddTicks(826), null, 40, 1 },
                    { 3, 6, new DateTime(2022, 2, 10, 16, 36, 24, 763, DateTimeKind.Unspecified).AddTicks(5536), null, 106, 1 },
                    { 3, 7, new DateTime(2022, 11, 26, 16, 37, 40, 267, DateTimeKind.Unspecified).AddTicks(9747), null, 49, 1 },
                    { 3, 9, new DateTime(2020, 12, 31, 5, 50, 25, 946, DateTimeKind.Unspecified).AddTicks(803), null, 128, 1 },
                    { 3, 10, new DateTime(2020, 4, 20, 15, 16, 24, 80, DateTimeKind.Unspecified).AddTicks(7024), null, 24, 1 },
                    { 14, 1, new DateTime(2020, 12, 14, 19, 25, 32, 830, DateTimeKind.Unspecified).AddTicks(4902), null, 134, 1 },
                    { 14, 5, new DateTime(2022, 9, 26, 17, 49, 14, 923, DateTimeKind.Unspecified).AddTicks(385), null, 144, 1 },
                    { 14, 10, new DateTime(2020, 11, 1, 7, 14, 33, 614, DateTimeKind.Unspecified).AddTicks(5222), null, 157, 1 },
                    { 26, 2, new DateTime(2020, 9, 19, 10, 5, 25, 106, DateTimeKind.Unspecified).AddTicks(2393), null, 91, 1 },
                    { 26, 4, new DateTime(2020, 6, 4, 22, 38, 51, 511, DateTimeKind.Unspecified).AddTicks(2645), null, 57, 1 }
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
