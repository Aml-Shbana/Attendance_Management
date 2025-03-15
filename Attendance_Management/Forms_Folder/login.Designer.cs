namespace Attendance_Management.Forms_Folder
{
    partial class login
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
            txtemail = new System.Windows.Forms.TextBox();
            txtpass = new System.Windows.Forms.TextBox();
            btnlogin = new System.Windows.Forms.Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            chbshowpass = new System.Windows.Forms.CheckBox();
            btnclear = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtemail
            // 
            txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtemail.BackColor = System.Drawing.Color.AliceBlue;
            txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtemail.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            txtemail.Location = new System.Drawing.Point(19, 72);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = " Email";
            txtemail.Size = new System.Drawing.Size(239, 34);
            txtemail.TabIndex = 2;
            txtemail.MouseLeave += txtemail_MouseLeave;
            txtemail.MouseHover += txtemail_MouseHover;
            // 
            // txtpass
            // 
            txtpass.BackColor = System.Drawing.Color.AliceBlue;
            txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtpass.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            txtpass.Location = new System.Drawing.Point(19, 131);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '●';
            txtpass.PlaceholderText = "Password";
            txtpass.Size = new System.Drawing.Size(239, 34);
            txtpass.TabIndex = 3;
            txtpass.MouseLeave += txtpass_MouseLeave;
            txtpass.MouseHover += txtpass_MouseHover;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = System.Drawing.Color.CornflowerBlue;
            btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnlogin.Location = new System.Drawing.Point(28, 320);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new System.Drawing.Size(219, 37);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            btnlogin.Enter += btnlogin_Enter;
            btnlogin.MouseLeave += btnlogin_MouseLeave;
            btnlogin.MouseHover += btnlogin_MouseHover;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            linkLabel1.DisabledLinkColor = System.Drawing.Color.MediumBlue;
            linkLabel1.ForeColor = System.Drawing.Color.MediumBlue;
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new System.Drawing.Point(71, 223);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(128, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Passowrd ?";
            linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseEnter += linkLabel1_MouseEnter;
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
            // 
            // chbshowpass
            // 
            chbshowpass.AutoSize = true;
            chbshowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            chbshowpass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            chbshowpass.Location = new System.Drawing.Point(19, 186);
            chbshowpass.Name = "chbshowpass";
            chbshowpass.Size = new System.Drawing.Size(132, 24);
            chbshowpass.TabIndex = 6;
            chbshowpass.Text = "Show Password";
            chbshowpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbshowpass.UseVisualStyleBackColor = true;
            chbshowpass.CheckedChanged += chbshowpass_CheckedChanged;
            chbshowpass.MouseLeave += chbshowpass_MouseLeave;
            chbshowpass.MouseHover += chbshowpass_MouseHover;
            // 
            // btnclear
            // 
            btnclear.BackColor = System.Drawing.Color.CornflowerBlue;
            btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnclear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnclear.Location = new System.Drawing.Point(28, 265);
            btnclear.Name = "btnclear";
            btnclear.Size = new System.Drawing.Size(219, 37);
            btnclear.TabIndex = 7;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            btnclear.MouseLeave += btnclear_MouseLeave;
            btnclear.MouseHover += btnclear_MouseHover;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Cursor = System.Windows.Forms.Cursors.No;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            label1.Location = new System.Drawing.Point(53, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 52);
            label1.TabIndex = 9;
            label1.Text = "Welcome";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Snow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(chbshowpass);
            panel1.Location = new System.Drawing.Point(470, 49);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(276, 360);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.CornflowerBlue;
            label2.Cursor = System.Windows.Forms.Cursors.No;
            label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(19, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(239, 34);
            label2.TabIndex = 8;
            label2.Text = "Login Page";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(818, 474);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chbshowpass;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}