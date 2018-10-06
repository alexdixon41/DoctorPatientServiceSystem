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
            this.patientInformationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.patientNameLabel.Location = new System.Drawing.Point(13, 13);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(134, 24);
            this.patientNameLabel.TabIndex = 0;
            this.patientNameLabel.Text = "Patient Name";
            // 
            // patientInformationBox
            // 
            this.patientInformationBox.Controls.Add(this.generalInformationListView);
            this.patientInformationBox.Location = new System.Drawing.Point(17, 41);
            this.patientInformationBox.Name = "patientInformationBox";
            this.patientInformationBox.Size = new System.Drawing.Size(400, 315);
            this.patientInformationBox.TabIndex = 1;
            this.patientInformationBox.TabStop = false;
            this.patientInformationBox.Text = "General Information";
            // 
            // generalInformationListView
            // 
            this.generalInformationListView.Location = new System.Drawing.Point(7, 20);
            this.generalInformationListView.Margin = new System.Windows.Forms.Padding(2);
            this.generalInformationListView.Name = "generalInformationListView";
            this.generalInformationListView.Size = new System.Drawing.Size(387, 289);
            this.generalInformationListView.TabIndex = 0;
            this.generalInformationListView.UseCompatibleStateImageBehavior = false;
            // 
            // viewMedicalHistoryButton
            // 
            this.viewMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.viewMedicalHistoryButton.Location = new System.Drawing.Point(424, 61);
            this.viewMedicalHistoryButton.Name = "viewMedicalHistoryButton";
            this.viewMedicalHistoryButton.Size = new System.Drawing.Size(188, 75);
            this.viewMedicalHistoryButton.TabIndex = 2;
            this.viewMedicalHistoryButton.Text = "View Medical History";
            this.viewMedicalHistoryButton.UseVisualStyleBackColor = true;
            // 
            // requestMedicalHistoryButton
            // 
            this.requestMedicalHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.requestMedicalHistoryButton.Location = new System.Drawing.Point(424, 168);
            this.requestMedicalHistoryButton.Name = "requestMedicalHistoryButton";
            this.requestMedicalHistoryButton.Size = new System.Drawing.Size(188, 79);
            this.requestMedicalHistoryButton.TabIndex = 3;
            this.requestMedicalHistoryButton.Text = "Request to View Medical History";
            this.requestMedicalHistoryButton.UseVisualStyleBackColor = true;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createAppointmentButton.Location = new System.Drawing.Point(424, 274);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(188, 76);
            this.createAppointmentButton.TabIndex = 4;
            this.createAppointmentButton.Text = "Create an Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // GeneralPatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.requestMedicalHistoryButton);
            this.Controls.Add(this.viewMedicalHistoryButton);
            this.Controls.Add(this.patientInformationBox);
            this.Controls.Add(this.patientNameLabel);
            this.Name = "GeneralPatientRecords";
            this.Text = "General Patient Records";
            this.Load += new System.EventHandler(this.SecurePatientRecords_Load);
            this.patientInformationBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.GroupBox patientInformationBox;
        private System.Windows.Forms.ListView generalInformationListView;
        private System.Windows.Forms.Button viewMedicalHistoryButton;
        private System.Windows.Forms.Button requestMedicalHistoryButton;
        private System.Windows.Forms.Button createAppointmentButton;
    }
}