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
            SuspendLayout();
            // 
            // setcode
            // 
            setcode.AutoSize = true;
            setcode.Location = new System.Drawing.Point(154, 88);
            setcode.Name = "setcode";
            setcode.Size = new System.Drawing.Size(69, 20);
            setcode.TabIndex = 0;
            setcode.Text = "Set Code";
            // 
            // txtsetcode
            // 
            txtsetcode.Location = new System.Drawing.Point(280, 87);
            txtsetcode.Name = "txtsetcode";
            txtsetcode.Size = new System.Drawing.Size(125, 27);
            txtsetcode.TabIndex = 1;
            // 
            // btnVerify
            // 
            btnVerify.Location = new System.Drawing.Point(277, 235);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new System.Drawing.Size(94, 29);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // VerifyOTP
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnVerify);
            Controls.Add(txtsetcode);
            Controls.Add(setcode);
            Name = "VerifyOTP";
            Text = "VerifyOTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label setcode;
        private System.Windows.Forms.TextBox txtsetcode;
        private System.Windows.Forms.Button btnVerify;
    }
}