namespace DoctorPatientSystem
{
	partial class DoctorNotification
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
			this.doctorNotificationListView = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.Location = new System.Drawing.Point(13, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Notifications";
			// 
			// doctorNotificationListView
			// 
			this.doctorNotificationListView.FullRowSelect = true;
			this.doctorNotificationListView.Location = new System.Drawing.Point(18, 62);
			this.doctorNotificationListView.Name = "doctorNotificationListView";
			this.doctorNotificationListView.Size = new System.Drawing.Size(753, 283);
			this.doctorNotificationListView.TabIndex = 1;
			this.doctorNotificationListView.UseCompatibleStateImageBehavior = false;
			this.doctorNotificationListView.View = System.Windows.Forms.View.Details;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.button1.Location = new System.Drawing.Point(663, 351);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "Select";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DoctorNotification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 453);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.doctorNotificationListView);
			this.Controls.Add(this.label1);
			this.Name = "DoctorNotification";
			this.Text = "doctorNotification";
			this.Load += new System.EventHandler(this.DoctorNotification_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView doctorNotificationListView;
		private System.Windows.Forms.Button button1;
	}
}