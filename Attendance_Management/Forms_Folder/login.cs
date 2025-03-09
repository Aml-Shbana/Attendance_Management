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
        public login()
        {
            InitializeComponent();

        }
        public static int LoggedInEmployeeID;
        #region button login

        private void log_infun()
        {
            string email = txtemail.Text.Trim();
            string password = txtpass.Text.Trim();
            //check if isempty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = con.Employees.FirstOrDefault(f => f.Email == email && f.Password == password);
            if (user == null)
            {
                MessageBox.Show("Error", "invaild Email or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user != null)
            {
                //save id
                LoggedInEmployeeID = user.EmployeeID;
            }
            //set role
            switch (user.Role)
            {
                case UserRole.Admin:
                    //new admindashboard().Show();
                    MessageBox.Show("admin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case UserRole.HR:
                    new HR().Show();
                    // this.Hide();
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
        #region sho forgetpass form

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
                txtpass.PasswordChar = '*';
            }

        }
        #endregion

        #region button clear
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtemail.Text = txtpass.Text = "";
        }
        #endregion

        private void btnlogin_Enter(object sender, EventArgs e)
        {
            log_infun();
        }
    }
}
