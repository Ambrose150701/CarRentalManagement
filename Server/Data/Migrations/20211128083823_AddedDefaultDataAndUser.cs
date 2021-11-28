using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Vehicles",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Models",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Makes",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Customers",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Colours",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "updätedby",
                table: "Bookings",
                newName: "Updatedby");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "4e1311d2-8fef-494f-bc63-b4c7db25a85e", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "71736ea8-4278-4176-bf48-71f894c6be9f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3ee8fb8d-ee42-434f-8fbb-9a14d10d1c0a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELLgyACQVMsjuv5TkxHLRtNTX9+NCh/jsuLtkGQZ2+WWaSPYKU0XPHCfQjGxslh6oQ==", null, false, "5ef71d2f-47cd-4b02-8f2c-f97aebcf9034", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 28, 16, 38, 22, 661, DateTimeKind.Local).AddTicks(2381), new DateTime(2021, 11, 28, 16, 38, 22, 662, DateTimeKind.Local).AddTicks(4767), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 28, 16, 38, 22, 662, DateTimeKind.Local).AddTicks(6374), new DateTime(2021, 11, 28, 16, 38, 22, 662, DateTimeKind.Local).AddTicks(6383), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(1160), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(1192), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(1201), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(1205), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9235), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9251), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9257), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9260), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9264), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9266), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9270), new DateTime(2021, 11, 28, 16, 38, 22, 665, DateTimeKind.Local).AddTicks(9272), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

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

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Vehicles",
                newName: "updätedby");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Models",
                newName: "updätedby");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Makes",
                newName: "updätedby");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Customers",
                newName: "updätedby");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Colours",
                newName: "updätedby");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Bookings",
                newName: "updätedby");
        }
    }
}
