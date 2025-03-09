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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtemail = new System.Windows.Forms.TextBox();
            txtpass = new System.Windows.Forms.TextBox();
            btnlogin = new System.Windows.Forms.Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            chbshowpass = new System.Windows.Forms.CheckBox();
            btnclear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(91, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(91, 180);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // txtemail
            // 
            txtemail.Location = new System.Drawing.Point(271, 100);
            txtemail.Name = "txtemail";
            txtemail.Size = new System.Drawing.Size(266, 27);
            txtemail.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Location = new System.Drawing.Point(271, 180);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new System.Drawing.Size(266, 27);
            txtpass.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Location = new System.Drawing.Point(491, 348);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new System.Drawing.Size(94, 51);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            btnlogin.Enter += btnlogin_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(245, 295);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(117, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Passowrd";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // chbshowpass
            // 
            chbshowpass.AutoSize = true;
            chbshowpass.Location = new System.Drawing.Point(303, 235);
            chbshowpass.Name = "chbshowpass";
            chbshowpass.Size = new System.Drawing.Size(132, 24);
            chbshowpass.TabIndex = 6;
            chbshowpass.Text = "Show Password";
            chbshowpass.UseVisualStyleBackColor = true;
            chbshowpass.CheckedChanged += chbshowpass_CheckedChanged;
            // 
            // btnclear
            // 
            btnclear.Location = new System.Drawing.Point(511, 282);
            btnclear.Name = "btnclear";
            btnclear.Size = new System.Drawing.Size(94, 29);
            btnclear.TabIndex = 7;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnclear);
            Controls.Add(chbshowpass);
            Controls.Add(linkLabel1);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chbshowpass;
        private System.Windows.Forms.Button btnclear;
    }
}