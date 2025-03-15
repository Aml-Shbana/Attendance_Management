namespace Attendance_Management.Forms_Folder
{
    partial class ResetPassword
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
            txtconfirmpass = new System.Windows.Forms.TextBox();
            txtnewpass = new System.Windows.Forms.TextBox();
            btnsave = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            checkBox1 = new System.Windows.Forms.CheckBox();
            chbshowpassold = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblreset = new System.Windows.Forms.Label();
            btnback = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.BackColor = System.Drawing.Color.AliceBlue;
            txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtconfirmpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtconfirmpass.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            txtconfirmpass.Location = new System.Drawing.Point(107, 302);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.PasswordChar = '●';
            txtconfirmpass.PlaceholderText = "Confirm Passowrd";
            txtconfirmpass.Size = new System.Drawing.Size(309, 27);
            txtconfirmpass.TabIndex = 16;
            txtconfirmpass.MouseLeave += txtconfirmpass_MouseLeave;
            txtconfirmpass.MouseHover += txtconfirmpass_MouseHover;
            // 
            // txtnewpass
            // 
            txtnewpass.BackColor = System.Drawing.Color.AliceBlue;
            txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtnewpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtnewpass.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            txtnewpass.Location = new System.Drawing.Point(107, 231);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.PasswordChar = '●';
            txtnewpass.PlaceholderText = "New Passord";
            txtnewpass.Size = new System.Drawing.Size(309, 27);
            txtnewpass.TabIndex = 15;
            txtnewpass.MouseLeave += txtnewpass_MouseLeave;
            txtnewpass.MouseHover += txtnewpass_MouseHover;
            // 
            // btnsave
            // 
            btnsave.BackColor = System.Drawing.Color.RoyalBlue;
            btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnsave.ForeColor = System.Drawing.Color.White;
            btnsave.Location = new System.Drawing.Point(107, 367);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(309, 40);
            btnsave.TabIndex = 17;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            btnsave.MouseLeave += btnsave_MouseLeave;
            btnsave.MouseHover += btnsave_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(btnback);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(chbshowpassold);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(txtnewpass);
            panel1.Controls.Add(txtconfirmpass);
            panel1.Location = new System.Drawing.Point(296, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(513, 498);
            panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            checkBox1.Location = new System.Drawing.Point(422, 231);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(30, 27);
            checkBox1.TabIndex = 20;
            checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chbshowpassold
            // 
            chbshowpassold.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            chbshowpassold.Location = new System.Drawing.Point(422, 302);
            chbshowpassold.Name = "chbshowpassold";
            chbshowpassold.Size = new System.Drawing.Size(30, 26);
            chbshowpassold.TabIndex = 19;
            chbshowpassold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbshowpassold.UseVisualStyleBackColor = true;
            chbshowpassold.CheckedChanged += chbshowpassold_CheckedChanged;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(107, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(312, 176);
            label4.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(lblreset);
            panel2.Location = new System.Drawing.Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(299, 258);
            panel2.TabIndex = 19;
            // 
            // lblreset
            // 
            lblreset.AutoSize = true;
            lblreset.Font = new System.Drawing.Font("Elephant", 16.1999989F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblreset.ForeColor = System.Drawing.Color.RoyalBlue;
            lblreset.Location = new System.Drawing.Point(45, 91);
            lblreset.Name = "lblreset";
            lblreset.Size = new System.Drawing.Size(245, 35);
            lblreset.TabIndex = 0;
            lblreset.Text = "Reset Password";
            lblreset.MouseLeave += lblreset_MouseLeave;
            lblreset.MouseHover += lblreset_MouseHover;
            // 
            // btnback
            // 
            btnback.BackColor = System.Drawing.Color.Transparent;
            btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            btnback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnback.ForeColor = System.Drawing.Color.Transparent;
            btnback.Location = new System.Drawing.Point(452, 435);
            btnback.Name = "btnback";
            btnback.Size = new System.Drawing.Size(58, 60);
            btnback.TabIndex = 21;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(809, 498);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ResetPassword";
            Text = "ResetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chbshowpassold;
        private System.Windows.Forms.Button btnback;
    }
}