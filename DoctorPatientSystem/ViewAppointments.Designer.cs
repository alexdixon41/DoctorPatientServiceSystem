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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointments));
			this.appointmentsListView = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.selectButton = new System.Windows.Forms.Button();
			this.viewAppointmentsPanel = new System.Windows.Forms.Panel();
			this.appointmentDetailPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.statusLabel = new System.Windows.Forms.Label();
			this.acceptButton = new System.Windows.Forms.Button();
			this.denyButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.viewAppointmentsPanel.SuspendLayout();
			this.appointmentDetailPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// appointmentsListView
			// 
			this.appointmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.appointmentsListView.FullRowSelect = true;
			this.appointmentsListView.Location = new System.Drawing.Point(19, 27);
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
			this.label1.Location = new System.Drawing.Point(16, 7);
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
			this.selectButton.Location = new System.Drawing.Point(661, 379);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(95, 36);
			this.selectButton.TabIndex = 2;
			this.selectButton.Text = "Select";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			// 
			// viewAppointmentsPanel
			// 
			this.viewAppointmentsPanel.Controls.Add(this.selectButton);
			this.viewAppointmentsPanel.Controls.Add(this.label1);
			this.viewAppointmentsPanel.Controls.Add(this.appointmentsListView);
			this.viewAppointmentsPanel.Location = new System.Drawing.Point(3, 28);
			this.viewAppointmentsPanel.Name = "viewAppointmentsPanel";
			this.viewAppointmentsPanel.Size = new System.Drawing.Size(777, 421);
			this.viewAppointmentsPanel.TabIndex = 3;
			// 
			// appointmentDetailPanel
			// 
			this.appointmentDetailPanel.Controls.Add(this.backButton);
			this.appointmentDetailPanel.Controls.Add(this.denyButton);
			this.appointmentDetailPanel.Controls.Add(this.acceptButton);
			this.appointmentDetailPanel.Controls.Add(this.statusLabel);
			this.appointmentDetailPanel.Controls.Add(this.timeLabel);
			this.appointmentDetailPanel.Controls.Add(this.nameLabel);
			this.appointmentDetailPanel.Controls.Add(this.label5);
			this.appointmentDetailPanel.Controls.Add(this.label4);
			this.appointmentDetailPanel.Controls.Add(this.label3);
			this.appointmentDetailPanel.Controls.Add(this.label2);
			this.appointmentDetailPanel.Location = new System.Drawing.Point(8, 10);
			this.appointmentDetailPanel.Name = "appointmentDetailPanel";
			this.appointmentDetailPanel.Size = new System.Drawing.Size(772, 406);
			this.appointmentDetailPanel.TabIndex = 4;
			this.appointmentDetailPanel.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(254, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Appointment Details";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(154, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Patient Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(116, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Appointment Time:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(103, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Appointment Status:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.nameLabel.Location = new System.Drawing.Point(310, 91);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(53, 20);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "label6";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.timeLabel.Location = new System.Drawing.Point(310, 149);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(53, 20);
			this.timeLabel.TabIndex = 5;
			this.timeLabel.Text = "label6";
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.statusLabel.Location = new System.Drawing.Point(310, 211);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(53, 20);
			this.statusLabel.TabIndex = 6;
			this.statusLabel.Text = "label6";
			// 
			// acceptButton
			// 
			this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.acceptButton.Location = new System.Drawing.Point(266, 315);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(97, 40);
			this.acceptButton.TabIndex = 7;
			this.acceptButton.Text = "Accept";
			this.acceptButton.UseVisualStyleBackColor = true;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// denyButton
			// 
			this.denyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
			this.denyButton.Location = new System.Drawing.Point(403, 315);
			this.denyButton.Name = "denyButton";
			this.denyButton.Size = new System.Drawing.Size(97, 40);
			this.denyButton.TabIndex = 8;
			this.denyButton.Text = "Deny";
			this.denyButton.UseVisualStyleBackColor = true;
			this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
			// 
			// backButton
			// 
			this.backButton.AutoSize = true;
			this.backButton.BackColor = System.Drawing.Color.Transparent;
			this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.backButton.FlatAppearance.BorderSize = 0;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
			this.backButton.Location = new System.Drawing.Point(14, 6);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(77, 38);
			this.backButton.TabIndex = 15;
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// ViewAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.appointmentDetailPanel);
			this.Controls.Add(this.viewAppointmentsPanel);
			this.Name = "ViewAppointments";
			this.Size = new System.Drawing.Size(800, 450);
			this.viewAppointmentsPanel.ResumeLayout(false);
			this.viewAppointmentsPanel.PerformLayout();
			this.appointmentDetailPanel.ResumeLayout(false);
			this.appointmentDetailPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView appointmentsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.Panel viewAppointmentsPanel;
		private System.Windows.Forms.Panel appointmentDetailPanel;
		private System.Windows.Forms.Button denyButton;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button backButton;
	}
}