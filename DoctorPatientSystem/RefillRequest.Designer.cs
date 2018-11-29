﻿namespace DoctorPatientSystem
{
    partial class RefillRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.prescriptionListView = new System.Windows.Forms.ListView();
            this.selectPrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionsPanel = new System.Windows.Forms.Panel();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.refillsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prescriptionsPanel.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request a Prescription Refill";
            // 
            // prescriptionListView
            // 
            this.prescriptionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriptionListView.FullRowSelect = true;
            this.prescriptionListView.Location = new System.Drawing.Point(28, 84);
            this.prescriptionListView.Name = "prescriptionListView";
            this.prescriptionListView.Size = new System.Drawing.Size(1009, 465);
            this.prescriptionListView.TabIndex = 1;
            this.prescriptionListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionListView.View = System.Windows.Forms.View.Details;
            // 
            // selectPrescriptionButton
            // 
            this.selectPrescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPrescriptionButton.AutoSize = true;
            this.selectPrescriptionButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrescriptionButton.Location = new System.Drawing.Point(704, 14);
            this.selectPrescriptionButton.Name = "selectPrescriptionButton";
            this.selectPrescriptionButton.Size = new System.Drawing.Size(333, 48);
            this.selectPrescriptionButton.TabIndex = 3;
            this.selectPrescriptionButton.Text = "View Prescription Details";
            this.selectPrescriptionButton.UseVisualStyleBackColor = true;
            this.selectPrescriptionButton.Click += new System.EventHandler(this.selectPrescriptionButton_Click);
            // 
            // prescriptionsPanel
            // 
            this.prescriptionsPanel.Controls.Add(this.prescriptionListView);
            this.prescriptionsPanel.Controls.Add(this.label1);
            this.prescriptionsPanel.Controls.Add(this.selectPrescriptionButton);
            this.prescriptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionsPanel.Name = "prescriptionsPanel";
            this.prescriptionsPanel.Size = new System.Drawing.Size(1050, 565);
            this.prescriptionsPanel.TabIndex = 4;
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.panel2);
            this.prescriptionDetailPanel.Controls.Add(this.button1);
            this.prescriptionDetailPanel.Controls.Add(this.label2);
            this.prescriptionDetailPanel.Controls.Add(this.backButton);
            this.prescriptionDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(1050, 565);
            this.prescriptionDetailPanel.TabIndex = 5;
            this.prescriptionDetailPanel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Image = global::DoctorPatientSystem.Properties.Resources.icons8_left_32;
            this.backButton.Location = new System.Drawing.Point(19, 18);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 40);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prescription Details";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(842, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Request Refill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.remainingLabel);
            this.panel2.Controls.Add(this.refillsLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(19, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 478);
            this.panel2.TabIndex = 9;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(79, 46);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 23);
            this.statusLabel.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Status: ";
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.Location = new System.Drawing.Point(169, 122);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(0, 23);
            this.remainingLabel.TabIndex = 11;
            // 
            // refillsLabel
            // 
            this.refillsLabel.AutoSize = true;
            this.refillsLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillsLabel.Location = new System.Drawing.Point(78, 83);
            this.refillsLabel.Name = "refillsLabel";
            this.refillsLabel.Size = new System.Drawing.Size(0, 23);
            this.refillsLabel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Remaining Refills: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Refills: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(67, 8);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 23);
            this.dateLabel.TabIndex = 7;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicine,
            this.count,
            this.dose,
            this.route,
            this.instructions});
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(7, 206);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1013, 259);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // medicine
            // 
            this.medicine.Text = "Name";
            this.medicine.Width = 140;
            // 
            // count
            // 
            this.count.Text = "Quantity";
            this.count.Width = 80;
            // 
            // dose
            // 
            this.dose.Text = "Dosage";
            this.dose.Width = 80;
            // 
            // route
            // 
            this.route.Text = "Route";
            this.route.Width = 120;
            // 
            // instructions
            // 
            this.instructions.Text = "Instructions";
            this.instructions.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prescription Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date: ";
            // 
            // RefillRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prescriptionDetailPanel);
            this.Controls.Add(this.prescriptionsPanel);
            this.Name = "RefillRequest";
            this.Size = new System.Drawing.Size(1050, 565);
            this.Load += new System.EventHandler(this.RefillRequest_Load);
            this.prescriptionsPanel.ResumeLayout(false);
            this.prescriptionsPanel.PerformLayout();
            this.prescriptionDetailPanel.ResumeLayout(false);
            this.prescriptionDetailPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView prescriptionListView;
        private System.Windows.Forms.Button selectPrescriptionButton;
        private System.Windows.Forms.Panel prescriptionsPanel;
        private System.Windows.Forms.Panel prescriptionDetailPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label refillsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader medicine;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader dose;
        private System.Windows.Forms.ColumnHeader route;
        private System.Windows.Forms.ColumnHeader instructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}