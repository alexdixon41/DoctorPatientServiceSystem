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
            this.noticesListView = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectNotificationButton = new System.Windows.Forms.Button();
            this.notificationListPanel = new System.Windows.Forms.Panel();
            this.noticeDetailPanel = new System.Windows.Forms.Panel();
            this.denyButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.noticeTitleLabel = new System.Windows.Forms.Label();
            this.notificationListPanel.SuspendLayout();
            this.noticeDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notices";
            // 
            // noticesListView
            // 
            this.noticesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noticesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.date,
            this.status,
            this.sender,
            this.message});
            this.noticesListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticesListView.FullRowSelect = true;
            this.noticesListView.Location = new System.Drawing.Point(20, 67);
            this.noticesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noticesListView.MultiSelect = false;
            this.noticesListView.Name = "noticesListView";
            this.noticesListView.Size = new System.Drawing.Size(598, 494);
            this.noticesListView.TabIndex = 1;
            this.noticesListView.UseCompatibleStateImageBehavior = false;
            this.noticesListView.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 240;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // sender
            // 
            this.sender.Text = "Sender";
            this.sender.Width = 220;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 500;
            // 
            // selectNotificationButton
            // 
            this.selectNotificationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectNotificationButton.AutoSize = true;
            this.selectNotificationButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNotificationButton.Location = new System.Drawing.Point(478, 11);
            this.selectNotificationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectNotificationButton.Name = "selectNotificationButton";
            this.selectNotificationButton.Size = new System.Drawing.Size(139, 40);
            this.selectNotificationButton.TabIndex = 2;
            this.selectNotificationButton.Text = "View Notice";
            this.selectNotificationButton.UseVisualStyleBackColor = true;
            this.selectNotificationButton.Click += new System.EventHandler(this.selectNotificationButton_Click);
            // 
            // notificationListPanel
            // 
            this.notificationListPanel.Controls.Add(this.selectNotificationButton);
            this.notificationListPanel.Controls.Add(this.label1);
            this.notificationListPanel.Controls.Add(this.noticesListView);
            this.notificationListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationListPanel.Location = new System.Drawing.Point(0, 0);
            this.notificationListPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationListPanel.MinimumSize = new System.Drawing.Size(338, 244);
            this.notificationListPanel.Name = "notificationListPanel";
            this.notificationListPanel.Size = new System.Drawing.Size(626, 570);
            this.notificationListPanel.TabIndex = 3;
            this.notificationListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.notificationListPanel_Paint);
            // 
            // noticeDetailPanel
            // 
            this.noticeDetailPanel.Controls.Add(this.denyButton);
            this.noticeDetailPanel.Controls.Add(this.acceptButton);
            this.noticeDetailPanel.Controls.Add(this.dateTextBox);
            this.noticeDetailPanel.Controls.Add(this.label4);
            this.noticeDetailPanel.Controls.Add(this.typeTextBox);
            this.noticeDetailPanel.Controls.Add(this.label3);
            this.noticeDetailPanel.Controls.Add(this.messageTextBox);
            this.noticeDetailPanel.Controls.Add(this.fromTextBox);
            this.noticeDetailPanel.Controls.Add(this.label2);
            this.noticeDetailPanel.Controls.Add(this.backButton);
            this.noticeDetailPanel.Controls.Add(this.noticeTitleLabel);
            this.noticeDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noticeDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.noticeDetailPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noticeDetailPanel.Name = "noticeDetailPanel";
            this.noticeDetailPanel.Size = new System.Drawing.Size(626, 570);
            this.noticeDetailPanel.TabIndex = 4;
            this.noticeDetailPanel.Visible = false;
            // 
            // denyButton
            // 
            this.denyButton.AutoSize = true;
            this.denyButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyButton.Location = new System.Drawing.Point(446, 16);
            this.denyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(83, 40);
            this.denyButton.TabIndex = 14;
            this.denyButton.Text = "Deny";
            this.denyButton.UseVisualStyleBackColor = true;
            this.denyButton.Visible = false;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.AutoSize = true;
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(534, 16);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(89, 40);
            this.acceptButton.TabIndex = 13;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(86, 119);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(532, 32);
            this.dateTextBox.TabIndex = 12;
            this.dateTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date: ";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(86, 67);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(532, 32);
            this.typeTextBox.TabIndex = 10;
            this.typeTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(24, 226);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(594, 335);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.TabStop = false;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(86, 172);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(532, 32);
            this.fromTextBox.TabIndex = 7;
            this.fromTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "From: ";
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
            this.backButton.Location = new System.Drawing.Point(14, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 38);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // noticeTitleLabel
            // 
            this.noticeTitleLabel.AutoSize = true;
            this.noticeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeTitleLabel.Location = new System.Drawing.Point(75, 13);
            this.noticeTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noticeTitleLabel.Name = "noticeTitleLabel";
            this.noticeTitleLabel.Size = new System.Drawing.Size(202, 41);
            this.noticeTitleLabel.TabIndex = 0;
            this.noticeTitleLabel.Text = "Notice Details";
            // 
            // NotificationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noticeDetailPanel);
            this.Controls.Add(this.notificationListPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NotificationUserControl";
            this.Size = new System.Drawing.Size(626, 570);
            this.notificationListPanel.ResumeLayout(false);
            this.notificationListPanel.PerformLayout();
            this.noticeDetailPanel.ResumeLayout(false);
            this.noticeDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView noticesListView;
        private System.Windows.Forms.Button selectNotificationButton;
        private System.Windows.Forms.Panel notificationListPanel;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader sender;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.Panel noticeDetailPanel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label noticeTitleLabel;
        private System.Windows.Forms.Button denyButton;
        private System.Windows.Forms.Button acceptButton;
    }
}