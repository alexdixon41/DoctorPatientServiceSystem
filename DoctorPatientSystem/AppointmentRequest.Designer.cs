namespace DoctorPatientSystem
{
    partial class AppointmentRequest
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
            this.appointmentDetailPanel = new System.Windows.Forms.Panel();
            this.viewAppointmentsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorListView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.availableAppointmentPanel = new System.Windows.Forms.Panel();
            this.selectAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentListView = new System.Windows.Forms.ListView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButton = new System.Windows.Forms.Button();
            this.appointmentDetailPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.availableAppointmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentDetailPanel
            // 
            this.appointmentDetailPanel.Controls.Add(this.viewAppointmentsButton);
            this.appointmentDetailPanel.Controls.Add(this.label1);
            this.appointmentDetailPanel.Controls.Add(this.tableLayoutPanel1);
            this.appointmentDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.appointmentDetailPanel.Name = "appointmentDetailPanel";
            this.appointmentDetailPanel.Size = new System.Drawing.Size(1029, 613);
            this.appointmentDetailPanel.TabIndex = 0;
            // 
            // viewAppointmentsButton
            // 
            this.viewAppointmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewAppointmentsButton.AutoSize = true;
            this.viewAppointmentsButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsButton.Location = new System.Drawing.Point(627, 16);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(386, 48);
            this.viewAppointmentsButton.TabIndex = 8;
            this.viewAppointmentsButton.Text = "View Available Appointments";
            this.viewAppointmentsButton.UseVisualStyleBackColor = true;
            this.viewAppointmentsButton.Click += new System.EventHandler(this.viewAppointmentsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Appointment";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 514);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.doctorListView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Doctor";
            // 
            // doctorListView
            // 
            this.doctorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.officeName,
            this.officeNumber});
            this.doctorListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorListView.FullRowSelect = true;
            this.doctorListView.Location = new System.Drawing.Point(7, 78);
            this.doctorListView.Name = "doctorListView";
            this.doctorListView.Size = new System.Drawing.Size(966, 322);
            this.doctorListView.TabIndex = 0;
            this.doctorListView.UseCompatibleStateImageBehavior = false;
            this.doctorListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 96);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Day";
            // 
            // availableAppointmentPanel
            // 
            this.availableAppointmentPanel.Controls.Add(this.backButton);
            this.availableAppointmentPanel.Controls.Add(this.selectAppointmentButton);
            this.availableAppointmentPanel.Controls.Add(this.appointmentListView);
            this.availableAppointmentPanel.Controls.Add(this.dateLabel);
            this.availableAppointmentPanel.Controls.Add(this.appointmentsLabel);
            this.availableAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableAppointmentPanel.Location = new System.Drawing.Point(0, 0);
            this.availableAppointmentPanel.Name = "availableAppointmentPanel";
            this.availableAppointmentPanel.Size = new System.Drawing.Size(1029, 613);
            this.availableAppointmentPanel.TabIndex = 1;
            this.availableAppointmentPanel.Visible = false;
            // 
            // selectAppointmentButton
            // 
            this.selectAppointmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAppointmentButton.AutoSize = true;
            this.selectAppointmentButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAppointmentButton.Location = new System.Drawing.Point(742, 20);
            this.selectAppointmentButton.Name = "selectAppointmentButton";
            this.selectAppointmentButton.Size = new System.Drawing.Size(271, 48);
            this.selectAppointmentButton.TabIndex = 4;
            this.selectAppointmentButton.Text = "Select Appointment";
            this.selectAppointmentButton.UseVisualStyleBackColor = true;
            this.selectAppointmentButton.Click += new System.EventHandler(this.selectAppointmentButton_Click);
            // 
            // appointmentListView
            // 
            this.appointmentListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.appointmentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentListView.FullRowSelect = true;
            this.appointmentListView.Location = new System.Drawing.Point(19, 130);
            this.appointmentListView.MultiSelect = false;
            this.appointmentListView.Name = "appointmentListView";
            this.appointmentListView.Size = new System.Drawing.Size(994, 466);
            this.appointmentListView.TabIndex = 3;
            this.appointmentListView.UseCompatibleStateImageBehavior = false;
            this.appointmentListView.View = System.Windows.Forms.View.List;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 89);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 38);
            this.dateLabel.TabIndex = 2;
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(100, 16);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(420, 51);
            this.appointmentsLabel.TabIndex = 0;
            this.appointmentsLabel.Text = "Available Appointments";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 45);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(773, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(106, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(867, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search for a doctor";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(7, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 38);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // officeName
            // 
            this.officeName.Text = "Office";
            this.officeName.Width = 280;
            // 
            // officeNumber
            // 
            this.officeNumber.Text = "Phone Number";
            this.officeNumber.Width = 200;
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
            // AppointmentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentDetailPanel);
            this.Controls.Add(this.availableAppointmentPanel);
            this.Name = "AppointmentRequest";
            this.Size = new System.Drawing.Size(1029, 613);
            this.appointmentDetailPanel.ResumeLayout(false);
            this.appointmentDetailPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.availableAppointmentPanel.ResumeLayout(false);
            this.availableAppointmentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel appointmentDetailPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAppointmentsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel availableAppointmentPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.ListView appointmentListView;
        private System.Windows.Forms.Button selectAppointmentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView doctorListView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader officeName;
        private System.Windows.Forms.ColumnHeader officeNumber;
        private System.Windows.Forms.Button backButton;
    }
}