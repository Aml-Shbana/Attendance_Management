using Attendance_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Attendance_Management.Forms_Folder
{
    public partial class HR : Form
    {
        private readonly Context _context;
        private string connectionString = "Server =.; database = Attendance_Management; Trusted_Connection = True; TrustServerCertificate = True";
        private Timer pollTimer;
        private DateTime lastCheckTime = DateTime.Now;
        public HR()
        {
            InitializeComponent();
            _context = new Context();
            InitializePolling();
        }
        private void InitializePolling()
        {
            pollTimer = new Timer();
            pollTimer.Interval = 4000;
            pollTimer.Tick += PollTimer_Tick;
            pollTimer.Start();
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
            CustomizeDataGridView(dgv_attendance);
            CustomizeDataGridView(dgv_employees);
            CustomizeDataGridView(dgv_Leaves);
            CustomizeDataGridView(dgv_logs);
            CustomizeDataGridView(dgv_reports);
        }
        #region Real Time Notification

        private void PollTimer_Tick(object sender, EventArgs e)
        {
            CheckForChanges();
        }
        private Dictionary<string, DateTime> notifiedEmployees = new Dictionary<string, DateTime>();

        private void CheckForChanges()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                 SELECT E.Name, A.CheckInTime 
                 FROM Attendances A 
                 INNER JOIN Employees E ON A.EmployeeID = E.EmployeeID
                 WHERE A.LateArrival = 1 
                 AND A.CheckInTime > @LastCheckTime
                 ORDER BY A.CheckInTime ASC", conn))
                {
                    cmd.Parameters.AddWithValue("@LastCheckTime", lastCheckTime);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DateTime maxCheckInTime = lastCheckTime;

                        while (reader.Read())
                        {
                            string employeeName = reader["Name"].ToString();
                            DateTime checkInTime = Convert.ToDateTime(reader["CheckInTime"]);

                            // التحقق مما إذا كان الموظف لم يتم إشعاره بنفس الوقت
                            if (!notifiedEmployees.ContainsKey(employeeName) || notifiedEmployees[employeeName] < checkInTime)
                            {
                                MessageBox.Show($"🚨 Employee {employeeName} was late and checked in at {checkInTime:hh:mm tt}!", "Late Arrival Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                notifiedEmployees[employeeName] = checkInTime; // تخزين وقت إشعار الموظف

                                // تحديث أكبر قيمة لـ CheckInTime
                                if (checkInTime > maxCheckInTime)
                                    maxCheckInTime = checkInTime;
                            }
                        }

                        // تحديث `lastCheckTime` فقط إذا وجدنا سجلات جديدة
                        lastCheckTime = maxCheckInTime;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Manage Employees Tab
        #region function
        // show employee in data grid view 
        private void LoadEmployee()
        {
            dgv_employees.DataSource = _context.Employees.Where(e => e.Role == UserRole.Employee).ToList();
            dgv_employees.Columns["EmployeeID"].Visible = false;
            dgv_employees.Columns["Password"].Visible = false;
            dgv_employees.Columns["Role"].Visible = false;
            dgv_employees.Columns["ConfirmPassword"].Visible = false;

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
        }
        #endregion

        #region close label
        private void pb_close_Click(object sender, EventArgs e)
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
            //validation password
            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Please enter the  Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Password = txt_pass.Text.Trim(),
                ConfirmPassword = txt_pass.Text.Trim(),
                Schedule = (WorkSchedule)Enum.Parse(typeof(WorkSchedule), cmb_schedule.SelectedItem.ToString()),
                Role = UserRole.Employee
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
                    txt_phone.Text = EMB.Phone;
                    txt_pass.Text = EMB.Password;
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
                if (txt_pass.Text != EMP.Password)
                {
                    MessageBox.Show("You Don't Have Permission to Reset Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    _context.SaveChanges();
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployee();
                }
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
            var currentMonth = DateTime.Now.Month;
            var best_emp = _context.Attendances
                    .Include(a => a.Employee)
                    .Where(a => a.CheckInTime.HasValue && a.CheckOutTime.HasValue && a.CheckInTime.Value.Month == currentMonth)
                    .ToList() // جلب البيانات كـ List لتجنب أخطاء Null
                    .GroupBy(a => a.Employee.Name)
                    .Select(g => new
                    {
                        EmployeeName = g.Key,
                        TotalHours = g.Sum(a => (a.CheckOutTime.Value - a.CheckInTime.Value).TotalHours),
                        Month = currentMonth
                    })
                    .OrderByDescending(e => e.TotalHours)
                    .FirstOrDefault();
            if (best_emp != null)
            {
                new Ideal_Employee(best_emp.EmployeeName, best_emp.TotalHours, best_emp.Month).Show();
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
        private void FrequentAbsenteesReport()
        {
            var start_date = dtp_sdate.Value.Date;
            var end_date = dtp_edate.Value.Date;

            int totalDays = (end_date - start_date).Days + 1;

            var EMP = _context.Attendances.Include(e => e.Employee)
                                          .Where(e => e.Employee.Role == UserRole.Employee)
                                          .Where(e => e.CheckInTime.HasValue &&
                                                      e.CheckInTime.Value.Date >= start_date &&
                                                      e.CheckInTime.Value.Date <= end_date)
                                          .GroupBy(a => a.Employee.Name)
                                          .Select(e => new
                                          {
                                              Name = e.Key,
                                              TotalDaysPresent = e.Count(),
                                              TotalDaysAbsence = totalDays - e.Count(),
                                              LateDays = e.Count(a => a.LateArrival == true),
                                              EarlyLeavesDays = e.Count(a => a.EarlyDeparture == true),
                                          })
                                          .ToList();

            var frequentabsences = EMP.Where(e => e.TotalDaysAbsence > 5).ToList();

            dgv_reports.DataSource = frequentabsences;
        }


        private void Export_To_Excel(DataGridView gridView, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Report");
                //add header
                for (int i = 1; i <= gridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = gridView.Columns[i - 1].HeaderText;

                }
                //add table data
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = gridView.Rows[i].Cells[j].Value?.ToString();
                    }

                }
                worksheet.Cells.AutoFitColumns();
                package.SaveAs(new FileInfo(filePath));
            }
        }

        private void Export_To_PDF(DataGridView gridView, string filepath)
        {
            using (PdfWriter pdfWriter = new PdfWriter(filepath))
            {
                //create pdf file
                PdfDocument pdf = new PdfDocument(pdfWriter);
                //create document to wrire into
                Document document = new Document(pdf);
                //add address to document 
                document.Add(new Paragraph("Attendance Report")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20));
                //create table have the same number of columns of data grid view 
                Table table = new Table(UnitValue.CreatePercentArray(gridView.Columns.Count)).UseAllAvailableWidth();
                //add header
                foreach (DataGridViewColumn column in gridView.Columns)
                {
                    table.AddHeaderCell(column.HeaderText);
                }
                //add table data 
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString());
                    }
                }
                //add table to document 
                document.Add(table);
                //close document 
                document.Close();
            }
        }
        #endregion
        #region buttons
        private void btn_daily_Click(object sender, EventArgs e)
        {
            try
            {
                DailyReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_monthly_Click(object sender, EventArgs e)
        {

            try
            {
                MonthlyReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_weekly_Click(object sender, EventArgs e)
        {
            try
            {
                WeeklyReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void btn_frequentabsences_Click(object sender, EventArgs e)
        {
            try
            {
                FrequentAbsenteesReport();
            }
            catch
            {
                MessageBox.Show("Select Start Date and End Date ");
            }
        }
        #endregion

        #region pdf button
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            // create SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "Report.pdf";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                Export_To_PDF(dgv_reports, filePath);

                MessageBox.Show("Report exported to PDF successfully!");
            }
        }

        #endregion

        #region excel button

        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //select type of file
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            //title of save window
            saveFileDialog.Title = "Save Excel File";
            //take name from user 
            saveFileDialog.FileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                Export_To_Excel(dgv_reports, path);
                MessageBox.Show("Report exported to Excel successfully!");
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

        #region Data Grid View
        private void CustomizeDataGridView(DataGridView dataGrid)
        {
            // تخصيص الـ DataGridView
            dataGrid.DefaultCellStyle.BackColor = Color.White; // خلفية الخلايا بيضاء
            dataGrid.DefaultCellStyle.ForeColor = Color.DarkBlue; // لون النص Dark Blue
            dataGrid.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular); // تصغير حجم الخط
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // تخصيص الـ Header
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue; // رأس الجدول Dark Blue
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // النص داخل الرأس أبيض
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // تصغير حجم الخط
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // تعطيل التصميم الافتراضي للرأس
            dataGrid.EnableHeadersVisualStyles = false;

            // لون حدود الجدول
            dataGrid.GridColor = Color.DarkBlue;

            // ارتفاع الصفوف
            dataGrid.RowTemplate.Height = 35; // تصغير ارتفاع الصفوف

            // ضبط حجم الأعمدة والصفوف تلقائيًا
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }
        #endregion
    }
}

