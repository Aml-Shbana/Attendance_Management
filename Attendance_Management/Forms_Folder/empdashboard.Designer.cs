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
            btnCheckIn = new System.Windows.Forms.Button();
            btnStartQR = new System.Windows.Forms.Button();
            btnCheckOut = new System.Windows.Forms.Button();
            pbCamera = new System.Windows.Forms.PictureBox();
            btnclose = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            lbldept = new System.Windows.Forms.Label();
            lblname = new System.Windows.Forms.Label();
            lblAttendanceStatus = new System.Windows.Forms.Label();
            lblCurrentTime = new System.Windows.Forms.Label();
            tabLeaveRequest = new System.Windows.Forms.TabPage();
            button1 = new System.Windows.Forms.Button();
            lblstatus = new System.Windows.Forms.Label();
            btnSubmitLeave = new System.Windows.Forms.Button();
            txtReason = new System.Windows.Forms.TextBox();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            cmbLeaveType = new System.Windows.Forms.ComboBox();
            lblleavestatus = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tabAttendanceHistory = new System.Windows.Forms.TabPage();
            lblLastCheckOut = new System.Windows.Forms.Label();
            lbltodaycom = new System.Windows.Forms.Label();
            lblLastCheckIn = new System.Windows.Forms.Label();
            lbllatelychecked = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            lblEarlyDeparture = new System.Windows.Forms.Label();
            lblLateArrival = new System.Windows.Forms.Label();
            dgvAttendanceHistory = new System.Windows.Forms.DataGridView();
            tabchange = new System.Windows.Forms.TabPage();
            confirm = new System.Windows.Forms.CheckBox();
            checkBox1new = new System.Windows.Forms.CheckBox();
            chbshowpassold = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            btnsave = new System.Windows.Forms.Button();
            txtconfirmpass = new System.Windows.Forms.TextBox();
            txtnewpass = new System.Windows.Forms.TextBox();
            txtoldpass = new System.Windows.Forms.TextBox();
            TimerClock = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabcontrolemp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCamera).BeginInit();
            tabLeaveRequest.SuspendLayout();
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
            tabControl1.Size = new System.Drawing.Size(1128, 556);
            tabControl1.TabIndex = 0;
            // 
            // tabcontrolemp
            // 
            tabcontrolemp.Controls.Add(panel1);
            tabcontrolemp.Location = new System.Drawing.Point(4, 29);
            tabcontrolemp.Name = "tabcontrolemp";
            tabcontrolemp.Padding = new System.Windows.Forms.Padding(3);
            tabcontrolemp.Size = new System.Drawing.Size(1120, 523);
            tabcontrolemp.TabIndex = 0;
            tabcontrolemp.Text = "CheckInOut";
            tabcontrolemp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
           
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(btnStartQR);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(pbCamera);
            panel1.Controls.Add(btnclose);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbldept);
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(lblAttendanceStatus);
            panel1.Controls.Add(lblCurrentTime);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(20);
            panel1.Size = new System.Drawing.Size(1114, 517);
            panel1.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = System.Drawing.Color.RoyalBlue;
            btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCheckIn.Location = new System.Drawing.Point(438, 254);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new System.Drawing.Size(205, 40);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            btnCheckIn.MouseLeave += btnCheckIn_MouseLeave;
            btnCheckIn.MouseHover += btnCheckIn_MouseHover;
            // 
            // btnStartQR
            // 
            btnStartQR.BackColor = System.Drawing.Color.RoyalBlue;
            btnStartQR.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStartQR.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnStartQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnStartQR.Location = new System.Drawing.Point(438, 358);
            btnStartQR.Name = "btnStartQR";
            btnStartQR.Size = new System.Drawing.Size(205, 40);
            btnStartQR.TabIndex = 11;
            btnStartQR.Text = "Start QR Scan";
            btnStartQR.UseVisualStyleBackColor = false;
            btnStartQR.Click += btnStartQR_Click;
            btnStartQR.MouseLeave += btnStartQR_MouseLeave;
            btnStartQR.MouseHover += btnStartQR_MouseHover;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = System.Drawing.Color.RoyalBlue;
            btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCheckOut.Enabled = false;
            btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCheckOut.Location = new System.Drawing.Point(765, 254);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new System.Drawing.Size(205, 40);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            btnCheckOut.MouseLeave += btnCheckOut_MouseLeave;
            btnCheckOut.MouseHover += btnCheckOut_MouseHover;
            // 
            // pbCamera
            // 
            pbCamera.Location = new System.Drawing.Point(612, 432);
            pbCamera.Name = "pbCamera";
            pbCamera.Size = new System.Drawing.Size(125, 62);
            pbCamera.TabIndex = 10;
            pbCamera.TabStop = false;
            // 
            // btnclose
            // 
            btnclose.BackColor = System.Drawing.Color.RoyalBlue;
            btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnclose.Location = new System.Drawing.Point(765, 363);
            btnclose.Name = "btnclose";
            btnclose.Size = new System.Drawing.Size(205, 40);
            btnclose.TabIndex = 9;
            btnclose.Text = "Close ";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            btnclose.MouseLeave += btnclose_MouseLeave;
            btnclose.MouseHover += btnclose_MouseHover;
            // 
            // label9
            // 
            label9.Cursor = System.Windows.Forms.Cursors.No;
            label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            label9.Location = new System.Drawing.Point(587, 168);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 38);
            label9.TabIndex = 8;
            // 
            // label8
            // 
            label8.Cursor = System.Windows.Forms.Cursors.No;
            label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            
            label8.Location = new System.Drawing.Point(587, 100);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 40);
            label8.TabIndex = 7;
            // 
            // lbldept
            // 
            lbldept.AutoSize = true;
            lbldept.Cursor = System.Windows.Forms.Cursors.No;
            lbldept.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbldept.ForeColor = System.Drawing.Color.Black;
            lbldept.Location = new System.Drawing.Point(696, 178);
            lbldept.Name = "lbldept";
            lbldept.Size = new System.Drawing.Size(115, 25);
            lbldept.TabIndex = 6;
            lbldept.Text = "Department";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Cursor = System.Windows.Forms.Cursors.No;
            lblname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblname.ForeColor = System.Drawing.Color.Black;
            lblname.Location = new System.Drawing.Point(696, 107);
            lblname.Name = "lblname";
            lblname.Size = new System.Drawing.Size(62, 25);
            lblname.TabIndex = 5;
            lblname.Text = "Name";
            // 
            // lblAttendanceStatus
            // 
            lblAttendanceStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblAttendanceStatus.AutoSize = true;
            lblAttendanceStatus.Cursor = System.Windows.Forms.Cursors.No;
            lblAttendanceStatus.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAttendanceStatus.ForeColor = System.Drawing.Color.Black;
            lblAttendanceStatus.Location = new System.Drawing.Point(85, 20);
            lblAttendanceStatus.Name = "lblAttendanceStatus";
            lblAttendanceStatus.Size = new System.Drawing.Size(274, 38);
            lblAttendanceStatus.TabIndex = 1;
            lblAttendanceStatus.Text = "Attendance Status";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCurrentTime.Cursor = System.Windows.Forms.Cursors.No;
            lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = System.Drawing.Color.Black;
            lblCurrentTime.Location = new System.Drawing.Point(3, 97);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new System.Drawing.Size(131, 37);
            lblCurrentTime.TabIndex = 0;
            lblCurrentTime.Text = "Current Time";
            // 
            // tabLeaveRequest
            // 
            
            tabLeaveRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabLeaveRequest.Controls.Add(button1);
            tabLeaveRequest.Controls.Add(lblstatus);
            tabLeaveRequest.Controls.Add(btnSubmitLeave);
            tabLeaveRequest.Controls.Add(txtReason);
            tabLeaveRequest.Controls.Add(dtpEndDate);
            tabLeaveRequest.Controls.Add(dtpStartDate);
            tabLeaveRequest.Controls.Add(cmbLeaveType);
            tabLeaveRequest.Controls.Add(lblleavestatus);
            tabLeaveRequest.Controls.Add(label7);
            tabLeaveRequest.Controls.Add(label6);
            tabLeaveRequest.Controls.Add(label5);
            tabLeaveRequest.Controls.Add(label4);
            tabLeaveRequest.Location = new System.Drawing.Point(4, 29);
            tabLeaveRequest.Name = "tabLeaveRequest";
            tabLeaveRequest.Padding = new System.Windows.Forms.Padding(3);
            tabLeaveRequest.Size = new System.Drawing.Size(1120, 523);
            tabLeaveRequest.TabIndex = 1;
            tabLeaveRequest.Text = "LeaveRequest";
            tabLeaveRequest.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.MediumBlue;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button1.Location = new System.Drawing.Point(669, 347);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(233, 41);
            button1.TabIndex = 12;
            button1.Text = "Close ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblstatus.Location = new System.Drawing.Point(875, 176);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new System.Drawing.Size(65, 25);
            lblstatus.TabIndex = 11;
            lblstatus.Text = "Status";
            // 
            // btnSubmitLeave
            // 
            btnSubmitLeave.BackColor = System.Drawing.Color.MediumBlue;
            btnSubmitLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSubmitLeave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSubmitLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSubmitLeave.Location = new System.Drawing.Point(669, 273);
            btnSubmitLeave.Name = "btnSubmitLeave";
            btnSubmitLeave.Size = new System.Drawing.Size(233, 41);
            btnSubmitLeave.TabIndex = 10;
            btnSubmitLeave.Text = "Submit";
            btnSubmitLeave.UseVisualStyleBackColor = false;
            btnSubmitLeave.Click += btnSubmitLeave_Click;
            // 
            // txtReason
            // 
            txtReason.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtReason.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            txtReason.Location = new System.Drawing.Point(739, 105);
            txtReason.Name = "txtReason";
            txtReason.Size = new System.Drawing.Size(241, 27);
            txtReason.TabIndex = 9;
            txtReason.MouseLeave += txtReason_MouseLeave;
            txtReason.MouseHover += txtReason_MouseHover;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dtpEndDate.CalendarForeColor = System.Drawing.Color.MediumBlue;
            dtpEndDate.Cursor = System.Windows.Forms.Cursors.PanSouth;
            dtpEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dtpEndDate.Location = new System.Drawing.Point(8, 159);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(317, 31);
            dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dtpStartDate.CalendarForeColor = System.Drawing.Color.MediumBlue;
            dtpStartDate.CalendarMonthBackground = System.Drawing.Color.White;
            dtpStartDate.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            dtpStartDate.Cursor = System.Windows.Forms.Cursors.PanSouth;
            dtpStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dtpStartDate.Location = new System.Drawing.Point(8, 62);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(317, 31);
            dtpStartDate.TabIndex = 7;
            // 
            // cmbLeaveType
            // 
            cmbLeaveType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            cmbLeaveType.Cursor = System.Windows.Forms.Cursors.PanSouth;
            cmbLeaveType.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            cmbLeaveType.FormattingEnabled = true;
            cmbLeaveType.Location = new System.Drawing.Point(739, 31);
            cmbLeaveType.Name = "cmbLeaveType";
            cmbLeaveType.Size = new System.Drawing.Size(241, 28);
            cmbLeaveType.TabIndex = 6;
            cmbLeaveType.SelectedIndexChanged += cmbLeaveType_SelectedIndexChanged;
            // 
            // lblleavestatus
            // 
            lblleavestatus.AutoSize = true;
            lblleavestatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblleavestatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblleavestatus.Location = new System.Drawing.Point(599, 176);
            lblleavestatus.Name = "lblleavestatus";
            lblleavestatus.Size = new System.Drawing.Size(135, 25);
            lblleavestatus.TabIndex = 4;
            lblleavestatus.Text = "lblLeaveStatus";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.MediumBlue;
            label7.Location = new System.Drawing.Point(539, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(182, 28);
            label7.TabIndex = 3;
            label7.Text = "Reason of holiday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.MediumBlue;
            label6.Location = new System.Drawing.Point(8, 115);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(169, 31);
            label6.TabIndex = 2;
            label6.Text = "End of holiday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.MediumBlue;
            label5.Location = new System.Drawing.Point(8, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(181, 31);
            label5.TabIndex = 1;
            label5.Text = "Start of holiday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.MediumBlue;
            label4.Location = new System.Drawing.Point(539, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 28);
            label4.TabIndex = 0;
            label4.Text = "Type of holiday";
            // 
            // tabAttendanceHistory
            // 
            
            tabAttendanceHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabAttendanceHistory.Controls.Add(lblLastCheckOut);
            tabAttendanceHistory.Controls.Add(lbltodaycom);
            tabAttendanceHistory.Controls.Add(lblLastCheckIn);
            tabAttendanceHistory.Controls.Add(lbllatelychecked);
            tabAttendanceHistory.Controls.Add(button2);
            tabAttendanceHistory.Controls.Add(lblEarlyDeparture);
            tabAttendanceHistory.Controls.Add(lblLateArrival);
            tabAttendanceHistory.Controls.Add(dgvAttendanceHistory);
            tabAttendanceHistory.Location = new System.Drawing.Point(4, 29);
            tabAttendanceHistory.Name = "tabAttendanceHistory";
            tabAttendanceHistory.Size = new System.Drawing.Size(1120, 523);
            tabAttendanceHistory.TabIndex = 2;
            tabAttendanceHistory.Text = "AttendanceHistory";
            tabAttendanceHistory.UseVisualStyleBackColor = true;
            tabAttendanceHistory.Click += tabAttendanceHistory_Click;
            // 
            // lblLastCheckOut
            // 
            lblLastCheckOut.AutoSize = true;
            lblLastCheckOut.Cursor = System.Windows.Forms.Cursors.No;
            lblLastCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLastCheckOut.ForeColor = System.Drawing.Color.Black;
            lblLastCheckOut.Location = new System.Drawing.Point(22, 471);
            lblLastCheckOut.Name = "lblLastCheckOut";
            lblLastCheckOut.Size = new System.Drawing.Size(172, 31);
            lblLastCheckOut.TabIndex = 1;
            lblLastCheckOut.Text = "Take CheckOut";
            // 
            // lbltodaycom
            // 
            lbltodaycom.AutoSize = true;
            lbltodaycom.Cursor = System.Windows.Forms.Cursors.No;
            lbltodaycom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbltodaycom.ForeColor = System.Drawing.Color.Black;
            lbltodaycom.Location = new System.Drawing.Point(571, 11);
            lbltodaycom.Name = "lbltodaycom";
            lbltodaycom.Size = new System.Drawing.Size(513, 31);
            lbltodaycom.TabIndex = 15;
            lbltodaycom.Text = "Today's check has been successfully completed";
            // 
            // lblLastCheckIn
            // 
            lblLastCheckIn.AutoSize = true;
            lblLastCheckIn.Cursor = System.Windows.Forms.Cursors.No;
            lblLastCheckIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLastCheckIn.ForeColor = System.Drawing.Color.Black;
            lblLastCheckIn.Location = new System.Drawing.Point(22, 404);
            lblLastCheckIn.Name = "lblLastCheckIn";
            lblLastCheckIn.Size = new System.Drawing.Size(153, 31);
            lblLastCheckIn.TabIndex = 0;
            lblLastCheckIn.Text = "Take CheckIn";
            // 
            // lbllatelychecked
            // 
            lbllatelychecked.AutoSize = true;
            lbllatelychecked.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbllatelychecked.ForeColor = System.Drawing.Color.Black;
            lbllatelychecked.Location = new System.Drawing.Point(723, 11);
            lbllatelychecked.Name = "lbllatelychecked";
            lbllatelychecked.Size = new System.Drawing.Size(201, 31);
            lbllatelychecked.TabIndex = 14;
            lbllatelychecked.Text = "Recently Checked";
            lbllatelychecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Yellow;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(8, 11);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 35);
            button2.TabIndex = 13;
            button2.Text = "Close ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // lblEarlyDeparture
            // 
            lblEarlyDeparture.AutoSize = true;
            lblEarlyDeparture.Cursor = System.Windows.Forms.Cursors.No;
            lblEarlyDeparture.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEarlyDeparture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblEarlyDeparture.Location = new System.Drawing.Point(620, 143);
            lblEarlyDeparture.Name = "lblEarlyDeparture";
            lblEarlyDeparture.Size = new System.Drawing.Size(181, 31);
            lblEarlyDeparture.TabIndex = 4;
            lblEarlyDeparture.Text = "Early Departure";
            // 
            // lblLateArrival
            // 
            lblLateArrival.AutoSize = true;
            lblLateArrival.Cursor = System.Windows.Forms.Cursors.No;
            lblLateArrival.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLateArrival.ForeColor = System.Drawing.Color.Black;
            lblLateArrival.Location = new System.Drawing.Point(620, 87);
            lblLateArrival.Name = "lblLateArrival";
            lblLateArrival.Size = new System.Drawing.Size(137, 31);
            lblLateArrival.TabIndex = 3;
            lblLateArrival.Text = "Late Arrival";
            // 
            // dgvAttendanceHistory
            // 
            dgvAttendanceHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dgvAttendanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendanceHistory.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            dgvAttendanceHistory.Location = new System.Drawing.Point(487, 284);
            dgvAttendanceHistory.Name = "dgvAttendanceHistory";
            dgvAttendanceHistory.RowHeadersWidth = 51;
            dgvAttendanceHistory.Size = new System.Drawing.Size(625, 218);
            dgvAttendanceHistory.TabIndex = 2;
            // 
            // tabchange
            // 
            tabchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabchange.Controls.Add(confirm);
            tabchange.Controls.Add(checkBox1new);
            tabchange.Controls.Add(chbshowpassold);
            tabchange.Controls.Add(label1);
            tabchange.Controls.Add(button3);
            tabchange.Controls.Add(btnsave);
            tabchange.Controls.Add(txtconfirmpass);
            tabchange.Controls.Add(txtnewpass);
            tabchange.Controls.Add(txtoldpass);
            tabchange.Location = new System.Drawing.Point(4, 29);
            tabchange.Name = "tabchange";
            tabchange.Padding = new System.Windows.Forms.Padding(3);
            tabchange.Size = new System.Drawing.Size(1120, 523);
            tabchange.TabIndex = 3;
            tabchange.Text = "change password";
            tabchange.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            confirm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            confirm.Location = new System.Drawing.Point(906, 307);
            confirm.Name = "confirm";
            confirm.Size = new System.Drawing.Size(16, 26);
            confirm.TabIndex = 18;
            confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            confirm.UseVisualStyleBackColor = true;
            confirm.CheckedChanged += confirm_CheckedChanged;
            // 
            // checkBox1new
            // 
            checkBox1new.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBox1new.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            checkBox1new.Location = new System.Drawing.Point(906, 253);
            checkBox1new.Name = "checkBox1new";
            checkBox1new.Size = new System.Drawing.Size(21, 24);
            checkBox1new.TabIndex = 17;
            checkBox1new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBox1new.UseVisualStyleBackColor = true;
            checkBox1new.CheckedChanged += checkBox1mew_CheckedChanged;
            // 
            // chbshowpassold
            // 
            chbshowpassold.Cursor = System.Windows.Forms.Cursors.Hand;
            chbshowpassold.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            chbshowpassold.Location = new System.Drawing.Point(906, 202);
            chbshowpassold.Name = "chbshowpassold";
            chbshowpassold.Size = new System.Drawing.Size(30, 26);
            chbshowpassold.TabIndex = 16;
            chbshowpassold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chbshowpassold.UseVisualStyleBackColor = true;
            chbshowpassold.CheckedChanged += chbshowpassold_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.Location = new System.Drawing.Point(633, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(280, 161);
            label1.TabIndex = 15;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Tomato;
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.ForeColor = System.Drawing.Color.DarkBlue;
            button3.Location = new System.Drawing.Point(633, 435);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(289, 43);
            button3.TabIndex = 14;
            button3.Text = "Close ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // btnsave
            // 
            btnsave.BackColor = System.Drawing.Color.Tomato;
            btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnsave.ForeColor = System.Drawing.Color.DarkBlue;
            btnsave.Location = new System.Drawing.Point(633, 370);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(289, 43);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            btnsave.MouseLeave += btnsave_MouseLeave;
            btnsave.MouseHover += btnsave_MouseHover;
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.BackColor = System.Drawing.Color.WhiteSmoke;
            txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtconfirmpass.ForeColor = System.Drawing.Color.MediumBlue;
            txtconfirmpass.Location = new System.Drawing.Point(642, 306);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.PasswordChar = '●';
            txtconfirmpass.PlaceholderText = "Confirm Password";
            txtconfirmpass.Size = new System.Drawing.Size(258, 27);
            txtconfirmpass.TabIndex = 12;
            txtconfirmpass.MouseLeave += txtconfirmpass_MouseLeave;
            txtconfirmpass.MouseHover += txtconfirmpass_MouseHover;
            // 
            // txtnewpass
            // 
            txtnewpass.BackColor = System.Drawing.Color.WhiteSmoke;
            txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtnewpass.ForeColor = System.Drawing.Color.MediumBlue;
            txtnewpass.Location = new System.Drawing.Point(642, 250);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.PasswordChar = '●';
            txtnewpass.PlaceholderText = "New Password";
            txtnewpass.Size = new System.Drawing.Size(258, 27);
            txtnewpass.TabIndex = 11;
            txtnewpass.MouseLeave += txtnewpass_MouseLeave;
            txtnewpass.MouseHover += txtnewpass_MouseHover;
            // 
            // txtoldpass
            // 
            txtoldpass.BackColor = System.Drawing.Color.WhiteSmoke;
            txtoldpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtoldpass.ForeColor = System.Drawing.Color.MediumBlue;
            txtoldpass.Location = new System.Drawing.Point(642, 201);
            txtoldpass.Name = "txtoldpass";
            txtoldpass.PasswordChar = '●';
            txtoldpass.PlaceholderText = "Old Password";
            txtoldpass.Size = new System.Drawing.Size(258, 27);
            txtoldpass.TabIndex = 10;
            txtoldpass.MouseLeave += txtoldpass_MouseLeave;
            txtoldpass.MouseHover += txtoldpass_MouseHover;
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
            ClientSize = new System.Drawing.Size(1128, 556);
            Controls.Add(tabControl1);
            Name = "empdashboard";
            Text = "empdashboard";
            Load += empdashboard_Load;
            tabControl1.ResumeLayout(false);
            tabcontrolemp.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            tabLeaveRequest.ResumeLayout(false);
            tabLeaveRequest.PerformLayout();
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
        private System.Windows.Forms.Button btnSubmitLeave;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label lblleavestatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStartQR;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Label lbllatelychecked;
        private System.Windows.Forms.Label lbltodaycom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox confirm;
        private System.Windows.Forms.CheckBox checkBox1new;
        private System.Windows.Forms.CheckBox chbshowpassold;
    }
}