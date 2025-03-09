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
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnsave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.Location = new System.Drawing.Point(412, 251);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.Size = new System.Drawing.Size(125, 27);
            txtconfirmpass.TabIndex = 16;
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new System.Drawing.Point(412, 173);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.Size = new System.Drawing.Size(125, 27);
            txtnewpass.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(263, 258);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 20);
            label3.TabIndex = 14;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(263, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 13;
            label2.Text = "New Password";
            // 
            // btnsave
            // 
            btnsave.Location = new System.Drawing.Point(579, 347);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(94, 29);
            btnsave.TabIndex = 17;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnsave);
            Controls.Add(txtconfirmpass);
            Controls.Add(txtnewpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
    }
}