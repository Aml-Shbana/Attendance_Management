using Attendance_Management.Migrations;
using Attendance_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Attendance_Management.Forms_Folder
{
    public partial class empdashboard : Form
    {
        public readonly Context con = new Context();

        public empdashboard()
        {
            InitializeComponent();
        }
        #region loaded
        
        //code of timer
        private void empdashboard_Load(object sender, EventArgs e)
        {
            TimerClock.Tick += TimerClock_Tick;
            // عشان الوقت يتحدث كل مرة افتح الفورم
            TimerClock_Tick(null, null);
            //load typeleave in combobox
            cmbLeaveType.DataSource = Enum.GetValues(typeof(LeaveType));
            loadcheckinout();
            loadattendance();
        }
        #endregion
        #region checkin

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var late = new TimeSpan(9, 0, 0);
            var early = new TimeSpan(16, 0, 0);
            var attendata = con.Attendances.FirstOrDefault(a => a.EmployeeID == login.LoggedInEmployeeID && a.CheckInTime.Value.Date == today);

            if (attendata != null)
            {
                var now = DateTime.Now;
                var isLate = now.TimeOfDay > late;
                var isearly = now.TimeOfDay < early;

                #region store log action
                var log = new Logs
                {
                    EmployeeID = login.LoggedInEmployeeID,
                    Action = Action_Type.check_in,
                    Time_OfAction = now,
                };
                con.Logs.Add(log);
                con.SaveChanges();
                #endregion

                var atten = new Attendance
                {
                    EmployeeID = login.LoggedInEmployeeID,
                    CheckInTime = DateTime.Now,
                    LateArrival = isLate,
                    EarlyDeparture = isearly

                };
                con.Attendances.Add(atten);

                con.SaveChanges();
                lblAttendanceStatus.Text = "Attendance taken ,thank you";
                lblAttendanceStatus.ForeColor = Color.Green;
                lblLastCheckIn.BackColor = Color.Green;
                lblLastCheckIn.Text = "Take CheckIn ✔";
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;

                loadattendance();
            }
            else
            {
                MessageBox.Show("Warning!!", "Attendance was already taken!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        #endregion
        #region checkout
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;

            var attenCHOut = con.Attendances
           .Where(f => f.EmployeeID == login.LoggedInEmployeeID && f.CheckInTime.Value.Date == today)
          .OrderByDescending(f => f.CheckInTime)
            .FirstOrDefault(f => f.CheckOutTime == null);
            

            if (attenCHOut != null)
            {
                #region store log action
                var log = new Logs
                {
                    EmployeeID = login.LoggedInEmployeeID,
                    Action = Action_Type.check_out,
                    Time_OfAction = DateTime.Now,
                };
                con.Logs.Add(log);
                #endregion

                attenCHOut.CheckOutTime = DateTime.Now;
                con.SaveChanges();
                loadcheckinout();
                loadattendance();

            }
            else
            {
                MessageBox.Show("Warning!!", "Attendance must be registered first!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region tabloaded
       
        private void tabAttendanceHistory_Click(object sender, EventArgs e)
        {
            loadattendance();

        }
        #endregion
        #region function
        //function checkin checkout
        public void loadcheckinout()
        {
            
            var today = DateTime.Today;
            var check = con.Attendances.Where(w => w.EmployeeID == login.LoggedInEmployeeID && w.CheckInTime
            .Value.Date == today).OrderBy(o => o.CheckInTime).FirstOrDefault();
            if (check != null)
            {

                lblAttendanceStatus.Text = "Attendance taken ,thank you";
                lblAttendanceStatus.ForeColor = Color.Green;
                lblLastCheckIn.BackColor = Color.Green;
                lblLastCheckIn.Text = "Take CheckIn ✔";
                btnCheckIn.Enabled = false;
                if (check.CheckOutTime == null)
                {
                    btnCheckOut.Enabled = true;
                }
                else
                {
                    lblAttendanceStatus.Text = "Exit taken ,thank you";
                    lblAttendanceStatus.ForeColor = Color.Green;
                    lblLastCheckOut.BackColor = Color.Green;
                    lblLastCheckOut.Text = "Take CheckOut ✔";
                    btnCheckOut.Enabled = false;
                }
            }
            else
            {
                lblLastCheckIn.Text = "No Check-In Today";
                lblLastCheckIn.BackColor = Color.Red;
                lblAttendanceStatus.Text = "Please check in.";
                lblAttendanceStatus.ForeColor = Color.Red;
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }

        }
       //function attendance with validations
        public void loadattendance()
        {
            #region show
            var early = new TimeSpan(16, 0, 0);

            //show in datagrideview
            var historyAteend = con.Attendances.Where(w => w.EmployeeID == login.LoggedInEmployeeID)
                .OrderByDescending(o => o.CheckInTime).Select(s => new
                {
                    Date = s.CheckInTime.Value.Date.ToShortDateString(),
                    CheckIn = s.CheckInTime.Value.ToString("HH:mm"),

                    CheckOut = s.CheckOutTime.Value.ToString("HH:mm"),
                    TotalHours = s.TotalHoursWorked.HasValue ? $"{s.TotalHoursWorked.Value.TotalHours:F2}hour" : "N/A",
                    LateArrival = s.LateArrival ? "Yes" : "No",
                    EarlyDeparture = s.CheckOutTime.HasValue
                         ? (s.CheckOutTime.Value.TimeOfDay < early ? "Yes" : "No")
                         : "Not out"
                }).ToList();
            #endregion
            #region loaded data of employee
            
            lblname.Text = con.Employees.Where(w => w.EmployeeID == login.LoggedInEmployeeID)
                .Select(s => s.Name).FirstOrDefault();
            lbldept.Text = con.Employees.Where(w => w.EmployeeID == login.LoggedInEmployeeID)
             .Select(s => s.Department.ToString()).FirstOrDefault();
            #endregion
            #region lable

            //labels desighn
            dgvAttendanceHistory.DataSource = historyAteend;
            if (historyAteend.Any())
            {
                if (historyAteend.First().LateArrival == "Yes")
                {
                    lblLateArrival.BackColor = Color.Red;
                    lblLateArrival.Text = "Late Arrival 😡";

                }
                else
                {
                    lblLateArrival.Text = "EXCLANT NO Late Arrival 😁👍🥰";
                    lblLateArrival.BackColor = Color.Green;

                }

            }

            if (historyAteend.Any())
            {
                // 
                if (historyAteend.First().EarlyDeparture == "Yes")
                {
                    lblEarlyDeparture.Text = "Checked out early 🤔";
                    lblEarlyDeparture.BackColor = Color.Red;
                }
                else if (historyAteend.First().EarlyDeparture == "Not out")
                {
                    lblEarlyDeparture.Text = "still in work 🧐👩‍💻⏳";
                    lblEarlyDeparture.BackColor = Color.Orange;
                }
                else
                {
                    lblEarlyDeparture.Text = "Checked out on time 👌❤";
                    lblEarlyDeparture.BackColor = Color.Green;
                }
            }
            #endregion
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            //to show time
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #endregion

        #region save changed of password 

        private void btnsave_Click(object sender, EventArgs e)
        {
            string oldpass = txtoldpass.Text.Trim();
            string newpass = txtnewpass.Text.Trim();
            string confirmpass = txtconfirmpass.Text.Trim();
            var user = con.Employees.FirstOrDefault(f => f.EmployeeID == login.LoggedInEmployeeID);
            if (user == null)
            {
                MessageBox.Show("Warning", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (user.Password != oldpass)
            {
                MessageBox.Show("Warning", "Correct old password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            
            if (newpass != confirmpass)

            {
                MessageBox.Show("Warning", "Correct confirm password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            user.Password = newpass;
            con.SaveChanges();
            MessageBox.Show("Success", "Password updated successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region loaddata in combobox
        
        private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeaveType selectedtype = (LeaveType)cmbLeaveType.SelectedItem;
        }
        #endregion

        #region submit button for request holiday
        
        private void btnSubmitLeave_Click(object sender, EventArgs e)
        {
            var todayholiy = DateTime.Now.Date;
            if (dtpStartDate.Value.Date <= todayholiy || dtpEndDate.Value.Date <= todayholiy)
            {
                MessageBox.Show("Warning", "Correct holiday", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var leavreq = new LeaveRequest
            {
                EmployeeID = login.LoggedInEmployeeID,
                Type = (LeaveType)cmbLeaveType.SelectedItem,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                Status = LeaveStatus.Pending,
                Reason = txtReason.Text.Trim()
            };
            #region store log action
            var log = new Logs
            {
                EmployeeID = login.LoggedInEmployeeID,
                Action = Action_Type.leave_request,
                Time_OfAction = DateTime.Now,
            };
            con.Logs.Add(log);
            #endregion

            con.Leaves.Add(leavreq);
            con.SaveChanges();
            lblleavestatus.Text = "Sent request";
            lblleavestatus.BackColor = Color.Orange;
            lblstatus.Text = "Pending ⏰";
            lblstatus.BackColor = Color.Orange;

            MessageBox.Show("Warning", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear
            txtReason.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cmbLeaveType.SelectedIndex = 0;


        }
        #endregion

        #region close tabs and return to login
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
