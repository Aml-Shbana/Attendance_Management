using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Models
{
    public class Logs
    {
        [Key]
        public int LogId { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public Action_Type Action { get; set; }
        public DateTime Time_OfAction { get; set; }
        public virtual Employee Employee { get; set; }
    }
    public enum Action_Type
    {
        check_in, check_out, leave_request
    }
}
