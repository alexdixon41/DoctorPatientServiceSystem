namespace DoctorPatientSystem
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
            this.prescriptionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prescriber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pharamcy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectPrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionsPanel = new System.Windows.Forms.Panel();
            this.prescriptionDetailPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.prescriptionStatusLabel = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.refillsLabel = new System.Windows.Forms.Label();
            this.prescriptionRemainingRefillsLabel = new System.Windows.Forms.Label();
            this.prescriptionRefillLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.prescriptionDetailListView = new System.Windows.Forms.ListView();
            this.medicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.route = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.prescriptionDateLabel = new System.Windows.Forms.Label();
            this.prescriptionsPanel.SuspendLayout();
            this.prescriptionDetailPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request a Prescription Refill";
            // 
            // prescriptionListView
            // 
            this.prescriptionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriptionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prescriptionID,
            this.Prescriber,
            this.pharamcy,
            this.date});
            this.prescriptionListView.FullRowSelect = true;
            this.prescriptionListView.Location = new System.Drawing.Point(21, 68);
            this.prescriptionListView.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionListView.MultiSelect = false;
            this.prescriptionListView.Name = "prescriptionListView";
            this.prescriptionListView.Size = new System.Drawing.Size(758, 379);
            this.prescriptionListView.TabIndex = 1;
            this.prescriptionListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionListView.View = System.Windows.Forms.View.Details;
            // 
            // prescriptionID
            // 
            this.prescriptionID.Text = "ID";
            this.prescriptionID.Width = 150;
            // 
            // Prescriber
            // 
            this.Prescriber.Text = "Prescriber";
            this.Prescriber.Width = 200;
            // 
            // pharamcy
            // 
            this.pharamcy.Text = "Pharmacy";
            this.pharamcy.Width = 200;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // selectPrescriptionButton
            // 
            this.selectPrescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPrescriptionButton.AutoSize = true;
            this.selectPrescriptionButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrescriptionButton.Location = new System.Drawing.Point(518, 11);
            this.selectPrescriptionButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectPrescriptionButton.Name = "selectPrescriptionButton";
            this.selectPrescriptionButton.Size = new System.Drawing.Size(260, 40);
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
            this.prescriptionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionsPanel.Name = "prescriptionsPanel";
            this.prescriptionsPanel.Size = new System.Drawing.Size(788, 459);
            this.prescriptionsPanel.TabIndex = 4;
            // 
            // prescriptionDetailPanel
            // 
            this.prescriptionDetailPanel.Controls.Add(this.button1);
            this.prescriptionDetailPanel.Controls.Add(this.label2);
            this.prescriptionDetailPanel.Controls.Add(this.backButton);
            this.prescriptionDetailPanel.Controls.Add(this.panel2);
            this.prescriptionDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prescriptionDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.prescriptionDetailPanel.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionDetailPanel.Name = "prescriptionDetailPanel";
            this.prescriptionDetailPanel.Size = new System.Drawing.Size(788, 459);
            this.prescriptionDetailPanel.TabIndex = 5;
            this.prescriptionDetailPanel.Visible = false;
            this.prescriptionDetailPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.prescriptionDetailPanel_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Request Refill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prescription Details";
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
            this.backButton.Location = new System.Drawing.Point(14, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 38);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.prescriptionStatusLabel);
            this.panel2.Controls.Add(this.remainingLabel);
            this.panel2.Controls.Add(this.refillsLabel);
            this.panel2.Controls.Add(this.prescriptionRemainingRefillsLabel);
            this.panel2.Controls.Add(this.prescriptionRefillLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.prescriptionDetailListView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.prescriptionDateLabel);
            this.panel2.Location = new System.Drawing.Point(14, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 388);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(59, 37);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 19);
            this.statusLabel.TabIndex = 13;
            // 
            // prescriptionStatusLabel
            // 
            this.prescriptionStatusLabel.AutoSize = true;
            this.prescriptionStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionStatusLabel.Location = new System.Drawing.Point(2, 37);
            this.prescriptionStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prescriptionStatusLabel.Name = "prescriptionStatusLabel";
            this.prescriptionStatusLabel.Size = new System.Drawing.Size(55, 19);
            this.prescriptionStatusLabel.TabIndex = 12;
            this.prescriptionStatusLabel.Text = "Status: ";
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.Location = new System.Drawing.Point(127, 99);
            this.remainingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(0, 19);
            this.remainingLabel.TabIndex = 11;
            // 
            // refillsLabel
            // 
            this.refillsLabel.AutoSize = true;
            this.refillsLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillsLabel.Location = new System.Drawing.Point(58, 67);
            this.refillsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refillsLabel.Name = "refillsLabel";
            this.refillsLabel.Size = new System.Drawing.Size(0, 19);
            this.refillsLabel.TabIndex = 10;
            // 
            // prescriptionRemainingRefillsLabel
            // 
            this.prescriptionRemainingRefillsLabel.AutoSize = true;
            this.prescriptionRemainingRefillsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionRemainingRefillsLabel.Location = new System.Drawing.Point(2, 99);
            this.prescriptionRemainingRefillsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prescriptionRemainingRefillsLabel.Name = "prescriptionRemainingRefillsLabel";
            this.prescriptionRemainingRefillsLabel.Size = new System.Drawing.Size(126, 19);
            this.prescriptionRemainingRefillsLabel.TabIndex = 9;
            this.prescriptionRemainingRefillsLabel.Text = "Remaining Refills: ";
            // 
            // prescriptionRefillLabel
            // 
            this.prescriptionRefillLabel.AutoSize = true;
            this.prescriptionRefillLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionRefillLabel.Location = new System.Drawing.Point(2, 67);
            this.prescriptionRefillLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prescriptionRefillLabel.Name = "prescriptionRefillLabel";
            this.prescriptionRefillLabel.Size = new System.Drawing.Size(55, 19);
            this.prescriptionRefillLabel.TabIndex = 8;
            this.prescriptionRefillLabel.Text = "Refills: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(50, 6);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 19);
            this.dateLabel.TabIndex = 7;
            // 
            // prescriptionDetailListView
            // 
            this.prescriptionDetailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prescriptionDetailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicine,
            this.count,
            this.dose,
            this.route,
            this.instructions});
            this.prescriptionDetailListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionDetailListView.FullRowSelect = true;
            this.prescriptionDetailListView.Location = new System.Drawing.Point(5, 167);
            this.prescriptionDetailListView.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionDetailListView.MultiSelect = false;
            this.prescriptionDetailListView.Name = "prescriptionDetailListView";
            this.prescriptionDetailListView.Size = new System.Drawing.Size(761, 211);
            this.prescriptionDetailListView.TabIndex = 6;
            this.prescriptionDetailListView.UseCompatibleStateImageBehavior = false;
            this.prescriptionDetailListView.View = System.Windows.Forms.View.Details;
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
            this.label3.Location = new System.Drawing.Point(2, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prescription Details";
            // 
            // prescriptionDateLabel
            // 
            this.prescriptionDateLabel.AutoSize = true;
            this.prescriptionDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionDateLabel.Location = new System.Drawing.Point(2, 6);
            this.prescriptionDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prescriptionDateLabel.Name = "prescriptionDateLabel";
            this.prescriptionDateLabel.Size = new System.Drawing.Size(45, 19);
            this.prescriptionDateLabel.TabIndex = 3;
            this.prescriptionDateLabel.Text = "Date: ";
            // 
            // RefillRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prescriptionDetailPanel);
            this.Controls.Add(this.prescriptionsPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RefillRequest";
            this.Size = new System.Drawing.Size(788, 459);
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
        private System.Windows.Forms.Label prescriptionStatusLabel;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label refillsLabel;
        private System.Windows.Forms.Label prescriptionRemainingRefillsLabel;
        private System.Windows.Forms.Label prescriptionRefillLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListView prescriptionDetailListView;
        private System.Windows.Forms.ColumnHeader medicine;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader dose;
        private System.Windows.Forms.ColumnHeader route;
        private System.Windows.Forms.ColumnHeader instructions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prescriptionDateLabel;
        private System.Windows.Forms.ColumnHeader prescriptionID;
        private System.Windows.Forms.ColumnHeader Prescriber;
        private System.Windows.Forms.ColumnHeader pharamcy;
        private System.Windows.Forms.ColumnHeader date;
    }
}