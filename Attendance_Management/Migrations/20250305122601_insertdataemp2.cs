using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class insertdataemp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Department", "Email", "Name", "Password", "Phone", "Role", "Schedule" },
                values: new object[] { 8, "cs", "esraa@gmail.com", "esraa", "123", "1111111", 2, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8);
        }
    }
}
