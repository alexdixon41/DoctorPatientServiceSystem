namespace DoctorPatientSystem
{
    partial class CallRequest
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
            this.requestPhoneCall = new System.Windows.Forms.Button();
            this.doctorListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Request a Phone Call";
            // 
            // requestPhoneCall
            // 
            this.requestPhoneCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestPhoneCall.AutoSize = true;
            this.requestPhoneCall.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestPhoneCall.Location = new System.Drawing.Point(940, 20);
            this.requestPhoneCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestPhoneCall.Name = "requestPhoneCall";
            this.requestPhoneCall.Size = new System.Drawing.Size(277, 49);
            this.requestPhoneCall.TabIndex = 8;
            this.requestPhoneCall.Text = "Request Phone Call";
            this.requestPhoneCall.UseVisualStyleBackColor = true;
            this.requestPhoneCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorListView
            // 
            this.doctorListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.officeName,
            this.officePhone});
            this.doctorListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorListView.FullRowSelect = true;
            this.doctorListView.Location = new System.Drawing.Point(28, 147);
            this.doctorListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorListView.MultiSelect = false;
            this.doctorListView.Name = "doctorListView";
            this.doctorListView.Size = new System.Drawing.Size(1189, 484);
            this.doctorListView.TabIndex = 12;
            this.doctorListView.UseCompatibleStateImageBehavior = false;
            this.doctorListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Doctor Name";
            this.name.Width = 250;
            // 
            // officeName
            // 
            this.officeName.Text = "Office Name";
            this.officeName.Width = 250;
            // 
            // officePhone
            // 
            this.officePhone.Text = "Phone Number";
            this.officePhone.Width = 250;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(28, 101);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 38);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchKey
            // 
            this.searchKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKey.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchKey.Location = new System.Drawing.Point(144, 103);
            this.searchKey.Margin = new System.Windows.Forms.Padding(4, 4, 40, 4);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(1073, 34);
            this.searchKey.TabIndex = 10;
            this.searchKey.Text = "Search for a doctor";
            this.searchKey.Click += new System.EventHandler(this.searchKey_Click);
            // 
            // CallRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doctorListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.requestPhoneCall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CallRequest";
            this.Size = new System.Drawing.Size(1257, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button requestPhoneCall;
        private System.Windows.Forms.ListView doctorListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader officePhone;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.ColumnHeader officeName;
    }
}