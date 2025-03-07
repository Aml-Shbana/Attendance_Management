using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Models
{
    public class EmployeeAttendanceSummary
    {
        [Key]
        public int EmpSummaryID { get; set; }
        public int EmployeeID { get; set; }
        public int DailyAttendance  { get; set; } 
        public int monthlyAttendance  { get; set; }
        public int weekAttendance  { get; set; }

        public Employee Employee { get; set; }

    }
}
