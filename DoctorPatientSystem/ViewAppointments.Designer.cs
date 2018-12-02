namespace DoctorPatientSystem
{
	partial class ViewAppointments
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
			this.appointmentsListView = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.selectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// appointmentsListView
			// 
			this.appointmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.appointmentsListView.FullRowSelect = true;
			this.appointmentsListView.Location = new System.Drawing.Point(27, 48);
			this.appointmentsListView.MultiSelect = false;
			this.appointmentsListView.Name = "appointmentsListView";
			this.appointmentsListView.Size = new System.Drawing.Size(737, 346);
			this.appointmentsListView.TabIndex = 0;
			this.appointmentsListView.UseCompatibleStateImageBehavior = false;
			this.appointmentsListView.View = System.Windows.Forms.View.Details;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Appointments";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Patient Name";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Appointment Time";
			this.columnHeader2.Width = 140;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Status";
			this.columnHeader3.Width = 82;
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(669, 400);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(95, 36);
			this.selectButton.TabIndex = 2;
			this.selectButton.Text = "Select";
			this.selectButton.UseVisualStyleBackColor = true;
			// 
			// ViewAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.appointmentsListView);
			this.Name = "ViewAppointments";
			this.Size = new System.Drawing.Size(800, 450);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView appointmentsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button selectButton;
	}
}