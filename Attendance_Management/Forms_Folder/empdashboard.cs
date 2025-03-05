using Attendance_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        //code of timer
        private void empdashboard_Load(object sender, EventArgs e)
        {
            TimerClock.Tick += TimerClock_Tick;
            // عشان الوقت يتحدث كل مرة افتح الفورم
            TimerClock_Tick(null, null);

        }
        #region function

        public void loadattendance()
        {
            var historyAteend = con.Attendances.Where(w => w.EmployeeID == login.LoggedInEmployeeID)
                .OrderByDescending(o => o.CheckInTime).Select(s => new
                {
                    Date = s.CheckInTime.Value.Date.ToShortDateString(),
                    CheckIn = s.CheckInTime.Value.ToString("HH:mm"),

                    CheckOut = s.CheckOutTime.HasValue ? s.CheckOutTime.Value.ToString("HH:mm") : "no",
                    TotalHours = s.TotalHoursWorked.HasValue ? $"{s.TotalHoursWorked.Value.TotalHours:F2}hour" : "N/A",
                    LateArrival = s.LateArrival ? "Yes" : "No",
                    EarlyDeparture = s.EarlyDeparture ? "Yes" : "No",
                }).ToList();
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
                if (historyAteend.First().CheckOut != "No" && historyAteend.First().EarlyDeparture == "Yes")
                {
                    lblEarlyDeparture.Text = "Checked out early 🤔";
                    lblEarlyDeparture.BackColor = Color.Red;
                }
                else
                {
                    lblEarlyDeparture.Text = "Checked out on time 👌❤";
                    lblEarlyDeparture.BackColor = Color.Green;
                }
            }
        }
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            //to show time
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #endregion

        #region checkin
        
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var late = new TimeSpan(9, 0, 0);
            var early = new TimeSpan(16, 0, 0);
            var attendata = con.Attendances.FirstOrDefault(a => a.EmployeeID == login.LoggedInEmployeeID && a.CheckInTime.Value.Date == today
          );

            if ( attendata == null)
            {

                var now = DateTime.Now;
                var isLate = now.TimeOfDay > late;
                var isearly = now.TimeOfDay < early;
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

            if (attenCHOut != null)//سجل حضور و انصراف لا
            {
                attenCHOut.CheckOutTime = DateTime.Now;
                con.SaveChanges();
                con.Entry(attenCHOut).Reload();

                lblAttendanceStatus.Text = "Exit taken ,thank you";
                lblAttendanceStatus.ForeColor = Color.Green;
                lblLastCheckOut.BackColor = Color.Green;
                lblLastCheckOut.Text = "Take CheckOut ✔";
                btnCheckOut.Enabled = false;
                loadattendance();

            }
            else
            {
                MessageBox.Show("Warning!!", "Attendance must be registered first!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        private void tabAttendanceHistory_Click(object sender, EventArgs e)
        {
            loadattendance();

        }

        #region save chnged password
       
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
            //if (user.Password != confirmpass)
            //{
            //    MessageBox.Show("Warning", "Correct confirm password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;

            //}
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

    }
}
