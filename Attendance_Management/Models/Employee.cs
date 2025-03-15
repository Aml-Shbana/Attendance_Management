using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required]
        public UserRole Role { get; set; }
        [EmailAddress(ErrorMessage ="invaild Email!!")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="invalid phone number!!")]
        public string Phone { get; set; }
        [Required]
        public WorkSchedule Schedule { get; set; }
        [PasswordPropertyText(true)]
        public string Password { get; set; }
        [NotMapped] 
        public string ConfirmPassword { get; set; }
        //relations
        public virtual List<Attendance> Attendances { get; set; } = new List<Attendance>();
        public virtual List<LeaveRequest> Leaves { get; set; } = new List<LeaveRequest>();
        public virtual List<Logs> Logs { get; set; } = new List<Logs> ();
        
    }
    public enum UserRole
    {
        Admin,
        HR,
        Employee
    }
    public enum WorkSchedule
    {
        FullTime,
        PartTime,
        Remote
    }
    public enum Department
    {
        HR,
        IT,
        Finance,
        Marketing,
        Sales,
        Operations
    }
}
