using Attendance_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Nrbf;
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
            
                CustomizeDataGridView(dgvAttendanceHistory);
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

            if (attendata == null)
            {
                var now = DateTime.Now;
                var isLate = now.TimeOfDay > late;
                var atten = new Attendance
                #region store log action
 //var log = new Logs
 //{
 //    EmployeeID = login.LoggedInEmployeeID,
 //    Action = Action_Type.check_in,
 //    Time_OfAction = now,
 //};
 //               con.Logs.Add(log);
 //               con.SaveChanges();
                #endregion
                {
                    EmployeeID = login.LoggedInEmployeeID,
                    CheckInTime = DateTime.Now,
                    LateArrival = isLate,
                };

                con.Attendances.Add(atten);
                con.SaveChanges();
                loadcheckinout();
                loadattendance();
            }
            else
            {
                MessageBox.Show("Attendance has already been recorded for today.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                //var log = new Logs
                //{
                //    EmployeeID = login.LoggedInEmployeeID,
                //    Action = Action_Type.check_out,
                //    Time_OfAction = DateTime.Now,
                //};
                //con.Logs.Add(log);
                #endregion
                attenCHOut.CheckOutTime = DateTime.Now;
                con.SaveChanges();
                loadcheckinout();
                loadattendance();

            }
            else
            {
                MessageBox.Show("You must register your attendance first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                lbllatelychecked.Text = "";
                lbltodaycom.Text = "";
                lblAttendanceStatus.Text = "Attendance recorded successfully. Thank you!";
                lblAttendanceStatus.ForeColor = Color.CornflowerBlue;
                lblLastCheckIn.BackColor = Color.Transparent;
                lblLastCheckIn.ForeColor = Color.DarkGreen;
                lblLastCheckIn.Text = "Check-In Completed ✔";
                btnCheckIn.Enabled = false;
                if (check.CheckOutTime == null)
                {
                    lbllatelychecked.Text = "";
                    lbltodaycom.Text = "";

                    btnCheckOut.Enabled = true;
                    lblLastCheckOut.Text = "Check-Out Pending...⏰";
                    lblLastCheckOut.BackColor = Color.Transparent;
                    lblLastCheckOut.ForeColor = Color.Orange;
                }
                else
                {
                    lbllatelychecked.Text = "";
                    lbltodaycom.Text = "Today's check has been successfully completed";

                    lblAttendanceStatus.Text = "Check-Out recorded successfully. Have a great day!";
                    lblAttendanceStatus.ForeColor = Color.CornflowerBlue;
                    lblLastCheckOut.BackColor = Color.Transparent;
                    lblLastCheckOut.Text = "Check-Out Completed ✔";
                    lblLastCheckOut.ForeColor = Color.DarkGreen;
                    btnCheckOut.Enabled = false;
                }
            }
            else
            {

                lbllatelychecked.Text = $"📅 Last Check-Out";

                lbltodaycom.Text = "";

                lblLastCheckIn.Text = "No Check-In Recorded Today🔺";
                lblLastCheckIn.BackColor = Color.Transparent;
                lblAttendanceStatus.Text = "Please check in to start your work day.";
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
                    CheckIn = s.CheckInTime.HasValue
    ? s.CheckInTime.Value.ToString("HH:mm")
    : "Check-In Not Recorded",

                    CheckOut = s.CheckOutTime.HasValue
    ? s.CheckOutTime.Value.ToString("HH:mm")
    : "Check-Out Not Recorded",
                    TotalHours = s.TotalHoursWorked.HasValue ? $"{s.TotalHoursWorked.Value.TotalHours:F2}hour" : "N/A",
                    LateArrival = s.LateArrival ? "Yes" : "No",
                    EarlyDeparture = s.CheckOutTime.HasValue
                         ? (s.CheckOutTime.Value.TimeOfDay < early ? "Yes" : "No")
                         : "Not Checked Out"
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
                var latestAttendance = historyAteend.First();
                if (latestAttendance.LateArrival == "Yes")
                {

                    lblLateArrival.BackColor = Color.Transparent;
                    lblLateArrival.ForeColor = Color.Red;
                    lblLateArrival.Text = "⚠ Late Arrival - Please be on time!";

                }
                else if (latestAttendance.CheckIn == "Check-In Not Recorded")
                {

                    lblLastCheckIn.ForeColor = Color.Red;
                    lblLastCheckIn.BackColor = Color.Transparent;
                    lblLateArrival.Text = "⌛ No Check-In Recorded - Awaiting Attendance";

                }
                else if (latestAttendance.CheckOut == "Check-Out Not Recorded")
                {

                    lblLastCheckOut.BackColor = Color.Transparent;
                    lblLastCheckOut.ForeColor = Color.Orange;
                    lblLateArrival.Text = "⌛ Still at Work - No Check-Out Recorded";

                }
                else
                {

                    lblLateArrival.Text = "✅ Punctual Arrival - Keep it up! 😊👍";
                    lblLateArrival.BackColor = Color.Transparent;
                    lblLateArrival.ForeColor = Color.DarkGreen;

                }


                // 
                if (latestAttendance.EarlyDeparture == "Yes")
                {
                    lblEarlyDeparture.Text = "🚨 Early Check-Out - Please follow work hours!";
                    // lblEarlyDeparture.BackColor = Color.CornflowerBlue;
                    lblEarlyDeparture.ForeColor = Color.Red;
                }
                else if (latestAttendance.EarlyDeparture == "Not Checked Out")
                {

                    lblEarlyDeparture.Text = "⌛ Still at Work - No Check-Out Yet";
                    //  lblEarlyDeparture.BackColor = Color.CornflowerBlue;
                    lblEarlyDeparture.ForeColor = Color.Orange;

                }
                else
                {

                    lblEarlyDeparture.Text = "✅ Checked Out on Time - Great Job!";
                    // lblEarlyDeparture.BackColor = Color.CornflowerBlue;
                    lblEarlyDeparture.ForeColor = Color.DarkGreen;
                }
            }


            #endregion

        }
        #region time
        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            //to show time
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        #endregion
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
            //var log = new Logs
            //{
            //    EmployeeID = login.LoggedInEmployeeID,
            //    Action = Action_Type.leave_request,
            //    Time_OfAction = DateTime.Now,
            //};
            //con.Logs.Add(log);
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
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Data Grid View
        private void CustomizeDataGridView(DataGridView dataGrid)
        {
            // تخصيص الـ DataGridView
            dataGrid.DefaultCellStyle.BackColor = Color.White; // خلفية الخلايا بيضاء
            dataGrid.DefaultCellStyle.ForeColor = Color.DarkGreen; // لون النص Dark Blue
            dataGrid.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular); // تصغير حجم الخط
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // تخصيص الـ Header
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen; // رأس الجدول Dark Blue
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // النص داخل الرأس أبيض
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // تصغير حجم الخط
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // تعطيل التصميم الافتراضي للرأس
            dataGrid.EnableHeadersVisualStyles = false;

            // لون حدود الجدول
            dataGrid.GridColor = Color.DarkGreen;

            // ارتفاع الصفوف
            dataGrid.RowTemplate.Height = 30; // تصغير ارتفاع الصفوف

            // ضبط حجم الأعمدة والصفوف تلقائيًا
            //dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }
        #endregion
        #region Button QR
        private void btnStartQR_Click(object sender, EventArgs e)
        {
            GenerateQR generateQR = new GenerateQR();

            generateQR.ShowDialog();
            var today = DateTime.Today;

            var attendata = con.Attendances.FirstOrDefault(a => a.EmployeeID == login.LoggedInEmployeeID
                && a.CheckInTime.Value.Date == today);

            if (attendata == null)
            {
                btnCheckIn_Click(sender, e);
            }
            else if (attendata.CheckOutTime == null)
            {
                btnCheckOut_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Attendance was already taken!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        #endregion
        #region show password
        private void chbshowpassold_CheckedChanged(object sender, EventArgs e)
        {
            if (chbshowpassold.Checked)
            {
                txtoldpass.PasswordChar = '\0';
            }
            else
            {
                txtoldpass.PasswordChar = '●';
            }
        }

        private void checkBox1mew_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1new.Checked)
            {
                txtnewpass.PasswordChar = '\0';
            }
            else
            {
                txtnewpass.PasswordChar = '●';
            }
        }

        private void confirm_CheckedChanged(object sender, EventArgs e)
        {
            if (confirm.Checked)
            {
                txtconfirmpass.PasswordChar = '\0';
            }
            else
            {
                txtconfirmpass.PasswordChar = '●';
            }
        }

        private void btnCheckIn_MouseHover(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.Black;
        }
        #endregion
        #region ui color
        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            btnCheckIn.BackColor = Color.RoyalBlue;
        }

        private void btnCheckOut_MouseHover(object sender, EventArgs e)
        {
            btnCheckOut.BackColor = Color.Black;
        }

        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            btnCheckOut.BackColor = Color.RoyalBlue;

        }

        private void btnStartQR_MouseHover(object sender, EventArgs e)
        {
            btnStartQR.BackColor = Color.Black;

        }

        private void btnStartQR_MouseLeave(object sender, EventArgs e)
        {
            btnStartQR.BackColor = Color.RoyalBlue;

        }

        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.Black;

        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.RoyalBlue;

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            button2.ForeColor = Color.Black;
        }

        private void btnsave_MouseHover(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.DarkBlue;
            btnsave.ForeColor = Color.White;
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.BackColor = Color.Tomato;
            btnsave.ForeColor = Color.DarkBlue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkBlue;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Tomato;
            button3.ForeColor = Color.DarkBlue;
        }

        private void txtoldpass_MouseHover(object sender, EventArgs e)
        {
            txtoldpass.BackColor = Color.White;
        }

        private void txtoldpass_MouseLeave(object sender, EventArgs e)
        {
            txtoldpass.BackColor = Color.WhiteSmoke;
        }

        private void txtnewpass_MouseHover(object sender, EventArgs e)
        {
            txtnewpass.BackColor = Color.White;
        }

        private void txtnewpass_MouseLeave(object sender, EventArgs e)
        {
            txtnewpass.BackColor = Color.WhiteSmoke;
        }

        private void txtconfirmpass_MouseHover(object sender, EventArgs e)
        {
            txtconfirmpass.BackColor = Color.White;
        }

        private void txtconfirmpass_MouseLeave(object sender, EventArgs e)
        {
            txtconfirmpass.BackColor = Color.WhiteSmoke;
        }



        private void txtReason_MouseHover(object sender, EventArgs e)
        {
            txtReason.BackColor = Color.White;
        }

        private void txtReason_MouseLeave(object sender, EventArgs e)
        {
            txtReason.BackColor = SystemColors.GradientInactiveCaption;
        }

#endregion
    }
}
