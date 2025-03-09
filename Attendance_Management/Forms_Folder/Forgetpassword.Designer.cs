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
            SuspendLayout();
            // 
            // enteremail
            // 
            enteremail.AutoSize = true;
            enteremail.Location = new System.Drawing.Point(109, 137);
            enteremail.Name = "enteremail";
            enteremail.Size = new System.Drawing.Size(84, 20);
            enteremail.TabIndex = 0;
            enteremail.Text = "Enter Email";
            // 
            // txtenteremail
            // 
            txtenteremail.Location = new System.Drawing.Point(224, 134);
            txtenteremail.Name = "txtenteremail";
            txtenteremail.Size = new System.Drawing.Size(125, 27);
            txtenteremail.TabIndex = 1;
            // 
            // btnSendOTP
            // 
            btnSendOTP.Location = new System.Drawing.Point(469, 284);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new System.Drawing.Size(94, 29);
            btnSendOTP.TabIndex = 2;
            btnSendOTP.Text = "SendOTP";
            btnSendOTP.UseVisualStyleBackColor = true;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // btnback
            // 
            btnback.Location = new System.Drawing.Point(102, 380);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(94, 29);
            btnback.TabIndex = 3;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // Forgetpassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnback);
            Controls.Add(btnSendOTP);
            Controls.Add(txtenteremail);
            Controls.Add(enteremail);
            Name = "Forgetpassword";
            Text = "Forgetpassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label enteremail;
        private System.Windows.Forms.TextBox txtenteremail;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Button btnback;
    }
}