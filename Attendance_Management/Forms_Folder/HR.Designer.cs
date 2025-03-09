namespace Attendance_Management.Forms_Folder
{
    partial class HR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR));
            tab_AttendanceTracking = new System.Windows.Forms.TabControl();
            tab_ManageEmployees = new System.Windows.Forms.TabPage();
            pb_ceyes = new System.Windows.Forms.PictureBox();
            pb_oeyes = new System.Windows.Forms.PictureBox();
            lbl_close = new System.Windows.Forms.Label();
            dgv_employees = new System.Windows.Forms.DataGridView();
            btn_delete = new System.Windows.Forms.Button();
            btn_update = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            cmb_department = new System.Windows.Forms.ComboBox();
            cmb_schedule = new System.Windows.Forms.ComboBox();
            txt_password = new System.Windows.Forms.TextBox();
            txt_email = new System.Windows.Forms.TextBox();
            txt_phone = new System.Windows.Forms.TextBox();
            txt_name = new System.Windows.Forms.TextBox();
            lbl_password = new System.Windows.Forms.Label();
            lbl_phone = new System.Windows.Forms.Label();
            lbl_schedule = new System.Windows.Forms.Label();
            lbl_email = new System.Windows.Forms.Label();
            lbl_department = new System.Windows.Forms.Label();
            lbl_name = new System.Windows.Forms.Label();
            tabPage_AttendanceTracking = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            lbl_chickIN = new System.Windows.Forms.Label();
            lbl_empname = new System.Windows.Forms.Label();
            cmb_employee = new System.Windows.Forms.ComboBox();
            btn_addattendace = new System.Windows.Forms.Button();
            lbl_THD = new System.Windows.Forms.Label();
            lbl_chickOUT = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btn_overview = new System.Windows.Forms.Button();
            btn_idealemployee = new System.Windows.Forms.Button();
            btn_THD = new System.Windows.Forms.Button();
            dgv_attendance = new System.Windows.Forms.DataGridView();
            dtp_date = new System.Windows.Forms.DateTimePicker();
            lbl_closeApp = new System.Windows.Forms.Label();
            lbl_date = new System.Windows.Forms.Label();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tab_AttendanceTracking.SuspendLayout();
            tab_ManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ceyes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_oeyes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_employees).BeginInit();
            tabPage_AttendanceTracking.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_attendance).BeginInit();
            SuspendLayout();
            // 
            // tab_AttendanceTracking
            // 
            tab_AttendanceTracking.Controls.Add(tab_ManageEmployees);
            tab_AttendanceTracking.Controls.Add(tabPage_AttendanceTracking);
            tab_AttendanceTracking.Controls.Add(tabPage3);
            tab_AttendanceTracking.Controls.Add(tabPage4);
            tab_AttendanceTracking.Location = new System.Drawing.Point(2, 12);
            tab_AttendanceTracking.Name = "tab_AttendanceTracking";
            tab_AttendanceTracking.SelectedIndex = 0;
            tab_AttendanceTracking.Size = new System.Drawing.Size(1141, 436);
            tab_AttendanceTracking.TabIndex = 0;
            // 
            // tab_ManageEmployees
            // 
            tab_ManageEmployees.Controls.Add(pb_ceyes);
            tab_ManageEmployees.Controls.Add(pb_oeyes);
            tab_ManageEmployees.Controls.Add(lbl_close);
            tab_ManageEmployees.Controls.Add(dgv_employees);
            tab_ManageEmployees.Controls.Add(btn_delete);
            tab_ManageEmployees.Controls.Add(btn_update);
            tab_ManageEmployees.Controls.Add(btn_add);
            tab_ManageEmployees.Controls.Add(cmb_department);
            tab_ManageEmployees.Controls.Add(cmb_schedule);
            tab_ManageEmployees.Controls.Add(txt_password);
            tab_ManageEmployees.Controls.Add(txt_email);
            tab_ManageEmployees.Controls.Add(txt_phone);
            tab_ManageEmployees.Controls.Add(txt_name);
            tab_ManageEmployees.Controls.Add(lbl_password);
            tab_ManageEmployees.Controls.Add(lbl_phone);
            tab_ManageEmployees.Controls.Add(lbl_schedule);
            tab_ManageEmployees.Controls.Add(lbl_email);
            tab_ManageEmployees.Controls.Add(lbl_department);
            tab_ManageEmployees.Controls.Add(lbl_name);
            tab_ManageEmployees.Location = new System.Drawing.Point(4, 29);
            tab_ManageEmployees.Name = "tab_ManageEmployees";
            tab_ManageEmployees.Padding = new System.Windows.Forms.Padding(3);
            tab_ManageEmployees.Size = new System.Drawing.Size(1133, 403);
            tab_ManageEmployees.TabIndex = 0;
            tab_ManageEmployees.Text = "Manage Employees";
            tab_ManageEmployees.UseVisualStyleBackColor = true;
            // 
            // pb_ceyes
            // 
            pb_ceyes.Image = (System.Drawing.Image)resources.GetObject("pb_ceyes.Image");
            pb_ceyes.Location = new System.Drawing.Point(467, 182);
            pb_ceyes.Name = "pb_ceyes";
            pb_ceyes.Size = new System.Drawing.Size(32, 27);
            pb_ceyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_ceyes.TabIndex = 18;
            pb_ceyes.TabStop = false;
            pb_ceyes.Visible = false;
            pb_ceyes.Click += pb_ceyes_Click;
            // 
            // pb_oeyes
            // 
            pb_oeyes.Image = (System.Drawing.Image)resources.GetObject("pb_oeyes.Image");
            pb_oeyes.Location = new System.Drawing.Point(467, 182);
            pb_oeyes.Name = "pb_oeyes";
            pb_oeyes.Size = new System.Drawing.Size(32, 27);
            pb_oeyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_oeyes.TabIndex = 17;
            pb_oeyes.TabStop = false;
            pb_oeyes.Click += pb_oeyes_Click;
            // 
            // lbl_close
            // 
            lbl_close.AutoSize = true;
            lbl_close.Location = new System.Drawing.Point(1032, 364);
            lbl_close.Name = "lbl_close";
            lbl_close.Size = new System.Drawing.Size(77, 20);
            lbl_close.TabIndex = 16;
            lbl_close.Text = "Close App";
            lbl_close.Click += lbl_close_Click;
            // 
            // dgv_employees
            // 
            dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employees.Location = new System.Drawing.Point(537, 26);
            dgv_employees.Name = "dgv_employees";
            dgv_employees.RowHeadersWidth = 51;
            dgv_employees.Size = new System.Drawing.Size(572, 297);
            dgv_employees.TabIndex = 15;
            dgv_employees.RowHeaderMouseDoubleClick += dgv_employees_RowHeaderMouseDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new System.Drawing.Point(379, 351);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(159, 46);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete Employee";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new System.Drawing.Point(205, 351);
            btn_update.Name = "btn_update";
            btn_update.Size = new System.Drawing.Size(159, 46);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update Employee";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(24, 351);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(159, 46);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add Employee";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cmb_department
            // 
            cmb_department.FormattingEnabled = true;
            cmb_department.Location = new System.Drawing.Point(131, 238);
            cmb_department.Name = "cmb_department";
            cmb_department.Size = new System.Drawing.Size(368, 28);
            cmb_department.TabIndex = 11;
            // 
            // cmb_schedule
            // 
            cmb_schedule.FormattingEnabled = true;
            cmb_schedule.Location = new System.Drawing.Point(131, 293);
            cmb_schedule.Name = "cmb_schedule";
            cmb_schedule.Size = new System.Drawing.Size(368, 28);
            cmb_schedule.TabIndex = 10;
            // 
            // txt_password
            // 
            txt_password.Location = new System.Drawing.Point(131, 182);
            txt_password.Name = "txt_password";
            txt_password.Size = new System.Drawing.Size(368, 27);
            txt_password.TabIndex = 9;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_email
            // 
            txt_email.Location = new System.Drawing.Point(131, 81);
            txt_email.Name = "txt_email";
            txt_email.Size = new System.Drawing.Size(368, 27);
            txt_email.TabIndex = 8;
            // 
            // txt_phone
            // 
            txt_phone.Location = new System.Drawing.Point(131, 136);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(368, 27);
            txt_phone.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new System.Drawing.Point(131, 26);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(368, 27);
            txt_name.TabIndex = 6;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new System.Drawing.Point(24, 182);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(70, 20);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "Password";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new System.Drawing.Point(24, 136);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new System.Drawing.Size(50, 20);
            lbl_phone.TabIndex = 4;
            lbl_phone.Text = "Phone";
            // 
            // lbl_schedule
            // 
            lbl_schedule.AutoSize = true;
            lbl_schedule.Location = new System.Drawing.Point(24, 293);
            lbl_schedule.Name = "lbl_schedule";
            lbl_schedule.Size = new System.Drawing.Size(69, 20);
            lbl_schedule.TabIndex = 3;
            lbl_schedule.Text = "Schedule";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new System.Drawing.Point(24, 81);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new System.Drawing.Size(46, 20);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            // 
            // lbl_department
            // 
            lbl_department.AutoSize = true;
            lbl_department.Location = new System.Drawing.Point(24, 238);
            lbl_department.Name = "lbl_department";
            lbl_department.Size = new System.Drawing.Size(89, 20);
            lbl_department.TabIndex = 1;
            lbl_department.Text = "Department";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new System.Drawing.Point(24, 26);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // tabPage_AttendanceTracking
            // 
            tabPage_AttendanceTracking.Controls.Add(panel1);
            tabPage_AttendanceTracking.Controls.Add(flowLayoutPanel1);
            tabPage_AttendanceTracking.Controls.Add(dgv_attendance);
            tabPage_AttendanceTracking.Controls.Add(dtp_date);
            tabPage_AttendanceTracking.Controls.Add(lbl_closeApp);
            tabPage_AttendanceTracking.Controls.Add(lbl_date);
            tabPage_AttendanceTracking.Location = new System.Drawing.Point(4, 29);
            tabPage_AttendanceTracking.Name = "tabPage_AttendanceTracking";
            tabPage_AttendanceTracking.Padding = new System.Windows.Forms.Padding(3);
            tabPage_AttendanceTracking.Size = new System.Drawing.Size(1133, 403);
            tabPage_AttendanceTracking.TabIndex = 1;
            tabPage_AttendanceTracking.Text = "Attendance Tracking";
            tabPage_AttendanceTracking.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_chickIN);
            panel1.Controls.Add(lbl_empname);
            panel1.Controls.Add(cmb_employee);
            panel1.Controls.Add(btn_addattendace);
            panel1.Controls.Add(lbl_THD);
            panel1.Controls.Add(lbl_chickOUT);
            panel1.Location = new System.Drawing.Point(32, 95);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(355, 295);
            panel1.TabIndex = 16;
            // 
            // lbl_chickIN
            // 
            lbl_chickIN.AutoSize = true;
            lbl_chickIN.Location = new System.Drawing.Point(3, 74);
            lbl_chickIN.Name = "lbl_chickIN";
            lbl_chickIN.Size = new System.Drawing.Size(58, 20);
            lbl_chickIN.TabIndex = 1;
            lbl_chickIN.Text = "chick in";
            lbl_chickIN.Visible = false;
            // 
            // lbl_empname
            // 
            lbl_empname.AutoSize = true;
            lbl_empname.Location = new System.Drawing.Point(3, 20);
            lbl_empname.Name = "lbl_empname";
            lbl_empname.Size = new System.Drawing.Size(119, 20);
            lbl_empname.TabIndex = 0;
            lbl_empname.Text = "Employee Name";
            // 
            // cmb_employee
            // 
            cmb_employee.FormattingEnabled = true;
            cmb_employee.Location = new System.Drawing.Point(128, 20);
            cmb_employee.Name = "cmb_employee";
            cmb_employee.Size = new System.Drawing.Size(211, 28);
            cmb_employee.TabIndex = 4;
            cmb_employee.SelectedIndexChanged += cmb_employee_SelectedIndexChanged;
            // 
            // btn_addattendace
            // 
            btn_addattendace.Location = new System.Drawing.Point(3, 250);
            btn_addattendace.Name = "btn_addattendace";
            btn_addattendace.Size = new System.Drawing.Size(210, 29);
            btn_addattendace.TabIndex = 14;
            btn_addattendace.Text = "Add Data";
            btn_addattendace.UseVisualStyleBackColor = true;
            // 
            // lbl_THD
            // 
            lbl_THD.AutoSize = true;
            lbl_THD.Location = new System.Drawing.Point(3, 158);
            lbl_THD.Name = "lbl_THD";
            lbl_THD.Size = new System.Drawing.Size(144, 20);
            lbl_THD.TabIndex = 3;
            lbl_THD.Text = "Total Worked Hours ";
            lbl_THD.Visible = false;
            // 
            // lbl_chickOUT
            // 
            lbl_chickOUT.AutoSize = true;
            lbl_chickOUT.Location = new System.Drawing.Point(3, 116);
            lbl_chickOUT.Name = "lbl_chickOUT";
            lbl_chickOUT.Size = new System.Drawing.Size(72, 20);
            lbl_chickOUT.TabIndex = 0;
            lbl_chickOUT.Text = "check out";
            lbl_chickOUT.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_overview);
            flowLayoutPanel1.Controls.Add(btn_idealemployee);
            flowLayoutPanel1.Controls.Add(btn_THD);
            flowLayoutPanel1.Location = new System.Drawing.Point(413, 326);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(681, 41);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // btn_overview
            // 
            btn_overview.Location = new System.Drawing.Point(3, 3);
            btn_overview.Name = "btn_overview";
            btn_overview.Size = new System.Drawing.Size(210, 29);
            btn_overview.TabIndex = 7;
            btn_overview.Text = "Over View ";
            btn_overview.UseVisualStyleBackColor = true;
            btn_overview.Click += btn_overview_Click;
            // 
            // btn_idealemployee
            // 
            btn_idealemployee.Location = new System.Drawing.Point(219, 3);
            btn_idealemployee.Name = "btn_idealemployee";
            btn_idealemployee.Size = new System.Drawing.Size(210, 29);
            btn_idealemployee.TabIndex = 10;
            btn_idealemployee.Text = " Ideal Employee";
            btn_idealemployee.UseVisualStyleBackColor = true;
            btn_idealemployee.Click += btn_idealemployee_Click;
            // 
            // btn_THD
            // 
            btn_THD.Location = new System.Drawing.Point(435, 3);
            btn_THD.Name = "btn_THD";
            btn_THD.Size = new System.Drawing.Size(210, 29);
            btn_THD.TabIndex = 8;
            btn_THD.Text = "Total hour per day";
            btn_THD.UseVisualStyleBackColor = true;
            btn_THD.Click += btn_THD_Click;
            // 
            // dgv_attendance
            // 
            dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_attendance.Location = new System.Drawing.Point(413, 22);
            dgv_attendance.Name = "dgv_attendance";
            dgv_attendance.RowHeadersWidth = 51;
            dgv_attendance.Size = new System.Drawing.Size(704, 298);
            dgv_attendance.TabIndex = 6;
            dgv_attendance.DataBindingComplete += dgv_attendance_DataBindingComplete;
            // 
            // dtp_date
            // 
            dtp_date.Location = new System.Drawing.Point(168, 32);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new System.Drawing.Size(219, 27);
            dtp_date.TabIndex = 5;
            dtp_date.ValueChanged += dtp_date_ValueChanged;
            // 
            // lbl_closeApp
            // 
            lbl_closeApp.AutoSize = true;
            lbl_closeApp.Location = new System.Drawing.Point(1040, 370);
            lbl_closeApp.Name = "lbl_closeApp";
            lbl_closeApp.Size = new System.Drawing.Size(77, 20);
            lbl_closeApp.TabIndex = 2;
            lbl_closeApp.Text = "Close App";
            lbl_closeApp.Click += lbl_closeApp_Click;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new System.Drawing.Point(32, 29);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new System.Drawing.Size(41, 20);
            lbl_date.TabIndex = 1;
            lbl_date.Text = "Date";
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1133, 403);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(1133, 403);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // HR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1155, 450);
            Controls.Add(tab_AttendanceTracking);
            Name = "HR";
            Text = "HR Page";
            Load += HR_Load;
            tab_AttendanceTracking.ResumeLayout(false);
            tab_ManageEmployees.ResumeLayout(false);
            tab_ManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ceyes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_oeyes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_employees).EndInit();
            tabPage_AttendanceTracking.ResumeLayout(false);
            tabPage_AttendanceTracking.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_attendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tab_AttendanceTracking;
        private System.Windows.Forms.TabPage tab_ManageEmployees;
        private System.Windows.Forms.TabPage tabPage_AttendanceTracking;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_schedule;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.ComboBox cmb_schedule;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.PictureBox pb_oeyes;
        private System.Windows.Forms.PictureBox pb_ceyes;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cmb_employee;
        private System.Windows.Forms.Label lbl_closeApp;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_empname;
        private System.Windows.Forms.Button btn_THD;
        private System.Windows.Forms.Button btn_idealemployee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_addattendace;
        private System.Windows.Forms.Label lbl_chickIN;
        private System.Windows.Forms.Label lbl_chickOUT;
        private System.Windows.Forms.Label lbl_THD;
        private System.Windows.Forms.Panel panel1;
    }
}