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

    public partial class login : Form
    {
        //call dbcontext
        private readonly Context con = new Context();
        public static int LoggedInEmployeeID;
        public login()
        {
            InitializeComponent();

        }
        #region button login
        private void log_infun()
        {
            string email = txtemail.Text.Trim();
            string password = txtpass.Text.Trim();
            //check if isempty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both your email and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = con.Employees.FirstOrDefault(f => f.Email == email && f.Password == password);
            if (user == null)
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user != null)
            {
                //save id
                LoggedInEmployeeID = user.EmployeeID;
                MessageBox.Show($"Welcome, {user.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //set role
            switch (user.Role)
            {
                case UserRole.Admin:
                    new Admin().Show();
                    this.Hide();
                    break;

                case UserRole.HR:
                    new HR().Show();
                    this.Hide();
                    break;
                case UserRole.Employee:
                    new empdashboard().Show();
                    break;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            log_infun();

        }
        #endregion
        #region show forgetpass form

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forgetpassword().Show();
        }
        #endregion
        #region show password

        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbshowpass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '●';
            }

        }
        #endregion

        #region button clear
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemail.Text = txtpass.Text = "";
        }
        #endregion

        #region Enter
        private void btnlogin_Enter(object sender, EventArgs e)
        {
            log_infun();
        }
        #endregion


        #region ui color
        private void btnclear_MouseHover(object sender, EventArgs e)
        {
            btnclear.BackColor = Color.MediumBlue;
        }

        private void btnclear_MouseLeave(object sender, EventArgs e)
        {
            btnclear.BackColor = Color.CornflowerBlue;
        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.MediumBlue;

        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = Color.CornflowerBlue;
        }

        private void txtemail_MouseHover(object sender, EventArgs e)
        {
            txtemail.BackColor = Color.White;

        }

        private void txtemail_MouseLeave(object sender, EventArgs e)
        {
            txtemail.BackColor = Color.AliceBlue;
        }

        private void txtpass_MouseHover(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.White;
        }

        private void txtpass_MouseLeave(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.AliceBlue;
        }

        private void chbshowpass_MouseHover(object sender, EventArgs e)
        {
            chbshowpass.ForeColor = Color.MediumBlue;
        }

        private void chbshowpass_MouseLeave(object sender, EventArgs e)
        {
            chbshowpass.ForeColor = SystemColors.ActiveCaption;
        }



        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = SystemColors.ActiveCaption;

        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.MediumBlue;

        }
        #endregion
    }
}

