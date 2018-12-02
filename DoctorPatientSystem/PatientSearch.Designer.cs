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
			this.createMedicalRecordButton = new System.Windows.Forms.Button();
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
			this.patientNameRecordLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.medicineHistoryListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.medicalRecordListView = new System.Windows.Forms.ListView();
			this.updateMedicalRecordButton = new System.Windows.Forms.Button();
			this.backToBasicInfoButton = new System.Windows.Forms.Button();
			this.updateRecordPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.disordersTextBox = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.allergiesTextBox = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.notesTextBox = new System.Windows.Forms.RichTextBox();
			this.createButton = new System.Windows.Forms.Button();
			this.backToMedicalRecord = new System.Windows.Forms.Button();
			this.submitUpdateButton = new System.Windows.Forms.Button();
			this.weightTextBox = new System.Windows.Forms.TextBox();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.maritalStatusTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.updateOrCreateLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.patientBox.SuspendLayout();
			this.patientSearchPanel.SuspendLayout();
			this.basicPatientInfoPanel.SuspendLayout();
			this.viewMedicalRecordPanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.updateRecordPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.patientSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.patientSearchPanel.Location = new System.Drawing.Point(0, 0);
			this.patientSearchPanel.Name = "patientSearchPanel";
			this.patientSearchPanel.Size = new System.Drawing.Size(1064, 522);
			this.patientSearchPanel.TabIndex = 7;
			// 
			// basicPatientInfoPanel
			// 
			this.basicPatientInfoPanel.Controls.Add(this.createMedicalRecordButton);
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
			this.basicPatientInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.basicPatientInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.basicPatientInfoPanel.Location = new System.Drawing.Point(0, 0);
			this.basicPatientInfoPanel.Name = "basicPatientInfoPanel";
			this.basicPatientInfoPanel.Size = new System.Drawing.Size(1064, 522);
			this.basicPatientInfoPanel.TabIndex = 8;
			this.basicPatientInfoPanel.Visible = false;
			// 
			// createMedicalRecordButton
			// 
			this.createMedicalRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.createMedicalRecordButton.Location = new System.Drawing.Point(557, 66);
			this.createMedicalRecordButton.Margin = new System.Windows.Forms.Padding(4);
			this.createMedicalRecordButton.Name = "createMedicalRecordButton";
			this.createMedicalRecordButton.Size = new System.Drawing.Size(251, 97);
			this.createMedicalRecordButton.TabIndex = 17;
			this.createMedicalRecordButton.Text = "Create Medical Record";
			this.createMedicalRecordButton.UseVisualStyleBackColor = true;
			this.createMedicalRecordButton.Visible = false;
			this.createMedicalRecordButton.Click += new System.EventHandler(this.createMedicalRecordButton_Click);
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
			this.viewMedicalRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewMedicalRecordPanel.Location = new System.Drawing.Point(0, 0);
			this.viewMedicalRecordPanel.Name = "viewMedicalRecordPanel";
			this.viewMedicalRecordPanel.Size = new System.Drawing.Size(1064, 522);
			this.viewMedicalRecordPanel.TabIndex = 9;
			this.viewMedicalRecordPanel.Visible = false;
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
			// medicalRecordListView
			// 
			this.medicalRecordListView.Location = new System.Drawing.Point(8, 24);
			this.medicalRecordListView.Name = "medicalRecordListView";
			this.medicalRecordListView.Size = new System.Drawing.Size(317, 291);
			this.medicalRecordListView.TabIndex = 0;
			this.medicalRecordListView.UseCompatibleStateImageBehavior = false;
			this.medicalRecordListView.View = System.Windows.Forms.View.List;
			// 
			// updateMedicalRecordButton
			// 
			this.updateMedicalRecordButton.Location = new System.Drawing.Point(19, 380);
			this.updateMedicalRecordButton.Name = "updateMedicalRecordButton";
			this.updateMedicalRecordButton.Size = new System.Drawing.Size(317, 44);
			this.updateMedicalRecordButton.TabIndex = 13;
			this.updateMedicalRecordButton.Text = "Update Medical Record";
			this.updateMedicalRecordButton.UseVisualStyleBackColor = true;
			this.updateMedicalRecordButton.Click += new System.EventHandler(this.updateMedicalRecordButton_Click);
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
			this.backToBasicInfoButton.Location = new System.Drawing.Point(11, 6);
			this.backToBasicInfoButton.Name = "backToBasicInfoButton";
			this.backToBasicInfoButton.Size = new System.Drawing.Size(77, 38);
			this.backToBasicInfoButton.TabIndex = 12;
			this.backToBasicInfoButton.UseVisualStyleBackColor = false;
			this.backToBasicInfoButton.Click += new System.EventHandler(this.backToBasicInfoButton_Click);
			// 
			// updateRecordPanel
			// 
			this.updateRecordPanel.Controls.Add(this.tableLayoutPanel1);
			this.updateRecordPanel.Controls.Add(this.createButton);
			this.updateRecordPanel.Controls.Add(this.backToMedicalRecord);
			this.updateRecordPanel.Controls.Add(this.submitUpdateButton);
			this.updateRecordPanel.Controls.Add(this.weightTextBox);
			this.updateRecordPanel.Controls.Add(this.heightTextBox);
			this.updateRecordPanel.Controls.Add(this.maritalStatusTextBox);
			this.updateRecordPanel.Controls.Add(this.label7);
			this.updateRecordPanel.Controls.Add(this.label6);
			this.updateRecordPanel.Controls.Add(this.updateOrCreateLabel);
			this.updateRecordPanel.Controls.Add(this.label4);
			this.updateRecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.updateRecordPanel.Location = new System.Drawing.Point(0, 0);
			this.updateRecordPanel.Name = "updateRecordPanel";
			this.updateRecordPanel.Size = new System.Drawing.Size(1064, 522);
			this.updateRecordPanel.TabIndex = 17;
			this.updateRecordPanel.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 134);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 372);
			this.tableLayoutPanel1.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.disordersTextBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1015, 118);
			this.panel1.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(-1, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(103, 28);
			this.label8.TabIndex = 4;
			this.label8.Text = "Disorders:";
			// 
			// disordersTextBox
			// 
			this.disordersTextBox.Location = new System.Drawing.Point(0, 29);
			this.disordersTextBox.Name = "disordersTextBox";
			this.disordersTextBox.Size = new System.Drawing.Size(1012, 85);
			this.disordersTextBox.TabIndex = 10;
			this.disordersTextBox.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.allergiesTextBox);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 127);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1015, 118);
			this.panel2.TabIndex = 1;
			// 
			// allergiesTextBox
			// 
			this.allergiesTextBox.Location = new System.Drawing.Point(0, 37);
			this.allergiesTextBox.Name = "allergiesTextBox";
			this.allergiesTextBox.Size = new System.Drawing.Size(1012, 77);
			this.allergiesTextBox.TabIndex = 11;
			this.allergiesTextBox.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(-1, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 28);
			this.label9.TabIndex = 5;
			this.label9.Text = "Allergies:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.notesTextBox);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 251);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1015, 118);
			this.panel3.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(-1, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 28);
			this.label10.TabIndex = 6;
			this.label10.Text = "Notes:";
			// 
			// notesTextBox
			// 
			this.notesTextBox.Location = new System.Drawing.Point(0, 31);
			this.notesTextBox.Name = "notesTextBox";
			this.notesTextBox.Size = new System.Drawing.Size(1012, 86);
			this.notesTextBox.TabIndex = 12;
			this.notesTextBox.Text = "";
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(943, 30);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(97, 40);
			this.createButton.TabIndex = 15;
			this.createButton.Text = "Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// backToMedicalRecord
			// 
			this.backToMedicalRecord.AutoSize = true;
			this.backToMedicalRecord.BackColor = System.Drawing.Color.Transparent;
			this.backToMedicalRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.backToMedicalRecord.FlatAppearance.BorderSize = 0;
			this.backToMedicalRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backToMedicalRecord.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backToMedicalRecord.Image = ((System.Drawing.Image)(resources.GetObject("backToMedicalRecord.Image")));
			this.backToMedicalRecord.Location = new System.Drawing.Point(19, 16);
			this.backToMedicalRecord.Name = "backToMedicalRecord";
			this.backToMedicalRecord.Size = new System.Drawing.Size(77, 38);
			this.backToMedicalRecord.TabIndex = 14;
			this.backToMedicalRecord.UseVisualStyleBackColor = false;
			this.backToMedicalRecord.Click += new System.EventHandler(this.backToMedicalRecord_Click);
			// 
			// submitUpdateButton
			// 
			this.submitUpdateButton.Location = new System.Drawing.Point(943, 30);
			this.submitUpdateButton.Name = "submitUpdateButton";
			this.submitUpdateButton.Size = new System.Drawing.Size(97, 40);
			this.submitUpdateButton.TabIndex = 13;
			this.submitUpdateButton.Text = "Update";
			this.submitUpdateButton.UseVisualStyleBackColor = true;
			this.submitUpdateButton.Click += new System.EventHandler(this.submitUpdateButton_Click);
			// 
			// weightTextBox
			// 
			this.weightTextBox.Location = new System.Drawing.Point(854, 91);
			this.weightTextBox.Name = "weightTextBox";
			this.weightTextBox.Size = new System.Drawing.Size(183, 22);
			this.weightTextBox.TabIndex = 9;
			// 
			// heightTextBox
			// 
			this.heightTextBox.Location = new System.Drawing.Point(376, 84);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(183, 22);
			this.heightTextBox.TabIndex = 8;
			// 
			// maritalStatusTextBox
			// 
			this.maritalStatusTextBox.Location = new System.Drawing.Point(128, 83);
			this.maritalStatusTextBox.Name = "maritalStatusTextBox";
			this.maritalStatusTextBox.Size = new System.Drawing.Size(183, 22);
			this.maritalStatusTextBox.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(792, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "Weight:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(317, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "Height:";
			// 
			// updateOrCreateLabel
			// 
			this.updateOrCreateLabel.AutoSize = true;
			this.updateOrCreateLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateOrCreateLabel.Location = new System.Drawing.Point(100, 18);
			this.updateOrCreateLabel.Name = "updateOrCreateLabel";
			this.updateOrCreateLabel.Size = new System.Drawing.Size(412, 51);
			this.updateOrCreateLabel.TabIndex = 1;
			this.updateOrCreateLabel.Text = "Update Medical Record";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "Marital Status:";
			// 
			// PatientSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.patientSearchPanel);
			this.Controls.Add(this.basicPatientInfoPanel);
			this.Controls.Add(this.updateRecordPanel);
			this.Controls.Add(this.viewMedicalRecordPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PatientSearch";
			this.Size = new System.Drawing.Size(1064, 522);
			this.Load += new System.EventHandler(this.PatientSearch_Load);
			this.patientBox.ResumeLayout(false);
			this.patientSearchPanel.ResumeLayout(false);
			this.patientSearchPanel.PerformLayout();
			this.basicPatientInfoPanel.ResumeLayout(false);
			this.basicPatientInfoPanel.PerformLayout();
			this.viewMedicalRecordPanel.ResumeLayout(false);
			this.viewMedicalRecordPanel.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.updateRecordPanel.ResumeLayout(false);
			this.updateRecordPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
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
		private System.Windows.Forms.Panel updateRecordPanel;
		private System.Windows.Forms.Button submitUpdateButton;
		private System.Windows.Forms.RichTextBox notesTextBox;
		private System.Windows.Forms.RichTextBox allergiesTextBox;
		private System.Windows.Forms.RichTextBox disordersTextBox;
		private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.TextBox maritalStatusTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label updateOrCreateLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button backToMedicalRecord;
		private System.Windows.Forms.Button createMedicalRecordButton;
		private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}