using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class newdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 21);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Leaves",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "Department",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "Department",
                value: "Finance");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                column: "Department",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                column: "Department",
                value: "Marketing");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                column: "Department",
                value: "Marketing");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Department", "Email", "Name", "Phone", "Role", "Schedule" },
                values: new object[] { "HR", "fatma@company.com", "Fatma", "0667788990", 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Leaves",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "Department",
                value: "Sales");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6,
                column: "Department",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7,
                columns: new[] { "Department", "Email", "Name", "Phone", "Role", "Schedule" },
                values: new object[] { "IT", "eman@gmail.com", "eman", "1111111", 2, 0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Department", "Email", "Name", "Password", "Phone", "Role", "Schedule" },
                values: new object[,]
                {
                    { 8, "IT", "esraa@gmail.com", "esraa", "123", "1111111", 2, 0 },
                    { 9, "Marketing", "yasser@gmail.com", "yasser", "55555", "1111111", 2, 0 },
                    { 10, "Marketing", "fa@gmail.com", "fatma", "111", "1111111", 2, 0 },
                    { 11, "Marketing", "sara@gmail.com", "sara", "111", "1111111", 2, 0 },
                    { 12, "Marketing", "a@gmail.com", "a", "111", "1111111", 2, 0 },
                    { 13, "Operations", "b@gmail.com", "b", "111", "1111111", 2, 0 },
                    { 14, "Operations", "c@gmail.com", "c", "111", "1111111", 2, 0 },
                    { 15, "Operations", "d@gmail.com", "d", "111", "1111111", 2, 0 },
                    { 16, "Operations", "new@gmail.com", "new", "111", "1111111", 2, 0 },
                    { 17, "Operations", "n@gmail.com", "n", "111", "1111111", 2, 0 },
                    { 18, "Operations", "last@gmail.com", "last", "111", "1111111", 2, 0 },
                    { 19, "Operations", "last1@gmail.com", "last1", "111", "1111111", 2, 0 },
                    { 20, "Operations", "last2@gmail.com", "last2", "111", "1111111", 2, 0 },
                    { 21, "Operations", "last3@gmail.com", "last3", "111", "1111111", 2, 0 }
                });
        }
    }
}
