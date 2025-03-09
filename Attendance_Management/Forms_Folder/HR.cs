using Attendance_Management.Models;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.Forms_Folder
{
    public partial class HR : Form
    {
        private readonly Context _context;
        public HR()
        {
            InitializeComponent();
            _context = new Context();
        }

        private void HR_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadAttendance();
            LoadCMP_LogsData();
            LoadLogsData_AtDate();
            LoadData_cmb();
            LoadLeaveReuset();
            clear_data();
        }
        #region Manage Employees Tab
        #region function
        // show employee in data grid view 
        private void LoadEmployee()
        {
            dgv_employees.DataSource = _context.Employees.Where(e => e.Role == UserRole.Employee).ToList();
            dgv_employees.Columns["EmployeeID"].Visible = false;
            dgv_employees.Columns["Password"].Visible = false;
            dgv_employees.Columns["Role"].Visible = false;

            cmb_department.DataSource = Enum.GetValues(typeof(Department));
            cmb_schedule.DataSource = Enum.GetValues(typeof(WorkSchedule));

            Clear_txt();
        }

        //validation email
        private bool IsValidEmail(string email)
        {
            try
            {
                var e = new System.Net.Mail.MailAddress(email);
                return e.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //clear text boxs of employee
        private void Clear_txt()
        {
            txt_name.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_password.Text = string.Empty;
        }
        #endregion

        #region close label
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Add Button
        private void btn_add_Click(object sender, EventArgs e)
        {
            //validation name 
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Please enter the employee's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validation department 
            if (cmb_department.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate Email
            if (string.IsNullOrWhiteSpace(txt_email.Text) || !IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validation phone 
            if (string.IsNullOrWhiteSpace(txt_phone.Text) || !txt_phone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number (digits only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validate Schedule
            if (cmb_schedule.SelectedItem == null)
            {
                MessageBox.Show("Please select a schedule.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //create new employee 
            var employee = new Employee()
            {
                Name = txt_name.Text.Trim(),
                Department = (Department)Enum.Parse(typeof(Department), cmb_department.SelectedItem.ToString()),
                Email = txt_email.Text.Trim(),
                Phone = txt_phone.Text.Trim(),
                Schedule = (WorkSchedule)Enum.Parse(typeof(WorkSchedule), cmb_schedule.SelectedItem.ToString()),
                Password = txt_password.Text.Trim(),
            };
            try
            {
                _context.Add(employee);
                _context.SaveChanges();
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region row double click
        int emp_id;
        private void dgv_employees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_employees.SelectedRows.Count > 0)
            {
                emp_id = Convert.ToInt32(dgv_employees.SelectedRows[0].Cells["EmployeeID"].Value);
                var EMB = _context.Employees.FirstOrDefault(e => e.EmployeeID == emp_id);
                if (EMB != null)
                {
                    txt_name.Text = EMB.Name;
                    txt_email.Text = EMB.Email;
                    txt_password.Text = EMB.Password;
                    txt_phone.Text = EMB.Phone;
                    cmb_schedule.SelectedItem = EMB.Schedule;
                    cmb_department.SelectedItem = EMB.Department;
                }
            }
        }
        #endregion   

        #region update button

        // update button
        private void btn_update_Click(object sender, EventArgs e)
        {
            var EMP = _context.Employees.Find(emp_id);
            if (EMP != null)
            {
                EMP.Name = txt_name.Text.Trim();
                EMP.Department = (Department)Enum.Parse(typeof(Department), cmb_department.SelectedItem.ToString());
                EMP.Email = txt_email.Text.Trim();
                EMP.Phone = txt_phone.Text.Trim();
                EMP.Schedule = (WorkSchedule)Enum.Parse(typeof(WorkSchedule), cmb_schedule.SelectedItem.ToString());
                EMP.Password = txt_password.Text.Trim();

                _context.SaveChanges();
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployee();
            }
            else
            {
                MessageBox.Show("Please select an employee to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion 


        #region Delete Button 
        // delete button
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                var employee = _context.Employees.Find(emp_id);

                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployee();
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region show and hide password
        private void pb_ceyes_Click(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar == false)
            {
                pb_ceyes.Visible = false;
                pb_oeyes.Visible = true;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void pb_oeyes_Click(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar == true)
            {
                pb_ceyes.Visible = true;
                pb_oeyes.Visible = false;
                txt_password.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #endregion

        #region Attendance Tracking Tab

        #region function
        private void LoadAttendance()
        {
            //load data in data grid view 
            dgv_attendance.DataSource = _context.Attendances.Include(a => a.Employee)
                                                            .Where(e => e.Employee.Role == UserRole.Employee)
                                                            .Select(a => new
                                                            {
                                                                a.Employee.Name,
                                                                a.CheckInTime,
                                                                a.LateArrival,
                                                                a.CheckOutTime,
                                                                a.EarlyDeparture,
                                                            })
                                                            .ToList();

        }
        private void LoadData_cmb()
        {
            //load data in compo box
            cmb_employee.DataSource = _context.Employees.Where(e => e.Role == UserRole.Employee).ToList();
            cmb_employee.DisplayMember = "Name";
            cmb_employee.ValueMember = "EmployeeID";
        }
        #endregion

        #region close app button

        private void lbl_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region over view button
        private void btn_overview_Click(object sender, EventArgs e)
        {
            LoadAttendance();
            lbl_THD.Visible = false;
            lbl_chickIN.Visible = false;
            lbl_chickOUT.Visible = false;
        }

        #endregion

        #region view Employee Data depending on Emp Name
        private void Emp_Data()
        {
            lbl_THD.Visible = false;
            var result = _context.Attendances
                .Where(e => e.EmployeeID == (int)cmb_employee.SelectedValue
                         && e.CheckInTime.HasValue
                         && (e.CheckInTime.Value.Date == dtp_date.Value.Date || e.CheckInTime.Value.Date == DateTime.Today.Date))
                .Select(e => new
                {
                    e.CheckInTime,
                    e.CheckOutTime,
                    e.LateArrival,
                    e.EarlyDeparture
                })
                .FirstOrDefault();
            lbl_chickIN.Visible = true;
            lbl_chickOUT.Visible = true;

            if (result != null)
            {
                lbl_chickIN.Text = result.CheckInTime.HasValue ? $"Check-In : {result.CheckInTime.Value.TimeOfDay.ToString()}" : "No Check-In";
                lbl_chickOUT.Text = result.CheckOutTime.HasValue ? $"Check-Out :{result.CheckOutTime.Value.TimeOfDay.ToString()}" : "No Check-Out";
            }
            else
            {
                lbl_chickIN.Text = "No data available";
                lbl_chickOUT.Text = "No data available";
            }
        }

        #endregion

        #region combo box
        private void cmb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //chenge data depend on emp id and emp name 
            Emp_Data();
        }

        #endregion

        #region change data depend in date  

        //view Employee depending on date 
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            dgv_attendance.DataSource = _context.Attendances
                .Where(a => a.CheckInTime.Value.Date == dtp_date.Value.Date && a.Employee.Role == UserRole.Employee)
                .Select(a => new
                {
                    a.Employee.Name,
                    a.CheckInTime,
                    a.CheckOutTime,
                    a.LateArrival,
                    a.EarlyDeparture
                })
                .ToList();
        }
        #endregion   

        #region ideal employee button

        //view ideal Employee every month
        private void btn_idealemployee_Click(object sender, EventArgs e)
        {
            var best_emp = _context.Attendances.Include(a => a.Employee).Where(a => a.CheckInTime.Value.Month == DateTime.Now.Month).AsEnumerable()
                .GroupBy(a => a.Employee.Name)
                .Select(g => new
                {
                    EmployeeName = g.Key,
                    TotalHours = g.Sum(a => (a.CheckOutTime.Value - a.CheckInTime.Value).TotalHours)
                })
                .OrderByDescending(e => e.TotalHours).FirstOrDefault();
            if (best_emp != null)
            {
                MessageBox.Show($"Best Employee : {best_emp.EmployeeName} with a total of {best_emp.TotalHours} working hours on Month :{DateTime.Now.Month}.", "Best Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No available data.", "Best Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion 

        #region Calc Total Hour button

        private void btn_THD_Click(object sender, EventArgs e)
        {
            Emp_Data();
            var totalHours = _context.Attendances
                .AsEnumerable()
                .Where(a => a.EmployeeID == (int)cmb_employee.SelectedValue
                         && a.CheckInTime.HasValue
                         && a.CheckOutTime.HasValue
                         && a.CheckInTime.Value.Date == dtp_date.Value.Date)
                .Sum(a => (a.CheckOutTime.Value - a.CheckInTime.Value).TotalHours);

            lbl_THD.Visible = true;
            lbl_THD.Text = $"Total Hours: {totalHours:F2}";
        }

        #endregion

        #region highlight late arrival and early departure

        //highlight late arrival and early departure after load data in data grid view
        private void dgv_attendance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_attendance.Rows)
            {
                if (row.Cells["LateArrival"].Value != null && row.Cells["EarlyDeparture"].Value != null)
                {
                    var late = Convert.ToInt32(row.Cells["LateArrival"].Value);
                    var early = Convert.ToInt32(row.Cells["EarlyDeparture"].Value);

                    if (late > 0 || early > 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Leave Management Tab

        #region function
        private void LoadLeaveReuset()
        {
            dgv_Leaves.DataSource = _context.Leaves.Where(l => l.Status == LeaveStatus.Pending).Include(l => l.Employee).Select(l => new
            {
                l.LeaveRequestID,
                l.Employee.Name,
                StartDate = l.StartDate.ToString(),
                EndDate = l.EndDate.ToString(),
                l.Type,
                l.Reason,
                l.Status
            }).ToList();
            dgv_Leaves.Columns["LeaveRequestID"].Visible = false;
        }

        private void LoadApprovedLeaveReuset()
        {
            dgv_Leaves.DataSource = _context.Leaves.Where(l => l.Status == LeaveStatus.Approved).Include(l => l.Employee).Select(l => new
            {
                l.LeaveRequestID,
                l.Employee.Name,
                StartDate = l.StartDate.ToString(),
                EndDate = l.EndDate.ToString(),
                l.Type,
                l.Reason,
                l.Status
            }).ToList();
            dgv_Leaves.Columns["LeaveRequestID"].Visible = false;
        }

        private void LoadRejectedLeaveReuset()
        {
            dgv_Leaves.DataSource = _context.Leaves.Where(l => l.Status == LeaveStatus.Rejected).Include(l => l.Employee).Select(l => new
            {
                l.LeaveRequestID,
                l.Employee.Name,
                StartDate = l.StartDate.ToString(),
                EndDate = l.EndDate.ToString(),
                l.Type,
                l.Reason,
                l.Status
            }).ToList();
            dgv_Leaves.Columns["LeaveRequestID"].Visible = false;
        }

        private void clear_data()
        {
            lbl_e_email.Text = string.Empty;
            lbl_e_name.Text = string.Empty;
            lbl_startdate.Text = string.Empty;
            lbl_status.Text = string.Empty;
            lbl_type.Text = string.Empty;
            lbl_enddate.Text = string.Empty;
        }
        #endregion

        #region View all pending leave request

        //load all pending leave request
        private void btn_leaveRequest_Click(object sender, EventArgs e)
        {
            LoadLeaveReuset();
            clear_data();
        }
        #endregion

        #region View all Approved leave request
        private void btn_approvedrequest_Click(object sender, EventArgs e)
        {
            LoadApprovedLeaveReuset();
            clear_data();
        }

        #endregion

        #region View all Rejected leave request
        private void btn_RejectedRequest_Click(object sender, EventArgs e)
        {
            LoadRejectedLeaveReuset();
            clear_data();
        }

        #endregion

        #region RowHeaderMouseDoubleClick
        int leaveeId;
        private void dgv_Leaves_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_Leaves.Rows.Count > 0)
            {
                leaveeId = Convert.ToInt32(dgv_Leaves.SelectedRows[0].Cells["LeaveRequestID"].Value);
                var request = _context.Leaves.Where(l => l.LeaveRequestID == leaveeId).Include(l => l.Employee).FirstOrDefault();

                lbl_e_email.Text = request.Employee.Email;
                lbl_e_name.Text = request.Employee.Name;
                lbl_startdate.Text = request.StartDate.ToString();
                lbl_status.Text = request.Status.ToString();
                lbl_type.Text = request.Type.ToString();
                lbl_enddate.Text = request.EndDate.ToString();
            }
        }
        #endregion

        #region Approved button

        private void btn_approve_Click(object sender, EventArgs e)
        {
            var request = _context.Leaves.Where(l => l.LeaveRequestID == leaveeId).Include(l => l.Employee).FirstOrDefault();
            if (request != null)
            {
                request.Status = LeaveStatus.Approved;
                _context.Update(request);
                _context.SaveChanges();
                MessageBox.Show("Approved Request");
                LoadLeaveReuset();
            }
            else
            {
                MessageBox.Show("Request not found!");
            }
        }
        #endregion

        #region Rejected Button
        private void btn_reject_Click(object sender, EventArgs e)
        {
            var request = _context.Leaves.Where(l => l.LeaveRequestID == leaveeId).Include(l => l.Employee).FirstOrDefault();
            if (request != null)
            {
                request.Status = LeaveStatus.Rejected;
                _context.Update(request);
                _context.SaveChanges();
                MessageBox.Show("Rejected Request");
                LoadLeaveReuset();
            }
            else
            {
                MessageBox.Show("Request not found!");
            }
        }

        #endregion

        #endregion

        #region Reports Tab
        #region functions

        public void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Report");

            // إضافة عناوين الأعمدة
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
            }

            // إضافة البيانات
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                }
            }

            workbook.SaveAs(filePath);
        }

        private void DailyReport()
        {
            var daily_report = _context.Attendances.Include(a => a.Employee)
                                                         .Where(a => a.CheckInTime.HasValue && a.CheckInTime.Value.Date == DateTime.Today.Date && a.Employee.Role == UserRole.Employee)
                                                         .Select(e => new
                                                         {
                                                             e.Employee.Name,
                                                             e.CheckInTime,
                                                             e.CheckOutTime,
                                                             Status = e.LateArrival ? "Late" : "On Time",
                                                             EarlyDeparture = e.EarlyDeparture ? "Leave Early" : "Leave On Time",
                                                         }).ToList();
            dgv_reports.DataSource = daily_report;
        }

        private void WeeklyReport()
        {
            var start_date = DateTime.Today.AddDays(-7).Date;
            var weekly_report = _context.Attendances.Include(a => a.Employee)
                                .Where(e => e.CheckInTime.Value.Date >= start_date && e.CheckInTime.Value.Date <= DateTime.Today.Date && e.Employee.Role == UserRole.Employee)
                                .GroupBy(a => a.Employee.Name)
                                .Select(e => new
                                {
                                    Name = e.Key,
                                    TotalDaysPresent = e.Count(),
                                    TotalDaysAbsence = 7 - e.Count(),
                                    LateDays = e.Count(a => a.LateArrival == true),
                                    EarlyLeavesDays = e.Count(a => a.EarlyDeparture == true),
                                }).ToList();
            dgv_reports.DataSource = weekly_report;
        }

        private void MonthlyReport()
        {
            var start_date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).Date;
            var monthly_report = _context.Attendances.Include(a => a.Employee)
                                 .Where(e => e.CheckInTime.Value.Date >= start_date && e.CheckInTime.Value.Date <= DateTime.Today.Date && e.Employee.Role == UserRole.Employee)
                                 .GroupBy(a => a.Employee.Name)
                                 .Select(e => new
                                 {
                                     Name = e.Key,
                                     TotalDaysPresent = e.Count(),
                                     TotalDaysAbsence = DateTime.Today.Day - e.Count(),
                                     LateDays = e.Count(a => a.LateArrival == true),
                                     EarlyLeavesDays = e.Count(a => a.EarlyDeparture == true),
                                 }).ToList();
            dgv_reports.DataSource = monthly_report;
        }
        private void periodReport()
        {
            var start_date = dtp_sdate.Value.Date;
            var end_date = dtp_edate.Value.Date;

            var report = _context.Attendances.Include(a => a.Employee)
                                 .Where(e => e.CheckInTime.Value.Date >= start_date && e.CheckInTime.Value.Date <= end_date && e.Employee.Role == UserRole.Employee)
                                 .GroupBy(a => a.Employee.Name)
                                 .Select(e => new
                                 {
                                     Name = e.Key,
                                     TotalDaysPresent = e.Count(),
                                     TotalDaysAbsence = DateTime.Today.Day - e.Count(),
                                     LateDays = e.Count(a => a.LateArrival == true),
                                     EarlyLeavesDays = e.Count(a => a.EarlyDeparture == true),
                                 }).ToList();
            dgv_reports.DataSource = report;
        }
        #endregion

        #region buttons
        private void btn_daily_Click(object sender, EventArgs e)
        {
            DailyReport();
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {
            MonthlyReport();
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            WeeklyReport();
        }

        private void btn_RangeDate_Click(object sender, EventArgs e)
        {
            try
            {
                periodReport();
            }
            catch
            {
                MessageBox.Show("Select Start Date and End Date ");
            }
        }
        #endregion

        #endregion

        #region Logging Tab
        #region functions 
        private void LoadLogsData()
        {
            dgv_logs.DataSource = _context.Logs.Include(e => e.Employee).Where(e => e.Employee.Role == UserRole.Employee && e.EmployeeID == (int)cmb_employeelogsname.SelectedValue)
                                               .Select(e => new
                                               {
                                                   e.Employee.Name,
                                                   e.Action,
                                                   e.Time_OfAction
                                               }).OrderByDescending(l => l.Time_OfAction).ToList();
        }

        private void LoadLogsData_AtDate()
        {
            dgv_logs.DataSource = _context.Logs.Include(e => e.Employee)
                .Where(e => e.Employee.Role == UserRole.Employee && (e.Time_OfAction.Date == dtp_spacificdate.Value.Date || e.Time_OfAction.Date == DateTime.Now.Date))
                                               .Select(e => new
                                               {
                                                   e.Employee.Name,
                                                   e.Action,
                                                   e.Time_OfAction
                                               }).OrderByDescending(l => l.Time_OfAction).ToList();
        }
        private void LoadCMP_LogsData()
        {
            cmb_employeelogsname.DataSource = _context.Employees.Where(e => e.Role == UserRole.Employee).ToList();
            cmb_employeelogsname.ValueMember = "EmployeeID";
            cmb_employeelogsname.DisplayMember = "Name";
        }


        #endregion

        #region btton of change data depend in employee name and date
        private void btn_logsAtDate_Click(object sender, EventArgs e)
        {
            LoadLogsData_AtDate();
        }

        private void cmb_employeelogsname_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogsData();
        }

        #endregion

        #endregion


        private void btn_pdf_Click(object sender, EventArgs e)
        {

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_reports, "D:\\MY Career\\ITI\\LINQ\\Project\\Attendance_Management\\Files");
        }
    }
}
