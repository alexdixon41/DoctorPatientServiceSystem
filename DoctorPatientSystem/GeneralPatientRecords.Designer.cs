namespace DoctorPatientSystem
{
    partial class GeneralPatientRecords
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
			this.patientNameLabel = new System.Windows.Forms.Label();
			this.patientInformationBox = new System.Windows.Forms.GroupBox();
			this.generalInformationListView = new System.Windows.Forms.ListView();
			this.viewMedicalHistoryButton = new System.Windows.Forms.Button();
			this.requestMedicalHistoryButton = new System.Windows.Forms.Button();
			this.createAppointmentButton = new System.Windows.Forms.Button();
			this.basicPatientInfoPanel = new System.Windows.Forms.Panel();
			this.patientInformationBox.SuspendLayout();
			this.basicPatientInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// patientNameLabel
			// 
			this.patientNameLabel.AutoSize = true;
			this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.patientNameLabel.Location = new System.Drawing.Point(9, 12);
			this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.patientNameLabel.Name = "patientNameLabel";
			this.patientNameLabel.Size = new System.Drawing.Size(170, 29);
			this.patientNameLabel.TabIndex = 0;
			this.patientNameLabel.Text = "Patient Name";
			// 
			// patientInformationBox
			// 
			this.patientInformationBox.Controls.Add(this.generalInformationListView);
			this.patientInformationBox.Location = new System.Drawing.Point(15, 46);
			this.patientInformationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.patientInformationBox.Name = "patientInformationBox";
			this.patientInformationBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.patientInformationBox.Size = new System.Drawing.Size(533, 388);
			this.patientInformationBox.TabIndex = 1;
			this.patientInformationBox.TabStop = false;
			this.patientInformationBox.Text = "General Information";
			// 
			// generalInformationListView
			// 
			this.generalInformationListView.Location = new System.Drawing.Point(9, 25);
			this.generalInformationListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.generalInformationListView.Name = "generalInformationListView";
			this.generalInformationListView.Size = new System.Drawing.Size(515, 355);
			this.generalInformationListView.TabIndex = 0;
			this.generalInformationListView.UseCompatibleStateImageBehavior = false;
			// 
			// viewMedicalHistoryButton
			// 
			this.viewMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.viewMedicalHistoryButton.Location = new System.Drawing.Point(557, 71);
			this.viewMedicalHistoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.viewMedicalHistoryButton.Name = "viewMedicalHistoryButton";
			this.viewMedicalHistoryButton.Size = new System.Drawing.Size(251, 92);
			this.viewMedicalHistoryButton.TabIndex = 2;
			this.viewMedicalHistoryButton.Text = "View Medical History";
			this.viewMedicalHistoryButton.UseVisualStyleBackColor = true;
			// 
			// requestMedicalHistoryButton
			// 
			this.requestMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.requestMedicalHistoryButton.Location = new System.Drawing.Point(557, 203);
			this.requestMedicalHistoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.requestMedicalHistoryButton.Name = "requestMedicalHistoryButton";
			this.requestMedicalHistoryButton.Size = new System.Drawing.Size(251, 97);
			this.requestMedicalHistoryButton.TabIndex = 3;
			this.requestMedicalHistoryButton.Text = "Request to View Medical History";
			this.requestMedicalHistoryButton.UseVisualStyleBackColor = true;
			// 
			// createAppointmentButton
			// 
			this.createAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.createAppointmentButton.Location = new System.Drawing.Point(557, 333);
			this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.createAppointmentButton.Name = "createAppointmentButton";
			this.createAppointmentButton.Size = new System.Drawing.Size(251, 94);
			this.createAppointmentButton.TabIndex = 4;
			this.createAppointmentButton.Text = "Create an Appointment";
			this.createAppointmentButton.UseVisualStyleBackColor = true;
			// 
			// basicPatientInfoPanel
			// 
			this.basicPatientInfoPanel.Controls.Add(this.createAppointmentButton);
			this.basicPatientInfoPanel.Controls.Add(this.requestMedicalHistoryButton);
			this.basicPatientInfoPanel.Controls.Add(this.viewMedicalHistoryButton);
			this.basicPatientInfoPanel.Controls.Add(this.patientInformationBox);
			this.basicPatientInfoPanel.Controls.Add(this.patientNameLabel);
			this.basicPatientInfoPanel.Location = new System.Drawing.Point(8, 4);
			this.basicPatientInfoPanel.Name = "basicPatientInfoPanel";
			this.basicPatientInfoPanel.Size = new System.Drawing.Size(821, 447);
			this.basicPatientInfoPanel.TabIndex = 5;
			// 
			// GeneralPatientRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 453);
			this.Controls.Add(this.basicPatientInfoPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "GeneralPatientRecords";
			this.Text = "General Patient Records";
			this.Load += new System.EventHandler(this.SecurePatientRecords_Load);
			this.patientInformationBox.ResumeLayout(false);
			this.basicPatientInfoPanel.ResumeLayout(false);
			this.basicPatientInfoPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.GroupBox patientInformationBox;
        private System.Windows.Forms.ListView generalInformationListView;
        private System.Windows.Forms.Button viewMedicalHistoryButton;
        private System.Windows.Forms.Button requestMedicalHistoryButton;
        private System.Windows.Forms.Button createAppointmentButton;
		private System.Windows.Forms.Panel basicPatientInfoPanel;
	}
}