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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;
namespace Attendance_Management.Forms_Folder
{
    public partial class ResetPassword : Form
    {
        private readonly Context con = new Context();

        private string userEmail; // البريد الإلكتروني لل user الحالي
        public ResetPassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }
        #region save new password
       
        private void btnsave_Click(object sender, EventArgs e)
        {
            string newPassword = txtnewpass.Text.Trim();
            string confirmPassword = txtconfirmpass.Text.Trim();

            if (newPassword.Length < 6) // الكود الجديد ميقلش عن 6 حروف
            {
                MessageBox.Show("password shoud be 6 numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword) 
            {
                MessageBox.Show("new != confirm", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword); // تشفير كلمة المرور
            var user = con.Employees.FirstOrDefault(x => x.Email == userEmail);
            if (user != null) { 
                user.Password = newPassword; 
            con.SaveChanges(); 
            MessageBox.Show("success change password!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
            else
            {
                MessageBox.Show("Error change password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
    #endregion
}
