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
        }
        #region Manage Employees Tab
        #region function
        // show employee in data grid view 
        private void LoadEmployee()
        {
            dgv_employees.DataSource = _context.Employees.ToList();
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
            if(txt_password.UseSystemPasswordChar == false)
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
    }
}
