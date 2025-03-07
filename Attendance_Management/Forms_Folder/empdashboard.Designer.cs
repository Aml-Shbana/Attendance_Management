namespace Attendance_Management.Forms_Folder
{
    partial class empdashboard
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
            components = new System.ComponentModel.Container();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabcontrolemp = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnCheckIn = new System.Windows.Forms.Button();
            btnCheckOut = new System.Windows.Forms.Button();
            lblAttendanceStatus = new System.Windows.Forms.Label();
            lblCurrentTime = new System.Windows.Forms.Label();
            tabLeaveRequest = new System.Windows.Forms.TabPage();
            tabAttendanceHistory = new System.Windows.Forms.TabPage();
            lblEarlyDeparture = new System.Windows.Forms.Label();
            lblLateArrival = new System.Windows.Forms.Label();
            dgvAttendanceHistory = new System.Windows.Forms.DataGridView();
            lblLastCheckOut = new System.Windows.Forms.Label();
            lblLastCheckIn = new System.Windows.Forms.Label();
            tabchange = new System.Windows.Forms.TabPage();
            btnsave = new System.Windows.Forms.Button();
            txtconfirmpass = new System.Windows.Forms.TextBox();
            txtnewpass = new System.Windows.Forms.TextBox();
            txtoldpass = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TimerClock = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabcontrolemp.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabAttendanceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).BeginInit();
            tabchange.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabcontrolemp);
            tabControl1.Controls.Add(tabLeaveRequest);
            tabControl1.Controls.Add(tabAttendanceHistory);
            tabControl1.Controls.Add(tabchange);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(938, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabcontrolemp
            // 
            tabcontrolemp.Controls.Add(panel1);
            tabcontrolemp.Location = new System.Drawing.Point(4, 29);
            tabcontrolemp.Name = "tabcontrolemp";
            tabcontrolemp.Padding = new System.Windows.Forms.Padding(3);
            tabcontrolemp.Size = new System.Drawing.Size(930, 479);
            tabcontrolemp.TabIndex = 0;
            tabcontrolemp.Text = "CheckInOut";
            tabcontrolemp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblAttendanceStatus);
            panel1.Controls.Add(lblCurrentTime);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(20);
            panel1.Size = new System.Drawing.Size(924, 473);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCheckIn);
            flowLayoutPanel1.Controls.Add(btnCheckOut);
            flowLayoutPanel1.Location = new System.Drawing.Point(448, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            flowLayoutPanel1.Size = new System.Drawing.Size(205, 268);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new System.Drawing.Point(13, 13);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new System.Drawing.Size(143, 62);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Enabled = false;
            btnCheckOut.Location = new System.Drawing.Point(13, 81);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(143, 62);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lblAttendanceStatus
            // 
            lblAttendanceStatus.AutoSize = true;
            lblAttendanceStatus.Dock = System.Windows.Forms.DockStyle.Top;
            lblAttendanceStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAttendanceStatus.ForeColor = System.Drawing.Color.Black;
            lblAttendanceStatus.Location = new System.Drawing.Point(20, 58);
            lblAttendanceStatus.Name = "lblAttendanceStatus";
            lblAttendanceStatus.Size = new System.Drawing.Size(256, 38);
            lblAttendanceStatus.TabIndex = 1;
            lblAttendanceStatus.Text = "Attendance Status";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Dock = System.Windows.Forms.DockStyle.Top;
            lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = System.Drawing.Color.Black;
            lblCurrentTime.Location = new System.Drawing.Point(20, 20);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new System.Drawing.Size(189, 38);
            lblCurrentTime.TabIndex = 0;
            lblCurrentTime.Text = "Current Time";
            // 
            // tabLeaveRequest
            // 
            tabLeaveRequest.Location = new System.Drawing.Point(4, 29);
            tabLeaveRequest.Name = "tabLeaveRequest";
            tabLeaveRequest.Padding = new System.Windows.Forms.Padding(3);
            tabLeaveRequest.Size = new System.Drawing.Size(930, 479);
            tabLeaveRequest.TabIndex = 1;
            tabLeaveRequest.Text = "LeaveRequest";
            tabLeaveRequest.UseVisualStyleBackColor = true;
            // 
            // tabAttendanceHistory
            // 
            tabAttendanceHistory.Controls.Add(lblEarlyDeparture);
            tabAttendanceHistory.Controls.Add(lblLateArrival);
            tabAttendanceHistory.Controls.Add(dgvAttendanceHistory);
            tabAttendanceHistory.Controls.Add(lblLastCheckOut);
            tabAttendanceHistory.Controls.Add(lblLastCheckIn);
            tabAttendanceHistory.Location = new System.Drawing.Point(4, 29);
            tabAttendanceHistory.Name = "tabAttendanceHistory";
            tabAttendanceHistory.Size = new System.Drawing.Size(930, 479);
            tabAttendanceHistory.TabIndex = 2;
            tabAttendanceHistory.Text = "AttendanceHistory";
            tabAttendanceHistory.UseVisualStyleBackColor = true;
            tabAttendanceHistory.Click += tabAttendanceHistory_Click;
            // 
            // lblEarlyDeparture
            // 
            lblEarlyDeparture.AutoSize = true;
            lblEarlyDeparture.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEarlyDeparture.ForeColor = System.Drawing.Color.Black;
            lblEarlyDeparture.Location = new System.Drawing.Point(595, 373);
            lblEarlyDeparture.Name = "lblEarlyDeparture";
            lblEarlyDeparture.Size = new System.Drawing.Size(181, 31);
            lblEarlyDeparture.TabIndex = 4;
            lblEarlyDeparture.Text = "Early Departure";
            // 
            // lblLateArrival
            // 
            lblLateArrival.AutoSize = true;
            lblLateArrival.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLateArrival.ForeColor = System.Drawing.Color.Black;
            lblLateArrival.Location = new System.Drawing.Point(60, 373);
            lblLateArrival.Name = "lblLateArrival";
            lblLateArrival.Size = new System.Drawing.Size(137, 31);
            lblLateArrival.TabIndex = 3;
            lblLateArrival.Text = "Late Arrival";
            // 
            // dgvAttendanceHistory
            // 
            dgvAttendanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendanceHistory.Location = new System.Drawing.Point(342, 0);
            dgvAttendanceHistory.Name = "dgvAttendanceHistory";
            dgvAttendanceHistory.RowHeadersWidth = 51;
            dgvAttendanceHistory.Size = new System.Drawing.Size(545, 268);
            dgvAttendanceHistory.TabIndex = 2;
            // 
            // lblLastCheckOut
            // 
            lblLastCheckOut.AutoSize = true;
            lblLastCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLastCheckOut.Location = new System.Drawing.Point(79, 118);
            lblLastCheckOut.Name = "lblLastCheckOut";
            lblLastCheckOut.Size = new System.Drawing.Size(172, 31);
            lblLastCheckOut.TabIndex = 1;
            lblLastCheckOut.Text = "Take CheckOut";
            // 
            // lblLastCheckIn
            // 
            lblLastCheckIn.AutoSize = true;
            lblLastCheckIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLastCheckIn.Location = new System.Drawing.Point(79, 60);
            lblLastCheckIn.Name = "lblLastCheckIn";
            lblLastCheckIn.Size = new System.Drawing.Size(153, 31);
            lblLastCheckIn.TabIndex = 0;
            lblLastCheckIn.Text = "Take CheckIn";
            // 
            // tabchange
            // 
            tabchange.Controls.Add(btnsave);
            tabchange.Controls.Add(txtconfirmpass);
            tabchange.Controls.Add(txtnewpass);
            tabchange.Controls.Add(txtoldpass);
            tabchange.Controls.Add(label3);
            tabchange.Controls.Add(label2);
            tabchange.Controls.Add(label1);
            tabchange.Location = new System.Drawing.Point(4, 29);
            tabchange.Name = "tabchange";
            tabchange.Padding = new System.Windows.Forms.Padding(3);
            tabchange.Size = new System.Drawing.Size(930, 479);
            tabchange.TabIndex = 3;
            tabchange.Text = "change password";
            tabchange.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Location = new System.Drawing.Point(604, 344);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(94, 29);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.Location = new System.Drawing.Point(382, 253);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.Size = new System.Drawing.Size(125, 27);
            txtconfirmpass.TabIndex = 12;
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new System.Drawing.Point(382, 175);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.Size = new System.Drawing.Size(125, 27);
            txtnewpass.TabIndex = 11;
            // 
            // txtoldpass
            // 
            txtoldpass.Location = new System.Drawing.Point(366, 105);
            txtoldpass.Name = "txtoldpass";
            txtoldpass.Size = new System.Drawing.Size(125, 27);
            txtoldpass.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(233, 260);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 20);
            label3.TabIndex = 9;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(233, 178);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 8;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(235, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Old Password";
            // 
            // TimerClock
            // 
            TimerClock.Enabled = true;
            TimerClock.Interval = 1000;
            // 
            // empdashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(938, 512);
            Controls.Add(tabControl1);
            Name = "empdashboard";
            Text = "empdashboard";
            Load += empdashboard_Load;
            tabControl1.ResumeLayout(false);
            tabcontrolemp.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tabAttendanceHistory.ResumeLayout(false);
            tabAttendanceHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).EndInit();
            tabchange.ResumeLayout(false);
            tabchange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabcontrolemp;
        private System.Windows.Forms.TabPage tabLeaveRequest;
        private System.Windows.Forms.TabPage tabAttendanceHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer TimerClock;
        private System.Windows.Forms.DataGridView dgvAttendanceHistory;
        private System.Windows.Forms.Label lblLastCheckOut;
        private System.Windows.Forms.Label lblLastCheckIn;
        private System.Windows.Forms.Label lblEarlyDeparture;
        private System.Windows.Forms.Label lblLateArrival;
        private System.Windows.Forms.TabPage tabchange;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}