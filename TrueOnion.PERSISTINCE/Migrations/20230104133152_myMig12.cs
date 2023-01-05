using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrueOnion.PERSISTINCE.Migrations
{
    /// <inheritdoc />
    public partial class myMig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 5 });

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
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 9 });

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
                keyValues: new object[] { 1, 5 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2021, 9, 14, 19, 24, 10, 629, DateTimeKind.Unspecified).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2021, 7, 16, 5, 52, 12, 397, DateTimeKind.Unspecified).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 10 },
                columns: new[] { "Id", "InsertedDate" },
                values: new object[] { 0, new DateTime(2022, 5, 15, 12, 59, 50, 989, DateTimeKind.Unspecified).AddTicks(9442) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Id", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2022, 1, 5, 18, 3, 7, 496, DateTimeKind.Unspecified).AddTicks(875), null, 1 },
                    { 2, 1, 0, new DateTime(2020, 10, 20, 21, 54, 59, 422, DateTimeKind.Unspecified).AddTicks(309), null, 1 },
                    { 2, 2, 0, new DateTime(2021, 6, 12, 23, 27, 17, 229, DateTimeKind.Unspecified).AddTicks(8927), null, 1 },
                    { 1, 6, 0, new DateTime(2022, 9, 1, 11, 14, 45, 588, DateTimeKind.Unspecified).AddTicks(5594), null, 1 },
                    { 1, 7, 0, new DateTime(2021, 10, 30, 17, 59, 35, 997, DateTimeKind.Unspecified).AddTicks(3330), null, 1 },
                    { 2, 7, 0, new DateTime(2021, 8, 22, 20, 45, 3, 930, DateTimeKind.Unspecified).AddTicks(9574), null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2e542f7e-d7fc-4304-87ce-4742da800be5", "Elena28@hotmail.com", true, new DateTime(2020, 4, 2, 4, 58, 37, 548, DateTimeKind.Unspecified).AddTicks(9759), "ELENA28@HOTMAIL.COM", "GLENNA43", "tn8TPVIHg6", "(333) 726-6309 x401", "cUkJrHcTkA", "Glenna43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2fe69709-cc4b-4c5d-9b20-35e32302d2c2", "Maryjane7@gmail.com", true, new DateTime(2021, 9, 7, 3, 5, 27, 927, DateTimeKind.Unspecified).AddTicks(2011), "MARYJANE7@GMAIL.COM", "MATHEW_BECKER16", "MrSX90DUyU", "1-609-701-4736 x08106", "N5Ne8zjHqP", "Mathew_Becker16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4b1f5cb8-60a3-40d5-b275-0f02e7c4e772", "Alexzander_Will97@gmail.com", true, new DateTime(2021, 11, 17, 7, 21, 52, 259, DateTimeKind.Unspecified).AddTicks(9950), "ALEXZANDER_WILL97@GMAIL.COM", "FERNANDO60", "oU2SZebZ_o", "(406) 253-6925", "JQtMQi14A1", "Fernando60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80b98c6d-dfd5-4ec2-a78c-5b60f5136e68", "Jamil.Ernser@gmail.com", true, new DateTime(2021, 6, 3, 12, 33, 12, 450, DateTimeKind.Unspecified).AddTicks(6133), "JAMIL.ERNSER@GMAIL.COM", "ZELLA.SANFORD98", "OBpn6uOyTw", "278-498-4421", "1gqrep7ffQ", "Zella.Sanford98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80eb2788-67fe-4dbf-8f6f-82e1feca74c2", "Annetta.Wilkinson40@gmail.com", true, new DateTime(2021, 7, 10, 6, 28, 36, 67, DateTimeKind.Unspecified).AddTicks(3207), "ANNETTA.WILKINSON40@GMAIL.COM", "SHAYNA49", "14MYSdEeq8", "753-355-1189 x174", "pBxNpvXfHw", "Shayna49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5352e0e9-8400-49ba-bb7d-6cb2fbabb4aa", "Godfrey.Hahn47@gmail.com", true, new DateTime(2020, 9, 15, 2, 40, 39, 961, DateTimeKind.Unspecified).AddTicks(9351), "GODFREY.HAHN47@GMAIL.COM", "MARTINE_KOZEY1", "7IymD7_dHX", "344-705-0445 x808", "Mhi6qY1yvA", "Martine_Kozey1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e658c302-3578-48d8-a90e-5ce8308cffdc", "Carmela.Volkman12@yahoo.com", true, new DateTime(2022, 8, 13, 22, 42, 59, 757, DateTimeKind.Unspecified).AddTicks(4110), "CARMELA.VOLKMAN12@YAHOO.COM", "MERVIN.LANGOSH", "zFSsXqUpUT", "404-608-8791", "PKO9Ed46vU", "Mervin.Langosh" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "b48c284f-fcb6-42bc-95b6-8da75a177de6", "Austyn38@gmail.com", true, new DateTime(2022, 12, 1, 14, 4, 24, 275, DateTimeKind.Unspecified).AddTicks(3970), "AUSTYN38@GMAIL.COM", "VANESSA_RODRIGUEZ", "0HelwEAlRA", "1-352-610-4779", "rKMRzBv7qy", "Vanessa_Rodriguez" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43fcb6eb-2516-49cd-b5b4-46ff7d276786", "Larue80@hotmail.com", true, new DateTime(2021, 9, 4, 3, 29, 11, 376, DateTimeKind.Unspecified).AddTicks(5975), "LARUE80@HOTMAIL.COM", "MYRIAM_GUTKOWSKI51", "XqWrieGryv", "(690) 774-4475 x07750", "AX3EMPXme5", "Myriam_Gutkowski51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "16d94b44-c4b1-46c4-ae9d-a80d36d28d4b", "Hubert_Mraz50@hotmail.com", true, new DateTime(2021, 3, 3, 18, 56, 14, 102, DateTimeKind.Unspecified).AddTicks(4217), "HUBERT_MRAZ50@HOTMAIL.COM", "CLIFFORD.ONDRICKA", "qah9nycayY", "1-327-845-1507 x8404", "jewEANvxfP", "Clifford.Ondricka" });

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
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Computers", new DateTime(2022, 12, 17, 12, 18, 38, 916, DateTimeKind.Unspecified).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Outdoors", new DateTime(2022, 1, 23, 7, 22, 27, 347, DateTimeKind.Unspecified).AddTicks(7312) });

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
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Shoes", new DateTime(2022, 11, 15, 2, 9, 33, 928, DateTimeKind.Unspecified).AddTicks(9519) });

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
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Grocery", new DateTime(2020, 7, 1, 0, 23, 28, 782, DateTimeKind.Unspecified).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Computers", new DateTime(2020, 10, 17, 4, 20, 2, 316, DateTimeKind.Unspecified).AddTicks(2065), 4 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 3, new DateTime(2021, 11, 5, 20, 40, 5, 451, DateTimeKind.Unspecified).AddTicks(9138), "Generic Frozen Salad", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 2, new DateTime(2022, 7, 26, 21, 22, 24, 676, DateTimeKind.Unspecified).AddTicks(3801), "Unbranded Metal Ball", 136 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 8, 30, 3, 59, 30, 551, DateTimeKind.Unspecified).AddTicks(7332), "Generic Concrete Mouse", 57m, 16 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2021, 9, 14, 6, 6, 16, 906, DateTimeKind.Unspecified).AddTicks(5470), "Small Metal Tuna", 167 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 7, new DateTime(2021, 4, 2, 19, 29, 39, 451, DateTimeKind.Unspecified).AddTicks(2001), "Handcrafted Metal Shoes", 71 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 8, 9, 5, 54, 50, 325, DateTimeKind.Unspecified).AddTicks(3234), "Licensed Fresh Cheese", 57m, 62 });

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
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2020, 5, 25, 17, 0, 51, 512, DateTimeKind.Unspecified).AddTicks(4664), "Unbranded Steel Bacon", 50m, 41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 6, 30, 13, 32, 4, 83, DateTimeKind.Unspecified).AddTicks(9415), "Generic Steel Ball", 49m, 161 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 6, 7, 1, 41, 41, 718, DateTimeKind.Unspecified).AddTicks(9991), "Licensed Concrete Sausages", 52m, 72 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 5, 12, 21, 8, 24, 394, DateTimeKind.Unspecified).AddTicks(9695), "Refined Frozen Pizza", 57m, 169 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 6, 23, 20, 10, 45, 156, DateTimeKind.Unspecified).AddTicks(7814), "Awesome Concrete Sausages", 56m, 94 });

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
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 8, new DateTime(2021, 6, 18, 4, 42, 36, 633, DateTimeKind.Unspecified).AddTicks(8151), "Unbranded Plastic Pants", 138 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 5, 22, 8, 54, 41, 492, DateTimeKind.Unspecified).AddTicks(6649), "Ergonomic Rubber Cheese", 57m, 73 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 11, 2, 25, 34, 603, DateTimeKind.Unspecified).AddTicks(5587), 81 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 10, 12, 14, 46, 1, 129, DateTimeKind.Unspecified).AddTicks(5299), 88 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 21, 22, 54, 18, 177, DateTimeKind.Unspecified).AddTicks(4594), 80 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 12, 24, 9, 25, 21, 865, DateTimeKind.Unspecified).AddTicks(4209), 189 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 25, 4, 53, 52, 287, DateTimeKind.Unspecified).AddTicks(2241), 43 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 2, 25, 21, 20, 17, 865, DateTimeKind.Unspecified).AddTicks(4289), 12 });

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
                keyValues: new object[] { 12, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 8, 9, 22, 3, 38, 927, DateTimeKind.Unspecified).AddTicks(6415), 11 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 6, 26, 20, 0, 48, 859, DateTimeKind.Unspecified).AddTicks(4413), 172 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 10, 10, 19, 39, 24, 259, DateTimeKind.Unspecified).AddTicks(6338), 104 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 8, 1, 22, 31, 50, 22, DateTimeKind.Unspecified).AddTicks(1855), 38 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 54, 32, 473, DateTimeKind.Unspecified).AddTicks(862), 68 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 3, 26, 6, 42, 24, 702, DateTimeKind.Unspecified).AddTicks(6861), 56 });

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
                keyValues: new object[] { 19, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 19, 7, 32, 55, 982, DateTimeKind.Unspecified).AddTicks(9085), 57 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 9, 28, 8, 28, 3, 526, DateTimeKind.Unspecified).AddTicks(8113), 158 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 1, 2, 7, 12, 8, 859, DateTimeKind.Unspecified).AddTicks(7014), 48 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 29, 16, 40, 16, 370, DateTimeKind.Unspecified).AddTicks(7728), 183 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 8, 15, 52, 42, 522, DateTimeKind.Unspecified).AddTicks(3197), 70 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 7, 14, 3, 5, 35, 889, DateTimeKind.Unspecified).AddTicks(152), 109 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2023, 1, 3, 19, 50, 5, 464, DateTimeKind.Unspecified).AddTicks(3918), 63 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 7, 22, 5, 13, 45, 317, DateTimeKind.Unspecified).AddTicks(8255), 60 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 4, 6, 40, 43, 228, DateTimeKind.Unspecified).AddTicks(1578), 144 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 28, 21, 9, 41, 819, DateTimeKind.Unspecified).AddTicks(2034), 188 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 2, 17, 21, 51, 49, 492, DateTimeKind.Unspecified).AddTicks(956), 120 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 12, 30, 22, 42, 26, 131, DateTimeKind.Unspecified).AddTicks(9333), 6 });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2020, 8, 18, 22, 0, 26, 22, DateTimeKind.Unspecified).AddTicks(4040), null, 177, 1 },
                    { 1, 9, new DateTime(2022, 1, 10, 16, 59, 15, 740, DateTimeKind.Unspecified).AddTicks(9626), null, 152, 1 },
                    { 2, 5, new DateTime(2020, 7, 12, 18, 52, 31, 976, DateTimeKind.Unspecified).AddTicks(1456), null, 151, 1 },
                    { 2, 8, new DateTime(2022, 4, 9, 2, 45, 17, 24, DateTimeKind.Unspecified).AddTicks(3184), null, 25, 1 },
                    { 2, 10, new DateTime(2021, 2, 28, 0, 35, 58, 593, DateTimeKind.Unspecified).AddTicks(3120), null, 109, 1 },
                    { 3, 6, new DateTime(2020, 6, 17, 21, 7, 8, 432, DateTimeKind.Unspecified).AddTicks(1328), null, 87, 1 },
                    { 4, 6, new DateTime(2022, 3, 1, 6, 21, 7, 177, DateTimeKind.Unspecified).AddTicks(5435), null, 60, 1 },
                    { 5, 2, new DateTime(2022, 12, 8, 4, 44, 40, 522, DateTimeKind.Unspecified).AddTicks(8674), null, 3, 1 },
                    { 5, 6, new DateTime(2022, 1, 9, 20, 36, 19, 868, DateTimeKind.Unspecified).AddTicks(835), null, 36, 1 },
                    { 6, 2, new DateTime(2020, 6, 22, 8, 9, 41, 674, DateTimeKind.Unspecified).AddTicks(5270), null, 94, 1 },
                    { 7, 4, new DateTime(2021, 7, 25, 13, 51, 25, 257, DateTimeKind.Unspecified).AddTicks(3686), null, 196, 1 },
                    { 7, 7, new DateTime(2021, 3, 10, 19, 27, 53, 113, DateTimeKind.Unspecified).AddTicks(1106), null, 19, 1 },
                    { 8, 6, new DateTime(2021, 5, 15, 6, 23, 23, 321, DateTimeKind.Unspecified).AddTicks(6882), null, 71, 1 },
                    { 9, 5, new DateTime(2021, 3, 14, 8, 27, 5, 770, DateTimeKind.Unspecified).AddTicks(829), null, 158, 1 },
                    { 10, 5, new DateTime(2021, 8, 5, 6, 34, 22, 626, DateTimeKind.Unspecified).AddTicks(404), null, 77, 1 },
                    { 11, 3, new DateTime(2022, 6, 25, 0, 32, 52, 989, DateTimeKind.Unspecified).AddTicks(5632), null, 118, 1 },
                    { 11, 8, new DateTime(2022, 11, 4, 3, 41, 55, 205, DateTimeKind.Unspecified).AddTicks(2189), null, 74, 1 },
                    { 12, 2, new DateTime(2021, 3, 5, 3, 50, 25, 299, DateTimeKind.Unspecified).AddTicks(6146), null, 143, 1 },
                    { 12, 8, new DateTime(2022, 5, 28, 5, 4, 29, 123, DateTimeKind.Unspecified).AddTicks(237), null, 56, 1 },
                    { 13, 3, new DateTime(2021, 5, 25, 8, 55, 42, 262, DateTimeKind.Unspecified).AddTicks(6066), null, 138, 1 },
                    { 13, 8, new DateTime(2021, 11, 17, 16, 36, 25, 46, DateTimeKind.Unspecified).AddTicks(767), null, 118, 1 },
                    { 14, 3, new DateTime(2022, 9, 21, 19, 29, 19, 31, DateTimeKind.Unspecified).AddTicks(3724), null, 3, 1 },
                    { 15, 5, new DateTime(2022, 7, 9, 20, 41, 34, 450, DateTimeKind.Unspecified).AddTicks(8536), null, 89, 1 },
                    { 15, 6, new DateTime(2022, 10, 25, 13, 47, 39, 33, DateTimeKind.Unspecified).AddTicks(7575), null, 93, 1 },
                    { 15, 8, new DateTime(2021, 5, 13, 19, 51, 51, 981, DateTimeKind.Unspecified).AddTicks(5269), null, 53, 1 },
                    { 16, 3, new DateTime(2022, 3, 29, 20, 20, 45, 124, DateTimeKind.Unspecified).AddTicks(3414), null, 192, 1 },
                    { 17, 9, new DateTime(2022, 1, 22, 22, 18, 52, 534, DateTimeKind.Unspecified).AddTicks(5143), null, 133, 1 },
                    { 18, 5, new DateTime(2021, 11, 30, 16, 14, 52, 342, DateTimeKind.Unspecified).AddTicks(7074), null, 119, 1 },
                    { 19, 4, new DateTime(2022, 4, 23, 22, 46, 1, 597, DateTimeKind.Unspecified).AddTicks(9230), null, 124, 1 },
                    { 19, 5, new DateTime(2020, 3, 31, 8, 51, 51, 646, DateTimeKind.Unspecified).AddTicks(56), null, 52, 1 },
                    { 20, 7, new DateTime(2021, 10, 1, 12, 42, 37, 800, DateTimeKind.Unspecified).AddTicks(2021), null, 153, 1 },
                    { 20, 10, new DateTime(2020, 11, 19, 8, 10, 28, 129, DateTimeKind.Unspecified).AddTicks(7436), null, 89, 1 },
                    { 21, 2, new DateTime(2022, 1, 1, 2, 17, 39, 561, DateTimeKind.Unspecified).AddTicks(4635), null, 23, 1 },
                    { 21, 7, new DateTime(2020, 11, 14, 5, 4, 45, 127, DateTimeKind.Unspecified).AddTicks(2914), null, 137, 1 },
                    { 21, 10, new DateTime(2020, 6, 11, 10, 55, 48, 891, DateTimeKind.Unspecified).AddTicks(1959), null, 151, 1 },
                    { 22, 2, new DateTime(2022, 12, 14, 5, 25, 44, 11, DateTimeKind.Unspecified).AddTicks(8691), null, 146, 1 },
                    { 22, 10, new DateTime(2022, 11, 8, 22, 38, 57, 196, DateTimeKind.Unspecified).AddTicks(9537), null, 148, 1 },
                    { 23, 10, new DateTime(2020, 9, 21, 0, 32, 55, 23, DateTimeKind.Unspecified).AddTicks(8764), null, 52, 1 },
                    { 24, 2, new DateTime(2022, 3, 31, 16, 25, 43, 32, DateTimeKind.Unspecified).AddTicks(9533), null, 6, 1 },
                    { 24, 6, new DateTime(2020, 4, 17, 18, 0, 22, 442, DateTimeKind.Unspecified).AddTicks(4091), null, 192, 1 },
                    { 24, 7, new DateTime(2020, 12, 16, 17, 54, 9, 510, DateTimeKind.Unspecified).AddTicks(9320), null, 141, 1 },
                    { 24, 8, new DateTime(2020, 12, 16, 16, 43, 32, 599, DateTimeKind.Unspecified).AddTicks(7796), null, 35, 1 },
                    { 24, 9, new DateTime(2022, 11, 20, 8, 36, 47, 401, DateTimeKind.Unspecified).AddTicks(1688), null, 12, 1 },
                    { 25, 1, new DateTime(2021, 12, 5, 22, 43, 47, 709, DateTimeKind.Unspecified).AddTicks(8642), null, 118, 1 },
                    { 25, 5, new DateTime(2020, 11, 28, 1, 57, 39, 742, DateTimeKind.Unspecified).AddTicks(5715), null, 47, 1 },
                    { 25, 7, new DateTime(2021, 9, 12, 9, 10, 45, 106, DateTimeKind.Unspecified).AddTicks(8453), null, 57, 1 },
                    { 26, 10, new DateTime(2020, 7, 8, 3, 40, 22, 482, DateTimeKind.Unspecified).AddTicks(7629), null, 116, 1 },
                    { 27, 2, new DateTime(2022, 7, 28, 1, 23, 21, 891, DateTimeKind.Unspecified).AddTicks(3734), null, 107, 1 },
                    { 27, 7, new DateTime(2021, 5, 25, 6, 3, 21, 899, DateTimeKind.Unspecified).AddTicks(2851), null, 89, 1 },
                    { 28, 6, new DateTime(2021, 12, 28, 10, 7, 9, 406, DateTimeKind.Unspecified).AddTicks(3753), null, 180, 1 },
                    { 28, 9, new DateTime(2021, 2, 6, 3, 56, 14, 40, DateTimeKind.Unspecified).AddTicks(2396), null, 120, 1 },
                    { 29, 10, new DateTime(2021, 9, 15, 13, 9, 34, 246, DateTimeKind.Unspecified).AddTicks(8127), null, 60, 1 },
                    { 30, 2, new DateTime(2022, 5, 20, 5, 40, 17, 583, DateTimeKind.Unspecified).AddTicks(7363), null, 198, 1 },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 5, 2 });

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
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 7 });

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
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 6 });

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
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 5 });

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
                keyValues: new object[] { 24, 6 });

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
                keyValues: new object[] { 25, 1 });

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
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 30, 2 });

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
                value: new DateTime(2023, 1, 2, 17, 11, 12, 492, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 2, 17, 11, 12, 492, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertedDate",
                value: new DateTime(2023, 1, 2, 17, 11, 12, 492, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 5 },
                column: "InsertedDate",
                value: new DateTime(2022, 12, 19, 23, 17, 29, 38, DateTimeKind.Unspecified).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 },
                column: "InsertedDate",
                value: new DateTime(2020, 5, 7, 17, 23, 28, 101, DateTimeKind.Unspecified).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 10 },
                column: "InsertedDate",
                value: new DateTime(2022, 8, 19, 1, 42, 10, 551, DateTimeKind.Unspecified).AddTicks(56));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "InsertedDate", "LastModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 4, 4, 1, 37, 19, 823, DateTimeKind.Unspecified).AddTicks(1984), null, 1 },
                    { 1, 3, new DateTime(2020, 9, 8, 0, 33, 7, 330, DateTimeKind.Unspecified).AddTicks(3106), null, 1 },
                    { 2, 3, new DateTime(2020, 4, 2, 16, 23, 9, 817, DateTimeKind.Unspecified).AddTicks(4738), null, 1 },
                    { 2, 5, new DateTime(2021, 7, 19, 17, 12, 46, 320, DateTimeKind.Unspecified).AddTicks(1398), null, 1 },
                    { 3, 7, new DateTime(2021, 7, 7, 8, 25, 59, 88, DateTimeKind.Unspecified).AddTicks(6190), null, 1 },
                    { 2, 9, new DateTime(2022, 10, 30, 0, 52, 57, 84, DateTimeKind.Unspecified).AddTicks(6419), null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d1841ee7-a849-4d96-8947-9eb4d9aa6e40", "Nicole.Kohler@gmail.com", false, new DateTime(2021, 5, 2, 9, 8, 24, 68, DateTimeKind.Unspecified).AddTicks(7630), "NICOLE.KOHLER@GMAIL.COM", "TRINITY_BRAKUS87", "IZktMP1DPe", "1-637-568-1747 x23606", null, "Trinity_Brakus87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "426e7c22-df59-4e4f-a132-dc1df543a91e", "Griffin26@yahoo.com", false, new DateTime(2022, 6, 2, 12, 32, 2, 103, DateTimeKind.Unspecified).AddTicks(1418), "GRIFFIN26@YAHOO.COM", "SCOTTY.WHITE9", "AkNak_lbzf", "(383) 976-0447", null, "Scotty.White9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a9167273-5f89-4f47-b9cb-d2bf47bd98f8", "Jeffry.Smith59@yahoo.com", false, new DateTime(2020, 9, 11, 7, 0, 54, 475, DateTimeKind.Unspecified).AddTicks(8210), "JEFFRY.SMITH59@YAHOO.COM", "REYNA.GLOVER25", "I6nyKcSXwl", "(254) 411-4114 x8987", null, "Reyna.Glover25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7c140cd4-a1b7-426a-ae86-90fdbff1f3c9", "Finn_Rempel46@hotmail.com", false, new DateTime(2021, 6, 15, 20, 34, 45, 307, DateTimeKind.Unspecified).AddTicks(6490), "FINN_REMPEL46@HOTMAIL.COM", "GINO_HAND", "J1v4kLqSkc", "681-983-8468 x634", null, "Gino_Hand" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "401ccde3-de8d-4611-884d-aa9efb1b7e5e", "Gabe87@gmail.com", false, new DateTime(2022, 3, 17, 20, 15, 52, 98, DateTimeKind.Unspecified).AddTicks(8734), "GABE87@GMAIL.COM", "HERMAN93", "1yY12no_IU", "1-215-870-6863", null, "Herman93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e0eb8d98-b828-49bd-8d42-d122631e462b", "Concepcion28@yahoo.com", false, new DateTime(2022, 2, 24, 21, 3, 46, 186, DateTimeKind.Unspecified).AddTicks(5879), "CONCEPCION28@YAHOO.COM", "KIERAN.JAKUBOWSKI", "FWnATtx5yT", "1-433-759-6343", null, "Kieran.Jakubowski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e3f055e9-ac31-4fb4-b108-97c1d366f2d5", "Ewald19@gmail.com", false, new DateTime(2021, 12, 15, 10, 54, 38, 372, DateTimeKind.Unspecified).AddTicks(2205), "EWALD19@GMAIL.COM", "IVORY71", "4gly2BYZ7t", "332.336.7090", null, "Ivory71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d82895d3-9c4e-4c49-8a76-20ad02ab3531", "Tyrique5@gmail.com", false, new DateTime(2022, 4, 25, 23, 44, 15, 520, DateTimeKind.Unspecified).AddTicks(6761), "TYRIQUE5@GMAIL.COM", "DARWIN_THOMPSON98", "Q93WyQUi4I", "671.226.4983", null, "Darwin_Thompson98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2784c652-b036-4571-b4d6-c11938e3f650", "Dora50@yahoo.com", false, new DateTime(2022, 12, 26, 3, 55, 52, 989, DateTimeKind.Unspecified).AddTicks(4608), "DORA50@YAHOO.COM", "DANGELO_KLOCKO34", "Je1KUvzuu0", "(335) 256-6573 x4263", null, "Dangelo_Klocko34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "InsertedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9c08684d-2d7f-463f-aaf7-e710410b31cc", "Novella68@gmail.com", false, new DateTime(2022, 6, 22, 21, 4, 20, 943, DateTimeKind.Unspecified).AddTicks(616), "NOVELLA68@GMAIL.COM", "SAIGE_WOLFF77", "m_TEqhl2JM", "(475) 788-0281", null, "Saige_Wolff77" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertedDate",
                value: new DateTime(2021, 4, 14, 8, 32, 20, 182, DateTimeKind.Unspecified).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Computers", new DateTime(2022, 5, 4, 23, 4, 28, 561, DateTimeKind.Unspecified).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Tools", new DateTime(2020, 6, 16, 7, 30, 19, 57, DateTimeKind.Unspecified).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Baby", new DateTime(2021, 10, 26, 6, 1, 38, 26, DateTimeKind.Unspecified).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Music", new DateTime(2021, 6, 13, 20, 41, 47, 655, DateTimeKind.Unspecified).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Garden", new DateTime(2020, 5, 7, 6, 58, 0, 861, DateTimeKind.Unspecified).AddTicks(5275), 5 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Electronics", new DateTime(2022, 2, 1, 6, 53, 55, 553, DateTimeKind.Unspecified).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Health", new DateTime(2020, 4, 8, 8, 42, 12, 751, DateTimeKind.Unspecified).AddTicks(1580), 5 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "InsertedDate" },
                values: new object[] { "Movies", new DateTime(2021, 1, 5, 19, 21, 34, 67, DateTimeKind.Unspecified).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "InsertedDate", "ParentID" },
                values: new object[] { "Music", new DateTime(2021, 1, 13, 12, 42, 3, 812, DateTimeKind.Unspecified).AddTicks(1505), 8 });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 18, 5, 9, 56, 859, DateTimeKind.Unspecified).AddTicks(488), "Papua New Guinea", new DateTime(2022, 5, 19, 10, 34, 42, 131, DateTimeKind.Unspecified).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 4, 24, 5, 36, 44, 146, DateTimeKind.Unspecified).AddTicks(2481), "El Salvador", new DateTime(2021, 7, 6, 0, 45, 20, 334, DateTimeKind.Unspecified).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 5, 28, 8, 31, 9, 374, DateTimeKind.Unspecified).AddTicks(659), "Slovakia (Slovak Republic)", new DateTime(2021, 2, 28, 13, 57, 54, 813, DateTimeKind.Unspecified).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 2, 5, 7, 36, 51, 936, DateTimeKind.Unspecified).AddTicks(6343), "Comoros", new DateTime(2020, 11, 15, 0, 17, 36, 938, DateTimeKind.Unspecified).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 8, 6, 24, 7, 360, DateTimeKind.Unspecified).AddTicks(6815), "Guernsey", new DateTime(2022, 1, 12, 20, 41, 31, 828, DateTimeKind.Unspecified).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 20, 12, 22, 34, 920, DateTimeKind.Unspecified).AddTicks(5991), "Congo", new DateTime(2020, 6, 2, 14, 7, 45, 249, DateTimeKind.Unspecified).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 24, 1, 35, 55, 78, DateTimeKind.Unspecified).AddTicks(8742), "Uruguay", new DateTime(2021, 8, 24, 3, 10, 49, 858, DateTimeKind.Unspecified).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 8, 2, 10, 8, 19, 493, DateTimeKind.Unspecified).AddTicks(5383), "Antarctica (the territory South of 60 deg S)", new DateTime(2021, 10, 29, 11, 22, 22, 614, DateTimeKind.Unspecified).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 3, 15, 13, 31, 53, 301, DateTimeKind.Unspecified).AddTicks(4320), "Mali", new DateTime(2020, 5, 30, 5, 17, 15, 894, DateTimeKind.Unspecified).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 6, 29, 23, 3, 42, 966, DateTimeKind.Unspecified).AddTicks(1436), "Saint Kitts and Nevis", new DateTime(2021, 11, 17, 13, 49, 39, 571, DateTimeKind.Unspecified).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 9, 29, 22, 9, 13, 132, DateTimeKind.Unspecified).AddTicks(3864), "Bolivia", new DateTime(2022, 2, 23, 20, 46, 17, 813, DateTimeKind.Unspecified).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 3, 19, 9, 19, 15, 550, DateTimeKind.Unspecified).AddTicks(1448), "Netherlands Antilles", new DateTime(2021, 1, 12, 14, 1, 54, 444, DateTimeKind.Unspecified).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 3, 9, 18, 35, 56, 242, DateTimeKind.Unspecified).AddTicks(7409), "Democratic People's Republic of Korea", new DateTime(2020, 8, 1, 22, 24, 25, 638, DateTimeKind.Unspecified).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 9, 27, 8, 32, 24, 114, DateTimeKind.Unspecified).AddTicks(5264), "Bermuda", new DateTime(2021, 3, 3, 12, 16, 10, 787, DateTimeKind.Unspecified).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 11, 20, 8, 37, 45, 62, DateTimeKind.Unspecified).AddTicks(828), "Sri Lanka", new DateTime(2022, 10, 23, 21, 26, 44, 861, DateTimeKind.Unspecified).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 8, 29, 15, 4, 19, 789, DateTimeKind.Unspecified).AddTicks(7459), "Equatorial Guinea", new DateTime(2021, 7, 13, 14, 51, 27, 586, DateTimeKind.Unspecified).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 9, 22, 22, 32, 54, 703, DateTimeKind.Unspecified).AddTicks(1698), "Puerto Rico", new DateTime(2020, 7, 8, 21, 28, 5, 856, DateTimeKind.Unspecified).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 3, 22, 9, 55, 28, 177, DateTimeKind.Unspecified).AddTicks(6938), "Brazil", new DateTime(2022, 11, 6, 17, 24, 15, 751, DateTimeKind.Unspecified).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 5, 28, 12, 0, 52, 330, DateTimeKind.Unspecified).AddTicks(1255), "Bhutan", new DateTime(2022, 7, 1, 8, 21, 0, 92, DateTimeKind.Unspecified).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 9, 23, 5, 26, 4, 34, DateTimeKind.Unspecified).AddTicks(5135), "Guadeloupe", new DateTime(2022, 6, 4, 8, 1, 59, 10, DateTimeKind.Unspecified).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 12, 23, 1, 7, 24, 550, DateTimeKind.Unspecified).AddTicks(4402), "Togo", new DateTime(2021, 6, 28, 7, 43, 38, 309, DateTimeKind.Unspecified).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 4, 14, 17, 0, 41, 612, DateTimeKind.Unspecified).AddTicks(90), "El Salvador", new DateTime(2021, 9, 27, 13, 50, 42, 831, DateTimeKind.Unspecified).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 7, 24, 1, 7, 33, 380, DateTimeKind.Unspecified).AddTicks(29), "Montserrat", new DateTime(2021, 2, 2, 4, 51, 42, 224, DateTimeKind.Unspecified).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 6, 24, 10, 1, 17, 225, DateTimeKind.Unspecified).AddTicks(2647), "Mongolia", new DateTime(2021, 2, 14, 22, 8, 40, 776, DateTimeKind.Unspecified).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2020, 6, 7, 10, 9, 48, 533, DateTimeKind.Unspecified).AddTicks(3805), "Saint Lucia", new DateTime(2021, 11, 6, 20, 16, 16, 33, DateTimeKind.Unspecified).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 8, 1, 4, 3, 12, 757, DateTimeKind.Unspecified).AddTicks(6546), "Benin", new DateTime(2021, 12, 12, 0, 49, 34, 469, DateTimeKind.Unspecified).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2021, 7, 29, 21, 6, 2, 541, DateTimeKind.Unspecified).AddTicks(5341), "Malaysia", new DateTime(2021, 3, 26, 1, 46, 0, 392, DateTimeKind.Unspecified).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 7, 17, 17, 17, 49, 796, DateTimeKind.Unspecified).AddTicks(92), "Malta", new DateTime(2021, 1, 12, 17, 34, 41, 32, DateTimeKind.Unspecified).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 6, 1, 2, 9, 14, 333, DateTimeKind.Unspecified).AddTicks(2492), "Estonia", new DateTime(2021, 5, 31, 7, 59, 40, 923, DateTimeKind.Unspecified).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InsertedDate", "MadeIn", "RelaseDate" },
                values: new object[] { new DateTime(2022, 1, 26, 6, 25, 44, 65, DateTimeKind.Unspecified).AddTicks(3959), "San Marino", new DateTime(2021, 6, 3, 23, 13, 6, 35, DateTimeKind.Unspecified).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 9, new DateTime(2021, 6, 1, 11, 6, 29, 370, DateTimeKind.Unspecified).AddTicks(6328), "Licensed Soft Pizza", 191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 1, new DateTime(2022, 10, 3, 6, 16, 4, 258, DateTimeKind.Unspecified).AddTicks(5003), "Awesome Concrete Ball", 56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2020, 5, 19, 8, 14, 22, 119, DateTimeKind.Unspecified).AddTicks(1695), "Gorgeous Soft Hat", 49m, 36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2020, 10, 18, 13, 52, 40, 658, DateTimeKind.Unspecified).AddTicks(6013), "Awesome Plastic Chair", 53m, 153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 9, 27, 1, 55, 19, 878, DateTimeKind.Unspecified).AddTicks(6705), "Handmade Cotton Shoes", 56m, 89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 3, new DateTime(2020, 11, 14, 1, 4, 42, 86, DateTimeKind.Unspecified).AddTicks(9662), "Awesome Plastic Computer", 114 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2020, 12, 10, 13, 27, 43, 612, DateTimeKind.Unspecified).AddTicks(8826), "Awesome Fresh Bike", 53m, 89 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2020, 5, 3, 9, 13, 23, 403, DateTimeKind.Unspecified).AddTicks(2706), "Licensed Concrete Keyboard", 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 3, 19, 8, 15, 35, 35, DateTimeKind.Unspecified).AddTicks(9505), "Ergonomic Steel Chips", 54m, 109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 9, 10, 4, 26, 39, 754, DateTimeKind.Unspecified).AddTicks(1804), "Awesome Rubber Computer", 55m, 131 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 12, 21, 22, 29, 14, 699, DateTimeKind.Unspecified).AddTicks(2128), "Gorgeous Metal Gloves", 54m, 165 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2020, 8, 2, 18, 1, 56, 632, DateTimeKind.Unspecified).AddTicks(1944), "Sleek Plastic Towels", 50m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2020, 5, 23, 5, 56, 51, 846, DateTimeKind.Unspecified).AddTicks(5216), "Handmade Concrete Hat", 51m, 139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 3, 31, 17, 52, 55, 854, DateTimeKind.Unspecified).AddTicks(2713), "Tasty Granite Hat", 49m, 198 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2020, 5, 4, 21, 17, 58, 731, DateTimeKind.Unspecified).AddTicks(4545), "Handcrafted Metal Fish", 57m, 140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 2, 9, 14, 35, 39, 124, DateTimeKind.Unspecified).AddTicks(252), "Intelligent Steel Chicken", 50m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2020, 5, 22, 19, 48, 43, 433, DateTimeKind.Unspecified).AddTicks(8836), "Ergonomic Plastic Bacon", 56m, 32 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 1, 8, 13, 16, 0, 294, DateTimeKind.Unspecified).AddTicks(9598), "Small Soft Shoes", 57m, 147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 11, 13, 5, 42, 26, 365, DateTimeKind.Unspecified).AddTicks(7503), "Incredible Cotton Tuna", 56m, 175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 1, 27, 3, 17, 19, 252, DateTimeKind.Unspecified).AddTicks(7835), "Rustic Metal Shoes", 57m, 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2020, 12, 4, 2, 43, 39, 770, DateTimeKind.Unspecified).AddTicks(4994), "Ergonomic Fresh Soap", 54m, 56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 1, 2, 17, 39, 44, 262, DateTimeKind.Unspecified).AddTicks(689), "Unbranded Fresh Car", 53m, 179 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2020, 10, 26, 7, 29, 54, 429, DateTimeKind.Unspecified).AddTicks(204), "Sleek Frozen Keyboard", 56m, 92 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 6, 17, 7, 14, 37, 866, DateTimeKind.Unspecified).AddTicks(27), "Ergonomic Wooden Tuna", 52m, 61 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2020, 8, 7, 8, 22, 17, 710, DateTimeKind.Unspecified).AddTicks(7813), "Generic Granite Chair", 49m, 88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 5, 20, 11, 49, 41, 451, DateTimeKind.Unspecified).AddTicks(1420), "Handcrafted Frozen Towels", 56m, 103 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2020, 5, 31, 18, 2, 38, 842, DateTimeKind.Unspecified).AddTicks(871), "Fantastic Soft Gloves", 52m, 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2020, 8, 17, 12, 1, 9, 199, DateTimeKind.Unspecified).AddTicks(9886), "Gorgeous Soft Ball", 49m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Stock" },
                values: new object[] { 5, new DateTime(2022, 2, 14, 8, 42, 48, 313, DateTimeKind.Unspecified).AddTicks(4577), "Refined Rubber Towels", 196 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryID", "InsertedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 9, 24, 4, 6, 44, 892, DateTimeKind.Unspecified).AddTicks(7307), "Practical Granite Chicken", 55m, 40 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 4, 8, 22, 1, 9, 480, DateTimeKind.Unspecified).AddTicks(4539), 83 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 11, 21, 10, 16, 48, 375, DateTimeKind.Unspecified).AddTicks(35), 146 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 5, 30, 23, 46, 0, 951, DateTimeKind.Unspecified).AddTicks(6504), 25 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 9, 26, 21, 23, 39, 736, DateTimeKind.Unspecified).AddTicks(4431), 104 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 4, 30, 21, 4, 48, 283, DateTimeKind.Unspecified).AddTicks(8783), 149 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 7, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 11, 15, 13, 42, 14, 381, DateTimeKind.Unspecified).AddTicks(6751), 170 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 11, 1, 21, 37, 40, 557, DateTimeKind.Unspecified).AddTicks(9013), 187 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 5, 3, 7, 24, 5, 782, DateTimeKind.Unspecified).AddTicks(9216), 157 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 10, 8 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 20, 7, 32, 1, 685, DateTimeKind.Unspecified).AddTicks(7649), 119 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 11, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 4, 3, 8, 3, 243, DateTimeKind.Unspecified).AddTicks(5967), 89 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 12, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 3, 11, 16, 7, 26, 569, DateTimeKind.Unspecified).AddTicks(1068), 89 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 13, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 2, 18, 13, 13, 13, 861, DateTimeKind.Unspecified).AddTicks(4775), 24 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 10, 8, 17, 5, 30, 317, DateTimeKind.Unspecified).AddTicks(7350), 94 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 7 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 10, 22, 0, 35, 19, 667, DateTimeKind.Unspecified).AddTicks(6591), 117 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 15, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 9, 5, 17, 52, 54, 239, DateTimeKind.Unspecified).AddTicks(9622), 64 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 17, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 27, 14, 15, 45, 155, DateTimeKind.Unspecified).AddTicks(8617), 164 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 18, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 8, 10, 13, 16, 20, 848, DateTimeKind.Unspecified).AddTicks(1099), 197 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 25, 8, 18, 25, 538, DateTimeKind.Unspecified).AddTicks(9077), 169 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 19, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 6, 18, 15, 53, 7, 343, DateTimeKind.Unspecified).AddTicks(701), 86 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 21, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 8, 25, 20, 22, 54, 274, DateTimeKind.Unspecified).AddTicks(3692), 53 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 1, 3, 5, 59, 44, 48, DateTimeKind.Unspecified).AddTicks(8019), 114 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 22, 9 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 9, 2, 35, 13, 194, DateTimeKind.Unspecified).AddTicks(4173), 160 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 23, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 6, 7, 18, 23, 49, 602, DateTimeKind.Unspecified).AddTicks(6342), 35 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 24, 10 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 7, 18, 5, 34, 48, 822, DateTimeKind.Unspecified).AddTicks(1136), 40 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 25, 4 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 7, 29, 9, 16, 43, 621, DateTimeKind.Unspecified).AddTicks(8485), 23 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 26, 1 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2021, 4, 7, 4, 22, 43, 310, DateTimeKind.Unspecified).AddTicks(409), 39 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 27, 3 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 1, 31, 10, 20, 54, 988, DateTimeKind.Unspecified).AddTicks(3161), 25 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 2 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2022, 10, 29, 7, 12, 58, 789, DateTimeKind.Unspecified).AddTicks(8469), 178 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 28, 5 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 4, 19, 13, 54, 48, 999, DateTimeKind.Unspecified).AddTicks(8128), 194 });

            migrationBuilder.UpdateData(
                table: "ProductsSuppliers",
                keyColumns: new[] { "ProductID", "SupplierID" },
                keyValues: new object[] { 29, 6 },
                columns: new[] { "InsertedDate", "MaxCountPerShipping" },
                values: new object[] { new DateTime(2020, 10, 28, 8, 5, 9, 906, DateTimeKind.Unspecified).AddTicks(8871), 176 });

            migrationBuilder.InsertData(
                table: "ProductsSuppliers",
                columns: new[] { "ProductID", "SupplierID", "InsertedDate", "LastModifiedDate", "MaxCountPerShipping", "Status" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 12, 6, 10, 19, 47, 99, DateTimeKind.Unspecified).AddTicks(4455), null, 10, 1 },
                    { 2, 6, new DateTime(2020, 4, 9, 0, 3, 50, 913, DateTimeKind.Unspecified).AddTicks(5119), null, 81, 1 },
                    { 2, 7, new DateTime(2020, 11, 14, 9, 48, 46, 911, DateTimeKind.Unspecified).AddTicks(9038), null, 28, 1 },
                    { 3, 1, new DateTime(2020, 11, 27, 23, 15, 19, 416, DateTimeKind.Unspecified).AddTicks(5097), null, 78, 1 },
                    { 3, 8, new DateTime(2022, 5, 28, 20, 8, 27, 846, DateTimeKind.Unspecified).AddTicks(4332), null, 55, 1 },
                    { 4, 2, new DateTime(2020, 5, 16, 4, 29, 21, 629, DateTimeKind.Unspecified).AddTicks(7313), null, 50, 1 },
                    { 4, 4, new DateTime(2022, 9, 28, 2, 6, 52, 274, DateTimeKind.Unspecified).AddTicks(887), null, 36, 1 },
                    { 4, 5, new DateTime(2021, 9, 30, 1, 42, 0, 560, DateTimeKind.Unspecified).AddTicks(6586), null, 171, 1 },
                    { 7, 2, new DateTime(2021, 10, 29, 10, 58, 26, 818, DateTimeKind.Unspecified).AddTicks(6500), null, 17, 1 },
                    { 7, 5, new DateTime(2021, 12, 3, 0, 51, 8, 565, DateTimeKind.Unspecified).AddTicks(9655), null, 15, 1 },
                    { 8, 8, new DateTime(2022, 10, 17, 7, 45, 19, 877, DateTimeKind.Unspecified).AddTicks(6900), null, 156, 1 },
                    { 8, 9, new DateTime(2021, 5, 3, 6, 59, 13, 901, DateTimeKind.Unspecified).AddTicks(6562), null, 152, 1 },
                    { 9, 1, new DateTime(2020, 8, 23, 10, 11, 13, 657, DateTimeKind.Unspecified).AddTicks(5137), null, 115, 1 },
                    { 9, 4, new DateTime(2022, 10, 4, 22, 20, 1, 135, DateTimeKind.Unspecified).AddTicks(6510), null, 2, 1 },
                    { 10, 1, new DateTime(2020, 8, 27, 12, 51, 36, 954, DateTimeKind.Unspecified).AddTicks(1990), null, 15, 1 },
                    { 10, 3, new DateTime(2020, 4, 2, 12, 3, 10, 393, DateTimeKind.Unspecified).AddTicks(3309), null, 171, 1 },
                    { 10, 7, new DateTime(2021, 3, 8, 8, 33, 38, 477, DateTimeKind.Unspecified).AddTicks(9699), null, 117, 1 },
                    { 10, 9, new DateTime(2022, 12, 19, 18, 49, 15, 717, DateTimeKind.Unspecified).AddTicks(404), null, 102, 1 },
                    { 12, 3, new DateTime(2020, 11, 4, 16, 31, 27, 366, DateTimeKind.Unspecified).AddTicks(7148), null, 69, 1 },
                    { 12, 7, new DateTime(2022, 7, 20, 8, 7, 5, 918, DateTimeKind.Unspecified).AddTicks(5107), null, 35, 1 },
                    { 13, 5, new DateTime(2022, 9, 29, 20, 8, 2, 584, DateTimeKind.Unspecified).AddTicks(7414), null, 130, 1 },
                    { 13, 9, new DateTime(2021, 4, 5, 18, 56, 47, 720, DateTimeKind.Unspecified).AddTicks(1910), null, 40, 1 },
                    { 14, 4, new DateTime(2020, 5, 13, 1, 0, 50, 880, DateTimeKind.Unspecified).AddTicks(434), null, 1, 1 },
                    { 14, 5, new DateTime(2021, 8, 17, 3, 19, 2, 279, DateTimeKind.Unspecified).AddTicks(9834), null, 171, 1 },
                    { 14, 9, new DateTime(2021, 5, 3, 1, 23, 42, 973, DateTimeKind.Unspecified).AddTicks(9353), null, 152, 1 },
                    { 15, 2, new DateTime(2022, 4, 30, 7, 29, 32, 223, DateTimeKind.Unspecified).AddTicks(4630), null, 181, 1 },
                    { 16, 5, new DateTime(2022, 6, 19, 5, 12, 15, 944, DateTimeKind.Unspecified).AddTicks(3293), null, 154, 1 },
                    { 16, 7, new DateTime(2022, 6, 24, 17, 23, 53, 379, DateTimeKind.Unspecified).AddTicks(8955), null, 90, 1 },
                    { 17, 4, new DateTime(2021, 2, 20, 17, 46, 57, 963, DateTimeKind.Unspecified).AddTicks(1647), null, 76, 1 },
                    { 17, 5, new DateTime(2021, 10, 13, 17, 56, 7, 496, DateTimeKind.Unspecified).AddTicks(3087), null, 44, 1 },
                    { 19, 2, new DateTime(2021, 7, 5, 3, 14, 43, 160, DateTimeKind.Unspecified).AddTicks(788), null, 78, 1 },
                    { 20, 2, new DateTime(2022, 1, 6, 19, 51, 5, 742, DateTimeKind.Unspecified).AddTicks(2247), null, 33, 1 },
                    { 20, 3, new DateTime(2022, 11, 8, 16, 50, 44, 600, DateTimeKind.Unspecified).AddTicks(68), null, 84, 1 },
                    { 20, 4, new DateTime(2021, 1, 27, 17, 50, 59, 912, DateTimeKind.Unspecified).AddTicks(6891), null, 182, 1 },
                    { 21, 6, new DateTime(2022, 6, 22, 0, 35, 18, 975, DateTimeKind.Unspecified).AddTicks(2375), null, 4, 1 },
                    { 22, 3, new DateTime(2021, 12, 26, 4, 20, 12, 31, DateTimeKind.Unspecified).AddTicks(3611), null, 55, 1 },
                    { 22, 8, new DateTime(2020, 8, 3, 0, 55, 47, 396, DateTimeKind.Unspecified).AddTicks(9079), null, 17, 1 },
                    { 23, 1, new DateTime(2020, 10, 17, 13, 28, 17, 764, DateTimeKind.Unspecified).AddTicks(1572), null, 124, 1 },
                    { 23, 2, new DateTime(2022, 4, 12, 12, 23, 33, 595, DateTimeKind.Unspecified).AddTicks(108), null, 64, 1 },
                    { 23, 4, new DateTime(2020, 5, 11, 20, 48, 20, 253, DateTimeKind.Unspecified).AddTicks(1862), null, 140, 1 },
                    { 23, 6, new DateTime(2022, 3, 19, 22, 22, 39, 331, DateTimeKind.Unspecified).AddTicks(3667), null, 119, 1 },
                    { 23, 8, new DateTime(2021, 5, 12, 17, 0, 11, 445, DateTimeKind.Unspecified).AddTicks(5191), null, 131, 1 },
                    { 24, 1, new DateTime(2021, 2, 20, 7, 54, 16, 666, DateTimeKind.Unspecified).AddTicks(3480), null, 82, 1 },
                    { 24, 4, new DateTime(2020, 4, 21, 4, 56, 33, 336, DateTimeKind.Unspecified).AddTicks(1936), null, 64, 1 },
                    { 24, 5, new DateTime(2020, 10, 8, 12, 1, 6, 707, DateTimeKind.Unspecified).AddTicks(414), null, 189, 1 },
                    { 25, 6, new DateTime(2022, 10, 11, 0, 50, 53, 177, DateTimeKind.Unspecified).AddTicks(3744), null, 65, 1 },
                    { 25, 9, new DateTime(2020, 12, 26, 9, 11, 3, 179, DateTimeKind.Unspecified).AddTicks(6671), null, 69, 1 },
                    { 25, 10, new DateTime(2021, 2, 23, 6, 25, 20, 79, DateTimeKind.Unspecified).AddTicks(7990), null, 139, 1 },
                    { 26, 9, new DateTime(2020, 6, 24, 9, 39, 24, 583, DateTimeKind.Unspecified).AddTicks(4777), null, 49, 1 },
                    { 27, 1, new DateTime(2020, 5, 25, 8, 21, 26, 77, DateTimeKind.Unspecified).AddTicks(4230), null, 90, 1 },
                    { 27, 8, new DateTime(2022, 9, 17, 0, 51, 59, 98, DateTimeKind.Unspecified).AddTicks(5886), null, 39, 1 },
                    { 28, 3, new DateTime(2021, 11, 12, 10, 53, 29, 520, DateTimeKind.Unspecified).AddTicks(8213), null, 129, 1 },
                    { 28, 7, new DateTime(2021, 1, 20, 6, 32, 8, 867, DateTimeKind.Unspecified).AddTicks(465), null, 125, 1 },
                    { 28, 10, new DateTime(2021, 4, 4, 18, 26, 36, 864, DateTimeKind.Unspecified).AddTicks(3854), null, 90, 1 },
                    { 29, 1, new DateTime(2022, 10, 10, 19, 34, 32, 356, DateTimeKind.Unspecified).AddTicks(3802), null, 30, 1 },
                    { 29, 3, new DateTime(2020, 6, 29, 13, 55, 15, 43, DateTimeKind.Unspecified).AddTicks(5576), null, 73, 1 },
                    { 29, 5, new DateTime(2021, 5, 5, 13, 33, 14, 206, DateTimeKind.Unspecified).AddTicks(6188), null, 18, 1 },
                    { 30, 9, new DateTime(2020, 6, 11, 0, 49, 48, 794, DateTimeKind.Unspecified).AddTicks(6258), null, 195, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "041 Rogelio Shoal, New Esperanza, Mozambique", "Hettinger Group", new DateTime(2021, 5, 25, 17, 7, 16, 742, DateTimeKind.Unspecified).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "904 Marvin Coves, East Claudieland, Bahrain", "Reynolds - Donnelly", new DateTime(2022, 11, 5, 6, 12, 13, 650, DateTimeKind.Unspecified).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "752 Asia Passage, Justusfurt, Cook Islands", "Price Group", new DateTime(2020, 10, 6, 16, 0, 37, 163, DateTimeKind.Unspecified).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "46942 Kirlin Ports, East Margaretta, Guam", "Weissnat - Osinski", new DateTime(2022, 2, 5, 16, 4, 31, 432, DateTimeKind.Unspecified).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "9766 Stephen Neck, Reichertburgh, Luxembourg", "King and Sons", new DateTime(2020, 11, 18, 11, 9, 18, 693, DateTimeKind.Unspecified).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "3623 Heller Center, West Alfredaburgh, Belize", "Johnson - Tromp", new DateTime(2022, 2, 6, 17, 43, 7, 330, DateTimeKind.Unspecified).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "01956 Fannie Bridge, East Yasmeenport, Albania", "Bradtke - Turner", new DateTime(2020, 10, 4, 5, 29, 35, 842, DateTimeKind.Unspecified).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "320 Reinger Ferry, Port Nicolettemouth, Central African Republic", "Stamm - Funk", new DateTime(2022, 11, 5, 19, 17, 14, 300, DateTimeKind.Unspecified).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "9827 Schuster Brooks, West Angie, Austria", "Kozey - Thompson", new DateTime(2021, 10, 24, 10, 26, 52, 852, DateTimeKind.Unspecified).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "CompanyName", "InsertedDate" },
                values: new object[] { "648 Gulgowski Union, North Otha, Sudan", "Wolff - Hirthe", new DateTime(2022, 7, 20, 8, 23, 38, 753, DateTimeKind.Unspecified).AddTicks(4983) });
        }
    }
}
