﻿using HealthcardWinForms.GlobalInfos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcardWinForms
{
    public partial class PatientHomeForm : Form
    {
        public PatientHomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150, 150);
            UsernameLabel.Text = UserInfo.UserName;

        }

        private void MyPrescriptionMenuItem_Click(object sender, EventArgs e)
        {
            ViewPrescriptionForm viewPrescriptionForm = new ViewPrescriptionForm();
            viewPrescriptionForm.ViewPrescriptionOfPatient();
            viewPrescriptionForm.Tag = this;
            viewPrescriptionForm.ShowDialog(this);
        }

        private void viewMyLabReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReportForm viewReportForm = new ViewReportForm();
            viewReportForm.ViewReports(UserInfo.UserID, true);
            viewReportForm.Tag = this;
            viewReportForm.ShowDialog(this);
        }
    }
}
