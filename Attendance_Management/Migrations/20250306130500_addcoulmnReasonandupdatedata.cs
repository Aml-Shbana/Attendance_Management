using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management.Migrations
{
    /// <inheritdoc />
    public partial class addcoulmnReasonandupdatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Leaves",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 1,
                column: "Reason",
                value: "Not specified");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 2,
                column: "Reason",
                value: "Not specified");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 3,
                column: "Reason",
                value: "Not specified");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 4,
                column: "Reason",
                value: "Not specified");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 5,
                column: "Reason",
                value: "Not specified");

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveRequestID",
                keyValue: 6,
                column: "Reason",
                value: "Not specified");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Leaves");
        }
    }
}
