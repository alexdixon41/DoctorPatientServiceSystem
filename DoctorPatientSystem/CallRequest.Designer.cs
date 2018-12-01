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
            this.label2 = new System.Windows.Forms.Label();
            this.doctorListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.officeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Request a Phone Call";
            // 
            // requestPhoneCall
            // 
            this.requestPhoneCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.requestPhoneCall.AutoSize = true;
            this.requestPhoneCall.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestPhoneCall.Location = new System.Drawing.Point(663, 17);
            this.requestPhoneCall.Margin = new System.Windows.Forms.Padding(2);
            this.requestPhoneCall.Name = "requestPhoneCall";
            this.requestPhoneCall.Size = new System.Drawing.Size(208, 40);
            this.requestPhoneCall.TabIndex = 8;
            this.requestPhoneCall.Text = "Request Phone Call";
            this.requestPhoneCall.UseVisualStyleBackColor = true;
            this.requestPhoneCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter a Doctor\'s name:";
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
            this.doctorListView.Location = new System.Drawing.Point(41, 131);
            this.doctorListView.Name = "doctorListView";
            this.doctorListView.Size = new System.Drawing.Size(829, 334);
            this.doctorListView.TabIndex = 12;
            this.doctorListView.UseCompatibleStateImageBehavior = false;
            this.doctorListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Doctor Name";
            this.name.Width = 250;
            // 
            // officePhone
            // 
            this.officePhone.Text = "Phone Number";
            this.officePhone.Width = 250;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(749, 105);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 20);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchKey
            // 
            this.searchKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchKey.Location = new System.Drawing.Point(41, 105);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(702, 20);
            this.searchKey.TabIndex = 10;
            // 
            // officeName
            // 
            this.officeName.Text = "Office Name";
            this.officeName.Width = 250;
            // 
            // CallRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doctorListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.requestPhoneCall);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallRequest";
            this.Size = new System.Drawing.Size(943, 526);
            this.Load += new System.EventHandler(this.CallRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button requestPhoneCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView doctorListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader officePhone;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.ColumnHeader officeName;
    }
}