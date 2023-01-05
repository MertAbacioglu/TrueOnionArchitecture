using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myMig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUserRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 34, 37, 361, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 34, 37, 361, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 34, 37, 361, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "InsertedDate",
                value: new DateTime(2020, 6, 3, 18, 47, 51, 72, DateTimeKind.Unspecified).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 },
                column: "InsertedDate",
                value: new DateTime(2020, 11, 11, 21, 12, 24, 77, DateTimeKind.Unspecified).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7 },
                column: "InsertedDate",
                value: new DateTime(2022, 1, 24, 10, 15, 41, 785, DateTimeKind.Unspecified).AddTicks(4032));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2021, 6, 4, 20, 43, 56, 231, DateTimeKind.Unspecified).AddTicks(3392), null, 1 },
                    { 1, 3, new DateTime(2022, 9, 12, 5, 48, 7, 768, DateTimeKind.Unspecified).AddTicks(7001), null, 1 },
                    { 3, 5, new DateTime(2022, 1, 24, 3, 40, 55, 753, DateTimeKind.Unspecified).AddTicks(3946), null, 1 },
                    { 3, 6, new DateTime(2020, 6, 8, 22, 0, 43, 411, DateTimeKind.Unspecified).AddTicks(2922), null, 1 },
                    { 2, 8, new DateTime(2022, 4, 17, 10, 46, 18, 692, DateTimeKind.Unspecified).AddTicks(8254), null, 1 },
                    { 3, 8, new DateTime(2020, 8, 2, 20, 52, 37, 936, DateTimeKind.Unspecified).AddTicks(8427), null, 1 },
                    { 3, 10, new DateTime(2022, 9, 5, 11, 12, 34, 467, DateTimeKind.Unspecified).AddTicks(3105), null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "102f4140-db62-4261-98e7-40d410d3b427", "Grover_Gislason@gmail.com", new DateTime(2020, 9, 19, 12, 3, 40, 265, DateTimeKind.Unspecified).AddTicks(2424), "GROVER_GISLASON@GMAIL.COM", "BUD_RUTHERFORD88", "cqPkiPtj1i", "677-969-0233 x802", "PBoGhcvJV1", "Bud_Rutherford88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a9f948a9-a551-4011-b592-5b37b9b8ea43", "Bill_Rempel@yahoo.com", new DateTime(2021, 2, 24, 16, 36, 56, 14, DateTimeKind.Unspecified).AddTicks(829), "BILL_REMPEL@YAHOO.COM", "ANIBAL_MERTZ", "WIyS_DnrBv", "389-659-0271 x6367", "EIswkuYApL", "Anibal_Mertz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63e49a49-f9f6-47c6-a0fb-6e08c02da7cf", "Annamae.Spinka81@gmail.com", new DateTime(2022, 6, 17, 14, 20, 24, 613, DateTimeKind.Unspecified).AddTicks(2087), "ANNAMAE.SPINKA81@GMAIL.COM", "HERSHEL_GUTKOWSKI", "F95sDNMQk6", "(240) 898-1599", "DKghawfFmi", "Hershel_Gutkowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "15cb2bff-a398-44a8-b531-26b08f1db654", "Melyna38@yahoo.com", new DateTime(2020, 8, 31, 22, 31, 43, 222, DateTimeKind.Unspecified).AddTicks(1784), "MELYNA38@YAHOO.COM", "HILARIO_MURAZIK", "FH6YgGlO8Q", "872.338.1549 x7970", "NY3G_tZiie", "Hilario_Murazik" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6b3e89b8-d173-4723-a8d6-6dbfb183d00a", "Edmund_Trantow84@gmail.com", new DateTime(2022, 7, 12, 17, 19, 2, 544, DateTimeKind.Unspecified).AddTicks(9996), "EDMUND_TRANTOW84@GMAIL.COM", "DEDRICK27", "3FrmMHkNGU", "827-916-1434", "HT6QeZEsMt", "Dedrick27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e34c943a-e260-40fa-92b3-203f450945fa", "Edna_Rempel25@hotmail.com", new DateTime(2022, 4, 9, 21, 58, 4, 827, DateTimeKind.Unspecified).AddTicks(3486), "EDNA_REMPEL25@HOTMAIL.COM", "NOEMIE.DAVIS27", "Y6vjx4ssJd", "624-238-1110 x4555", "tOlWCVi6K_", "Noemie.Davis27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97767538-1e66-4e78-99a6-30a6b0e3401e", "Lori99@hotmail.com", new DateTime(2020, 7, 10, 17, 12, 45, 789, DateTimeKind.Unspecified).AddTicks(2497), "LORI99@HOTMAIL.COM", "LIZA.SAUER", "kx8xweZ3PC", "(765) 207-7119 x7585", "BrElPhyR9R", "Liza.Sauer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "53bc203a-4aa9-4f53-8c97-4068ad86d7ca", "Lowell.Grimes@yahoo.com", new DateTime(2021, 10, 13, 1, 7, 39, 833, DateTimeKind.Unspecified).AddTicks(9132), "LOWELL.GRIMES@YAHOO.COM", "BAILEE.FADEL", "nJtUy6Trs4", "1-477-349-3821", "4XABSLFaSf", "Bailee.Fadel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4d6e7fb4-11b4-4356-89c4-205caf7efc12", "Freddy.Kris@yahoo.com", new DateTime(2021, 4, 13, 8, 5, 27, 787, DateTimeKind.Unspecified).AddTicks(2954), "FREDDY.KRIS@YAHOO.COM", "NANNIE77", "VGOxsyNdCI", "(354) 920-2114 x597", "s8xkDUI3Vq", "Nannie77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1a2ff622-4ae3-4a28-a579-5643a31f0374", "Dovie_Corwin@yahoo.com", new DateTime(2020, 4, 7, 2, 18, 49, 277, DateTimeKind.Unspecified).AddTicks(7940), "DOVIE_CORWIN@YAHOO.COM", "IGNATIUS.ERNSER", "YhnDzaRfQ8", "684-220-8781 x16859", "v39rLPXhK6", "Ignatius.Ernser" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertedDate",
                value: new DateTime(2020, 5, 14, 22, 5, 19, 298, DateTimeKind.Unspecified).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Health", new DateTime(2022, 7, 26, 11, 20, 25, 461, DateTimeKind.Unspecified).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Beauty", new DateTime(2022, 5, 23, 21, 36, 10, 749, DateTimeKind.Unspecified).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Shoes", new DateTime(2021, 6, 8, 2, 32, 8, 591, DateTimeKind.Unspecified).AddTicks(4824), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Movies", new DateTime(2021, 9, 11, 10, 0, 46, 336, DateTimeKind.Unspecified).AddTicks(2944), 3 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Grocery", new DateTime(2020, 6, 14, 3, 23, 32, 661, DateTimeKind.Unspecified).AddTicks(7519), 4 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Toys", new DateTime(2021, 4, 12, 4, 46, 54, 619, DateTimeKind.Unspecified).AddTicks(9143), 3 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Outdoors", new DateTime(2021, 10, 4, 21, 46, 24, 689, DateTimeKind.Unspecified).AddTicks(2683), 6 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertedDate", "ParentID" },
                values: new object[] { new DateTime(2021, 9, 12, 19, 28, 22, 936, DateTimeKind.Unspecified).AddTicks(4525), 6 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Baby", new DateTime(2022, 3, 10, 10, 7, 59, 97, DateTimeKind.Unspecified).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 7, 17, 23, 52, 38, 316, DateTimeKind.Unspecified).AddTicks(4874), "Vietnam", new DateTime(2020, 4, 28, 0, 8, 51, 353, DateTimeKind.Unspecified).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 12, 6, 14, 16, 27, 390, DateTimeKind.Unspecified).AddTicks(8269), "Iraq", new DateTime(2020, 8, 23, 12, 54, 0, 130, DateTimeKind.Unspecified).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 18, 3, 17, 16, 825, DateTimeKind.Unspecified).AddTicks(801), "Bulgaria", new DateTime(2020, 4, 26, 10, 5, 18, 562, DateTimeKind.Unspecified).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 9, 30, 12, 15, 37, 231, DateTimeKind.Unspecified).AddTicks(6597), "Argentina", new DateTime(2021, 7, 5, 15, 0, 14, 999, DateTimeKind.Unspecified).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 10, 5, 19, 35, 36, 719, DateTimeKind.Unspecified).AddTicks(3839), "Saint Kitts and Nevis", new DateTime(2020, 11, 30, 11, 49, 35, 317, DateTimeKind.Unspecified).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 7, 30, 3, 53, 6, 626, DateTimeKind.Unspecified).AddTicks(4178), "Solomon Islands", new DateTime(2020, 7, 25, 16, 19, 46, 162, DateTimeKind.Unspecified).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 5, 21, 12, 14, 2, 99, DateTimeKind.Unspecified).AddTicks(8394), "Saint Martin", new DateTime(2021, 2, 15, 9, 7, 34, 668, DateTimeKind.Unspecified).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 6, 16, 16, 32, 30, 844, DateTimeKind.Unspecified).AddTicks(9405), "Sweden", new DateTime(2020, 10, 18, 1, 0, 26, 684, DateTimeKind.Unspecified).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 10, 13, 1, 45, 53, 504, DateTimeKind.Unspecified).AddTicks(7916), "Dominica", new DateTime(2021, 3, 20, 17, 11, 30, 588, DateTimeKind.Unspecified).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 1, 27, 16, 33, 52, 545, DateTimeKind.Unspecified).AddTicks(8716), "Seychelles", new DateTime(2022, 6, 11, 1, 9, 26, 661, DateTimeKind.Unspecified).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 12, 24, 9, 55, 6, 782, DateTimeKind.Unspecified).AddTicks(7569), "Antarctica (the territory South of 60 deg S)", new DateTime(2022, 6, 28, 3, 41, 9, 75, DateTimeKind.Unspecified).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 11, 3, 20, 0, 50, 994, DateTimeKind.Unspecified).AddTicks(3007), "Saint Lucia", new DateTime(2021, 6, 23, 17, 26, 9, 527, DateTimeKind.Unspecified).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 10, 14, 10, 28, 898, DateTimeKind.Unspecified).AddTicks(291), "Sao Tome and Principe", new DateTime(2022, 4, 7, 18, 26, 1, 960, DateTimeKind.Unspecified).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 10, 23, 3, 23, 10, 376, DateTimeKind.Unspecified).AddTicks(6946), "Lebanon", new DateTime(2020, 12, 25, 11, 46, 29, 779, DateTimeKind.Unspecified).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 9, 9, 0, 23, 32, 666, DateTimeKind.Unspecified).AddTicks(8654), "Belarus", new DateTime(2022, 8, 15, 1, 8, 51, 10, DateTimeKind.Unspecified).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 1, 7, 10, 34, 24, 372, DateTimeKind.Unspecified).AddTicks(828), "Guam", new DateTime(2020, 9, 3, 14, 52, 23, 678, DateTimeKind.Unspecified).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 11, 9, 10, 5, 21, 895, DateTimeKind.Unspecified).AddTicks(3109), "Italy", new DateTime(2020, 5, 10, 4, 10, 38, 637, DateTimeKind.Unspecified).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 5, 25, 20, 35, 0, 793, DateTimeKind.Unspecified).AddTicks(7768), "Kuwait", new DateTime(2020, 3, 27, 7, 15, 13, 362, DateTimeKind.Unspecified).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 25, 6, 28, 2, 461, DateTimeKind.Unspecified).AddTicks(5732), "Armenia", new DateTime(2022, 2, 25, 2, 49, 45, 797, DateTimeKind.Unspecified).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 6, 20, 23, 52, 15, 6, DateTimeKind.Unspecified).AddTicks(9205), "Paraguay", new DateTime(2022, 6, 26, 2, 48, 22, 722, DateTimeKind.Unspecified).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 10, 14, 9, 10, 45, 229, DateTimeKind.Unspecified).AddTicks(6568), "Macedonia", new DateTime(2021, 10, 28, 9, 35, 12, 746, DateTimeKind.Unspecified).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 6, 14, 23, 53, 31, 728, DateTimeKind.Unspecified).AddTicks(3193), "Fiji", new DateTime(2021, 12, 26, 14, 58, 38, 437, DateTimeKind.Unspecified).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 9, 25, 8, 58, 47, 483, DateTimeKind.Unspecified).AddTicks(2142), "Anguilla", new DateTime(2021, 4, 11, 22, 21, 39, 288, DateTimeKind.Unspecified).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 7, 6, 6, 37, 33, 458, DateTimeKind.Unspecified).AddTicks(1787), "Timor-Leste", new DateTime(2020, 11, 15, 12, 1, 23, 62, DateTimeKind.Unspecified).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 11, 5, 19, 20, 27, 76, DateTimeKind.Unspecified).AddTicks(2475), "Thailand", new DateTime(2021, 2, 11, 8, 20, 34, 727, DateTimeKind.Unspecified).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 6, 29, 23, 46, 39, 277, DateTimeKind.Unspecified).AddTicks(8537), "Bangladesh", new DateTime(2021, 8, 6, 19, 3, 40, 970, DateTimeKind.Unspecified).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 12, 3, 12, 4, 53, 542, DateTimeKind.Unspecified).AddTicks(8473), "China", new DateTime(2021, 5, 18, 4, 31, 43, 891, DateTimeKind.Unspecified).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 7, 10, 14, 44, 542, DateTimeKind.Unspecified).AddTicks(8886), "Reunion", new DateTime(2022, 9, 11, 1, 16, 54, 332, DateTimeKind.Unspecified).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 4, 6, 53, 43, 536, DateTimeKind.Unspecified).AddTicks(7818), "Zambia", new DateTime(2021, 3, 24, 8, 50, 5, 221, DateTimeKind.Unspecified).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 4, 18, 2, 2, 19, 609, DateTimeKind.Unspecified).AddTicks(7810), "Mauritius", new DateTime(2022, 4, 15, 18, 36, 20, 492, DateTimeKind.Unspecified).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 3, 11, 0, 3, 25, 701, DateTimeKind.Unspecified).AddTicks(6250), "Tasty Metal Computer", 53m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 6, 15, 23, 38, 57, 620, DateTimeKind.Unspecified).AddTicks(1293), "Incredible Concrete Gloves", 53m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 3, 25, 23, 41, 48, 554, DateTimeKind.Unspecified).AddTicks(2568), "Refined Granite Computer", 56m, 22 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 6, new DateTime(2021, 12, 4, 1, 58, 34, 300, DateTimeKind.Unspecified).AddTicks(2007), "Incredible Plastic Shoes", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2021, 9, 12, 23, 55, 21, 623, DateTimeKind.Unspecified).AddTicks(975), "Awesome Wooden Bacon", 50m, 182 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2020, 8, 10, 9, 21, 41, 716, DateTimeKind.Unspecified).AddTicks(6955), "Refined Plastic Pants", 57m, 180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 5, 17, 10, 9, 48, 557, DateTimeKind.Unspecified).AddTicks(7262), "Incredible Soft Computer", 55m, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 9, 30, 23, 21, 18, 694, DateTimeKind.Unspecified).AddTicks(7795), "Gorgeous Metal Keyboard", 57m, 191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2020, 7, 25, 6, 38, 1, 705, DateTimeKind.Unspecified).AddTicks(3754), "Awesome Soft Ball", 53m, 130 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2020, 9, 7, 14, 59, 58, 314, DateTimeKind.Unspecified).AddTicks(3393), "Unbranded Steel Hat", 53m, 88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 3, 25, 1, 12, 32, 958, DateTimeKind.Unspecified).AddTicks(8953), "Small Concrete Fish", 54m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2020, 7, 18, 6, 4, 40, 846, DateTimeKind.Unspecified).AddTicks(380), "Incredible Plastic Hat", 53m, 106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 12, 14, 1, 29, 20, 176, DateTimeKind.Unspecified).AddTicks(37), "Handmade Granite Pizza", 54m, 105 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2020, 10, 12, 22, 30, 32, 607, DateTimeKind.Unspecified).AddTicks(5328), "Gorgeous Frozen Sausages", 49m, 102 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2020, 10, 24, 23, 49, 24, 384, DateTimeKind.Unspecified).AddTicks(28), "Small Soft Sausages", 152 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2020, 4, 25, 5, 39, 29, 511, DateTimeKind.Unspecified).AddTicks(8577), "Rustic Cotton Chair", 51m, 125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 11, 4, 23, 59, 28, 33, DateTimeKind.Unspecified).AddTicks(4268), "Fantastic Granite Cheese", 53m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 10, 11, 19, 22, 54, 322, DateTimeKind.Unspecified).AddTicks(7750), "Practical Rubber Bacon", 50m, 132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 2, new DateTime(2022, 4, 12, 22, 38, 13, 101, DateTimeKind.Unspecified).AddTicks(5203), "Intelligent Frozen Bike", 112 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 4, 30, 6, 50, 19, 852, DateTimeKind.Unspecified).AddTicks(7596), "Practical Metal Computer", 52m, 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 7, 24, 0, 44, 33, 664, DateTimeKind.Unspecified).AddTicks(283), "Rustic Frozen Tuna", 51m, 121 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 5, new DateTime(2020, 4, 23, 11, 10, 5, 360, DateTimeKind.Unspecified).AddTicks(555), "Unbranded Concrete Bike", 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 8, 21, 11, 18, 1, 99, DateTimeKind.Unspecified).AddTicks(865), "Small Rubber Tuna", 49m, 75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 10, 29, 12, 18, 18, 973, DateTimeKind.Unspecified).AddTicks(1844), "Refined Steel Bike", 53m, 145 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 5, 31, 20, 15, 16, 933, DateTimeKind.Unspecified).AddTicks(6271), "Tasty Fresh Car", 49m, 168 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2020, 11, 5, 20, 19, 34, 710, DateTimeKind.Unspecified).AddTicks(6323), "Unbranded Wooden Sausages", 55m, 125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2020, 6, 26, 9, 30, 34, 270, DateTimeKind.Unspecified).AddTicks(3677), "Unbranded Metal Salad", 55m, 141 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2020, 4, 29, 16, 49, 20, 9, DateTimeKind.Unspecified).AddTicks(9124), "Unbranded Rubber Ball", 57m, 194 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 8, 26, 19, 20, 30, 885, DateTimeKind.Unspecified).AddTicks(2993), "Handmade Cotton Mouse", 109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2020, 9, 2, 3, 49, 55, 425, DateTimeKind.Unspecified).AddTicks(249), "Unbranded Plastic Pants", 56m, 17 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 12, 11, 2, 20, 29, 966, DateTimeKind.Unspecified).AddTicks(7245), 21 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 12, 23, 13, 17, 39, 179, DateTimeKind.Unspecified).AddTicks(9516), 183 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 1, 21, 14, 11, 20, 472, DateTimeKind.Unspecified).AddTicks(1505), 65 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 11, 24, 11, 38, 44, 983, DateTimeKind.Unspecified).AddTicks(3843), 200 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 9, 24, 19, 49, 17, 783, DateTimeKind.Unspecified).AddTicks(5400), 18 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 12, 17, 5, 48, 50, 221, DateTimeKind.Unspecified).AddTicks(4800), 59 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 30, 2, 28, 48, 679, DateTimeKind.Unspecified).AddTicks(4088), 4 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 6, 27, 13, 32, 54, 698, DateTimeKind.Unspecified).AddTicks(6395), 46 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 8 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 4, 15, 20, 51, 6, 947, DateTimeKind.Unspecified).AddTicks(7915), 82 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 19, 0, 3, 15, 926, DateTimeKind.Unspecified).AddTicks(7028), 22 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 25, 4, 19, 0, 13, DateTimeKind.Unspecified).AddTicks(6820), 32 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 31, 20, 56, 54, 213, DateTimeKind.Unspecified).AddTicks(4773), 187 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 10, 12, 16, 16, 19, 975, DateTimeKind.Unspecified).AddTicks(6325), 42 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 11, 12, 35, 20, 959, DateTimeKind.Unspecified).AddTicks(337), 125 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 9, 9, 15, 6, 8, 549, DateTimeKind.Unspecified).AddTicks(1480), 34 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 8, 14, 15, 47, 55, 88, DateTimeKind.Unspecified).AddTicks(2975), 26 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 20, 17, 30, 2, 965, DateTimeKind.Unspecified).AddTicks(6324), 42 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 2, 13, 1, 55, 18, 75, DateTimeKind.Unspecified).AddTicks(7880), 150 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 8, 7, 20, 8, 7, 336, DateTimeKind.Unspecified).AddTicks(8988), 105 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 26, 10, 26, 47, 876, DateTimeKind.Unspecified).AddTicks(850), 149 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 31, 5, 48, 28, 939, DateTimeKind.Unspecified).AddTicks(9339), 184 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 3, 5, 32, 49, 7, DateTimeKind.Unspecified).AddTicks(8856), 46 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 9, 7, 5, 40, 5, 813, DateTimeKind.Unspecified).AddTicks(5720), 156 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 7, 24, 10, 35, 49, 708, DateTimeKind.Unspecified).AddTicks(1377), 198 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 12, 19, 21, 39, 58, 129, DateTimeKind.Unspecified).AddTicks(5960), 145 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 9, 15, 10, 5, 51, 328, DateTimeKind.Unspecified).AddTicks(5189), 100 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 10, 2, 3, 9, 48, 687, DateTimeKind.Unspecified).AddTicks(8905), 141 });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2020, 4, 10, 16, 58, 47, 502, DateTimeKind.Unspecified).AddTicks(1597), null, 116, 1 },
                    { 1, 8, new DateTime(2020, 5, 7, 11, 47, 24, 205, DateTimeKind.Unspecified).AddTicks(5416), null, 125, 1 },
                    { 2, 3, new DateTime(2021, 5, 14, 10, 21, 37, 463, DateTimeKind.Unspecified).AddTicks(8141), null, 121, 1 },
                    { 3, 1, new DateTime(2021, 9, 3, 10, 21, 23, 949, DateTimeKind.Unspecified).AddTicks(8155), null, 46, 1 },
                    { 3, 3, new DateTime(2021, 2, 17, 5, 7, 45, 118, DateTimeKind.Unspecified).AddTicks(4214), null, 51, 1 },
                    { 3, 7, new DateTime(2021, 5, 22, 5, 39, 56, 839, DateTimeKind.Unspecified).AddTicks(235), null, 63, 1 },
                    { 3, 9, new DateTime(2022, 1, 15, 10, 26, 20, 814, DateTimeKind.Unspecified).AddTicks(1328), null, 177, 1 },
                    { 4, 1, new DateTime(2021, 2, 7, 18, 41, 39, 434, DateTimeKind.Unspecified).AddTicks(3396), null, 95, 1 },
                    { 4, 5, new DateTime(2020, 4, 11, 16, 22, 25, 95, DateTimeKind.Unspecified).AddTicks(2586), null, 15, 1 },
                    { 5, 4, new DateTime(2020, 4, 17, 1, 31, 54, 122, DateTimeKind.Unspecified).AddTicks(4543), null, 96, 1 },
                    { 6, 6, new DateTime(2022, 5, 13, 11, 18, 23, 808, DateTimeKind.Unspecified).AddTicks(908), null, 28, 1 },
                    { 6, 7, new DateTime(2020, 10, 15, 19, 36, 47, 485, DateTimeKind.Unspecified).AddTicks(1771), null, 115, 1 },
                    { 7, 8, new DateTime(2022, 12, 19, 14, 0, 23, 71, DateTimeKind.Unspecified).AddTicks(8277), null, 164, 1 },
                    { 8, 3, new DateTime(2022, 1, 13, 9, 35, 12, 173, DateTimeKind.Unspecified).AddTicks(6577), null, 73, 1 },
                    { 8, 4, new DateTime(2022, 10, 13, 23, 16, 52, 226, DateTimeKind.Unspecified).AddTicks(1170), null, 100, 1 },
                    { 8, 9, new DateTime(2022, 11, 12, 14, 57, 9, 451, DateTimeKind.Unspecified).AddTicks(4582), null, 98, 1 },
                    { 8, 10, new DateTime(2021, 6, 22, 9, 30, 0, 164, DateTimeKind.Unspecified).AddTicks(7748), null, 108, 1 },
                    { 9, 3, new DateTime(2020, 12, 5, 16, 57, 19, 915, DateTimeKind.Unspecified).AddTicks(9716), null, 86, 1 },
                    { 10, 1, new DateTime(2022, 2, 25, 22, 26, 46, 698, DateTimeKind.Unspecified).AddTicks(70), null, 5, 1 },
                    { 11, 10, new DateTime(2022, 5, 28, 11, 24, 58, 308, DateTimeKind.Unspecified).AddTicks(5611), null, 51, 1 },
                    { 12, 6, new DateTime(2020, 6, 27, 12, 16, 30, 185, DateTimeKind.Unspecified).AddTicks(4197), null, 148, 1 },
                    { 13, 2, new DateTime(2022, 9, 30, 5, 39, 20, 566, DateTimeKind.Unspecified).AddTicks(5851), null, 168, 1 },
                    { 13, 9, new DateTime(2020, 4, 26, 14, 57, 21, 865, DateTimeKind.Unspecified).AddTicks(8050), null, 76, 1 },
                    { 13, 10, new DateTime(2020, 7, 13, 2, 50, 2, 642, DateTimeKind.Unspecified).AddTicks(6567), null, 63, 1 },
                    { 14, 1, new DateTime(2022, 7, 20, 23, 53, 14, 174, DateTimeKind.Unspecified).AddTicks(1929), null, 171, 1 },
                    { 14, 2, new DateTime(2022, 5, 3, 13, 24, 21, 594, DateTimeKind.Unspecified).AddTicks(6600), null, 136, 1 },
                    { 14, 8, new DateTime(2021, 5, 20, 3, 50, 58, 356, DateTimeKind.Unspecified).AddTicks(7495), null, 191, 1 },
                    { 14, 9, new DateTime(2021, 6, 6, 4, 14, 1, 373, DateTimeKind.Unspecified).AddTicks(4913), null, 94, 1 },
                    { 14, 10, new DateTime(2021, 4, 1, 1, 26, 7, 358, DateTimeKind.Unspecified).AddTicks(2562), null, 93, 1 },
                    { 15, 4, new DateTime(2021, 3, 13, 15, 1, 29, 248, DateTimeKind.Unspecified).AddTicks(366), null, 52, 1 },
                    { 16, 2, new DateTime(2022, 10, 27, 2, 47, 22, 533, DateTimeKind.Unspecified).AddTicks(4965), null, 147, 1 },
                    { 16, 6, new DateTime(2021, 2, 19, 16, 15, 41, 812, DateTimeKind.Unspecified).AddTicks(7216), null, 167, 1 },
                    { 18, 1, new DateTime(2021, 10, 1, 13, 57, 49, 735, DateTimeKind.Unspecified).AddTicks(6969), null, 171, 1 },
                    { 18, 2, new DateTime(2020, 10, 24, 10, 37, 22, 300, DateTimeKind.Unspecified).AddTicks(1688), null, 154, 1 },
                    { 18, 7, new DateTime(2020, 10, 11, 12, 35, 0, 152, DateTimeKind.Unspecified).AddTicks(2721), null, 50, 1 },
                    { 18, 9, new DateTime(2022, 3, 19, 8, 46, 9, 274, DateTimeKind.Unspecified).AddTicks(4107), null, 4, 1 },
                    { 19, 3, new DateTime(2022, 12, 12, 0, 40, 24, 816, DateTimeKind.Unspecified).AddTicks(7663), null, 199, 1 },
                    { 19, 8, new DateTime(2021, 2, 23, 8, 54, 49, 148, DateTimeKind.Unspecified).AddTicks(8866), null, 19, 1 },
                    { 19, 10, new DateTime(2020, 11, 10, 14, 1, 15, 420, DateTimeKind.Unspecified).AddTicks(9997), null, 78, 1 },
                    { 20, 1, new DateTime(2021, 4, 1, 14, 42, 7, 937, DateTimeKind.Unspecified).AddTicks(7877), null, 75, 1 },
                    { 20, 4, new DateTime(2022, 2, 18, 21, 39, 19, 466, DateTimeKind.Unspecified).AddTicks(9645), null, 134, 1 },
                    { 20, 8, new DateTime(2020, 12, 17, 16, 27, 29, 271, DateTimeKind.Unspecified).AddTicks(4676), null, 153, 1 },
                    { 22, 7, new DateTime(2022, 12, 30, 6, 49, 9, 848, DateTimeKind.Unspecified).AddTicks(2412), null, 148, 1 },
                    { 23, 5, new DateTime(2022, 10, 19, 3, 46, 3, 342, DateTimeKind.Unspecified).AddTicks(7430), null, 195, 1 },
                    { 24, 1, new DateTime(2020, 3, 24, 17, 39, 22, 591, DateTimeKind.Unspecified).AddTicks(8826), null, 114, 1 },
                    { 24, 3, new DateTime(2022, 8, 23, 20, 23, 46, 950, DateTimeKind.Unspecified).AddTicks(3679), null, 75, 1 },
                    { 25, 6, new DateTime(2020, 3, 24, 5, 11, 10, 856, DateTimeKind.Unspecified).AddTicks(122), null, 119, 1 },
                    { 25, 9, new DateTime(2022, 3, 11, 0, 37, 11, 547, DateTimeKind.Unspecified).AddTicks(4091), null, 108, 1 },
                    { 26, 4, new DateTime(2021, 12, 21, 9, 5, 55, 747, DateTimeKind.Unspecified).AddTicks(6045), null, 184, 1 },
                    { 26, 5, new DateTime(2022, 6, 18, 3, 7, 18, 399, DateTimeKind.Unspecified).AddTicks(7963), null, 158, 1 },
                    { 26, 9, new DateTime(2021, 7, 25, 22, 15, 26, 354, DateTimeKind.Unspecified).AddTicks(3235), null, 108, 1 },
                    { 27, 5, new DateTime(2020, 8, 11, 17, 36, 17, 472, DateTimeKind.Unspecified).AddTicks(9683), null, 115, 1 },
                    { 27, 8, new DateTime(2021, 11, 10, 14, 12, 36, 80, DateTimeKind.Unspecified).AddTicks(8328), null, 140, 1 },
                    { 28, 4, new DateTime(2021, 8, 27, 13, 41, 32, 757, DateTimeKind.Unspecified).AddTicks(5589), null, 167, 1 },
                    { 28, 7, new DateTime(2021, 9, 4, 3, 41, 20, 221, DateTimeKind.Unspecified).AddTicks(8500), null, 99, 1 },
                    { 29, 1, new DateTime(2022, 6, 16, 7, 24, 48, 784, DateTimeKind.Unspecified).AddTicks(5970), null, 37, 1 },
                    { 30, 7, new DateTime(2022, 2, 14, 3, 53, 7, 481, DateTimeKind.Unspecified).AddTicks(34), null, 112, 1 },
                    { 30, 10, new DateTime(2020, 5, 3, 8, 20, 10, 267, DateTimeKind.Unspecified).AddTicks(4177), null, 141, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "67157 Wolf Mill, North Price, Hong Kong", "Schulist Group", new DateTime(2020, 5, 5, 23, 18, 33, 386, DateTimeKind.Unspecified).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "95672 Pfannerstill Cove, Lake Lacyberg, Greenland", "Armstrong, Batz and Goodwin", new DateTime(2021, 3, 19, 0, 13, 29, 566, DateTimeKind.Unspecified).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "8735 Ara Lodge, West Jenniferview, Kenya", "Auer, Kiehn and Hudson", new DateTime(2022, 9, 16, 20, 26, 36, 903, DateTimeKind.Unspecified).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "28079 Kunde Turnpike, Lake Walter, New Zealand", "Botsford - Feil", new DateTime(2020, 6, 21, 17, 36, 58, 357, DateTimeKind.Unspecified).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "23867 Avis Estate, New Clareburgh, Hungary", "Conroy and Sons", new DateTime(2022, 11, 8, 3, 49, 4, 42, DateTimeKind.Unspecified).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "070 Verlie Mountain, Corwinfort, Tuvalu", "Frami - Purdy", new DateTime(2022, 9, 23, 5, 37, 29, 683, DateTimeKind.Unspecified).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "0366 Suzanne Locks, Terryton, France", "Lynch LLC", new DateTime(2022, 3, 7, 23, 0, 11, 426, DateTimeKind.Unspecified).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "74195 Greta Via, South Joey, San Marino", "O'Reilly, Windler and Jast", new DateTime(2022, 6, 6, 10, 27, 4, 520, DateTimeKind.Unspecified).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "522 Aurelia Pass, West Stantonbury, Brazil", "Brekke, Walker and Wisozk", new DateTime(2021, 4, 11, 8, 32, 29, 488, DateTimeKind.Unspecified).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "3921 Greg Meadows, Port Arvidmouth, Solomon Islands", "Heller, Upton and Jast", new DateTime(2022, 6, 23, 21, 15, 21, 405, DateTimeKind.Unspecified).AddTicks(6339) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AspNetUserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 31, 52, 420, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 31, 52, 420, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 4, 16, 31, 52, 420, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2020, 10, 20, 21, 54, 59, 422, DateTimeKind.Unspecified).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2022, 9, 1, 11, 14, 45, 588, DateTimeKind.Unspecified).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2021, 8, 22, 20, 45, 3, 930, DateTimeKind.Unspecified).AddTicks(9574) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Id", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2022, 1, 5, 18, 3, 7, 496, DateTimeKind.Unspecified).AddTicks(875), null, 1 },
                    { 2, 2, 0, new DateTime(2021, 6, 12, 23, 27, 17, 229, DateTimeKind.Unspecified).AddTicks(8927), null, 1 },
                    { 1, 5, 0, new DateTime(2021, 9, 14, 19, 24, 10, 629, DateTimeKind.Unspecified).AddTicks(4977), null, 1 },
                    { 1, 7, 0, new DateTime(2021, 10, 30, 17, 59, 35, 997, DateTimeKind.Unspecified).AddTicks(3330), null, 1 },
                    { 1, 8, 0, new DateTime(2021, 7, 16, 5, 52, 12, 397, DateTimeKind.Unspecified).AddTicks(5284), null, 1 },
                    { 2, 10, 0, new DateTime(2022, 5, 15, 12, 59, 50, 989, DateTimeKind.Unspecified).AddTicks(9442), null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2e542f7e-d7fc-4304-87ce-4742da800be5", "Elena28@hotmail.com", new DateTime(2020, 4, 2, 4, 58, 37, 548, DateTimeKind.Unspecified).AddTicks(9759), "ELENA28@HOTMAIL.COM", "GLENNA43", "tn8TPVIHg6", "(333) 726-6309 x401", "cUkJrHcTkA", "Glenna43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2fe69709-cc4b-4c5d-9b20-35e32302d2c2", "Maryjane7@gmail.com", new DateTime(2021, 9, 7, 3, 5, 27, 927, DateTimeKind.Unspecified).AddTicks(2011), "MARYJANE7@GMAIL.COM", "MATHEW_BECKER16", "MrSX90DUyU", "1-609-701-4736 x08106", "N5Ne8zjHqP", "Mathew_Becker16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4b1f5cb8-60a3-40d5-b275-0f02e7c4e772", "Alexzander_Will97@gmail.com", new DateTime(2021, 11, 17, 7, 21, 52, 259, DateTimeKind.Unspecified).AddTicks(9950), "ALEXZANDER_WILL97@GMAIL.COM", "FERNANDO60", "oU2SZebZ_o", "(406) 253-6925", "JQtMQi14A1", "Fernando60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80b98c6d-dfd5-4ec2-a78c-5b60f5136e68", "Jamil.Ernser@gmail.com", new DateTime(2021, 6, 3, 12, 33, 12, 450, DateTimeKind.Unspecified).AddTicks(6133), "JAMIL.ERNSER@GMAIL.COM", "ZELLA.SANFORD98", "OBpn6uOyTw", "278-498-4421", "1gqrep7ffQ", "Zella.Sanford98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80eb2788-67fe-4dbf-8f6f-82e1feca74c2", "Annetta.Wilkinson40@gmail.com", new DateTime(2021, 7, 10, 6, 28, 36, 67, DateTimeKind.Unspecified).AddTicks(3207), "ANNETTA.WILKINSON40@GMAIL.COM", "SHAYNA49", "14MYSdEeq8", "753-355-1189 x174", "pBxNpvXfHw", "Shayna49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5352e0e9-8400-49ba-bb7d-6cb2fbabb4aa", "Godfrey.Hahn47@gmail.com", new DateTime(2020, 9, 15, 2, 40, 39, 961, DateTimeKind.Unspecified).AddTicks(9351), "GODFREY.HAHN47@GMAIL.COM", "MARTINE_KOZEY1", "7IymD7_dHX", "344-705-0445 x808", "Mhi6qY1yvA", "Martine_Kozey1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e658c302-3578-48d8-a90e-5ce8308cffdc", "Carmela.Volkman12@yahoo.com", new DateTime(2022, 8, 13, 22, 42, 59, 757, DateTimeKind.Unspecified).AddTicks(4110), "CARMELA.VOLKMAN12@YAHOO.COM", "MERVIN.LANGOSH", "zFSsXqUpUT", "404-608-8791", "PKO9Ed46vU", "Mervin.Langosh" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "b48c284f-fcb6-42bc-95b6-8da75a177de6", "Austyn38@gmail.com", new DateTime(2022, 12, 1, 14, 4, 24, 275, DateTimeKind.Unspecified).AddTicks(3970), "AUSTYN38@GMAIL.COM", "VANESSA_RODRIGUEZ", "0HelwEAlRA", "1-352-610-4779", "rKMRzBv7qy", "Vanessa_Rodriguez" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43fcb6eb-2516-49cd-b5b4-46ff7d276786", "Larue80@hotmail.com", new DateTime(2021, 9, 4, 3, 29, 11, 376, DateTimeKind.Unspecified).AddTicks(5975), "LARUE80@HOTMAIL.COM", "MYRIAM_GUTKOWSKI51", "XqWrieGryv", "(690) 774-4475 x07750", "AX3EMPXme5", "Myriam_Gutkowski51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "16d94b44-c4b1-46c4-ae9d-a80d36d28d4b", "Hubert_Mraz50@hotmail.com", new DateTime(2021, 3, 3, 18, 56, 14, 102, DateTimeKind.Unspecified).AddTicks(4217), "HUBERT_MRAZ50@HOTMAIL.COM", "CLIFFORD.ONDRICKA", "qah9nycayY", "1-327-845-1507 x8404", "jewEANvxfP", "Clifford.Ondricka" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertedDate",
                value: new DateTime(2021, 10, 30, 22, 27, 3, 388, DateTimeKind.Unspecified).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Toys", new DateTime(2020, 7, 23, 22, 20, 25, 201, DateTimeKind.Unspecified).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Home", new DateTime(2021, 3, 21, 15, 7, 12, 434, DateTimeKind.Unspecified).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Computers", new DateTime(2022, 12, 17, 12, 18, 38, 916, DateTimeKind.Unspecified).AddTicks(5992), 2 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Outdoors", new DateTime(2022, 1, 23, 7, 22, 27, 347, DateTimeKind.Unspecified).AddTicks(7312), 2 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Health", new DateTime(2021, 7, 21, 5, 30, 41, 634, DateTimeKind.Unspecified).AddTicks(9240), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Shoes", new DateTime(2022, 11, 15, 2, 9, 33, 928, DateTimeKind.Unspecified).AddTicks(9519), 2 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Toys", new DateTime(2021, 8, 11, 3, 38, 18, 756, DateTimeKind.Unspecified).AddTicks(5384), 3 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertedDate", "ParentID" },
                values: new object[] { new DateTime(2020, 7, 1, 0, 23, 28, 782, DateTimeKind.Unspecified).AddTicks(7675), 2 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Computers", new DateTime(2020, 10, 17, 4, 20, 2, 316, DateTimeKind.Unspecified).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 1, 16, 6, 52, 8, 580, DateTimeKind.Unspecified).AddTicks(3167), "Isle of Man", new DateTime(2021, 6, 13, 21, 9, 24, 822, DateTimeKind.Unspecified).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 4, 12, 7, 32, 46, 141, DateTimeKind.Unspecified).AddTicks(3843), "Somalia", new DateTime(2022, 11, 22, 15, 53, 28, 511, DateTimeKind.Unspecified).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 7, 29, 22, 19, 51, 759, DateTimeKind.Unspecified).AddTicks(5879), "Georgia", new DateTime(2021, 4, 24, 7, 0, 49, 104, DateTimeKind.Unspecified).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 7, 21, 11, 58, 35, 961, DateTimeKind.Unspecified).AddTicks(3490), "Iran", new DateTime(2022, 1, 26, 13, 36, 17, 490, DateTimeKind.Unspecified).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 5, 15, 20, 10, 4, 792, DateTimeKind.Unspecified).AddTicks(9208), "Malta", new DateTime(2022, 4, 6, 19, 49, 42, 261, DateTimeKind.Unspecified).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 11, 26, 3, 43, 41, 428, DateTimeKind.Unspecified).AddTicks(3769), "Sweden", new DateTime(2020, 10, 16, 1, 49, 1, 64, DateTimeKind.Unspecified).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 7, 3, 13, 18, 56, 296, DateTimeKind.Unspecified).AddTicks(5966), "Singapore", new DateTime(2020, 11, 30, 21, 23, 52, 101, DateTimeKind.Unspecified).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 8, 20, 4, 47, 35, 439, DateTimeKind.Unspecified).AddTicks(6924), "Uzbekistan", new DateTime(2022, 8, 8, 22, 20, 59, 427, DateTimeKind.Unspecified).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 3, 30, 11, 43, 20, 545, DateTimeKind.Unspecified).AddTicks(3884), "Ghana", new DateTime(2021, 4, 2, 2, 54, 53, 454, DateTimeKind.Unspecified).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 2, 25, 20, 57, 51, 455, DateTimeKind.Unspecified).AddTicks(910), "Antigua and Barbuda", new DateTime(2020, 6, 9, 13, 40, 9, 827, DateTimeKind.Unspecified).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 5, 28, 8, 37, 0, 892, DateTimeKind.Unspecified).AddTicks(9115), "Maldives", new DateTime(2020, 12, 9, 13, 51, 19, 210, DateTimeKind.Unspecified).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 11, 16, 22, 2, 59, 220, DateTimeKind.Unspecified).AddTicks(3616), "Sudan", new DateTime(2021, 9, 11, 7, 30, 23, 574, DateTimeKind.Unspecified).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 23, 25, 168, DateTimeKind.Unspecified).AddTicks(3053), "Zimbabwe", new DateTime(2020, 4, 16, 22, 19, 56, 651, DateTimeKind.Unspecified).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 32, 54, 952, DateTimeKind.Unspecified).AddTicks(8066), "Nicaragua", new DateTime(2021, 9, 24, 5, 29, 51, 343, DateTimeKind.Unspecified).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 12, 25, 23, 52, 26, 943, DateTimeKind.Unspecified).AddTicks(3643), "South Georgia and the South Sandwich Islands", new DateTime(2022, 9, 24, 6, 2, 19, 800, DateTimeKind.Unspecified).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 6, 17, 10, 17, 1, 906, DateTimeKind.Unspecified).AddTicks(8866), "Tonga", new DateTime(2022, 2, 18, 4, 43, 5, 275, DateTimeKind.Unspecified).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 4, 2, 0, 0, 57, 646, DateTimeKind.Unspecified).AddTicks(3665), "Trinidad and Tobago", new DateTime(2021, 10, 26, 2, 31, 34, 163, DateTimeKind.Unspecified).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 5, 13, 2, 4, 37, 781, DateTimeKind.Unspecified).AddTicks(4216), "Falkland Islands (Malvinas)", new DateTime(2022, 10, 8, 1, 57, 23, 76, DateTimeKind.Unspecified).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 10, 7, 0, 13, 57, 310, DateTimeKind.Unspecified).AddTicks(334), "Christmas Island", new DateTime(2020, 11, 4, 8, 37, 16, 518, DateTimeKind.Unspecified).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 10, 22, 19, 53, 24, 291, DateTimeKind.Unspecified).AddTicks(6161), "Turkey", new DateTime(2022, 3, 14, 7, 33, 38, 941, DateTimeKind.Unspecified).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 8, 1, 23, 0, 59, 580, DateTimeKind.Unspecified).AddTicks(5156), "Virgin Islands, U.S.", new DateTime(2022, 6, 19, 1, 4, 29, 378, DateTimeKind.Unspecified).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 9, 21, 12, 20, 31, 784, DateTimeKind.Unspecified).AddTicks(2030), "Cuba", new DateTime(2021, 2, 22, 16, 34, 59, 700, DateTimeKind.Unspecified).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 28, 40, 929, DateTimeKind.Unspecified).AddTicks(2888), "Lebanon", new DateTime(2021, 7, 16, 20, 18, 9, 322, DateTimeKind.Unspecified).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 9, 10, 21, 27, 38, 640, DateTimeKind.Unspecified).AddTicks(8944), "Thailand", new DateTime(2020, 3, 28, 23, 11, 22, 437, DateTimeKind.Unspecified).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 20, 19, 57, 10, 805, DateTimeKind.Unspecified).AddTicks(8574), "Dominican Republic", new DateTime(2020, 3, 25, 17, 59, 10, 42, DateTimeKind.Unspecified).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 6, 16, 3, 26, 45, 167, DateTimeKind.Unspecified).AddTicks(2032), "Tanzania", new DateTime(2022, 3, 29, 1, 20, 44, 965, DateTimeKind.Unspecified).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 10, 29, 20, 25, 58, 525, DateTimeKind.Unspecified).AddTicks(853), "Guam", new DateTime(2022, 5, 29, 8, 10, 10, 102, DateTimeKind.Unspecified).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 9, 30, 9, 12, 29, 840, DateTimeKind.Unspecified).AddTicks(4361), "Aruba", new DateTime(2020, 12, 10, 2, 36, 22, 295, DateTimeKind.Unspecified).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 11, 7, 2, 52, 47, 962, DateTimeKind.Unspecified).AddTicks(3572), "Colombia", new DateTime(2020, 5, 28, 3, 31, 15, 289, DateTimeKind.Unspecified).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 8, 16, 7, 45, 41, 381, DateTimeKind.Unspecified).AddTicks(5602), "Wallis and Futuna", new DateTime(2020, 9, 5, 9, 58, 46, 302, DateTimeKind.Unspecified).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 11, 5, 20, 40, 5, 451, DateTimeKind.Unspecified).AddTicks(9138), "Generic Frozen Salad", 57m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 7, 26, 21, 22, 24, 676, DateTimeKind.Unspecified).AddTicks(3801), "Unbranded Metal Ball", 57m, 136 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 1, 1, 14, 37, 27, 801, DateTimeKind.Unspecified).AddTicks(920), "Tasty Cotton Chips", 53m, 72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 7, new DateTime(2022, 8, 30, 3, 59, 30, 551, DateTimeKind.Unspecified).AddTicks(7332), "Generic Concrete Mouse", 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 5, 18, 17, 25, 25, 883, DateTimeKind.Unspecified).AddTicks(5890), "Handmade Frozen Table", 53m, 38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 9, 14, 6, 6, 16, 906, DateTimeKind.Unspecified).AddTicks(5470), "Small Metal Tuna", 50m, 167 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 11, 30, 20, 51, 41, 800, DateTimeKind.Unspecified).AddTicks(6955), "Practical Steel Pants", 57m, 188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2021, 4, 2, 19, 29, 39, 451, DateTimeKind.Unspecified).AddTicks(2001), "Handcrafted Metal Shoes", 49m, 71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 10, 27, 16, 55, 1, 632, DateTimeKind.Unspecified).AddTicks(7990), "Small Steel Computer", 49m, 62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 7, 4, 11, 17, 53, 524, DateTimeKind.Unspecified).AddTicks(4146), "Gorgeous Rubber Fish", 50m, 34 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 11, 3, 16, 45, 44, 658, DateTimeKind.Unspecified).AddTicks(4475), "Handmade Fresh Hat", 56m, 187 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 8, 9, 5, 54, 50, 325, DateTimeKind.Unspecified).AddTicks(3234), "Licensed Fresh Cheese", 57m, 62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 12, 17, 15, 24, 46, 859, DateTimeKind.Unspecified).AddTicks(8613), "Incredible Fresh Chips", 55m, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2020, 5, 25, 17, 0, 51, 512, DateTimeKind.Unspecified).AddTicks(4664), "Unbranded Steel Bacon", 50m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 13, 32, 4, 83, DateTimeKind.Unspecified).AddTicks(9415), "Generic Steel Ball", 161 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 3, 30, 4, 36, 3, 177, DateTimeKind.Unspecified).AddTicks(1614), "Intelligent Cotton Chair", 52m, 55 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 4, 16, 1, 27, 32, 817, DateTimeKind.Unspecified).AddTicks(3380), "Generic Granite Shoes", 55m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2020, 12, 28, 15, 19, 22, 840, DateTimeKind.Unspecified).AddTicks(3930), "Gorgeous Soft Towels", 54m, 186 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2021, 6, 7, 1, 41, 41, 718, DateTimeKind.Unspecified).AddTicks(9991), "Licensed Concrete Sausages", 72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 10, 19, 16, 10, 0, 42, DateTimeKind.Unspecified).AddTicks(535), "Gorgeous Cotton Mouse", 55m, 31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 5, 12, 21, 8, 24, 394, DateTimeKind.Unspecified).AddTicks(9695), "Refined Frozen Pizza", 57m, 169 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 4, new DateTime(2022, 6, 23, 20, 10, 45, 156, DateTimeKind.Unspecified).AddTicks(7814), "Awesome Concrete Sausages", 94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2020, 3, 21, 22, 59, 2, 503, DateTimeKind.Unspecified).AddTicks(5944), "Awesome Frozen Chair", 53m, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 10, 4, 7, 52, 58, 737, DateTimeKind.Unspecified).AddTicks(7681), "Handcrafted Plastic Tuna", 49m, 26 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 12, 15, 15, 19, 13, 824, DateTimeKind.Unspecified).AddTicks(3333), "Fantastic Metal Car", 57m, 87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 8, 19, 6, 2, 28, 628, DateTimeKind.Unspecified).AddTicks(6730), "Gorgeous Granite Towels", 57m, 156 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 10, 9, 11, 54, 12, 886, DateTimeKind.Unspecified).AddTicks(523), "Gorgeous Metal Chair", 57m, 109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 6, 30, 0, 16, 11, 941, DateTimeKind.Unspecified).AddTicks(8841), "Unbranded Concrete Keyboard", 55m, 138 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InsertedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 42, 36, 633, DateTimeKind.Unspecified).AddTicks(8151), "Unbranded Plastic Pants", 138 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 5, 22, 8, 54, 41, 492, DateTimeKind.Unspecified).AddTicks(6649), "Ergonomic Rubber Cheese", 57m, 73 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 1, 10, 16, 59, 15, 740, DateTimeKind.Unspecified).AddTicks(9626), 152 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 12, 18, 52, 31, 976, DateTimeKind.Unspecified).AddTicks(1456), 151 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 28, 0, 35, 58, 593, DateTimeKind.Unspecified).AddTicks(3120), 109 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 1, 6, 21, 7, 177, DateTimeKind.Unspecified).AddTicks(5435), 60 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 12, 8, 4, 44, 40, 522, DateTimeKind.Unspecified).AddTicks(8674), 3 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 3, 10, 19, 27, 53, 113, DateTimeKind.Unspecified).AddTicks(1106), 19 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 11, 18, 14, 38, 21, 762, DateTimeKind.Unspecified).AddTicks(9653), 10 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 12, 2, 6, 47, 15, 818, DateTimeKind.Unspecified).AddTicks(7250), 27 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 8 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 9, 14, 10, 19, 4, 878, DateTimeKind.Unspecified).AddTicks(1960), 3 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 4, 12, 17, 6, 48, 252, DateTimeKind.Unspecified).AddTicks(6046), 104 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 6, 26, 20, 0, 48, 859, DateTimeKind.Unspecified).AddTicks(4413), 172 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 41, 34, 450, DateTimeKind.Unspecified).AddTicks(8536), 89 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 10, 25, 13, 47, 39, 33, DateTimeKind.Unspecified).AddTicks(7575), 93 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 54, 32, 473, DateTimeKind.Unspecified).AddTicks(862), 68 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 1, 20, 14, 23, 42, 100, DateTimeKind.Unspecified).AddTicks(3004), 39 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 23, 16, 52, 33, 837, DateTimeKind.Unspecified).AddTicks(3242), 115 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 4, 23, 22, 46, 1, 597, DateTimeKind.Unspecified).AddTicks(9230), 124 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 1, 2, 7, 12, 8, 859, DateTimeKind.Unspecified).AddTicks(7014), 48 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 8, 15, 52, 42, 522, DateTimeKind.Unspecified).AddTicks(3197), 70 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 17, 18, 0, 22, 442, DateTimeKind.Unspecified).AddTicks(4091), 192 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 22, 5, 13, 45, 317, DateTimeKind.Unspecified).AddTicks(8255), 60 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 5, 25, 6, 3, 21, 899, DateTimeKind.Unspecified).AddTicks(2851), 89 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 28, 21, 9, 41, 819, DateTimeKind.Unspecified).AddTicks(2034), 188 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 12, 28, 10, 7, 9, 406, DateTimeKind.Unspecified).AddTicks(3753), 180 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 12, 30, 22, 42, 26, 131, DateTimeKind.Unspecified).AddTicks(9333), 6 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 9, 15, 13, 9, 34, 246, DateTimeKind.Unspecified).AddTicks(8127), 60 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 5, 20, 5, 40, 17, 583, DateTimeKind.Unspecified).AddTicks(7363), 198 });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2020, 8, 18, 22, 0, 26, 22, DateTimeKind.Unspecified).AddTicks(4040), null, 177, 1 },
                    { 1, 10, new DateTime(2020, 10, 11, 2, 25, 34, 603, DateTimeKind.Unspecified).AddTicks(5587), null, 81, 1 },
                    { 2, 8, new DateTime(2022, 4, 9, 2, 45, 17, 24, DateTimeKind.Unspecified).AddTicks(3184), null, 25, 1 },
                    { 3, 5, new DateTime(2022, 10, 12, 14, 46, 1, 129, DateTimeKind.Unspecified).AddTicks(5299), null, 88, 1 },
                    { 3, 6, new DateTime(2020, 6, 17, 21, 7, 8, 432, DateTimeKind.Unspecified).AddTicks(1328), null, 87, 1 },
                    { 3, 10, new DateTime(2021, 7, 21, 22, 54, 18, 177, DateTimeKind.Unspecified).AddTicks(4594), null, 80, 1 },
                    { 4, 3, new DateTime(2021, 12, 24, 9, 25, 21, 865, DateTimeKind.Unspecified).AddTicks(4209), null, 189, 1 },
                    { 5, 6, new DateTime(2022, 1, 9, 20, 36, 19, 868, DateTimeKind.Unspecified).AddTicks(835), null, 36, 1 },
                    { 6, 2, new DateTime(2020, 6, 22, 8, 9, 41, 674, DateTimeKind.Unspecified).AddTicks(5270), null, 94, 1 },
                    { 6, 3, new DateTime(2020, 7, 25, 4, 53, 52, 287, DateTimeKind.Unspecified).AddTicks(2241), null, 43, 1 },
                    { 7, 4, new DateTime(2021, 7, 25, 13, 51, 25, 257, DateTimeKind.Unspecified).AddTicks(3686), null, 196, 1 },
                    { 7, 6, new DateTime(2022, 2, 25, 21, 20, 17, 865, DateTimeKind.Unspecified).AddTicks(4289), null, 12, 1 },
                    { 8, 6, new DateTime(2021, 5, 15, 6, 23, 23, 321, DateTimeKind.Unspecified).AddTicks(6882), null, 71, 1 },
                    { 9, 5, new DateTime(2021, 3, 14, 8, 27, 5, 770, DateTimeKind.Unspecified).AddTicks(829), null, 158, 1 },
                    { 10, 5, new DateTime(2021, 8, 5, 6, 34, 22, 626, DateTimeKind.Unspecified).AddTicks(404), null, 77, 1 },
                    { 11, 3, new DateTime(2022, 6, 25, 0, 32, 52, 989, DateTimeKind.Unspecified).AddTicks(5632), null, 118, 1 },
                    { 11, 8, new DateTime(2022, 11, 4, 3, 41, 55, 205, DateTimeKind.Unspecified).AddTicks(2189), null, 74, 1 },
                    { 12, 2, new DateTime(2021, 3, 5, 3, 50, 25, 299, DateTimeKind.Unspecified).AddTicks(6146), null, 143, 1 },
                    { 12, 4, new DateTime(2021, 8, 9, 22, 3, 38, 927, DateTimeKind.Unspecified).AddTicks(6415), null, 11, 1 },
                    { 12, 8, new DateTime(2022, 5, 28, 5, 4, 29, 123, DateTimeKind.Unspecified).AddTicks(237), null, 56, 1 },
                    { 13, 3, new DateTime(2021, 5, 25, 8, 55, 42, 262, DateTimeKind.Unspecified).AddTicks(6066), null, 138, 1 },
                    { 13, 8, new DateTime(2021, 11, 17, 16, 36, 25, 46, DateTimeKind.Unspecified).AddTicks(767), null, 118, 1 },
                    { 14, 3, new DateTime(2022, 9, 21, 19, 29, 19, 31, DateTimeKind.Unspecified).AddTicks(3724), null, 3, 1 },
                    { 15, 3, new DateTime(2021, 10, 10, 19, 39, 24, 259, DateTimeKind.Unspecified).AddTicks(6338), null, 104, 1 },
                    { 15, 7, new DateTime(2022, 8, 1, 22, 31, 50, 22, DateTimeKind.Unspecified).AddTicks(1855), null, 38, 1 },
                    { 15, 8, new DateTime(2021, 5, 13, 19, 51, 51, 981, DateTimeKind.Unspecified).AddTicks(5269), null, 53, 1 },
                    { 16, 3, new DateTime(2022, 3, 29, 20, 20, 45, 124, DateTimeKind.Unspecified).AddTicks(3414), null, 192, 1 },
                    { 17, 3, new DateTime(2021, 3, 26, 6, 42, 24, 702, DateTimeKind.Unspecified).AddTicks(6861), null, 56, 1 },
                    { 17, 9, new DateTime(2022, 1, 22, 22, 18, 52, 534, DateTimeKind.Unspecified).AddTicks(5143), null, 133, 1 },
                    { 18, 5, new DateTime(2021, 11, 30, 16, 14, 52, 342, DateTimeKind.Unspecified).AddTicks(7074), null, 119, 1 },
                    { 19, 5, new DateTime(2020, 3, 31, 8, 51, 51, 646, DateTimeKind.Unspecified).AddTicks(56), null, 52, 1 },
                    { 19, 6, new DateTime(2021, 7, 19, 7, 32, 55, 982, DateTimeKind.Unspecified).AddTicks(9085), null, 57, 1 },
                    { 20, 7, new DateTime(2021, 10, 1, 12, 42, 37, 800, DateTimeKind.Unspecified).AddTicks(2021), null, 153, 1 },
                    { 20, 10, new DateTime(2020, 11, 19, 8, 10, 28, 129, DateTimeKind.Unspecified).AddTicks(7436), null, 89, 1 },
                    { 21, 1, new DateTime(2020, 9, 28, 8, 28, 3, 526, DateTimeKind.Unspecified).AddTicks(8113), null, 158, 1 },
                    { 21, 2, new DateTime(2022, 1, 1, 2, 17, 39, 561, DateTimeKind.Unspecified).AddTicks(4635), null, 23, 1 },
                    { 21, 7, new DateTime(2020, 11, 14, 5, 4, 45, 127, DateTimeKind.Unspecified).AddTicks(2914), null, 137, 1 },
                    { 21, 10, new DateTime(2020, 6, 11, 10, 55, 48, 891, DateTimeKind.Unspecified).AddTicks(1959), null, 151, 1 },
                    { 22, 2, new DateTime(2022, 12, 14, 5, 25, 44, 11, DateTimeKind.Unspecified).AddTicks(8691), null, 146, 1 },
                    { 22, 9, new DateTime(2020, 4, 29, 16, 40, 16, 370, DateTimeKind.Unspecified).AddTicks(7728), null, 183, 1 },
                    { 22, 10, new DateTime(2022, 11, 8, 22, 38, 57, 196, DateTimeKind.Unspecified).AddTicks(9537), null, 148, 1 },
                    { 23, 10, new DateTime(2020, 9, 21, 0, 32, 55, 23, DateTimeKind.Unspecified).AddTicks(8764), null, 52, 1 },
                    { 24, 2, new DateTime(2022, 3, 31, 16, 25, 43, 32, DateTimeKind.Unspecified).AddTicks(9533), null, 6, 1 },
                    { 24, 7, new DateTime(2020, 12, 16, 17, 54, 9, 510, DateTimeKind.Unspecified).AddTicks(9320), null, 141, 1 },
                    { 24, 8, new DateTime(2020, 12, 16, 16, 43, 32, 599, DateTimeKind.Unspecified).AddTicks(7796), null, 35, 1 },
                    { 24, 9, new DateTime(2022, 11, 20, 8, 36, 47, 401, DateTimeKind.Unspecified).AddTicks(1688), null, 12, 1 },
                    { 24, 10, new DateTime(2022, 7, 14, 3, 5, 35, 889, DateTimeKind.Unspecified).AddTicks(152), null, 109, 1 },
                    { 25, 1, new DateTime(2021, 12, 5, 22, 43, 47, 709, DateTimeKind.Unspecified).AddTicks(8642), null, 118, 1 },
                    { 25, 4, new DateTime(2023, 1, 3, 19, 50, 5, 464, DateTimeKind.Unspecified).AddTicks(3918), null, 63, 1 },
                    { 25, 5, new DateTime(2020, 11, 28, 1, 57, 39, 742, DateTimeKind.Unspecified).AddTicks(5715), null, 47, 1 },
                    { 25, 7, new DateTime(2021, 9, 12, 9, 10, 45, 106, DateTimeKind.Unspecified).AddTicks(8453), null, 57, 1 },
                    { 26, 10, new DateTime(2020, 7, 8, 3, 40, 22, 482, DateTimeKind.Unspecified).AddTicks(7629), null, 116, 1 },
                    { 27, 2, new DateTime(2022, 7, 28, 1, 23, 21, 891, DateTimeKind.Unspecified).AddTicks(3734), null, 107, 1 },
                    { 27, 3, new DateTime(2020, 10, 4, 6, 40, 43, 228, DateTimeKind.Unspecified).AddTicks(1578), null, 144, 1 },
                    { 28, 5, new DateTime(2022, 2, 17, 21, 51, 49, 492, DateTimeKind.Unspecified).AddTicks(956), null, 120, 1 },
                    { 28, 9, new DateTime(2021, 2, 6, 3, 56, 14, 40, DateTimeKind.Unspecified).AddTicks(2396), null, 120, 1 },
                    { 30, 3, new DateTime(2022, 11, 28, 6, 45, 47, 224, DateTimeKind.Unspecified).AddTicks(7223), null, 71, 1 },
                    { 30, 4, new DateTime(2020, 5, 4, 19, 20, 36, 734, DateTimeKind.Unspecified).AddTicks(4769), null, 46, 1 },
                    { 30, 6, new DateTime(2020, 4, 15, 10, 3, 13, 210, DateTimeKind.Unspecified).AddTicks(8857), null, 12, 1 },
                    { 30, 8, new DateTime(2020, 8, 10, 5, 10, 12, 659, DateTimeKind.Unspecified).AddTicks(9802), null, 112, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "83550 Dach Lodge, Gisselleville, Gabon", "Feeney - Armstrong", new DateTime(2021, 12, 10, 21, 32, 24, 322, DateTimeKind.Unspecified).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "938 Teagan Expressway, Port Jeraldfurt, Nicaragua", "Feest Inc", new DateTime(2022, 5, 2, 11, 39, 28, 311, DateTimeKind.Unspecified).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "8489 Dejuan Orchard, North Jessika, Cuba", "Breitenberg, Ernser and Beer", new DateTime(2022, 11, 26, 15, 21, 35, 7, DateTimeKind.Unspecified).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "1709 Boehm Bypass, Mitchelbury, Suriname", "Carroll, Hyatt and Morissette", new DateTime(2021, 2, 4, 13, 5, 53, 273, DateTimeKind.Unspecified).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "7787 Andre Stream, East Rogerberg, American Samoa", "Jaskolski, Beer and Aufderhar", new DateTime(2022, 10, 13, 1, 53, 33, 225, DateTimeKind.Unspecified).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "206 Rosella Field, Port Adellfort, Azerbaijan", "Gislason LLC", new DateTime(2021, 12, 8, 17, 56, 51, 104, DateTimeKind.Unspecified).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "4484 Elwin Corner, Milesland, Peru", "Kuhn LLC", new DateTime(2022, 8, 30, 11, 33, 1, 624, DateTimeKind.Unspecified).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "643 Ortiz Walks, Alyciahaven, Oman", "Jacobson, Leffler and Crooks", new DateTime(2021, 2, 12, 23, 25, 46, 573, DateTimeKind.Unspecified).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "3533 Joanie Loaf, South Angelina, El Salvador", "Watsica and Sons", new DateTime(2022, 6, 30, 20, 53, 35, 939, DateTimeKind.Unspecified).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "03383 Katelyn Mall, Ivahbury, French Polynesia", "Green - Heidenreich", new DateTime(2021, 8, 13, 6, 45, 58, 755, DateTimeKind.Unspecified).AddTicks(6) });
        }
    }
}
