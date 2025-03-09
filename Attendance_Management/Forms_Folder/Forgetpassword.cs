using Attendance_Management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.Forms_Folder
{
    public partial class Forgetpassword : Form
    {
        private readonly Context con = new Context();
        private string generatedOTP; // تخزين كود التحقق
        private string userEmail; // تخزين البريد الإلكتروني اللي دخلته
        public Forgetpassword()
        {
            InitializeComponent();
        }
        #region button send otp
        
        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            userEmail = txtenteremail.Text;
            var user = con.Employees.FirstOrDefault(e => e.Email == userEmail);
            if (user == null)
            {
                MessageBox.Show("correct email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            generatedOTP = random.Next(100000, 999999).ToString();
            if (SendOTPEmail(userEmail, generatedOTP))
            {    // إرسال البريد الإلكتروني
                MessageBox.Show("send code", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new VerifyOTP(userEmail, generatedOTP).Show();
            }
            else
            {
                MessageBox.Show("fail send email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
        #region SendOTPEmail

        private bool SendOTPEmail(string toEmail, string otp)
        {
            try
            {
                var smtp = new SmtpClient("smtp.gmail.com", 587)
                {            
                    Credentials = new NetworkCredential("amlshbana28@gmail.com", "uurb sohj tkhl mlnj"),
                    EnableSsl = true // تفعيل تشفير SSL
                };
                smtp.Send("your-email@gmail.com", toEmail, "code ", $"the code is: {otp}"); // إرسال البريد الإلكتروني
                return true;
            }
            catch
            {
                return false; 
            }
        }
        #endregion
        #region button back

        private void btnback_Click(object sender, EventArgs e)
        {
            login l=new login();
            l.Show();
            this.Close();
        }
        #endregion
    }
}
