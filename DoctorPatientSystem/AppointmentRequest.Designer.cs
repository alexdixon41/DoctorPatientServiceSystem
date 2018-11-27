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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.appointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableAppointmentPanel = new System.Windows.Forms.Panel();
            this.selectAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.appointmentDetailPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.availableAppointmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentDetailPanel
            // 
            this.appointmentDetailPanel.Controls.Add(this.viewAppointmentsButton);
            this.appointmentDetailPanel.Controls.Add(this.groupBox2);
            this.appointmentDetailPanel.Controls.Add(this.groupBox1);
            this.appointmentDetailPanel.Controls.Add(this.label1);
            this.appointmentDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.appointmentDetailPanel.Name = "appointmentDetailPanel";
            this.appointmentDetailPanel.Size = new System.Drawing.Size(832, 453);
            this.appointmentDetailPanel.TabIndex = 0;
            // 
            // viewAppointmentsButton
            // 
            this.viewAppointmentsButton.Location = new System.Drawing.Point(496, 344);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(251, 32);
            this.viewAppointmentsButton.TabIndex = 8;
            this.viewAppointmentsButton.Text = "View Available Appointments";
            this.viewAppointmentsButton.UseVisualStyleBackColor = true;
            this.viewAppointmentsButton.Click += new System.EventHandler(this.viewAppointmentsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.appointmentCalendar);
            this.groupBox2.Location = new System.Drawing.Point(496, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 271);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Day";
            // 
            // appointmentCalendar
            // 
            this.appointmentCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCalendar.Location = new System.Drawing.Point(12, 27);
            this.appointmentCalendar.Name = "appointmentCalendar";
            this.appointmentCalendar.TabIndex = 2;
            this.appointmentCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.appointmentCalendar_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doctorListBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Doctor";
            // 
            // doctorListBox
            // 
            this.doctorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorListBox.FormattingEnabled = true;
            this.doctorListBox.ItemHeight = 20;
            this.doctorListBox.Location = new System.Drawing.Point(6, 27);
            this.doctorListBox.Name = "doctorListBox";
            this.doctorListBox.Size = new System.Drawing.Size(462, 224);
            this.doctorListBox.TabIndex = 4;
            this.doctorListBox.SelectedIndexChanged += new System.EventHandler(this.doctorListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Appointment";
            // 
            // availableAppointmentPanel
            // 
            this.availableAppointmentPanel.Controls.Add(this.selectAppointmentButton);
            this.availableAppointmentPanel.Controls.Add(this.appointmentListView);
            this.availableAppointmentPanel.Controls.Add(this.label2);
            this.availableAppointmentPanel.Controls.Add(this.dateLabel);
            this.availableAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableAppointmentPanel.Location = new System.Drawing.Point(0, 0);
            this.availableAppointmentPanel.Name = "availableAppointmentPanel";
            this.availableAppointmentPanel.Size = new System.Drawing.Size(832, 453);
            this.availableAppointmentPanel.TabIndex = 1;
            this.availableAppointmentPanel.Visible = false;
            // 
            // selectAppointmentButton
            // 
            this.selectAppointmentButton.Location = new System.Drawing.Point(370, 328);
            this.selectAppointmentButton.Name = "selectAppointmentButton";
            this.selectAppointmentButton.Size = new System.Drawing.Size(209, 34);
            this.selectAppointmentButton.TabIndex = 4;
            this.selectAppointmentButton.Text = "Select Appointment";
            this.selectAppointmentButton.UseVisualStyleBackColor = true;
            this.selectAppointmentButton.Click += new System.EventHandler(this.selectAppointmentButton_Click);
            // 
            // appointmentListView
            // 
            this.appointmentListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.appointmentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentListView.FullRowSelect = true;
            this.appointmentListView.HoverSelection = true;
            this.appointmentListView.Location = new System.Drawing.Point(16, 94);
            this.appointmentListView.MultiSelect = false;
            this.appointmentListView.Name = "appointmentListView";
            this.appointmentListView.Size = new System.Drawing.Size(563, 228);
            this.appointmentListView.TabIndex = 3;
            this.appointmentListView.UseCompatibleStateImageBehavior = false;
            this.appointmentListView.View = System.Windows.Forms.View.Details;
            this.appointmentListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.appointmentListView_ItemSelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appointments";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(13, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(256, 25);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Thursday, October 11, 2018";
            // 
            // AppointmentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.appointmentDetailPanel);
            this.Controls.Add(this.availableAppointmentPanel);
            this.Name = "AppointmentRequest";
            this.Text = "AppointmentRequest";
            this.Load += new System.EventHandler(this.AppointmentRequest_Load);
            this.appointmentDetailPanel.ResumeLayout(false);
            this.appointmentDetailPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.availableAppointmentPanel.ResumeLayout(false);
            this.availableAppointmentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel appointmentDetailPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar appointmentCalendar;
        private System.Windows.Forms.Button viewAppointmentsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox doctorListBox;
        private System.Windows.Forms.Panel availableAppointmentPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListView appointmentListView;
        private System.Windows.Forms.Button selectAppointmentButton;
    }
}