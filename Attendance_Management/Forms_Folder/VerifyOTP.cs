using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Attendance_Management.Forms_Folder
{
    public partial class VerifyOTP : Form
    {
        private string userEmail; // تخزين البريد الإلكتروني
        private string correctOTP; // تخزين كود التحقق الصحيح
        public VerifyOTP(string email, string otp)
        {
            InitializeComponent();
            userEmail = email; //  حفظ البريد الالكتروني
            correctOTP = otp; // حفظ كود التحقق
        }
        #region button verify code
      
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtsetcode.Text.Trim() == correctOTP) // التحقق من  الكود المدخل هو هو الكود الصحيح
            {
                MessageBox.Show("success"," success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
                new ResetPassword(userEmail).Show(); 
            }
            else
            {
                MessageBox.Show("correct code", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
