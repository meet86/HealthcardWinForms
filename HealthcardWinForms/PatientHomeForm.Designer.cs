﻿namespace HealthcardWinForms
{
    partial class PatientHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientHomeForm));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPrescriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyLabReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(1411, 4);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 21);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionToolStripMenuItem,
            this.labReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1504, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyPrescriptionMenuItem});
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // MyPrescriptionMenuItem
            // 
            this.MyPrescriptionMenuItem.Name = "MyPrescriptionMenuItem";
            this.MyPrescriptionMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MyPrescriptionMenuItem.Text = "My Prescriptions";
            this.MyPrescriptionMenuItem.Click += new System.EventHandler(this.MyPrescriptionMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1371, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labReportsToolStripMenuItem
            // 
            this.labReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyLabReportsToolStripMenuItem});
            this.labReportsToolStripMenuItem.Name = "labReportsToolStripMenuItem";
            this.labReportsToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.labReportsToolStripMenuItem.Text = "Lab Reports";
            // 
            // viewMyLabReportsToolStripMenuItem
            // 
            this.viewMyLabReportsToolStripMenuItem.Name = "viewMyLabReportsToolStripMenuItem";
            this.viewMyLabReportsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.viewMyLabReportsToolStripMenuItem.Text = "View My Lab Reports";
            this.viewMyLabReportsToolStripMenuItem.Click += new System.EventHandler(this.viewMyLabReportsToolStripMenuItem_Click);
            // 
            // PatientHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 747);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PatientHomeForm";
            this.Text = "PatientHomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyPrescriptionMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem labReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyLabReportsToolStripMenuItem;
    }
}