using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceSummaries",
                columns: table => new
                {
                    EmpSummaryID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DailyAttendance = table.Column<int>(type: "int", nullable: false),
                    monthlyAttendance = table.Column<int>(type: "int", nullable: false),
                    weekAttendance = table.Column<int>(type: "int", nullable: false),
                    MonthlyWorkingHours = table.Column<int>(type: "int", nullable: false),
                    DailyWorkingHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceSummaries", x => new { x.EmpSummaryID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_AttendanceSummaries_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceSummaries_EmployeeID",
                table: "AttendanceSummaries",
                column: "EmployeeID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceSummaries");
        }
    }
}
