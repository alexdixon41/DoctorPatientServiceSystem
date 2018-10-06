namespace DoctorPatientSystem
{
	partial class DoctorMenu
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
            this.patientSearchButton = new System.Windows.Forms.Button();
            this.createRecordButton = new System.Windows.Forms.Button();
            this.notificationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.patientSearchButton.Location = new System.Drawing.Point(12, 110);
            this.patientSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientSearchButton.Name = "patientSearchButton";
            this.patientSearchButton.Size = new System.Drawing.Size(411, 105);
            this.patientSearchButton.TabIndex = 0;
            this.patientSearchButton.Text = "Search for a Patient";
            this.patientSearchButton.UseVisualStyleBackColor = true;
            this.patientSearchButton.Click += new System.EventHandler(this.patientSearchButton_Click);
            // 
            // createRecordButton
            // 
            this.createRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createRecordButton.Location = new System.Drawing.Point(12, 239);
            this.createRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createRecordButton.Name = "createRecordButton";
            this.createRecordButton.Size = new System.Drawing.Size(411, 105);
            this.createRecordButton.TabIndex = 1;
            this.createRecordButton.Text = "Create Medical Record";
            this.createRecordButton.UseVisualStyleBackColor = true;
            this.createRecordButton.Click += new System.EventHandler(this.createRecordButton_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.notificationButton.Location = new System.Drawing.Point(12, 12);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(776, 80);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.Text = "Notifications";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.createRecordButton);
            this.Controls.Add(this.patientSearchButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button patientSearchButton;
		private System.Windows.Forms.Button createRecordButton;
		private System.Windows.Forms.Button notificationButton;
	}
}