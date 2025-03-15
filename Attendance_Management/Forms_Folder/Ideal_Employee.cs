using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management.Forms_Folder
{
    public partial class Ideal_Employee : Form
    {
        string n;
        double t;
        int  m;
        public Ideal_Employee(string name , double total , int month)
        {
            InitializeComponent();
            n = name;
            t = total;
            m = month;
        }

        private void Ideal_Employee_Load(object sender, EventArgs e)
        {
            lbl_name.Visible = true;
            lbl_month.Visible = true;
            lbl_hours.Visible = true;

            lbl_name.Text = $"{n}";
            lbl_month.Text =$"{m}";
            lbl_hours.Text =$"{t}";
        }
    }
}
