﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using Attendance_Management.Models;
using ZXing.Windows.Compatibility;

namespace Attendance_Management.Forms_Folder
{
    public partial class GenerateQR : Form
    {

        public GenerateQR()
        {
            InitializeComponent();
            Initialize();
        }
        //ui QR
        #region ui
        private void Initialize()
        {
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();

            // 
            // pictureBoxQR
            // 
             this.pictureBoxQR.Location = new System.Drawing.Point(380, 280);
          //  this.pictureBoxQR.Location = new System.Drawing.Point((835 - pictureBoxQR.Width) / 2, (650 - pictureBoxQR.Height) / 2);
            this.pictureBoxQR.Size = new System.Drawing.Size(180, 150);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // GenerateQRForm
            // 
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.pictureBoxQR);
            this.Load += new System.EventHandler(this.GenerateQR_Load);
            this.ResumeLayout(false);
        }
        #endregion
        private void GenerateQR_Load(object sender, EventArgs e)
        {
            GenerateQRCode();

        }
        #region generate qr
        private void GenerateQRCode()
        {
            int employeeid = login.LoggedInEmployeeID;

            string QRdata = $"https://your-attendance-system.com/check-in?employeeId={employeeid}";
            //مسؤله انها تعمل ل qr
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = 250,
                    Width = 250,
                    Margin = 1
                }
            };
            //عمل ال qr بالصورة المطلوبه
            Bitmap qrbitmao = writer.Write(QRdata);
            // عرض الصورة
            pictureBoxQR.Image = qrbitmao;

        }
        #endregion
    }
}
