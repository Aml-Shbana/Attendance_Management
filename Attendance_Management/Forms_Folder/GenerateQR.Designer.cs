namespace Attendance_Management.Forms_Folder
{
    partial class GenerateQR
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
            pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.BackColor = System.Drawing.Color.Transparent;
            pictureBoxQR.ErrorImage = null;
            pictureBoxQR.Location = new System.Drawing.Point(336, 165);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new System.Drawing.Size(155, 91);
            pictureBoxQR.TabIndex = 0;
            pictureBoxQR.TabStop = false;
            // 
            // GenerateQR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(806, 384);
            Controls.Add(pictureBoxQR);
            Name = "GenerateQR";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GenerateQR";
            Load += GenerateQR_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQR;
    }
}