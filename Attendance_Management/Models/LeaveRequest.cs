using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Models
{
    public class LeaveRequest
    {
        [Key]
        public int LeaveRequestID { get; set; }
        [Required]
        public LeaveType Type { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public LeaveStatus Status { get; set; }
        //object
       // [ForeignKey(nameof(Employee))] //name of prop
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

    }
    public enum LeaveType
    {
        SickLeave,
        Vacation,
        UnpaidLeave
    }

    public enum LeaveStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
