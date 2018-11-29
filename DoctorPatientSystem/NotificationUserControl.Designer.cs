namespace DoctorPatientSystem
{
    partial class NotificationUserControl
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
            this.notificationListView = new System.Windows.Forms.ListView();
            this.selectNotificationButton = new System.Windows.Forms.Button();
            this.notificationListPanel = new System.Windows.Forms.Panel();
            this.notificationDetailPanel = new System.Windows.Forms.Panel();
            this.normalButtonPanel = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.recordRequestButtonPanel = new System.Windows.Forms.Panel();
            this.acceptRecordRequestButton = new System.Windows.Forms.Button();
            this.denyRecordRequestButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationListPanel.SuspendLayout();
            this.notificationDetailPanel.SuspendLayout();
            this.normalButtonPanel.SuspendLayout();
            this.recordRequestButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notifications";
            // 
            // notificationListView
            // 
            this.notificationListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationListView.FullRowSelect = true;
            this.notificationListView.Location = new System.Drawing.Point(12, 84);
            this.notificationListView.MultiSelect = false;
            this.notificationListView.Name = "notificationListView";
            this.notificationListView.Size = new System.Drawing.Size(808, 293);
            this.notificationListView.TabIndex = 1;
            this.notificationListView.UseCompatibleStateImageBehavior = false;
            this.notificationListView.View = System.Windows.Forms.View.Details;
            // 
            // selectNotificationButton
            // 
            this.selectNotificationButton.Location = new System.Drawing.Point(724, 383);
            this.selectNotificationButton.Name = "selectNotificationButton";
            this.selectNotificationButton.Size = new System.Drawing.Size(96, 34);
            this.selectNotificationButton.TabIndex = 2;
            this.selectNotificationButton.Text = "Select";
            this.selectNotificationButton.UseVisualStyleBackColor = true;
            this.selectNotificationButton.Click += new System.EventHandler(this.selectNotificationButton_Click);
            // 
            // notificationListPanel
            // 
            this.notificationListPanel.Controls.Add(this.selectNotificationButton);
            this.notificationListPanel.Controls.Add(this.label1);
            this.notificationListPanel.Controls.Add(this.notificationListView);
            this.notificationListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationListPanel.Location = new System.Drawing.Point(0, 0);
            this.notificationListPanel.Name = "notificationListPanel";
            this.notificationListPanel.Size = new System.Drawing.Size(832, 453);
            this.notificationListPanel.TabIndex = 3;
            // 
            // notificationDetailPanel
            // 
            this.notificationDetailPanel.Controls.Add(this.normalButtonPanel);
            this.notificationDetailPanel.Controls.Add(this.recordRequestButtonPanel);
            this.notificationDetailPanel.Controls.Add(this.label7);
            this.notificationDetailPanel.Controls.Add(this.label6);
            this.notificationDetailPanel.Controls.Add(this.label5);
            this.notificationDetailPanel.Controls.Add(this.label4);
            this.notificationDetailPanel.Controls.Add(this.textBox1);
            this.notificationDetailPanel.Controls.Add(this.label3);
            this.notificationDetailPanel.Controls.Add(this.label2);
            this.notificationDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.notificationDetailPanel.Name = "notificationDetailPanel";
            this.notificationDetailPanel.Size = new System.Drawing.Size(832, 453);
            this.notificationDetailPanel.TabIndex = 4;
            this.notificationDetailPanel.Visible = false;
            // 
            // normalButtonPanel
            // 
            this.normalButtonPanel.Controls.Add(this.confirmButton);
            this.normalButtonPanel.Location = new System.Drawing.Point(246, 344);
            this.normalButtonPanel.Name = "normalButtonPanel";
            this.normalButtonPanel.Size = new System.Drawing.Size(292, 73);
            this.normalButtonPanel.TabIndex = 9;
            this.normalButtonPanel.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(193, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(96, 34);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // recordRequestButtonPanel
            // 
            this.recordRequestButtonPanel.Controls.Add(this.acceptRecordRequestButton);
            this.recordRequestButtonPanel.Controls.Add(this.denyRecordRequestButton);
            this.recordRequestButtonPanel.Location = new System.Drawing.Point(265, 344);
            this.recordRequestButtonPanel.Name = "recordRequestButtonPanel";
            this.recordRequestButtonPanel.Size = new System.Drawing.Size(273, 48);
            this.recordRequestButtonPanel.TabIndex = 8;
            this.recordRequestButtonPanel.Visible = false;
            // 
            // acceptRecordRequestButton
            // 
            this.acceptRecordRequestButton.Location = new System.Drawing.Point(72, 3);
            this.acceptRecordRequestButton.Name = "acceptRecordRequestButton";
            this.acceptRecordRequestButton.Size = new System.Drawing.Size(96, 34);
            this.acceptRecordRequestButton.TabIndex = 8;
            this.acceptRecordRequestButton.Text = "Accept";
            this.acceptRecordRequestButton.UseVisualStyleBackColor = true;
            this.acceptRecordRequestButton.Click += new System.EventHandler(this.acceptRecordRequestButton_Click);
            // 
            // denyRecordRequestButton
            // 
            this.denyRecordRequestButton.Location = new System.Drawing.Point(174, 3);
            this.denyRecordRequestButton.Name = "denyRecordRequestButton";
            this.denyRecordRequestButton.Size = new System.Drawing.Size(96, 34);
            this.denyRecordRequestButton.TabIndex = 7;
            this.denyRecordRequestButton.Text = "Deny ";
            this.denyRecordRequestButton.UseVisualStyleBackColor = true;
            this.denyRecordRequestButton.Click += new System.EventHandler(this.denyRecordRequestButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "09/18/2018 10:00 AM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dr. Doolittle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sender: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(528, 132);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Dr. Doolittle would like to view your medical records to decide which treatment o" +
    "ption is best for you. Please respond soon.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Message: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notification Details";
            // 
            // NotificationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notificationListPanel);
            this.Controls.Add(this.notificationDetailPanel);
            this.Name = "NotificationUserControl";
            this.Size = new System.Drawing.Size(832, 453);
            this.Load += new System.EventHandler(this.PatientNotifications_Load);
            this.notificationListPanel.ResumeLayout(false);
            this.notificationListPanel.PerformLayout();
            this.notificationDetailPanel.ResumeLayout(false);
            this.notificationDetailPanel.PerformLayout();
            this.normalButtonPanel.ResumeLayout(false);
            this.recordRequestButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView notificationListView;
        private System.Windows.Forms.Button selectNotificationButton;
        private System.Windows.Forms.Panel notificationListPanel;
        private System.Windows.Forms.Panel notificationDetailPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel recordRequestButtonPanel;
        private System.Windows.Forms.Button acceptRecordRequestButton;
        private System.Windows.Forms.Button denyRecordRequestButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel normalButtonPanel;
        private System.Windows.Forms.Button confirmButton;
    }
}