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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMenu));
            this.notificationButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.refillRequestButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctorLogoutButton = new System.Windows.Forms.Button();
            this.patientSearchButton = new System.Windows.Forms.Button();
            this.viewAppointmentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationButton
            // 
            this.notificationButton.BackColor = System.Drawing.Color.White;
            this.notificationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationButton.FlatAppearance.BorderSize = 0;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationButton.Location = new System.Drawing.Point(11, 10);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(228, 89);
            this.notificationButton.TabIndex = 2;
            this.notificationButton.Text = "Notices";
            this.notificationButton.UseVisualStyleBackColor = false;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 240;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Size = new System.Drawing.Size(1235, 753);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1MinSize = 300;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(250, 753);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.viewAppointmentsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientSearchButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.refillRequestButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.notificationButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // refillRequestButton
            // 
            this.refillRequestButton.BackColor = System.Drawing.Color.White;
            this.refillRequestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refillRequestButton.FlatAppearance.BorderSize = 0;
            this.refillRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refillRequestButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refillRequestButton.Location = new System.Drawing.Point(11, 109);
            this.refillRequestButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.refillRequestButton.Name = "refillRequestButton";
            this.refillRequestButton.Size = new System.Drawing.Size(228, 89);
            this.refillRequestButton.TabIndex = 6;
            this.refillRequestButton.Text = "Refill Requests";
            this.refillRequestButton.UseVisualStyleBackColor = false;
            this.refillRequestButton.Click += new System.EventHandler(this.refillRequestButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.doctorLogoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(250, 354);
            this.panel1.TabIndex = 0;
            // 
            // doctorLogoutButton
            // 
            this.doctorLogoutButton.BackColor = System.Drawing.Color.White;
            this.doctorLogoutButton.BackgroundImage = global::DoctorPatientSystem.Properties.Resources.icons8_exit_50;
            this.doctorLogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.doctorLogoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorLogoutButton.FlatAppearance.BorderSize = 0;
            this.doctorLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorLogoutButton.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLogoutButton.Location = new System.Drawing.Point(11, 10);
            this.doctorLogoutButton.Name = "doctorLogoutButton";
            this.doctorLogoutButton.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.doctorLogoutButton.Size = new System.Drawing.Size(228, 334);
            this.doctorLogoutButton.TabIndex = 0;
            this.doctorLogoutButton.Text = "Logout";
            this.doctorLogoutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.doctorLogoutButton.UseVisualStyleBackColor = false;
            this.doctorLogoutButton.Click += new System.EventHandler(this.doctorLogoutButton_Click);
            // 
            // patientSearchButton
            // 
            this.patientSearchButton.BackColor = System.Drawing.Color.White;
            this.patientSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientSearchButton.FlatAppearance.BorderSize = 0;
            this.patientSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientSearchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSearchButton.Location = new System.Drawing.Point(11, 307);
            this.patientSearchButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.patientSearchButton.Name = "patientSearchButton";
            this.patientSearchButton.Size = new System.Drawing.Size(228, 91);
            this.patientSearchButton.TabIndex = 7;
            this.patientSearchButton.Text = "Search for a Patient";
            this.patientSearchButton.UseVisualStyleBackColor = false;
            this.patientSearchButton.Click += new System.EventHandler(this.patientSearchButton_Click);
            // 
            // viewAppointmentsButton
            // 
            this.viewAppointmentsButton.BackColor = System.Drawing.Color.White;
            this.viewAppointmentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAppointmentsButton.FlatAppearance.BorderSize = 0;
            this.viewAppointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAppointmentsButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsButton.Location = new System.Drawing.Point(11, 208);
            this.viewAppointmentsButton.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.viewAppointmentsButton.Name = "viewAppointmentsButton";
            this.viewAppointmentsButton.Size = new System.Drawing.Size(228, 89);
            this.viewAppointmentsButton.TabIndex = 8;
            this.viewAppointmentsButton.Text = "Appointments";
            this.viewAppointmentsButton.UseVisualStyleBackColor = false;
            this.viewAppointmentsButton.Click += new System.EventHandler(this.viewAppointmentsButton_Click);
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 753);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1250, 698);
            this.Name = "DoctorMenu";
            this.Text = "Doctor Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button refillRequestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctorLogoutButton;
        private System.Windows.Forms.Button viewAppointmentsButton;
        private System.Windows.Forms.Button patientSearchButton;
    }
}