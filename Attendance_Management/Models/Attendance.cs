using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Attendance_Management.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public DateTime? CheckInTime  { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public TimeSpan? TotalHoursWorked
        {
            //check
            get
            {
                return CheckOutTime.HasValue ? CheckOutTime.Value - CheckInTime : (TimeSpan?)null;
            }
        }  
        public bool LateArrival { get; set; } 
        public bool EarlyDeparture { get; set; }
       // object
       // [ForeignKey(nameof(Employee))] //name of prop
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
