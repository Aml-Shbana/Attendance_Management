using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class add_logsdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "LogId", "Action", "EmployeeID", "Time_OfAction" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2025, 3, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, new DateTime(2025, 3, 1, 17, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 0, 2, new DateTime(2025, 3, 2, 9, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 2, new DateTime(2025, 3, 2, 16, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 0, 3, new DateTime(2025, 3, 3, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 3, new DateTime(2025, 3, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 0, 4, new DateTime(2025, 3, 4, 8, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 4, new DateTime(2025, 3, 4, 16, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 0, 5, new DateTime(2025, 3, 5, 9, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 5, new DateTime(2025, 3, 5, 16, 55, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "LogId",
                keyValue: 10);
        }
    }
}
