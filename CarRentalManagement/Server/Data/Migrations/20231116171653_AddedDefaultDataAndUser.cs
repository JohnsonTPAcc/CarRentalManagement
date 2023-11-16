using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "117d9308-a77f-404b-9b92-de088db3e6ff", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO13aSJFmyn9+d0YYRV9pUKEQyGelcdP1sG960HKJLGNmKCO+dxT6aj13WtHXlJ8yw==", null, false, "528e1e29-7909-4278-9454-4eaf98cc6b6f", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(8688), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(8690), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9059), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9060), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9062), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9062), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9312), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9313), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9314), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9316), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9316), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 11, 17, 1, 16, 53, 742, DateTimeKind.Local).AddTicks(9318), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
