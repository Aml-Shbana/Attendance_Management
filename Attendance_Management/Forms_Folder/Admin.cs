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

namespace Attendance_Management.Forms_Folder
{
    public partial class Admin : Form
    {
        private readonly Context _context;
        public Admin()
        {
            InitializeComponent();
            _context = new Context();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadEmployee();

        }
        #region Manage Employees and HR Tab
        #region function
        // show employee in data grid view 
        private void LoadEmployee()
        {
            dgv_employees.EnableHeadersVisualStyles = false;
            dgv_employees.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#658cc4");
            dgv_employees.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // لون النص لجعل العنوان واضحًا
            dgv_employees.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // تحسين الشكل

            dgv_employees.DataSource = _context.Employees.ToList();
            dgv_employees.Columns["EmployeeID"].Visible = false;
            dgv_employees.Columns["Password"].Visible = false;
            dgv_employees.Columns["ConfirmPassword"].Visible = false;


            cmb_department.DataSource = Enum.GetValues(typeof(Department));
            cmb_schedule.DataSource = Enum.GetValues(typeof(WorkSchedule));
            cmb_role.DataSource = Enum.GetValues(typeof(UserRole));

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
            // Validate Role
            if (cmb_role.SelectedItem == null)
            {
                MessageBox.Show("Please select a Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Role = (UserRole)Enum.Parse(typeof(UserRole), cmb_role.SelectedItem.ToString())
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
                    cmb_role.SelectedItem = EMB.Role;
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
                EMP.Role = (UserRole)Enum.Parse(typeof(UserRole), cmb_role.SelectedItem.ToString());
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
    }
}
