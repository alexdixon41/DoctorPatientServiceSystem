namespace DoctorPatientSystem
{
    partial class PatientSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearch));
			this.fnameLabel = new System.Windows.Forms.Label();
			this.patientSearchTextBox = new System.Windows.Forms.TextBox();
			this.nameSearch = new System.Windows.Forms.Button();
			this.patientBox = new System.Windows.Forms.GroupBox();
			this.patientView = new System.Windows.Forms.ListView();
			this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.viewPatientInformation = new System.Windows.Forms.Button();
			this.patientSearchPanel = new System.Windows.Forms.Panel();
			this.basicPatientInfoPanel = new System.Windows.Forms.Panel();
			this.patientDOBLabel = new System.Windows.Forms.Label();
			this.patientIDLabel = new System.Windows.Forms.Label();
			this.patientNameLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.backToPatientSearchButton = new System.Windows.Forms.Button();
			this.createAppointmentButton = new System.Windows.Forms.Button();
			this.requestMedicalHistoryButton = new System.Windows.Forms.Button();
			this.viewMedicalHistoryButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.viewMedicalRecordPanel = new System.Windows.Forms.Panel();
			this.medicalRecordListView = new System.Windows.Forms.ListView();
			this.backToBasicInfoButton = new System.Windows.Forms.Button();
			this.updateMedicalRecordButton = new System.Windows.Forms.Button();
			this.medicineHistoryListView = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.patientNameRecordLabel = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.patientBox.SuspendLayout();
			this.patientSearchPanel.SuspendLayout();
			this.basicPatientInfoPanel.SuspendLayout();
			this.viewMedicalRecordPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// fnameLabel
			// 
			this.fnameLabel.AutoSize = true;
			this.fnameLabel.Location = new System.Drawing.Point(7, 9);
			this.fnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.fnameLabel.Name = "fnameLabel";
			this.fnameLabel.Size = new System.Drawing.Size(135, 17);
			this.fnameLabel.TabIndex = 0;
			this.fnameLabel.Text = "Enter Patient Name:";
			// 
			// patientSearchTextBox
			// 
			this.patientSearchTextBox.Location = new System.Drawing.Point(9, 30);
			this.patientSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientSearchTextBox.Name = "patientSearchTextBox";
			this.patientSearchTextBox.Size = new System.Drawing.Size(646, 22);
			this.patientSearchTextBox.TabIndex = 2;
			// 
			// nameSearch
			// 
			this.nameSearch.Location = new System.Drawing.Point(663, 24);
			this.nameSearch.Margin = new System.Windows.Forms.Padding(4);
			this.nameSearch.Name = "nameSearch";
			this.nameSearch.Size = new System.Drawing.Size(100, 28);
			this.nameSearch.TabIndex = 4;
			this.nameSearch.Text = "Search";
			this.nameSearch.UseVisualStyleBackColor = true;
			this.nameSearch.Click += new System.EventHandler(this.nameSearch_Click);
			// 
			// patientBox
			// 
			this.patientBox.Controls.Add(this.patientView);
			this.patientBox.Location = new System.Drawing.Point(4, 60);
			this.patientBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientBox.Name = "patientBox";
			this.patientBox.Padding = new System.Windows.Forms.Padding(4);
			this.patientBox.Size = new System.Drawing.Size(776, 290);
			this.patientBox.TabIndex = 5;
			this.patientBox.TabStop = false;
			this.patientBox.Text = "Patient View";
			// 
			// patientView
			// 
			this.patientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fName,
            this.patientID,
            this.DOB});
			this.patientView.FullRowSelect = true;
			this.patientView.Location = new System.Drawing.Point(10, 23);
			this.patientView.Margin = new System.Windows.Forms.Padding(4);
			this.patientView.Name = "patientView";
			this.patientView.Size = new System.Drawing.Size(755, 258);
			this.patientView.TabIndex = 0;
			this.patientView.UseCompatibleStateImageBehavior = false;
			this.patientView.View = System.Windows.Forms.View.Details;
			// 
			// fName
			// 
			this.fName.Text = "Name";
			this.fName.Width = 140;
			// 
			// patientID
			// 
			this.patientID.Text = "Patient ID";
			this.patientID.Width = 140;
			// 
			// DOB
			// 
			this.DOB.Text = "Date Of Birth";
			this.DOB.Width = 140;
			// 
			// viewPatientInformation
			// 
			this.viewPatientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.viewPatientInformation.Location = new System.Drawing.Point(242, 350);
			this.viewPatientInformation.Margin = new System.Windows.Forms.Padding(4);
			this.viewPatientInformation.Name = "viewPatientInformation";
			this.viewPatientInformation.Size = new System.Drawing.Size(333, 70);
			this.viewPatientInformation.TabIndex = 6;
			this.viewPatientInformation.Text = "View Patient Information";
			this.viewPatientInformation.UseVisualStyleBackColor = true;
			this.viewPatientInformation.Click += new System.EventHandler(this.viewPatientInformation_Click);
			// 
			// patientSearchPanel
			// 
			this.patientSearchPanel.Controls.Add(this.patientBox);
			this.patientSearchPanel.Controls.Add(this.viewPatientInformation);
			this.patientSearchPanel.Controls.Add(this.fnameLabel);
			this.patientSearchPanel.Controls.Add(this.nameSearch);
			this.patientSearchPanel.Controls.Add(this.patientSearchTextBox);
			this.patientSearchPanel.Location = new System.Drawing.Point(31, 21);
			this.patientSearchPanel.Name = "patientSearchPanel";
			this.patientSearchPanel.Size = new System.Drawing.Size(801, 429);
			this.patientSearchPanel.TabIndex = 7;
			// 
			// basicPatientInfoPanel
			// 
			this.basicPatientInfoPanel.Controls.Add(this.patientDOBLabel);
			this.basicPatientInfoPanel.Controls.Add(this.patientIDLabel);
			this.basicPatientInfoPanel.Controls.Add(this.patientNameLabel);
			this.basicPatientInfoPanel.Controls.Add(this.label2);
			this.basicPatientInfoPanel.Controls.Add(this.label1);
			this.basicPatientInfoPanel.Controls.Add(this.backToPatientSearchButton);
			this.basicPatientInfoPanel.Controls.Add(this.createAppointmentButton);
			this.basicPatientInfoPanel.Controls.Add(this.requestMedicalHistoryButton);
			this.basicPatientInfoPanel.Controls.Add(this.viewMedicalHistoryButton);
			this.basicPatientInfoPanel.Controls.Add(this.label3);
			this.basicPatientInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.basicPatientInfoPanel.Location = new System.Drawing.Point(17, 21);
			this.basicPatientInfoPanel.Name = "basicPatientInfoPanel";
			this.basicPatientInfoPanel.Size = new System.Drawing.Size(837, 455);
			this.basicPatientInfoPanel.TabIndex = 8;
			this.basicPatientInfoPanel.Visible = false;
			// 
			// patientDOBLabel
			// 
			this.patientDOBLabel.AutoSize = true;
			this.patientDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.patientDOBLabel.Location = new System.Drawing.Point(246, 203);
			this.patientDOBLabel.Name = "patientDOBLabel";
			this.patientDOBLabel.Size = new System.Drawing.Size(79, 29);
			this.patientDOBLabel.TabIndex = 16;
			this.patientDOBLabel.Text = "label3";
			// 
			// patientIDLabel
			// 
			this.patientIDLabel.AutoSize = true;
			this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.patientIDLabel.Location = new System.Drawing.Point(246, 134);
			this.patientIDLabel.Name = "patientIDLabel";
			this.patientIDLabel.Size = new System.Drawing.Size(79, 29);
			this.patientIDLabel.TabIndex = 15;
			this.patientIDLabel.Text = "label3";
			// 
			// patientNameLabel
			// 
			this.patientNameLabel.AutoSize = true;
			this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.patientNameLabel.Location = new System.Drawing.Point(246, 68);
			this.patientNameLabel.Name = "patientNameLabel";
			this.patientNameLabel.Size = new System.Drawing.Size(79, 29);
			this.patientNameLabel.TabIndex = 14;
			this.patientNameLabel.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 29);
			this.label2.TabIndex = 13;
			this.label2.Text = "Date of Birth:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(184, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 29);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID:";
			// 
			// backToPatientSearchButton
			// 
			this.backToPatientSearchButton.AutoSize = true;
			this.backToPatientSearchButton.BackColor = System.Drawing.Color.Transparent;
			this.backToPatientSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.backToPatientSearchButton.FlatAppearance.BorderSize = 0;
			this.backToPatientSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backToPatientSearchButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backToPatientSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("backToPatientSearchButton.Image")));
			this.backToPatientSearchButton.Location = new System.Drawing.Point(15, 6);
			this.backToPatientSearchButton.Name = "backToPatientSearchButton";
			this.backToPatientSearchButton.Size = new System.Drawing.Size(77, 38);
			this.backToPatientSearchButton.TabIndex = 11;
			this.backToPatientSearchButton.UseVisualStyleBackColor = false;
			this.backToPatientSearchButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// createAppointmentButton
			// 
			this.createAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.createAppointmentButton.Location = new System.Drawing.Point(557, 203);
			this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(4);
			this.createAppointmentButton.Name = "createAppointmentButton";
			this.createAppointmentButton.Size = new System.Drawing.Size(251, 94);
			this.createAppointmentButton.TabIndex = 4;
			this.createAppointmentButton.Text = "Create an Appointment";
			this.createAppointmentButton.UseVisualStyleBackColor = true;
			// 
			// requestMedicalHistoryButton
			// 
			this.requestMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.requestMedicalHistoryButton.Location = new System.Drawing.Point(557, 68);
			this.requestMedicalHistoryButton.Margin = new System.Windows.Forms.Padding(4);
			this.requestMedicalHistoryButton.Name = "requestMedicalHistoryButton";
			this.requestMedicalHistoryButton.Size = new System.Drawing.Size(251, 97);
			this.requestMedicalHistoryButton.TabIndex = 3;
			this.requestMedicalHistoryButton.Text = "Request to View Medical History";
			this.requestMedicalHistoryButton.UseVisualStyleBackColor = true;
			this.requestMedicalHistoryButton.Visible = false;
			this.requestMedicalHistoryButton.Click += new System.EventHandler(this.requestMedicalHistoryButton_Click);
			// 
			// viewMedicalHistoryButton
			// 
			this.viewMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.viewMedicalHistoryButton.Location = new System.Drawing.Point(557, 68);
			this.viewMedicalHistoryButton.Margin = new System.Windows.Forms.Padding(4);
			this.viewMedicalHistoryButton.Name = "viewMedicalHistoryButton";
			this.viewMedicalHistoryButton.Size = new System.Drawing.Size(251, 92);
			this.viewMedicalHistoryButton.TabIndex = 2;
			this.viewMedicalHistoryButton.Text = "View Medical History";
			this.viewMedicalHistoryButton.UseVisualStyleBackColor = true;
			this.viewMedicalHistoryButton.Visible = false;
			this.viewMedicalHistoryButton.Click += new System.EventHandler(this.viewMedicalHistoryButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(52, 68);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(177, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Patient Name:";
			// 
			// viewMedicalRecordPanel
			// 
			this.viewMedicalRecordPanel.Controls.Add(this.patientNameRecordLabel);
			this.viewMedicalRecordPanel.Controls.Add(this.groupBox2);
			this.viewMedicalRecordPanel.Controls.Add(this.groupBox1);
			this.viewMedicalRecordPanel.Controls.Add(this.updateMedicalRecordButton);
			this.viewMedicalRecordPanel.Controls.Add(this.backToBasicInfoButton);
			this.viewMedicalRecordPanel.Location = new System.Drawing.Point(6, 6);
			this.viewMedicalRecordPanel.Name = "viewMedicalRecordPanel";
			this.viewMedicalRecordPanel.Size = new System.Drawing.Size(750, 444);
			this.viewMedicalRecordPanel.TabIndex = 9;
			this.viewMedicalRecordPanel.Visible = false;
			// 
			// medicalRecordListView
			// 
			this.medicalRecordListView.Location = new System.Drawing.Point(8, 24);
			this.medicalRecordListView.Name = "medicalRecordListView";
			this.medicalRecordListView.Size = new System.Drawing.Size(317, 291);
			this.medicalRecordListView.TabIndex = 0;
			this.medicalRecordListView.UseCompatibleStateImageBehavior = false;
			this.medicalRecordListView.View = System.Windows.Forms.View.List;
			// 
			// backToBasicInfoButton
			// 
			this.backToBasicInfoButton.AutoSize = true;
			this.backToBasicInfoButton.BackColor = System.Drawing.Color.Transparent;
			this.backToBasicInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.backToBasicInfoButton.FlatAppearance.BorderSize = 0;
			this.backToBasicInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backToBasicInfoButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backToBasicInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("backToBasicInfoButton.Image")));
			this.backToBasicInfoButton.Location = new System.Drawing.Point(0, 3);
			this.backToBasicInfoButton.Name = "backToBasicInfoButton";
			this.backToBasicInfoButton.Size = new System.Drawing.Size(77, 38);
			this.backToBasicInfoButton.TabIndex = 12;
			this.backToBasicInfoButton.UseVisualStyleBackColor = false;
			this.backToBasicInfoButton.Click += new System.EventHandler(this.backToBasicInfoButton_Click);
			// 
			// updateMedicalRecordButton
			// 
			this.updateMedicalRecordButton.Location = new System.Drawing.Point(14, 387);
			this.updateMedicalRecordButton.Name = "updateMedicalRecordButton";
			this.updateMedicalRecordButton.Size = new System.Drawing.Size(167, 35);
			this.updateMedicalRecordButton.TabIndex = 13;
			this.updateMedicalRecordButton.Text = "Update Medical Record";
			this.updateMedicalRecordButton.UseVisualStyleBackColor = true;
			// 
			// medicineHistoryListView
			// 
			this.medicineHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.medicineHistoryListView.Location = new System.Drawing.Point(6, 23);
			this.medicineHistoryListView.Name = "medicineHistoryListView";
			this.medicineHistoryListView.Size = new System.Drawing.Size(348, 292);
			this.medicineHistoryListView.TabIndex = 14;
			this.medicineHistoryListView.UseCompatibleStateImageBehavior = false;
			this.medicineHistoryListView.View = System.Windows.Forms.View.Details;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.medicalRecordListView);
			this.groupBox1.Location = new System.Drawing.Point(11, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 331);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Information";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.medicineHistoryListView);
			this.groupBox2.Location = new System.Drawing.Point(361, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 331);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Medicine History";
			// 
			// patientNameRecordLabel
			// 
			this.patientNameRecordLabel.AutoSize = true;
			this.patientNameRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.patientNameRecordLabel.Location = new System.Drawing.Point(262, 12);
			this.patientNameRecordLabel.Name = "patientNameRecordLabel";
			this.patientNameRecordLabel.Size = new System.Drawing.Size(158, 29);
			this.patientNameRecordLabel.TabIndex = 18;
			this.patientNameRecordLabel.Text = "Patient Name";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Medicine Name";
			this.columnHeader1.Width = 113;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Dosage";
			this.columnHeader2.Width = 85;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Date";
			// 
			// PatientSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.viewMedicalRecordPanel);
			this.Controls.Add(this.patientSearchPanel);
			this.Controls.Add(this.basicPatientInfoPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PatientSearch";
			this.Size = new System.Drawing.Size(832, 453);
			this.Load += new System.EventHandler(this.PatientSearch_Load);
			this.patientBox.ResumeLayout(false);
			this.patientSearchPanel.ResumeLayout(false);
			this.patientSearchPanel.PerformLayout();
			this.basicPatientInfoPanel.ResumeLayout(false);
			this.basicPatientInfoPanel.PerformLayout();
			this.viewMedicalRecordPanel.ResumeLayout(false);
			this.viewMedicalRecordPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox patientSearchTextBox;
        private System.Windows.Forms.Button nameSearch;
        private System.Windows.Forms.GroupBox patientBox;
        private System.Windows.Forms.ListView patientView;
        private System.Windows.Forms.Button viewPatientInformation;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader patientID;
        private System.Windows.Forms.ColumnHeader DOB;
		private System.Windows.Forms.Panel patientSearchPanel;
		private System.Windows.Forms.Panel basicPatientInfoPanel;
		private System.Windows.Forms.Button createAppointmentButton;
		private System.Windows.Forms.Button requestMedicalHistoryButton;
		private System.Windows.Forms.Button viewMedicalHistoryButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button backToPatientSearchButton;
		private System.Windows.Forms.Label patientNameLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label patientDOBLabel;
		private System.Windows.Forms.Label patientIDLabel;
		private System.Windows.Forms.Panel viewMedicalRecordPanel;
		private System.Windows.Forms.ListView medicalRecordListView;
		private System.Windows.Forms.Button backToBasicInfoButton;
		private System.Windows.Forms.Button updateMedicalRecordButton;
		private System.Windows.Forms.ListView medicineHistoryListView;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label patientNameRecordLabel;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}