namespace Attendance_Management.Forms_Folder
{
    partial class Forgetpassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enteremail = new System.Windows.Forms.Label();
            txtenteremail = new System.Windows.Forms.TextBox();
            btnSendOTP = new System.Windows.Forms.Button();
            btnback = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // enteremail
            // 
            enteremail.AutoSize = true;
            enteremail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            enteremail.ForeColor = System.Drawing.Color.DimGray;
            enteremail.Location = new System.Drawing.Point(23, 94);
            enteremail.Name = "enteremail";
            enteremail.Size = new System.Drawing.Size(101, 23);
            enteremail.TabIndex = 0;
            enteremail.Text = "Enter Email";
            // 
            // txtenteremail
            // 
            txtenteremail.BackColor = System.Drawing.Color.AliceBlue;
            txtenteremail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtenteremail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtenteremail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            txtenteremail.Location = new System.Drawing.Point(23, 120);
            txtenteremail.Name = "txtenteremail";
            txtenteremail.Size = new System.Drawing.Size(254, 31);
            txtenteremail.TabIndex = 1;
            txtenteremail.MouseLeave += txtenteremail_MouseLeave;
            txtenteremail.MouseHover += txtenteremail_MouseHover;
            // 
            // btnSendOTP
            // 
            btnSendOTP.BackColor = System.Drawing.Color.DimGray;
            btnSendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSendOTP.ForeColor = System.Drawing.Color.White;
            btnSendOTP.Location = new System.Drawing.Point(23, 236);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new System.Drawing.Size(254, 40);
            btnSendOTP.TabIndex = 2;
            btnSendOTP.Text = "Send";
            btnSendOTP.UseVisualStyleBackColor = false;
            btnSendOTP.Click += btnSendOTP_Click;
            btnSendOTP.MouseLeave += btnSendOTP_MouseLeave;
            btnSendOTP.MouseHover += btnSendOTP_MouseHover;
            // 
            // btnback
            // 
            btnback.BackColor = System.Drawing.Color.Transparent;
            btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            btnback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnback.ForeColor = System.Drawing.Color.Transparent;
            btnback.Image = Properties.Resources.gray_open;
            btnback.Location = new System.Drawing.Point(219, 372);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(67, 77);
            btnback.TabIndex = 3;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(txtenteremail);
            panel1.Controls.Add(btnback);
            panel1.Controls.Add(enteremail);
            panel1.Controls.Add(btnSendOTP);
            panel1.Location = new System.Drawing.Point(511, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(289, 452);
            panel1.TabIndex = 4;
            // 
            // Forgetpassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._69dcb7feb96d5be3f7de530840edef4b;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Name = "Forgetpassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Forgetpassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label enteremail;
        private System.Windows.Forms.TextBox txtenteremail;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
    }
}