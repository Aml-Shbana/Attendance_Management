namespace Attendance_Management.Forms_Folder
{
    partial class VerifyOTP
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
            setcode = new System.Windows.Forms.Label();
            txtsetcode = new System.Windows.Forms.TextBox();
            btnVerify = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            chbshowpass = new System.Windows.Forms.CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // setcode
            // 
            setcode.AutoSize = true;
            setcode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            setcode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            setcode.Location = new System.Drawing.Point(3, 234);
            setcode.Name = "setcode";
            setcode.Size = new System.Drawing.Size(87, 25);
            setcode.TabIndex = 0;
            setcode.Text = "Set Code";
            // 
            // txtsetcode
            // 
            txtsetcode.BackColor = System.Drawing.Color.AliceBlue;
            txtsetcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtsetcode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtsetcode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            txtsetcode.Location = new System.Drawing.Point(0, 262);
            txtsetcode.Name = "txtsetcode";
            txtsetcode.PasswordChar = '●';
            txtsetcode.Size = new System.Drawing.Size(236, 30);
            txtsetcode.TabIndex = 1;
            txtsetcode.MouseLeave += txtsetcode_MouseLeave;
            txtsetcode.MouseHover += txtsetcode_MouseHover;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVerify.ForeColor = System.Drawing.Color.White;
            btnVerify.Location = new System.Drawing.Point(2, 337);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new System.Drawing.Size(239, 36);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            btnVerify.MouseLeave += btnVerify_MouseLeave;
            btnVerify.MouseHover += btnVerify_MouseHover;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(236, 206);
            label1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(chbshowpass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVerify);
            panel1.Controls.Add(txtsetcode);
            panel1.Controls.Add(setcode);
            panel1.Location = new System.Drawing.Point(561, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(244, 452);
            panel1.TabIndex = 4;
            // 
            // chbshowpass
            // 
            chbshowpass.AutoSize = true;
            chbshowpass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            chbshowpass.Location = new System.Drawing.Point(38, 307);
            chbshowpass.Name = "chbshowpass";
            chbshowpass.Size = new System.Drawing.Size(106, 24);
            chbshowpass.TabIndex = 7;
            chbshowpass.Text = "Show Code";
            chbshowpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbshowpass.UseVisualStyleBackColor = true;
            chbshowpass.CheckedChanged += chbshowpass_CheckedChanged;
            // 
            // VerifyOTP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Name = "VerifyOTP";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "VerifyOTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label setcode;
        private System.Windows.Forms.TextBox txtsetcode;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbshowpass;
    }
}