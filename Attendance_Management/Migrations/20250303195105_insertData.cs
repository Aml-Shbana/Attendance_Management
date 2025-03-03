using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class insertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Department", "Email", "Name", "Password", "Phone", "Role", "Schedule" },
                values: new object[,]
                {
                    { 1, "HR", "alice.johnson@company.com", "Alice Johnson", "hashedpass1", "0123456789", 0, 0 },
                    { 2, "IT", "bob.smith@company.com", "Bob Smith", "hashedpass2", "0987654321", 2, 2 },
                    { 3, "Finance", "charlie.brown@company.com", "Charlie Brown", "hashedpass3", "0543216789", 1, 1 },
                    { 4, "IT", "diana.green@company.com", "Diana Green", "hashedpass4", "0778899000", 2, 0 },
                    { 5, "Marketing", "ethan.white@company.com", "Ethan White", "hashedpass5", "0667788990", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "AttendanceID", "CheckInTime", "CheckOutTime", "EarlyDeparture", "EmployeeID", "LateArrival" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 1, 8, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), false, 1, true },
                    { 2, new DateTime(2025, 3, 2, 9, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 16, 50, 0, 0, DateTimeKind.Unspecified), false, 2, true },
                    { 3, new DateTime(2025, 3, 3, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 3, false },
                    { 4, new DateTime(2025, 3, 4, 8, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 16, 40, 0, 0, DateTimeKind.Unspecified), true, 4, true },
                    { 5, new DateTime(2025, 3, 5, 9, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 16, 55, 0, 0, DateTimeKind.Unspecified), false, 5, true },
                    { 6, new DateTime(2025, 3, 6, 8, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 17, 10, 0, 0, DateTimeKind.Unspecified), false, 1, true },
                    { 7, new DateTime(2025, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), true, 2, false },
                    { 8, new DateTime(2025, 3, 8, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 17, 15, 0, 0, DateTimeKind.Unspecified), false, 3, true },
                    { 9, new DateTime(2025, 3, 9, 8, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 16, 45, 0, 0, DateTimeKind.Unspecified), true, 4, false },
                    { 10, new DateTime(2025, 3, 10, 8, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), false, 5, true }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveRequestID", "EmployeeID", "EndDate", "StartDate", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 3, new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 3, 5, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 4, 1, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, 4, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0 },
                    { 6, 3, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "AttendanceID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5);
        }
    }
}
